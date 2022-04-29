
namespace ExpenseManager.ToolbarPopUpWindows
{
    partial class EditWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadButton = new System.Windows.Forms.Button();
            this.loadLabel = new System.Windows.Forms.Label();
            this.loadIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(283, 27);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(90, 27);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = true;
            this.loadLabel.Location = new System.Drawing.Point(29, 30);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(110, 20);
            this.loadLabel.TabIndex = 1;
            this.loadLabel.Text = "Transaction ID :";
            // 
            // loadIdTextBox
            // 
            this.loadIdTextBox.Location = new System.Drawing.Point(145, 27);
            this.loadIdTextBox.Name = "loadIdTextBox";
            this.loadIdTextBox.Size = new System.Drawing.Size(132, 27);
            this.loadIdTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(145, 88);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(228, 27);
            this.nameTextBox.TabIndex = 3;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Enabled = false;
            this.amountTextBox.Location = new System.Drawing.Point(145, 136);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(228, 27);
            this.amountTextBox.TabIndex = 4;
            // 
            // categoryComboBox
            // 
           /* this.categoryComboBox.DataSource = new ExpManagerDAL.Models.Category[] {
        ExpManagerDAL.Models.Category.Unspecified,
        ExpManagerDAL.Models.Category.Sport,
        ExpManagerDAL.Models.Category.Health,
        ExpManagerDAL.Models.Category.Food,
        ExpManagerDAL.Models.Category.FreeTime,
        ExpManagerDAL.Models.Category.People,
        ExpManagerDAL.Models.Category.Bills,
        ExpManagerDAL.Models.Category.Transport,
        ExpManagerDAL.Models.Category.Shopping};*/
            this.categoryComboBox.Enabled = false;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
                ExpManagerDAL.Models.Category.Unspecified,
                ExpManagerDAL.Models.Category.Sport,
                ExpManagerDAL.Models.Category.Health,
                ExpManagerDAL.Models.Category.Food,
                ExpManagerDAL.Models.Category.FreeTime,
                ExpManagerDAL.Models.Category.People,
                ExpManagerDAL.Models.Category.Bills,
                ExpManagerDAL.Models.Category.Transport,
                ExpManagerDAL.Models.Category.Shopping
            });
            this.categoryComboBox.Location = new System.Drawing.Point(145, 187);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(228, 28);
            this.categoryComboBox.TabIndex = 5;
            // 
            // datePicker
            // 
            this.datePicker.Enabled = false;
            this.datePicker.Location = new System.Drawing.Point(145, 237);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(228, 27);
            this.datePicker.TabIndex = 6;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(283, 294);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 31);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(64, 294);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(90, 31);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Update";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(56, 91);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 20);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name :";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(50, 139);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(69, 20);
            this.amountLabel.TabIndex = 10;
            this.amountLabel.Text = "Amount :";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(50, 190);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(76, 20);
            this.categoryLabel.TabIndex = 11;
            this.categoryLabel.Text = "Category :";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(64, 242);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(48, 20);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "Date :";
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Location = new System.Drawing.Point(175, 294);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(90, 31);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // EditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 363);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.loadIdTextBox);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.loadButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 410);
            this.MinimumSize = new System.Drawing.Size(420, 410);
            this.Name = "EditWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label loadLabel;
        private System.Windows.Forms.TextBox loadIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button resetButton;
    }
}