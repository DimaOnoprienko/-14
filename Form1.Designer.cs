namespace Одуванчик_14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            shoppingTextBox = new TextBox();
            shoppingListBox = new ListBox();
            addButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // shoppingTextBox
            // 
            shoppingTextBox.Location = new Point(53, 52);
            shoppingTextBox.Name = "shoppingTextBox";
            shoppingTextBox.Size = new Size(231, 31);
            shoppingTextBox.TabIndex = 0;
            shoppingTextBox.Text = "Введення покупки";
            // 
            // shoppingListBox
            // 
            shoppingListBox.FormattingEnabled = true;
            shoppingListBox.ItemHeight = 25;
            shoppingListBox.Location = new Point(53, 105);
            shoppingListBox.Name = "shoppingListBox";
            shoppingListBox.Size = new Size(279, 229);
            shoppingListBox.TabIndex = 1;
            shoppingListBox.SelectedIndexChanged += shoppingListBox_SelectedIndexChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(338, 52);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 34);
            addButton.TabIndex = 2;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(338, 105);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(112, 34);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 575);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(shoppingListBox);
            Controls.Add(shoppingTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox shoppingTextBox;
        private ListBox shoppingListBox;
        private Button addButton;
        private Button deleteButton;
    }
}