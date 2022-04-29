
namespace ExpenseManager
{
    partial class LoginForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.unameLabel = new System.Windows.Forms.Label();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.unameTextBox = new System.Windows.Forms.TextBox();
            this.passwdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.Location = new System.Drawing.Point(132, 125);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(73, 29);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.Location = new System.Drawing.Point(53, 125);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(73, 29);
            this.registerButton.TabIndex = 1;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(211, 125);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(73, 29);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // unameLabel
            // 
            this.unameLabel.AutoSize = true;
            this.unameLabel.Location = new System.Drawing.Point(32, 32);
            this.unameLabel.Name = "unameLabel";
            this.unameLabel.Size = new System.Drawing.Size(82, 20);
            this.unameLabel.TabIndex = 3;
            this.unameLabel.Text = "Username :";
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Location = new System.Drawing.Point(37, 80);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(77, 20);
            this.passwdLabel.TabIndex = 4;
            this.passwdLabel.Text = "Password :";
            // 
            // unameTextBox
            // 
            this.unameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unameTextBox.Location = new System.Drawing.Point(120, 29);
            this.unameTextBox.Name = "unameTextBox";
            this.unameTextBox.Size = new System.Drawing.Size(164, 27);
            this.unameTextBox.TabIndex = 5;
            // 
            // passwdTextBox
            // 
            this.passwdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwdTextBox.Location = new System.Drawing.Point(120, 77);
            this.passwdTextBox.Name = "passwdTextBox";
            this.passwdTextBox.Size = new System.Drawing.Size(164, 27);
            this.passwdTextBox.TabIndex = 6;
            this.passwdTextBox.UseSystemPasswordChar = true;
            this.passwdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwdTextBox_KeyPress);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 183);
            this.Controls.Add(this.passwdTextBox);
            this.Controls.Add(this.unameTextBox);
            this.Controls.Add(this.passwdLabel);
            this.Controls.Add(this.unameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(334, 230);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label unameLabel;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.TextBox unameTextBox;
        private System.Windows.Forms.TextBox passwdTextBox;
    }
}