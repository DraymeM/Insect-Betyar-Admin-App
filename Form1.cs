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

        private List<Category> categories = new List<Category>();
        private string currentFilePath = null; // Store the current JSON file path
        private string selectedImagePath = null; // Store the selected image path

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveToJsonFile()
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                try
                {
                    string jsonString = JsonSerializer.Serialize(categories, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(currentFilePath, jsonString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba t�rt�nt a file ment�se k�zben: {ex.Message}",
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

        private void KategoriaFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Select a JSON file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        currentFilePath = openFileDialog.FileName;
                        string jsonString = File.ReadAllText(currentFilePath);
                        categories = JsonSerializer.Deserialize<List<Category>>(jsonString);
                        PopulateCategories();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba t�rt�nt a file bet�lt�sekor: {ex.Message}",
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
                    SaveToJsonFile();

                    if (string.IsNullOrEmpty(currentFilePath))
                    {
                        MessageBox.Show("Warning: El�sz�r t�ltsd be a json f�jlt.",
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

        private void nevkategoriaTextBox_TextChanged(object sender, EventArgs e)
        {
            // We don't need to do anything here for now
            // This event is just included in case you want to add real-time validation later
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
                        // Get just the filename with extension
                        string fileName = Path.GetFileName(openFileDialog.FileName);
                        // Prepend /images/ to the filename
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
            // Check if we have a name
            if (string.IsNullOrEmpty(nevkategoriaTextBox.Text))
            {
                MessageBox.Show("K�rlek �rd be a kateg�ria nev�t!",
                    "Missing Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Check if we have an image selected
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
                // Create new category
                var newCategory = new Category
                {
                    name = nevkategoriaTextBox.Text,
                    image = selectedImagePath
                };

                // Add to categories list
                categories.Add(newCategory);

                // Update UI and save to file
                PopulateCategories();
                SaveToJsonFile();

                // Clear the inputs
                nevkategoriaTextBox.Text = "";
                selectedImagePath = null;

                if (string.IsNullOrEmpty(currentFilePath))
                {
                    MessageBox.Show("Warning: El�sz�r t�ltsd be a json f�jlt.",
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
    }
}