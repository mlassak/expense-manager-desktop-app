using ExpManagerDAL.Models;
using System;

namespace ExpenseManager.AddWindow
{
    partial class AddWindow
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
            this.transNameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.transNameLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transNameTextBox
            // 
            this.transNameTextBox.Location = new System.Drawing.Point(106, 48);
            this.transNameTextBox.Name = "transNameTextBox";
            this.transNameTextBox.Size = new System.Drawing.Size(227, 27);
            this.transNameTextBox.TabIndex = 0;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(106, 106);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(227, 27);
            this.amountTextBox.TabIndex = 1;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = new ExpManagerDAL.Models.Category[] 
            {
                ExpManagerDAL.Models.Category.Unspecified,
                ExpManagerDAL.Models.Category.Sport,
                ExpManagerDAL.Models.Category.Health,
                ExpManagerDAL.Models.Category.Food,
                ExpManagerDAL.Models.Category.FreeTime,
                ExpManagerDAL.Models.Category.People,
                ExpManagerDAL.Models.Category.Bills,
                ExpManagerDAL.Models.Category.Transport,
                ExpManagerDAL.Models.Category.Shopping
            };
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(106, 158);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryComboBox.Size = new System.Drawing.Size(227, 28);
            this.categoryComboBox.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(106, 209);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(227, 27);
            this.dateTimePicker.TabIndex = 3;
            // 
            // transNameLabel
            // 
            this.transNameLabel.AutoSize = true;
            this.transNameLabel.Location = new System.Drawing.Point(44, 51);
            this.transNameLabel.Name = "transNameLabel";
            this.transNameLabel.Size = new System.Drawing.Size(56, 20);
            this.transNameLabel.TabIndex = 4;
            this.transNameLabel.Text = "Name :";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(31, 109);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(69, 20);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Amount :";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(24, 161);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(76, 20);
            this.categoryLabel.TabIndex = 6;
            this.categoryLabel.Text = "Category :";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(52, 214);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(48, 20);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Date :";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(238, 270);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 32);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(123, 270);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(94, 32);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // AddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 353);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.transNameLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.transNameTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 400);
            this.MinimumSize = new System.Drawing.Size(420, 400);
            this.Name = "AddWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox transNameTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label transNameLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createButton;
    }
}