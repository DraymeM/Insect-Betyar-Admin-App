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
        private string currentCategoryFilePath = null;
        private string currentItemFilePath = null;
        private string selectedImagePath = null; // Used for both category and item image selection

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveToCategoryJsonFile()
        {
            if (!string.IsNullOrEmpty(currentCategoryFilePath))
            {
                try
                {
                    string jsonString = JsonSerializer.Serialize(categories, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(currentCategoryFilePath, jsonString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba t�rt�nt a kateg�ria file ment�se k�zben: {ex.Message}",
                        "Save Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void SaveToItemJsonFile()
        {
            if (!string.IsNullOrEmpty(currentItemFilePath))
            {
                try
                {
                    string jsonString = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(currentItemFilePath, jsonString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba t�rt�nt a term�k file ment�se k�zben: {ex.Message}",
                        "Save Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
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

            if (categories.Count > 0)
            {
                kategoriaComboBox.SelectedIndex = 0;
                kategoriaBoxT.SelectedIndex = 0;
            }
        }

        private void PopulateItems()
        {
            termekBoxT.Items.Clear();

            foreach (var item in items)
            {
                termekBoxT.Items.Add(item.name);
            }

            if (items.Count > 0)
            {
                termekBoxT.SelectedIndex = 0;
            }
        }

        private void KategoriaFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Select a category JSON file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        currentCategoryFilePath = openFileDialog.FileName;
                        string jsonString = File.ReadAllText(currentCategoryFilePath);
                        categories = JsonSerializer.Deserialize<List<Category>>(jsonString);
                        PopulateCategories();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba t�rt�nt a kateg�ria file bet�lt�sekor: {ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void termekFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Select an item JSON file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        currentItemFilePath = openFileDialog.FileName;
                        string jsonString = File.ReadAllText(currentItemFilePath);
                        items = JsonSerializer.Deserialize<List<Item>>(jsonString);
                        PopulateItems();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba t�rt�nt a term�k file bet�lt�sekor: {ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void kategoriaTorlesButton_Click(object sender, EventArgs e)
        {
            if (kategoriaBoxT.SelectedIndex != -1)
            {
                try
                {
                    string selectedCategory = kategoriaBoxT.SelectedItem.ToString();
                    categories.RemoveAll(c => c.name == selectedCategory);
                    PopulateCategories();
                    SaveToCategoryJsonFile();

                    if (string.IsNullOrEmpty(currentCategoryFilePath))
                    {
                        MessageBox.Show("Warning: El�sz�r t�ltsd be a kateg�ria json f�jlt.",
                            "No File Loaded",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba a kateg�ria t�rl�se k�zben!: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("K�rlek v�lassz egy kateg�ri�t a t�rl�shez!",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void termekTorlesButton_Click(object sender, EventArgs e)
        {
            if (termekBoxT.SelectedIndex != -1)
            {
                try
                {
                    string selectedItem = termekBoxT.SelectedItem.ToString();
                    items.RemoveAll(i => i.name == selectedItem);
                    PopulateItems();
                    SaveToItemJsonFile();

                    if (string.IsNullOrEmpty(currentItemFilePath))
                    {
                        MessageBox.Show("Warning: El�sz�r t�ltsd be a term�k json f�jlt.",
                            "No File Loaded",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba a term�k t�rl�se k�zben!: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("K�rlek v�lassz egy term�ket a t�rl�shez!",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void nevkategoriaTextBox_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for potential future validation
        }

        private void kepkategoriaFeltoltButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";
                openFileDialog.Title = "Select an image file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fileName = Path.GetFileName(openFileDialog.FileName);
                        selectedImagePath = "/images/" + fileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba a k�p kiv�laszt�sakor.: {ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void kategoriaMentesButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nevkategoriaTextBox.Text))
            {
                MessageBox.Show("K�rlek �rd be a kateg�ria nev�t!",
                    "Missing Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("El�sz�r v�lassz ki egy k�p f�jlt.",
                    "Missing Image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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
                SaveToCategoryJsonFile();

                nevkategoriaTextBox.Text = "";
                selectedImagePath = null;

                if (string.IsNullOrEmpty(currentCategoryFilePath))
                {
                    MessageBox.Show("Warning: El�sz�r t�ltsd be a kateg�ria json f�jlt.",
                        "No File Loaded",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding category: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void keptermekfeltButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";
                openFileDialog.Title = "Select an image file for the item";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fileName = Path.GetFileName(openFileDialog.FileName);
                        selectedImagePath = "/images/" + fileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba a term�k k�p kiv�laszt�sakor: {ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void termekMentesButton_Click(object sender, EventArgs e)
        {
            // Validate all required fields
            if (string.IsNullOrEmpty(nevtermektextBox.Text))
            {
                MessageBox.Show("K�rlek �rd be a term�k nev�t!",
                    "Missing Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("El�sz�r v�lassz ki egy k�p f�jlt a term�khez!",
                    "Missing Image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(leirasTexBox.Text))
            {
                MessageBox.Show("K�rlek �rd be a term�k le�r�s�t!",
                    "Missing Description",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(artextBox.Text))
            {
                MessageBox.Show("K�rlek �rd be a term�k �r�t!",
                    "Missing Price",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (kategoriaComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("K�rlek v�lassz egy kateg�ri�t!",
                    "Missing Category",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the highest existing ID and increment it
                int newId = items.Any() ? items.Max(i => i.id) + 1 : 1;

                // Create new item
                var newItem = new Item
                {
                    id = newId,
                    name = nevtermektextBox.Text,
                    picture = selectedImagePath,
                    description = leirasTexBox.Text,
                    price = artextBox.Text,
                    category = kategoriaComboBox.SelectedItem.ToString()
                };

                // Add to items list
                items.Add(newItem);

                // Update UI and save to file
                PopulateItems();
                SaveToItemJsonFile();

                // Clear input fields
                nevtermektextBox.Text = "";
                leirasTexBox.Text = "";
                artextBox.Text = "";
                selectedImagePath = null;

                if (string.IsNullOrEmpty(currentItemFilePath))
                {
                    MessageBox.Show("Warning: El�sz�r t�ltsd be a term�k json f�jlt.",
                        "No File Loaded",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba a term�k hozz�ad�sa k�zben: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}