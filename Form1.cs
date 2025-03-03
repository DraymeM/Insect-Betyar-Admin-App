using System.Text.Json;
using System.IO;

namespace Insect_Betyar_Admin_App
{
    public partial class Form1 : Form
    {
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

        private List<Category> categories = new List<Category>();
        private List<Item> items = new List<Item>();
        private string currentCategoryFilePath;
        private string currentItemFilePath;
        private string selectedImagePath;

        private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveJsonFile<T>(string filePath, List<T> data)
        {
            if (string.IsNullOrEmpty(filePath)) return;

            try
            {
                string jsonString = JsonSerializer.Serialize(data, JsonOptions);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Hiba t�rt�nt a ment�s k�zben: {ex.Message}", "Save Error");
            }
        }

        private void LoadCategoryFile(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                categories = JsonSerializer.Deserialize<List<Category>>(jsonString) ?? new List<Category>();
                PopulateCategories();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Hiba t�rt�nt a kateg�ria file bet�lt�sekor: {ex.Message}", "Load Error");
            }
        }

        private void LoadItemFile(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                items = JsonSerializer.Deserialize<List<Item>>(jsonString) ?? new List<Item>();
                PopulateItems();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Hiba t�rt�nt a term�k file bet�lt�sekor: {ex.Message}", "Load Error");
            }
        }

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
            if (kategoriaBoxT.Items.Count > 0) kategoriaBoxT.SelectedIndex = 0;
        }

        private void PopulateItems()
        {
            termekBoxT.Items.Clear();
            foreach (var item in items)
            {
                termekBoxT.Items.Add(item.name);
            }
            if (termekBoxT.Items.Count > 0) termekBoxT.SelectedIndex = 0;
        }

        private void KategoriaFileButton_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Select a category JSON file"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentCategoryFilePath = dialog.FileName;
                LoadCategoryFile(currentCategoryFilePath);
            }
        }

        private void termekFileButton_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Select an item JSON file"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentItemFilePath = dialog.FileName;
                LoadItemFile(currentItemFilePath);
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
                SaveJsonFile(currentCategoryFilePath, categories);
                CheckFileLoaded(currentCategoryFilePath, "kateg�ria");
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
                SaveJsonFile(currentItemFilePath, items);
                CheckFileLoaded(currentItemFilePath, "term�k");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Hiba a term�k t�rl�se k�zben!: {ex.Message}", "Error");
            }
        }

        private void kepkategoriaFeltoltButton_Click(object sender, EventArgs e)
        {
            selectedImagePath = SelectImageFile("Select an image file");
        }

        private void keptermekfeltButton_Click(object sender, EventArgs e)
        {
            selectedImagePath = SelectImageFile("Select an image file for the item");
        }

        private void kategoriaMentesButton_Click(object sender, EventArgs e)
        {
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
                SaveJsonFile(currentCategoryFilePath, categories);
                nevkategoriaTextBox.Text = "";
                selectedImagePath = null;
                CheckFileLoaded(currentCategoryFilePath, "kateg�ria");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Error adding category: {ex.Message}", "Error");
            }
        }

        private void termekMentesButton_Click(object sender, EventArgs e)
        {
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
                SaveJsonFile(currentItemFilePath, items);
                ClearItemInput();
                CheckFileLoaded(currentItemFilePath, "term�k");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Hiba a term�k hozz�ad�sa k�zben: {ex.Message}", "Error");
            }
        }

        private string SelectImageFile(string title)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "Image files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*",
                Title = title
            };

            try
            {
                return dialog.ShowDialog() == DialogResult.OK
                    ? "/images/" + Path.GetFileName(dialog.FileName)
                    : null;
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

        private void nevkategoriaTextBox_TextChanged(object sender, EventArgs e)
        {
            // Keep this empty event handler since it exists in the original
        }
    }
}