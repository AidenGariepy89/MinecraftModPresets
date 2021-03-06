
namespace MinecraftModPresets
{
    partial class Preset_Create
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
            this.PresetNameTextBox = new System.Windows.Forms.TextBox();
            this.PresetNameLabel = new System.Windows.Forms.Label();
            this.AddLabel = new System.Windows.Forms.Label();
            this.IgnoreForeverModsCheckBox = new System.Windows.Forms.CheckBox();
            this.AddActiveModsButton = new System.Windows.Forms.Button();
            this.AddStoredModsButton = new System.Windows.Forms.Button();
            this.CreateVersionButton = new System.Windows.Forms.Button();
            this.ModsInPresetDataGridView = new System.Windows.Forms.DataGridView();
            this.ModsInPresetLabel = new System.Windows.Forms.Label();
            this.ClearModsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ModsInPresetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(78, 32);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PresetNameTextBox
            // 
            this.PresetNameTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PresetNameTextBox.Location = new System.Drawing.Point(99, 118);
            this.PresetNameTextBox.Name = "PresetNameTextBox";
            this.PresetNameTextBox.Size = new System.Drawing.Size(255, 26);
            this.PresetNameTextBox.TabIndex = 6;
            // 
            // PresetNameLabel
            // 
            this.PresetNameLabel.AutoSize = true;
            this.PresetNameLabel.Location = new System.Drawing.Point(99, 93);
            this.PresetNameLabel.Name = "PresetNameLabel";
            this.PresetNameLabel.Size = new System.Drawing.Size(60, 22);
            this.PresetNameLabel.TabIndex = 5;
            this.PresetNameLabel.Text = "Name:";
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Location = new System.Drawing.Point(99, 147);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(50, 22);
            this.AddLabel.TabIndex = 5;
            this.AddLabel.Text = "Add:";
            // 
            // IgnoreForeverModsCheckBox
            // 
            this.IgnoreForeverModsCheckBox.AutoSize = true;
            this.IgnoreForeverModsCheckBox.Checked = true;
            this.IgnoreForeverModsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IgnoreForeverModsCheckBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IgnoreForeverModsCheckBox.Location = new System.Drawing.Point(99, 172);
            this.IgnoreForeverModsCheckBox.Name = "IgnoreForeverModsCheckBox";
            this.IgnoreForeverModsCheckBox.Size = new System.Drawing.Size(159, 19);
            this.IgnoreForeverModsCheckBox.TabIndex = 7;
            this.IgnoreForeverModsCheckBox.Text = "Ignore Forever Mods";
            this.IgnoreForeverModsCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddActiveModsButton
            // 
            this.AddActiveModsButton.Location = new System.Drawing.Point(99, 197);
            this.AddActiveModsButton.Name = "AddActiveModsButton";
            this.AddActiveModsButton.Size = new System.Drawing.Size(122, 64);
            this.AddActiveModsButton.TabIndex = 8;
            this.AddActiveModsButton.Text = "Add Active Mods";
            this.AddActiveModsButton.UseVisualStyleBackColor = true;
            this.AddActiveModsButton.Click += new System.EventHandler(this.AddActiveMods_Click);
            // 
            // AddStoredModsButton
            // 
            this.AddStoredModsButton.Location = new System.Drawing.Point(227, 197);
            this.AddStoredModsButton.Name = "AddStoredModsButton";
            this.AddStoredModsButton.Size = new System.Drawing.Size(127, 64);
            this.AddStoredModsButton.TabIndex = 8;
            this.AddStoredModsButton.Text = "Add Stored Mods";
            this.AddStoredModsButton.UseVisualStyleBackColor = true;
            this.AddStoredModsButton.Click += new System.EventHandler(this.AddStoredMods_Click);
            // 
            // CreateVersionButton
            // 
            this.CreateVersionButton.Location = new System.Drawing.Point(99, 267);
            this.CreateVersionButton.Name = "CreateVersionButton";
            this.CreateVersionButton.Size = new System.Drawing.Size(159, 71);
            this.CreateVersionButton.TabIndex = 9;
            this.CreateVersionButton.Text = "+";
            this.CreateVersionButton.UseVisualStyleBackColor = true;
            this.CreateVersionButton.Click += new System.EventHandler(this.CreateVersionButton_Click);
            // 
            // ModsInPresetDataGridView
            // 
            this.ModsInPresetDataGridView.AllowUserToAddRows = false;
            this.ModsInPresetDataGridView.AllowUserToDeleteRows = false;
            this.ModsInPresetDataGridView.AllowUserToResizeColumns = false;
            this.ModsInPresetDataGridView.AllowUserToResizeRows = false;
            this.ModsInPresetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModsInPresetDataGridView.Location = new System.Drawing.Point(383, 118);
            this.ModsInPresetDataGridView.MultiSelect = false;
            this.ModsInPresetDataGridView.Name = "ModsInPresetDataGridView";
            this.ModsInPresetDataGridView.ReadOnly = true;
            this.ModsInPresetDataGridView.RowTemplate.Height = 25;
            this.ModsInPresetDataGridView.Size = new System.Drawing.Size(338, 220);
            this.ModsInPresetDataGridView.TabIndex = 11;
            // 
            // ModsInPresetLabel
            // 
            this.ModsInPresetLabel.AutoSize = true;
            this.ModsInPresetLabel.Location = new System.Drawing.Point(383, 93);
            this.ModsInPresetLabel.Name = "ModsInPresetLabel";
            this.ModsInPresetLabel.Size = new System.Drawing.Size(160, 22);
            this.ModsInPresetLabel.TabIndex = 10;
            this.ModsInPresetLabel.Text = "Mods in Preset:";
            // 
            // ClearModsButton
            // 
            this.ClearModsButton.Location = new System.Drawing.Point(269, 267);
            this.ClearModsButton.Name = "ClearModsButton";
            this.ClearModsButton.Size = new System.Drawing.Size(85, 71);
            this.ClearModsButton.TabIndex = 12;
            this.ClearModsButton.Text = "Clear";
            this.ClearModsButton.UseVisualStyleBackColor = true;
            this.ClearModsButton.Click += new System.EventHandler(this.ClearModsButton_Click);
            // 
            // Preset_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearModsButton);
            this.Controls.Add(this.ModsInPresetDataGridView);
            this.Controls.Add(this.ModsInPresetLabel);
            this.Controls.Add(this.CreateVersionButton);
            this.Controls.Add(this.AddStoredModsButton);
            this.Controls.Add(this.AddActiveModsButton);
            this.Controls.Add(this.IgnoreForeverModsCheckBox);
            this.Controls.Add(this.PresetNameTextBox);
            this.Controls.Add(this.AddLabel);
            this.Controls.Add(this.PresetNameLabel);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Preset_Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Preset";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Preset_Create_FormClosing);
            this.Load += new System.EventHandler(this.Preset_Create_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModsInPresetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox PresetNameTextBox;
        private System.Windows.Forms.Label PresetNameLabel;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.CheckBox IgnoreForeverModsCheckBox;
        private System.Windows.Forms.Button AddActiveModsButton;
        private System.Windows.Forms.Button AddStoredModsButton;
        private System.Windows.Forms.Button CreateVersionButton;
        private System.Windows.Forms.DataGridView ModsInPresetDataGridView;
        private System.Windows.Forms.Label ModsInPresetLabel;
        private System.Windows.Forms.Button ClearModsButton;
    }
}