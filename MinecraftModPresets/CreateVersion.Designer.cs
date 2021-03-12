
namespace MinecraftModPresets
{
    partial class CreateVersion
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
            this.VersionNameLabel = new System.Windows.Forms.Label();
            this.VersionNameTextBox = new System.Windows.Forms.TextBox();
            this.ActiveModsPathLabel = new System.Windows.Forms.Label();
            this.ActiveModsPathTextBox = new System.Windows.Forms.TextBox();
            this.StorageModsPathLabel = new System.Windows.Forms.Label();
            this.StorageModsPathTextBox = new System.Windows.Forms.TextBox();
            this.CreateVersionButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.storageDirSearchButton = new System.Windows.Forms.Button();
            this.activeDirSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VersionNameLabel
            // 
            this.VersionNameLabel.AutoSize = true;
            this.VersionNameLabel.Location = new System.Drawing.Point(105, 93);
            this.VersionNameLabel.Name = "VersionNameLabel";
            this.VersionNameLabel.Size = new System.Drawing.Size(60, 22);
            this.VersionNameLabel.TabIndex = 0;
            this.VersionNameLabel.Text = "Name:";
            // 
            // VersionNameTextBox
            // 
            this.VersionNameTextBox.Location = new System.Drawing.Point(105, 118);
            this.VersionNameTextBox.Name = "VersionNameTextBox";
            this.VersionNameTextBox.Size = new System.Drawing.Size(349, 30);
            this.VersionNameTextBox.TabIndex = 1;
            // 
            // ActiveModsPathLabel
            // 
            this.ActiveModsPathLabel.AutoSize = true;
            this.ActiveModsPathLabel.Location = new System.Drawing.Point(105, 163);
            this.ActiveModsPathLabel.Name = "ActiveModsPathLabel";
            this.ActiveModsPathLabel.Size = new System.Drawing.Size(300, 22);
            this.ActiveModsPathLabel.TabIndex = 0;
            this.ActiveModsPathLabel.Text = "Path to Active Mods Directory";
            // 
            // ActiveModsPathTextBox
            // 
            this.ActiveModsPathTextBox.Location = new System.Drawing.Point(105, 188);
            this.ActiveModsPathTextBox.Name = "ActiveModsPathTextBox";
            this.ActiveModsPathTextBox.Size = new System.Drawing.Size(313, 30);
            this.ActiveModsPathTextBox.TabIndex = 1;
            // 
            // StorageModsPathLabel
            // 
            this.StorageModsPathLabel.AutoSize = true;
            this.StorageModsPathLabel.Location = new System.Drawing.Point(105, 233);
            this.StorageModsPathLabel.Name = "StorageModsPathLabel";
            this.StorageModsPathLabel.Size = new System.Drawing.Size(310, 22);
            this.StorageModsPathLabel.TabIndex = 0;
            this.StorageModsPathLabel.Text = "Path to Storage Mods Directory";
            // 
            // StorageModsPathTextBox
            // 
            this.StorageModsPathTextBox.Location = new System.Drawing.Point(105, 258);
            this.StorageModsPathTextBox.Name = "StorageModsPathTextBox";
            this.StorageModsPathTextBox.Size = new System.Drawing.Size(313, 30);
            this.StorageModsPathTextBox.TabIndex = 1;
            // 
            // CreateVersionButton
            // 
            this.CreateVersionButton.Location = new System.Drawing.Point(222, 311);
            this.CreateVersionButton.Name = "CreateVersionButton";
            this.CreateVersionButton.Size = new System.Drawing.Size(108, 100);
            this.CreateVersionButton.TabIndex = 2;
            this.CreateVersionButton.Text = "+";
            this.CreateVersionButton.UseVisualStyleBackColor = true;
            this.CreateVersionButton.Click += new System.EventHandler(this.CreateVersionButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(78, 32);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // storageDirSearchButton
            // 
            this.storageDirSearchButton.Location = new System.Drawing.Point(424, 258);
            this.storageDirSearchButton.Name = "storageDirSearchButton";
            this.storageDirSearchButton.Size = new System.Drawing.Size(30, 30);
            this.storageDirSearchButton.TabIndex = 3;
            this.storageDirSearchButton.UseVisualStyleBackColor = true;
            this.storageDirSearchButton.Click += new System.EventHandler(this.storageDirSearchButton_Click);
            // 
            // activeDirSearchButton
            // 
            this.activeDirSearchButton.Location = new System.Drawing.Point(424, 188);
            this.activeDirSearchButton.Name = "activeDirSearchButton";
            this.activeDirSearchButton.Size = new System.Drawing.Size(30, 30);
            this.activeDirSearchButton.TabIndex = 3;
            this.activeDirSearchButton.UseVisualStyleBackColor = true;
            this.activeDirSearchButton.Click += new System.EventHandler(this.activeDirSearchButton_Click);
            // 
            // CreateVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.activeDirSearchButton);
            this.Controls.Add(this.storageDirSearchButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CreateVersionButton);
            this.Controls.Add(this.StorageModsPathTextBox);
            this.Controls.Add(this.ActiveModsPathTextBox);
            this.Controls.Add(this.VersionNameTextBox);
            this.Controls.Add(this.StorageModsPathLabel);
            this.Controls.Add(this.ActiveModsPathLabel);
            this.Controls.Add(this.VersionNameLabel);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Version";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateVersion_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VersionNameLabel;
        private System.Windows.Forms.TextBox VersionNameTextBox;
        private System.Windows.Forms.Label ActiveModsPathLabel;
        private System.Windows.Forms.TextBox ActiveModsPathTextBox;
        private System.Windows.Forms.Label StorageModsPathLabel;
        private System.Windows.Forms.TextBox StorageModsPathTextBox;
        private System.Windows.Forms.Button CreateVersionButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button storageDirSearchButton;
        private System.Windows.Forms.Button activeDirSearchButton;
    }
}