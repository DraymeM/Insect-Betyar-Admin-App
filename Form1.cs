using System.Text.Json;
using System.IO;
using System.Windows.Forms; // Ensure this is included for ToolTip

namespace Insect_Betyar_Admin_App
{
    public partial class Form1 : Form
    {
        // Data Models
        public class Category
        {
            public string name { get; set; }
            public string image { get; set; }
        }

        public class Item
        {
            public int id { get; set; }
            public string name { get; set; }
            public string picture { get; set; }
            public string description { get; set; }
            public string price { get; set; }
            public string category { get; set; }
        }

        // Data Manager
        private class DataManager<T>
        {
            private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };

            public List<T> LoadFromFile(string filePath)
            {
                try
                {
                    string jsonString = File.ReadAllText(filePath);
                    return JsonSerializer.Deserialize<List<T>>(jsonString) ?? new List<T>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba t�rt�nt a file bet�lt�sekor: {ex.Message}", "Load Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<T>();
                }
            }

            public void SaveToFile(string filePath, List<T> data)
            {
                if (string.IsNullOrEmpty(filePath)) return;

                try
                {
                    string jsonString = JsonSerializer.Serialize(data, JsonOptions);
                    File.WriteAllText(filePath, jsonString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba t�rt�nt a ment�s k�zben: {ex.Message}", "Save Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // File Dialog Service
        private class FileDialogService
        {
            public string? ShowOpenFileDialog(string filter, string title)
            {
                using var dialog = new OpenFileDialog
                {
                    Filter = filter,
                    Title = title
                };
                return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : null;
            }
        }

        private readonly DataManager<Category> categoryManager = new();
        private readonly DataManager<Item> itemManager = new();
        private readonly FileDialogService fileDialogService = new();

        private List<Category> categories = new List<Category>();
        private List<Item> items = new List<Item>();
        private string currentCategoryFilePath;
        private string currentItemFilePath;
        private string? selectedImagePath;

        public Form1()
        {
            InitializeComponent();
            // Wire up the SelectedIndexChanged events
            kategoriaBoxT.SelectedIndexChanged += new EventHandler(kategoriaBoxT_SelectedIndexChanged);
            termekBoxT.SelectedIndexChanged += new EventHandler(termekBoxT_SelectedIndexChanged);
            // Wire up the new kategoriaModositasButton event
            kategoriaModositasButton.Click += new EventHandler(kategoriaModositasButton_Click);

            // Set initial visibility based on no selection
            UpdateButtonVisibility();

            // Add tooltips for termekBoxT and kategoriaBoxT
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(termekBoxT, "V�lassz ki egyet a m�dos�t�shoz vagy t�rl�shez, amennyiben nem v�lasztasz ki semmit akkor hozz�adni tudsz.");
            toolTip.SetToolTip(kategoriaBoxT, "V�lassz ki egyet a m�dos�t�shoz vagy t�rl�shez, amennyiben nem v�lasztasz ki semmit akkor hozz�adni tudsz.");
        }

        // Helper to update button visibility
        private void UpdateButtonVisibility()
        {
            kategoriaMentesButton.Visible = kategoriaBoxT.SelectedIndex == -1;
            kategoriaModositasButton.Visible = kategoriaBoxT.SelectedIndex != -1;
            kategoriaTorlesButton.Visible = kategoriaBoxT.SelectedIndex != -1;

            termekMentesButton.Visible = termekBoxT.SelectedIndex == -1;
            termekModositasButton.Visible = termekBoxT.SelectedIndex != -1;
            termekTorlesButton.Visible = termekBoxT.SelectedIndex != -1;
        }

        // UI Population
        private void PopulateCategories()
        {
            kategoriaComboBox.Items.Clear();
            kategoriaBoxT.Items.Clear();

            foreach (var category in categories)
            {
                kategoriaComboBox.Items.Add(category.name);
                kategoriaBoxT.Items.Add(category.name);
            }

            if (kategoriaComboBox.Items.Count > 0) kategoriaComboBox.SelectedIndex = 0;
            // No automatic selection for kategoriaBoxT
            UpdateButtonVisibility();
        }

        private void PopulateItems()
        {
            termekBoxT.Items.Clear();
            foreach (var item in items)
            {
                termekBoxT.Items.Add(item.name);
            }
            // No automatic selection for termekBoxT
            UpdateButtonVisibility();
        }

        // Event Handlers
        private void KategoriaFileButton_Click(object sender, EventArgs e)
        {
            currentCategoryFilePath = fileDialogService.ShowOpenFileDialog(
                "JSON files (*.json)|*.json|All files (*.*)|*.*",
                "Select a category JSON file");

            if (!string.IsNullOrEmpty(currentCategoryFilePath))
            {
                categories = categoryManager.LoadFromFile(currentCategoryFilePath);
                PopulateCategories();
            }
        }

        private void termekFileButton_Click(object sender, EventArgs e)
        {
            currentItemFilePath = fileDialogService.ShowOpenFileDialog(
                "JSON files (*.json)|*.json|All files (*.*)|*.*",
                "Select an item JSON file");

            if (!string.IsNullOrEmpty(currentItemFilePath))
            {
                items = itemManager.LoadFromFile(currentItemFilePath);
                PopulateItems();
            }
        }

        private void kategoriaTorlesButton_Click(object sender, EventArgs e)
        {
            if (kategoriaBoxT.SelectedIndex == -1)
            {
                ShowWarningMessage("K�rlek v�lassz egy kateg�ri�t a t�rl�shez!", "No Selection");
                return;
            }

            try
            {
                string selectedCategory = kategoriaBoxT.SelectedItem.ToString();
                categories.RemoveAll(c => c.name == selectedCategory);
                PopulateCategories();
                categoryManager.SaveToFile(currentCategoryFilePath, categories);
                CheckFileLoaded(currentCategoryFilePath, "kateg�ria");
                ClearKategoryInput();
                MessageBox.Show("Sikeresen t�r�l�s", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Hiba a kateg�ria t�rl�se k�zben!: {ex.Message}", "Error");
            }
        }

        private void termekTorlesButton_Click(object sender, EventArgs e)
        {
            if (termekBoxT.SelectedIndex == -1)
            {
                ShowWarningMessage("K�rlek v�lassz egy term�ket a t�rl�shez!", "No Selection");
                return;
            }

            try
            {
                string selectedItem = termekBoxT.SelectedItem.ToString();
                items.RemoveAll(i => i.name == selectedItem);
                PopulateItems();
                itemManager.SaveToFile(currentItemFilePath, items);
                CheckFileLoaded(currentItemFilePath, "term�k");
                ClearItemInput();
                MessageBox.Show("Sikeresen t�r�lte a nev�t", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Hiba a term�k t�rl�se k�zben!: {ex.Message}", "Error");
            }
        }

        private void kepkategoriaFeltoltButton_Click(object sender, EventArgs e)
        {
            LoadImage(kategoriaHozPictureBox);
        }

        private void keptermekfeltButton_Click(object sender, EventArgs e)
        {
            LoadImage(termekHozPictureBox);
        }

        private void kategoriaMentesButton_Click(object sender, EventArgs e)
        {
            if (kategoriaBoxT.SelectedIndex != -1)
            {
                ShowWarningMessage("Csak akkor menthetsz �j kateg�ri�t, ha nincs kiv�lasztva megl�v�!", "Invalid Operation");
                return;
            }

            if (string.IsNullOrEmpty(nevkategoriaTextBox.Text))
            {
                ShowWarningMessage("K�rlek �rd be a kateg�ria nev�t!", "Missing Name");
                return;
            }
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                ShowWarningMessage("El�sz�r v�lassz ki egy k�p f�jlt.", "Missing Image");
                return;
            }

            try
            {
                var newCategory = new Category
                {
                    name = nevkategoriaTextBox.Text,
                    image = selectedImagePath
                };

                categories.Add(newCategory);
                PopulateCategories();
                categoryManager.SaveToFile(currentCategoryFilePath, categories);
                ClearKategoryInput();
                CheckFileLoaded(currentCategoryFilePath, "kateg�ria");
                MessageBox.Show("Sikeresen mentet�s", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Error adding category: {ex.Message}", "Error");
            }
        }

        private void termekMentesButton_Click(object sender, EventArgs e)
        {
            if (termekBoxT.SelectedIndex != -1)
            {
                ShowWarningMessage("Csak akkor menthetsz �j term�ket, ha nincs kiv�lasztva megl�v�!", "Invalid Operation");
                return;
            }

            if (!ValidateItemInput()) return;

            try
            {
                var newItem = new Item
                {
                    id = items.Any() ? items.Max(i => i.id) + 1 : 1,
                    name = nevtermektextBox.Text,
                    picture = selectedImagePath,
                    description = leirasTexBox.Text,
                    price = artextBox.Text,
                    category = kategoriaComboBox.SelectedItem.ToString()
                };

                items.Add(newItem);
                PopulateItems();
                itemManager.SaveToFile(currentItemFilePath, items);
                ClearItemInput();
                CheckFileLoaded(currentItemFilePath, "term�k");
                MessageBox.Show("Sikeresen ment�s", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Hiba a term�k hozz�ad�sa k�zben: {ex.Message}", "Error");
            }
        }

        private void termekModositasButton_Click(object sender, EventArgs e)
        {
            if (termekBoxT.SelectedIndex == -1)
            {
                ShowWarningMessage("K�rlek v�lassz egy term�ket a m�dos�t�shoz!", "No Selection");
                return;
            }

            if (!ValidateItemInput()) return;

            try
            {
                string selectedItemName = termekBoxT.SelectedItem.ToString();
                Item selectedItem = items.FirstOrDefault(i => i.name == selectedItemName);

                if (selectedItem != null)
                {
                    // Update the selected item's attributes, including picture
                    selectedItem.name = nevtermektextBox.Text;
                    selectedItem.picture = selectedImagePath; // Override with new image
                    selectedItem.description = leirasTexBox.Text;
                    selectedItem.price = artextBox.Text;
                    selectedItem.category = kategoriaComboBox.SelectedItem.ToString();

                    // Refresh UI, save changes, clear fields, and deselect item
                    PopulateItems();
                    itemManager.SaveToFile(currentItemFilePath, items);
                    ClearItemInput();
                    termekBoxT.SelectedIndex = -1;
                    CheckFileLoaded(currentItemFilePath, "term�k");
                    MessageBox.Show("Sikeresen m�dos�tot�s", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ShowErrorMessage("A kiv�lasztott term�k nem tal�lhat�!", "Error");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Hiba a term�k m�dos�t�sa k�zben: {ex.Message}", "Error");
            }
        }

        private void kategoriaModositasButton_Click(object sender, EventArgs e)
        {
            if (kategoriaBoxT.SelectedIndex == -1)
            {
                ShowWarningMessage("K�rlek v�lassz egy kateg�ri�t a m�dos�t�shoz!", "No Selection");
                return;
            }

            if (string.IsNullOrEmpty(nevkategoriaTextBox.Text))
            {
                ShowWarningMessage("K�rlek �rd be a kateg�ria nev�t!", "Missing Name");
                return;
            }
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                ShowWarningMessage("El�sz�r v�lassz ki egy k�p f�jlt!", "Missing Image");
                return;
            }

            try
            {
                string selectedCategoryName = kategoriaBoxT.SelectedItem.ToString();
                Category selectedCategory = categories.FirstOrDefault(c => c.name == selectedCategoryName);

                if (selectedCategory != null)
                {
                    // Update the selected category's attributes
                    selectedCategory.name = nevkategoriaTextBox.Text;
                    selectedCategory.image = selectedImagePath;

                    // Refresh UI, save changes, clear fields, and deselect item
                    PopulateCategories();
                    categoryManager.SaveToFile(currentCategoryFilePath, categories);
                    ClearKategoryInput();
                    kategoriaBoxT.SelectedIndex = -1;
                    CheckFileLoaded(currentCategoryFilePath, "kateg�ria");
                    MessageBox.Show("Sikeresen m�dos�tva a kateg�ria", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ShowErrorMessage("A kiv�lasztott kateg�ria nem tal�lhat�!", "Error");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Hiba a kateg�ria m�dos�t�sa k�zben: {ex.Message}", "Error");
            }
        }

        private void nevkategoriaTextBox_TextChanged(object sender, EventArgs e)
        {
            // Keep this empty event handler since it exists in the original
        }

        private void kategoriaBoxT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kategoriaBoxT.SelectedIndex != -1)
            {
                nevkategoriaTextBox.Text = kategoriaBoxT.SelectedItem.ToString();
            }
            UpdateButtonVisibility();
        }

        private void termekBoxT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (termekBoxT.SelectedIndex != -1)
            {
                string selectedItemName = termekBoxT.SelectedItem.ToString();
                Item selectedItem = items.FirstOrDefault(i => i.name == selectedItemName);

                if (selectedItem != null)
                {
                    nevtermektextBox.Text = selectedItem.name;
                    leirasTexBox.Text = selectedItem.description;
                    artextBox.Text = selectedItem.price;

                    // Select the matching category in kategoriaComboBox
                    if (!string.IsNullOrEmpty(selectedItem.category))
                    {
                        int categoryIndex = kategoriaComboBox.Items.IndexOf(selectedItem.category);
                        if (categoryIndex != -1)
                        {
                            kategoriaComboBox.SelectedIndex = categoryIndex;
                        }
                    }
                }
            }
            UpdateButtonVisibility();
        }

        // Helper Methods
        private void LoadImage(PictureBox pictureBox)
        {
            string? fullImagePath = SelectImageFileFullPath("Select an image file for the item");
            if (!string.IsNullOrEmpty(fullImagePath))
            {
                try
                {
                    pictureBox.Image = Image.FromFile(fullImagePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    selectedImagePath = "/images/" + Path.GetFileName(fullImagePath);
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"Hiba a k�p megjelen�t�sekor: {ex.Message}\nPath: {fullImagePath}", "Image Display Error");
                }
            }
        }

        private string? SelectImageFileFullPath(string title)
        {
            try
            {
                return fileDialogService.ShowOpenFileDialog(
                    "Image files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*",
                    title);
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Hiba a k�p kiv�laszt�sakor: {ex.Message}", "Error");
                return null;
            }
        }

        private string? SelectImageFile(string title)
        {
            try
            {
                string? filePath = fileDialogService.ShowOpenFileDialog(
                    "Image files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*",
                    title);
                return filePath != null ? "/images/" + Path.GetFileName(filePath) : null;
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Hiba a k�p kiv�laszt�sakor: {ex.Message}", "Error");
                return null;
            }
        }

        private bool ValidateItemInput()
        {
            if (string.IsNullOrEmpty(nevtermektextBox.Text))
            {
                ShowWarningMessage("K�rlek �rd be a term�k nev�t!", "Missing Name");
                return false;
            }
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                ShowWarningMessage("El�sz�r v�lassz ki egy k�p f�jlt a term�khez!", "Missing Image");
                return false;
            }
            if (string.IsNullOrEmpty(leirasTexBox.Text))
            {
                ShowWarningMessage("K�rlek �rd be a term�k le�r�s�t!", "Missing Description");
                return false;
            }
            if (string.IsNullOrEmpty(artextBox.Text))
            {
                ShowWarningMessage("K�rlek �rd be a term�k �r�t!", "Missing Price");
                return false;
            }
            if (kategoriaComboBox.SelectedIndex == -1)
            {
                ShowWarningMessage("K�rlek v�lassz egy kateg�ri�t!", "Missing Category");
                return false;
            }
            return true;
        }

        private void ClearItemInput()
        {
            nevtermektextBox.Text = "";
            leirasTexBox.Text = "";
            artextBox.Text = "";
            selectedImagePath = null;
            termekHozPictureBox.Image = null;
        }

        private void ClearKategoryInput()
        {
            nevkategoriaTextBox.Text = "";
            selectedImagePath = null;
            kategoriaHozPictureBox.Image = null;
        }

        private void CheckFileLoaded(string filePath, string type)
        {
            if (string.IsNullOrEmpty(filePath))
                ShowWarningMessage($"Warning: El�sz�r t�ltsd be a {type} json f�jlt.", "No File Loaded");
        }

        private void ShowErrorMessage(string message, string title) =>
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void ShowWarningMessage(string message, string title) =>
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}