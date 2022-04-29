
namespace ExpenseManager
{
    partial class MainWindow
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
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.toolButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.TableLayoutPanel();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.manageAccountButton = new System.Windows.Forms.Button();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            this.toolButtonPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.toolButtonPanel, 0, 1);
            this.mainPanel.Controls.Add(this.menuStrip, 0, 0);
            this.mainPanel.Controls.Add(this.panel1, 0, 2);
            this.mainPanel.Controls.Add(this.bottomPanel, 0, 4);
            this.mainPanel.Controls.Add(this.dataTable, 0, 3);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 5;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.mainPanel.Size = new System.Drawing.Size(732, 703);
            this.mainPanel.TabIndex = 1;
            // 
            // toolButtonPanel
            // 
            this.toolButtonPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolButtonPanel.ColumnCount = 11;
            this.toolButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.toolButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.toolButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.toolButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.toolButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.toolButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.toolButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.toolButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.toolButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.toolButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.toolButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.toolButtonPanel.Controls.Add(this.logoutButton, 9, 0);
            this.toolButtonPanel.Controls.Add(this.exitButton, 10, 0);
            this.toolButtonPanel.Controls.Add(this.exportButton, 7, 0);
            this.toolButtonPanel.Controls.Add(this.importButton, 6, 0);
            this.toolButtonPanel.Controls.Add(this.loadButton, 4, 0);
            this.toolButtonPanel.Controls.Add(this.addButton, 0, 0);
            this.toolButtonPanel.Controls.Add(this.deleteButton, 2, 0);
            this.toolButtonPanel.Controls.Add(this.editButton, 1, 0);
            this.toolButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolButtonPanel.Location = new System.Drawing.Point(3, 27);
            this.toolButtonPanel.Name = "toolButtonPanel";
            this.toolButtonPanel.RowCount = 1;
            this.toolButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.toolButtonPanel.Size = new System.Drawing.Size(726, 64);
            this.toolButtonPanel.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoutButton.Location = new System.Drawing.Point(589, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(64, 58);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitButton.Location = new System.Drawing.Point(659, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(64, 58);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportButton.Enabled = false;
            this.exportButton.Location = new System.Drawing.Point(393, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(64, 58);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importButton
            // 
            this.importButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importButton.Location = new System.Drawing.Point(323, 3);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(64, 58);
            this.importButton.TabIndex = 3;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadButton.Location = new System.Drawing.Point(233, 3);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(64, 58);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Reload";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 58);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(143, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(64, 58);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(73, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(64, 58);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(732, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 1);
            this.panel1.TabIndex = 2;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.bottomPanel.ColumnCount = 3;
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.bottomPanel.Controls.Add(this.balanceLabel, 1, 0);
            this.bottomPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.bottomPanel.Controls.Add(this.balanceTextBox, 2, 0);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(3, 661);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.RowCount = 1;
            this.bottomPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomPanel.Size = new System.Drawing.Size(726, 39);
            this.bottomPanel.TabIndex = 3;
            // 
            // balanceLabel
            // 
            this.balanceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceLabel.Location = new System.Drawing.Point(525, 8);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(78, 23);
            this.balanceLabel.TabIndex = 1;
            this.balanceLabel.Text = "Balance :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.userLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usernameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.manageAccountButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 33);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLabel.Location = new System.Drawing.Point(3, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(54, 33);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "User :";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTextBox.Enabled = false;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTextBox.Location = new System.Drawing.Point(63, 3);
            this.usernameTextBox.MaxLength = 100;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(148, 25);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // manageAccountButton
            // 
            this.manageAccountButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageAccountButton.Location = new System.Drawing.Point(217, 3);
            this.manageAccountButton.Name = "manageAccountButton";
            this.manageAccountButton.Size = new System.Drawing.Size(74, 27);
            this.manageAccountButton.TabIndex = 2;
            this.manageAccountButton.Text = "Manage";
            this.manageAccountButton.UseVisualStyleBackColor = true;
            this.manageAccountButton.Click += new System.EventHandler(this.manageAccountButton_Click);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.balanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.balanceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.balanceTextBox.Enabled = false;
            this.balanceTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceTextBox.Location = new System.Drawing.Point(609, 3);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.ReadOnly = true;
            this.balanceTextBox.Size = new System.Drawing.Size(114, 32);
            this.balanceTextBox.TabIndex = 0;
            this.balanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.amountColumn,
            this.categoryColumn,
            this.dateColumn});
            this.dataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTable.Location = new System.Drawing.Point(3, 99);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.Size = new System.Drawing.Size(726, 556);
            this.dataTable.TabIndex = 4;
            // 
            // idColumn
            // 
            this.idColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idColumn.FillWeight = 133.6898F;
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 75;
            // 
            // nameColumn
            // 
            this.nameColumn.FillWeight = 110F;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // amountColumn
            // 
            this.amountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.amountColumn.FillWeight = 91.57755F;
            this.amountColumn.HeaderText = "Amount";
            this.amountColumn.MinimumWidth = 6;
            this.amountColumn.Name = "amountColumn";
            this.amountColumn.ReadOnly = true;
            this.amountColumn.Width = 125;
            // 
            // categoryColumn
            // 
            this.categoryColumn.FillWeight = 91.57755F;
            this.categoryColumn.HeaderText = "Category";
            this.categoryColumn.MinimumWidth = 6;
            this.categoryColumn.Name = "categoryColumn";
            this.categoryColumn.ReadOnly = true;
            // 
            // dateColumn
            // 
            this.dateColumn.FillWeight = 130F;
            this.dateColumn.HeaderText = "Date";
            this.dateColumn.MinimumWidth = 6;
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(732, 703);
            this.Controls.Add(this.mainPanel);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(750, 750);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Manager";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.toolButtonPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.TableLayoutPanel toolButtonPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel bottomPanel;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button manageAccountButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
    }
}

