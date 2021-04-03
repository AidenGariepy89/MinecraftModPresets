using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MinecraftModPresets
{
    public partial class ModMissing : Form
    {
        #region Class Declarations
        private PresetsPage ReferencePresetsPage { get; set; }
        private List<String> ModFiles { get; set; }
        private int Index { get; set; }

        #endregion

        #region Constructor and Loader

        public ModMissing(PresetsPage reference, List<string> modFiles, int index)
        {
            ReferencePresetsPage = reference;
            ModFiles = modFiles;
            Index = index;

            MessageBox.Show($"{ModFiles[Index]} does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            InitializeComponent();

            this.ControlBox = false;
        }

        private void ModMissing_Load(object sender, EventArgs e)
        {
            missingModMessageLabel.Text = $"New Path to {Path.GetFileName(ModFiles[Index])}";
        }

        #endregion

        #region Button Clicks

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(missingModPathTextBox.Text))
            {
                _ = MessageBox.Show($"{missingModPathTextBox.Text} does not exist!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ModFiles[Index] = missingModPathTextBox.Text;

            ReferencePresetsPage.Show();
            Close();
        }

        private void missingModSearchButton_Click(object sender, EventArgs e)
        {
            var fileFinder = new OpenFileDialog();
            DialogResult result = fileFinder.ShowDialog();

            if (result == DialogResult.OK && fileFinder.CheckFileExists)
            {
                missingModPathTextBox.Text = fileFinder.FileName;
            }
        }

        #endregion
    }
}
