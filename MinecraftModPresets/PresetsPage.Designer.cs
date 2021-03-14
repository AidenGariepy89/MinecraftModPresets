
namespace MinecraftModPresets
{
    partial class PresetsPage
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
            this.BackButton = new System.Windows.Forms.Button();
            this.VersionNameLabel = new System.Windows.Forms.Label();
            this.PresetsLabel = new System.Windows.Forms.Label();
            this.PresetsDataGridView = new System.Windows.Forms.DataGridView();
            this.CreatePresetButton = new System.Windows.Forms.Button();
            this.EditPresetButton = new System.Windows.Forms.Button();
            this.DeletePresetButton = new System.Windows.Forms.Button();
            this.LoadPresetButton = new System.Windows.Forms.Button();
            this.ModsInPresetDataGridView = new System.Windows.Forms.DataGridView();
            this.ModsInPresetLabel = new System.Windows.Forms.Label();
            this.EditAlwaysModsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PresetsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModsInPresetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(78, 32);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // VersionNameLabel
            // 
            this.VersionNameLabel.AutoSize = true;
            this.VersionNameLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VersionNameLabel.Location = new System.Drawing.Point(140, 57);
            this.VersionNameLabel.Name = "VersionNameLabel";
            this.VersionNameLabel.Size = new System.Drawing.Size(220, 28);
            this.VersionNameLabel.TabIndex = 4;
            this.VersionNameLabel.Text = "< Version Name >";
            // 
            // PresetsLabel
            // 
            this.PresetsLabel.AutoSize = true;
            this.PresetsLabel.Location = new System.Drawing.Point(75, 142);
            this.PresetsLabel.Name = "PresetsLabel";
            this.PresetsLabel.Size = new System.Drawing.Size(90, 22);
            this.PresetsLabel.TabIndex = 5;
            this.PresetsLabel.Text = "Presets:";
            // 
            // PresetsDataGridView
            // 
            this.PresetsDataGridView.AllowUserToAddRows = false;
            this.PresetsDataGridView.AllowUserToDeleteRows = false;
            this.PresetsDataGridView.AllowUserToResizeColumns = false;
            this.PresetsDataGridView.AllowUserToResizeRows = false;
            this.PresetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PresetsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PresetsDataGridView.Location = new System.Drawing.Point(75, 167);
            this.PresetsDataGridView.MultiSelect = false;
            this.PresetsDataGridView.Name = "PresetsDataGridView";
            this.PresetsDataGridView.ReadOnly = true;
            this.PresetsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PresetsDataGridView.RowTemplate.Height = 25;
            this.PresetsDataGridView.Size = new System.Drawing.Size(366, 420);
            this.PresetsDataGridView.TabIndex = 6;
            // 
            // CreatePresetButton
            // 
            this.CreatePresetButton.Location = new System.Drawing.Point(447, 167);
            this.CreatePresetButton.Name = "CreatePresetButton";
            this.CreatePresetButton.Size = new System.Drawing.Size(142, 64);
            this.CreatePresetButton.TabIndex = 7;
            this.CreatePresetButton.Text = "+";
            this.CreatePresetButton.UseVisualStyleBackColor = true;
            this.CreatePresetButton.Click += new System.EventHandler(this.CreatePresetButton_Click);
            // 
            // EditPresetButton
            // 
            this.EditPresetButton.Location = new System.Drawing.Point(447, 237);
            this.EditPresetButton.Name = "EditPresetButton";
            this.EditPresetButton.Size = new System.Drawing.Size(142, 64);
            this.EditPresetButton.TabIndex = 7;
            this.EditPresetButton.Text = "Edit";
            this.EditPresetButton.UseVisualStyleBackColor = true;
            this.EditPresetButton.Click += new System.EventHandler(this.EditPresetButton_Click);
            // 
            // DeletePresetButton
            // 
            this.DeletePresetButton.Location = new System.Drawing.Point(447, 307);
            this.DeletePresetButton.Name = "DeletePresetButton";
            this.DeletePresetButton.Size = new System.Drawing.Size(142, 64);
            this.DeletePresetButton.TabIndex = 7;
            this.DeletePresetButton.Text = "Delete";
            this.DeletePresetButton.UseVisualStyleBackColor = true;
            this.DeletePresetButton.Click += new System.EventHandler(this.DeletePresetButton_Click);
            // 
            // LoadPresetButton
            // 
            this.LoadPresetButton.Location = new System.Drawing.Point(447, 457);
            this.LoadPresetButton.Name = "LoadPresetButton";
            this.LoadPresetButton.Size = new System.Drawing.Size(142, 64);
            this.LoadPresetButton.TabIndex = 7;
            this.LoadPresetButton.Text = "Load";
            this.LoadPresetButton.UseVisualStyleBackColor = true;
            this.LoadPresetButton.Click += new System.EventHandler(this.LoadPresetButton_Click);
            // 
            // ModsInPresetDataGridView
            // 
            this.ModsInPresetDataGridView.AllowUserToAddRows = false;
            this.ModsInPresetDataGridView.AllowUserToDeleteRows = false;
            this.ModsInPresetDataGridView.AllowUserToResizeColumns = false;
            this.ModsInPresetDataGridView.AllowUserToResizeRows = false;
            this.ModsInPresetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModsInPresetDataGridView.Location = new System.Drawing.Point(595, 78);
            this.ModsInPresetDataGridView.MultiSelect = false;
            this.ModsInPresetDataGridView.Name = "ModsInPresetDataGridView";
            this.ModsInPresetDataGridView.ReadOnly = true;
            this.ModsInPresetDataGridView.RowTemplate.Height = 25;
            this.ModsInPresetDataGridView.Size = new System.Drawing.Size(512, 509);
            this.ModsInPresetDataGridView.TabIndex = 8;
            // 
            // ModsInPresetLabel
            // 
            this.ModsInPresetLabel.AutoSize = true;
            this.ModsInPresetLabel.Location = new System.Drawing.Point(595, 53);
            this.ModsInPresetLabel.Name = "ModsInPresetLabel";
            this.ModsInPresetLabel.Size = new System.Drawing.Size(160, 22);
            this.ModsInPresetLabel.TabIndex = 5;
            this.ModsInPresetLabel.Text = "Mods in Preset:";
            // 
            // EditAlwaysModsButton
            // 
            this.EditAlwaysModsButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditAlwaysModsButton.Location = new System.Drawing.Point(977, 40);
            this.EditAlwaysModsButton.Name = "EditAlwaysModsButton";
            this.EditAlwaysModsButton.Size = new System.Drawing.Size(130, 32);
            this.EditAlwaysModsButton.TabIndex = 3;
            this.EditAlwaysModsButton.Text = "edit always mods";
            this.EditAlwaysModsButton.UseVisualStyleBackColor = true;
            // 
            // PresetsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 639);
            this.Controls.Add(this.ModsInPresetDataGridView);
            this.Controls.Add(this.LoadPresetButton);
            this.Controls.Add(this.DeletePresetButton);
            this.Controls.Add(this.EditPresetButton);
            this.Controls.Add(this.CreatePresetButton);
            this.Controls.Add(this.PresetsDataGridView);
            this.Controls.Add(this.ModsInPresetLabel);
            this.Controls.Add(this.PresetsLabel);
            this.Controls.Add(this.VersionNameLabel);
            this.Controls.Add(this.EditAlwaysModsButton);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PresetsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<Version Name> Presets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PresetsPage_FormClosing);
            this.Load += new System.EventHandler(this.PresetsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PresetsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModsInPresetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label VersionNameLabel;
        private System.Windows.Forms.Label PresetsLabel;
        private System.Windows.Forms.DataGridView PresetsDataGridView;
        private System.Windows.Forms.Button CreatePresetButton;
        private System.Windows.Forms.Button EditPresetButton;
        private System.Windows.Forms.Button DeletePresetButton;
        private System.Windows.Forms.Button LoadPresetButton;
        private System.Windows.Forms.DataGridView ModsInPresetDataGridView;
        private System.Windows.Forms.Label ModsInPresetLabel;
        private System.Windows.Forms.Button EditAlwaysModsButton;
    }
}