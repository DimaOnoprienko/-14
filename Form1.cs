

namespace Одуванчик_14
{
    public partial class Form1 : Form
    {
        private List<string> shoppingList = new List<string>(); // Список покупок

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string newItem = shoppingTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(newItem))
            {

                shoppingList.Add(newItem);
                shoppingListBox.Items.Add($"{newItem} - {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");


                shoppingTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть назву покупки.");
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (shoppingListBox.SelectedIndex != -1)
            {
                // Видалити вибрану покупку зі списку та ListBox
                shoppingList.RemoveAt(shoppingListBox.SelectedIndex);
                shoppingListBox.Items.RemoveAt(shoppingListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть покупку для видалення.");
            }
        }

        private void shoppingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
