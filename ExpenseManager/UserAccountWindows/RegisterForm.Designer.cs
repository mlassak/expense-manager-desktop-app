
namespace ExpenseManager
{
    partial class RegisterForm
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
            this.unameLabel = new System.Windows.Forms.Label();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.confirmPasswdLabel = new System.Windows.Forms.Label();
            this.unameTextBox = new System.Windows.Forms.TextBox();
            this.passwdTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswdTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unameLabel
            // 
            this.unameLabel.AutoSize = true;
            this.unameLabel.Location = new System.Drawing.Point(85, 33);
            this.unameLabel.Name = "unameLabel";
            this.unameLabel.Size = new System.Drawing.Size(82, 20);
            this.unameLabel.TabIndex = 0;
            this.unameLabel.Text = "Username :";
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Location = new System.Drawing.Point(90, 82);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(77, 20);
            this.passwdLabel.TabIndex = 1;
            this.passwdLabel.Text = "Password :";
            // 
            // confirmPasswdLabel
            // 
            this.confirmPasswdLabel.AutoSize = true;
            this.confirmPasswdLabel.Location = new System.Drawing.Point(31, 127);
            this.confirmPasswdLabel.Name = "confirmPasswdLabel";
            this.confirmPasswdLabel.Size = new System.Drawing.Size(136, 20);
            this.confirmPasswdLabel.TabIndex = 2;
            this.confirmPasswdLabel.Text = "Confirm password :";
            // 
            // unameTextBox
            // 
            this.unameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unameTextBox.Location = new System.Drawing.Point(191, 26);
            this.unameTextBox.Name = "unameTextBox";
            this.unameTextBox.Size = new System.Drawing.Size(160, 27);
            this.unameTextBox.TabIndex = 3;
            // 
            // passwdTextBox
            // 
            this.passwdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwdTextBox.Location = new System.Drawing.Point(191, 79);
            this.passwdTextBox.Name = "passwdTextBox";
            this.passwdTextBox.Size = new System.Drawing.Size(160, 27);
            this.passwdTextBox.TabIndex = 4;
            this.passwdTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswdTextBox
            // 
            this.confirmPasswdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmPasswdTextBox.Location = new System.Drawing.Point(191, 127);
            this.confirmPasswdTextBox.Name = "confirmPasswdTextBox";
            this.confirmPasswdTextBox.Size = new System.Drawing.Size(160, 27);
            this.confirmPasswdTextBox.TabIndex = 5;
            this.confirmPasswdTextBox.UseSystemPasswordChar = true;
            this.confirmPasswdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmPasswdTextBox_KeyPress);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.Location = new System.Drawing.Point(167, 178);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(82, 29);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(269, 178);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(82, 29);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 233);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.confirmPasswdTextBox);
            this.Controls.Add(this.passwdTextBox);
            this.Controls.Add(this.unameTextBox);
            this.Controls.Add(this.confirmPasswdLabel);
            this.Controls.Add(this.passwdLabel);
            this.Controls.Add(this.unameLabel);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 280);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label unameLabel;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.Label confirmPasswdLabel;
        private System.Windows.Forms.TextBox unameTextBox;
        private System.Windows.Forms.TextBox passwdTextBox;
        private System.Windows.Forms.TextBox confirmPasswdTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
    }
}