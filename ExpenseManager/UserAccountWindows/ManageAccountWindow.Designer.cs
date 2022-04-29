
namespace ExpenseManager.UserAccountWindows
{
    partial class ManageAccountWindow
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.changeUnameTabPage = new System.Windows.Forms.TabPage();
            this.changeUnameButton = new System.Windows.Forms.Button();
            this.unameLabel = new System.Windows.Forms.Label();
            this.newUnameTextBox = new System.Windows.Forms.TextBox();
            this.changePasswdTabPage = new System.Windows.Forms.TabPage();
            this.changePasswdButton = new System.Windows.Forms.Button();
            this.confirmPasswdLabel = new System.Windows.Forms.Label();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.confirmPasswdTextBox = new System.Windows.Forms.TextBox();
            this.passwdTextBox = new System.Windows.Forms.TextBox();
            this.deleteAccountTabPage = new System.Windows.Forms.TabPage();
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.deleteAccConfirmCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.changeUnameTabPage.SuspendLayout();
            this.changePasswdTabPage.SuspendLayout();
            this.deleteAccountTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(371, 394);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 34);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.changeUnameTabPage);
            this.tabControl.Controls.Add(this.changePasswdTabPage);
            this.tabControl.Controls.Add(this.deleteAccountTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(452, 374);
            this.tabControl.TabIndex = 1;
            // 
            // changeUnameTabPage
            // 
            this.changeUnameTabPage.Controls.Add(this.changeUnameButton);
            this.changeUnameTabPage.Controls.Add(this.unameLabel);
            this.changeUnameTabPage.Controls.Add(this.newUnameTextBox);
            this.changeUnameTabPage.Location = new System.Drawing.Point(4, 29);
            this.changeUnameTabPage.Name = "changeUnameTabPage";
            this.changeUnameTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.changeUnameTabPage.Size = new System.Drawing.Size(444, 341);
            this.changeUnameTabPage.TabIndex = 0;
            this.changeUnameTabPage.Text = "Change username";
            this.changeUnameTabPage.UseVisualStyleBackColor = true;
            // 
            // changeUnameButton
            // 
            this.changeUnameButton.Location = new System.Drawing.Point(152, 182);
            this.changeUnameButton.Name = "changeUnameButton";
            this.changeUnameButton.Size = new System.Drawing.Size(141, 29);
            this.changeUnameButton.TabIndex = 2;
            this.changeUnameButton.Text = "Change username";
            this.changeUnameButton.UseVisualStyleBackColor = true;
            this.changeUnameButton.Click += new System.EventHandler(this.changeUnameButton_Click);
            // 
            // unameLabel
            // 
            this.unameLabel.AutoSize = true;
            this.unameLabel.Location = new System.Drawing.Point(62, 114);
            this.unameLabel.Name = "unameLabel";
            this.unameLabel.Size = new System.Drawing.Size(114, 20);
            this.unameLabel.TabIndex = 1;
            this.unameLabel.Text = "New username :";
            // 
            // newUnameTextBox
            // 
            this.newUnameTextBox.Location = new System.Drawing.Point(195, 111);
            this.newUnameTextBox.Name = "newUnameTextBox";
            this.newUnameTextBox.Size = new System.Drawing.Size(188, 27);
            this.newUnameTextBox.TabIndex = 0;
            // 
            // changePasswdTabPage
            // 
            this.changePasswdTabPage.Controls.Add(this.changePasswdButton);
            this.changePasswdTabPage.Controls.Add(this.confirmPasswdLabel);
            this.changePasswdTabPage.Controls.Add(this.passwdLabel);
            this.changePasswdTabPage.Controls.Add(this.confirmPasswdTextBox);
            this.changePasswdTabPage.Controls.Add(this.passwdTextBox);
            this.changePasswdTabPage.Location = new System.Drawing.Point(4, 29);
            this.changePasswdTabPage.Name = "changePasswdTabPage";
            this.changePasswdTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.changePasswdTabPage.Size = new System.Drawing.Size(444, 341);
            this.changePasswdTabPage.TabIndex = 1;
            this.changePasswdTabPage.Text = "Change password";
            this.changePasswdTabPage.UseVisualStyleBackColor = true;
            // 
            // changePasswdButton
            // 
            this.changePasswdButton.Location = new System.Drawing.Point(143, 226);
            this.changePasswdButton.Name = "changePasswdButton";
            this.changePasswdButton.Size = new System.Drawing.Size(158, 29);
            this.changePasswdButton.TabIndex = 4;
            this.changePasswdButton.Text = "Change password";
            this.changePasswdButton.UseVisualStyleBackColor = true;
            this.changePasswdButton.Click += new System.EventHandler(this.changePasswdButton_Click);
            // 
            // confirmPasswdLabel
            // 
            this.confirmPasswdLabel.AutoSize = true;
            this.confirmPasswdLabel.Location = new System.Drawing.Point(72, 157);
            this.confirmPasswdLabel.Name = "confirmPasswdLabel";
            this.confirmPasswdLabel.Size = new System.Drawing.Size(136, 20);
            this.confirmPasswdLabel.TabIndex = 3;
            this.confirmPasswdLabel.Text = "Confirm password :";
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Location = new System.Drawing.Point(95, 86);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(113, 20);
            this.passwdLabel.TabIndex = 2;
            this.passwdLabel.Text = "New password :";
            // 
            // confirmPasswdTextBox
            // 
            this.confirmPasswdTextBox.Location = new System.Drawing.Point(214, 154);
            this.confirmPasswdTextBox.Name = "confirmPasswdTextBox";
            this.confirmPasswdTextBox.Size = new System.Drawing.Size(158, 27);
            this.confirmPasswdTextBox.TabIndex = 1;
            this.confirmPasswdTextBox.UseSystemPasswordChar = true;
            // 
            // passwdTextBox
            // 
            this.passwdTextBox.Location = new System.Drawing.Point(214, 83);
            this.passwdTextBox.Name = "passwdTextBox";
            this.passwdTextBox.Size = new System.Drawing.Size(158, 27);
            this.passwdTextBox.TabIndex = 0;
            this.passwdTextBox.UseSystemPasswordChar = true;
            // 
            // deleteAccountTabPage
            // 
            this.deleteAccountTabPage.Controls.Add(this.deleteAccountButton);
            this.deleteAccountTabPage.Controls.Add(this.deleteAccConfirmCheckBox);
            this.deleteAccountTabPage.Location = new System.Drawing.Point(4, 29);
            this.deleteAccountTabPage.Name = "deleteAccountTabPage";
            this.deleteAccountTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.deleteAccountTabPage.Size = new System.Drawing.Size(444, 341);
            this.deleteAccountTabPage.TabIndex = 2;
            this.deleteAccountTabPage.Text = "Delete account";
            this.deleteAccountTabPage.UseVisualStyleBackColor = true;
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAccountButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteAccountButton.Enabled = false;
            this.deleteAccountButton.ForeColor = System.Drawing.Color.Black;
            this.deleteAccountButton.Location = new System.Drawing.Point(143, 186);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(140, 29);
            this.deleteAccountButton.TabIndex = 1;
            this.deleteAccountButton.Text = "Delete account";
            this.deleteAccountButton.UseVisualStyleBackColor = false;
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // deleteAccConfirmCheckBox
            // 
            this.deleteAccConfirmCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAccConfirmCheckBox.AutoSize = true;
            this.deleteAccConfirmCheckBox.Location = new System.Drawing.Point(129, 125);
            this.deleteAccConfirmCheckBox.Name = "deleteAccConfirmCheckBox";
            this.deleteAccConfirmCheckBox.Size = new System.Drawing.Size(186, 24);
            this.deleteAccConfirmCheckBox.TabIndex = 0;
            this.deleteAccConfirmCheckBox.Text = "Confirm delete account";
            this.deleteAccConfirmCheckBox.UseVisualStyleBackColor = true;
            this.deleteAccConfirmCheckBox.CheckedChanged += new System.EventHandler(this.deleteAccConfirmCheckBox_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(269, 394);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(96, 34);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ManageAccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 440);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.cancelButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(494, 487);
            this.MinimumSize = new System.Drawing.Size(494, 487);
            this.Name = "ManageAccountWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Account";
            this.tabControl.ResumeLayout(false);
            this.changeUnameTabPage.ResumeLayout(false);
            this.changeUnameTabPage.PerformLayout();
            this.changePasswdTabPage.ResumeLayout(false);
            this.changePasswdTabPage.PerformLayout();
            this.deleteAccountTabPage.ResumeLayout(false);
            this.deleteAccountTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage changeUnameTabPage;
        private System.Windows.Forms.TabPage changePasswdTabPage;
        private System.Windows.Forms.TabPage deleteAccountTabPage;
        private System.Windows.Forms.Button deleteAccountButton;
        private System.Windows.Forms.CheckBox deleteAccConfirmCheckBox;
        private System.Windows.Forms.Button changePasswdButton;
        private System.Windows.Forms.Label confirmPasswdLabel;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.TextBox confirmPasswdTextBox;
        private System.Windows.Forms.TextBox passwdTextBox;
        private System.Windows.Forms.Button changeUnameButton;
        private System.Windows.Forms.Label unameLabel;
        private System.Windows.Forms.TextBox newUnameTextBox;
        private System.Windows.Forms.Button okButton;
    }
}