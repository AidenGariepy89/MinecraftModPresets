
namespace MinecraftModPresets
{
    partial class StartWindow
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CreateVersionButton = new System.Windows.Forms.Button();
            this.OpenVersionButton = new System.Windows.Forms.Button();
            this.VersionsDataGridView = new System.Windows.Forms.DataGridView();
            this.VersionsLabel = new System.Windows.Forms.Label();
            this.DeleteVersionButton = new System.Windows.Forms.Button();
            this.EditVersionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VersionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(11, 9);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(220, 28);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Minecraft -IRON-";
            // 
            // CreateVersionButton
            // 
            this.CreateVersionButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateVersionButton.Location = new System.Drawing.Point(55, 109);
            this.CreateVersionButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateVersionButton.Name = "CreateVersionButton";
            this.CreateVersionButton.Size = new System.Drawing.Size(110, 108);
            this.CreateVersionButton.TabIndex = 1;
            this.CreateVersionButton.Text = "+";
            this.CreateVersionButton.UseVisualStyleBackColor = true;
            this.CreateVersionButton.Click += new System.EventHandler(this.CreateVersionButton_Click);
            // 
            // OpenVersionButton
            // 
            this.OpenVersionButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenVersionButton.Location = new System.Drawing.Point(55, 257);
            this.OpenVersionButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenVersionButton.Name = "OpenVersionButton";
            this.OpenVersionButton.Size = new System.Drawing.Size(110, 108);
            this.OpenVersionButton.TabIndex = 2;
            this.OpenVersionButton.Text = "Open";
            this.OpenVersionButton.UseVisualStyleBackColor = true;
            this.OpenVersionButton.Click += new System.EventHandler(this.OpenVersionButton_Click);
            // 
            // VersionsDataGridView
            // 
            this.VersionsDataGridView.AllowUserToAddRows = false;
            this.VersionsDataGridView.AllowUserToDeleteRows = false;
            this.VersionsDataGridView.AllowUserToResizeColumns = false;
            this.VersionsDataGridView.AllowUserToResizeRows = false;
            this.VersionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VersionsDataGridView.Location = new System.Drawing.Point(195, 109);
            this.VersionsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.VersionsDataGridView.MultiSelect = false;
            this.VersionsDataGridView.Name = "VersionsDataGridView";
            this.VersionsDataGridView.ReadOnly = true;
            this.VersionsDataGridView.RowTemplate.Height = 25;
            this.VersionsDataGridView.Size = new System.Drawing.Size(411, 256);
            this.VersionsDataGridView.TabIndex = 3;
            // 
            // VersionsLabel
            // 
            this.VersionsLabel.AutoSize = true;
            this.VersionsLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VersionsLabel.Location = new System.Drawing.Point(195, 79);
            this.VersionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VersionsLabel.Name = "VersionsLabel";
            this.VersionsLabel.Size = new System.Drawing.Size(129, 28);
            this.VersionsLabel.TabIndex = 4;
            this.VersionsLabel.Text = "Versions:";
            // 
            // DeleteVersionButton
            // 
            this.DeleteVersionButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteVersionButton.Location = new System.Drawing.Point(634, 109);
            this.DeleteVersionButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteVersionButton.Name = "DeleteVersionButton";
            this.DeleteVersionButton.Size = new System.Drawing.Size(97, 39);
            this.DeleteVersionButton.TabIndex = 5;
            this.DeleteVersionButton.Text = "Delete Selected";
            this.DeleteVersionButton.UseVisualStyleBackColor = true;
            this.DeleteVersionButton.Click += new System.EventHandler(this.DeleteVersionButton_Click);
            // 
            // EditVersionButton
            // 
            this.EditVersionButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditVersionButton.Location = new System.Drawing.Point(634, 164);
            this.EditVersionButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditVersionButton.Name = "EditVersionButton";
            this.EditVersionButton.Size = new System.Drawing.Size(97, 39);
            this.EditVersionButton.TabIndex = 5;
            this.EditVersionButton.Text = "Edit Selected";
            this.EditVersionButton.UseVisualStyleBackColor = true;
            this.EditVersionButton.Click += new System.EventHandler(this.EditVersionButton_Click);
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditVersionButton);
            this.Controls.Add(this.DeleteVersionButton);
            this.Controls.Add(this.VersionsLabel);
            this.Controls.Add(this.VersionsDataGridView);
            this.Controls.Add(this.OpenVersionButton);
            this.Controls.Add(this.CreateVersionButton);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartWindow_FormClosing);
            this.Load += new System.EventHandler(this.StartWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VersionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button CreateVersionButton;
        private System.Windows.Forms.Button OpenVersionButton;
        private System.Windows.Forms.DataGridView VersionsDataGridView;
        private System.Windows.Forms.Label VersionsLabel;
        private System.Windows.Forms.Button DeleteVersionButton;
        private System.Windows.Forms.Button EditVersionButton;
    }
}