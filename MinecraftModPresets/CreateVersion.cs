using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MinecraftModPresets.library;
using MinecraftModPresets.interfaces;

namespace MinecraftModPresets
{
    public partial class CreateVersion : Form
    {
        #region Class Declarations

        /// <summary>
        /// The Form that created it.
        /// </summary>
        private StartWindow ReferenceMain { get; set; }
        /// <summary>
        /// The MinecraftVersion to edit.
        /// </summary>
        private MinecraftVersion Version { get; set; }
        /// <summary>
        /// True if window is in edit mode.
        /// </summary>
        private List<string> ModsInActiveFolder { get; set; }
        private List<string> ModsInStorageFolder { get; set; }
        private bool IsEdit { get; set; } = false;

        private int VersionIndex { get; set; }

        private ILogger logger = Tools.GetLogger();

        #endregion

        #region Constructors
        /// <summary>
        /// Constructor of a creator instance of the CreateVersion window.
        /// </summary>
        /// <param name="main"> Gets the instance of the StartWindow that created this window. </param>
        public CreateVersion(StartWindow main)
        {
            ReferenceMain = main;

            InitializeComponent();
        }

        /// <summary>
        /// Constructor of an editor instance of the CreateVersion window.
        /// </summary>
        /// <param name="main"> Gets the instance of the StartWindow that created this window. </param>
        /// <param name="isEdit"> True if the window is editing an existing Version. </param>
        /// <param name="version"> The version this window is editing. </param>
        public CreateVersion(StartWindow main, bool isEdit, MinecraftVersion version, int index)
        {
            ReferenceMain = main;
            IsEdit = isEdit;
            VersionIndex = index;

            InitializeComponent();

            this.Text = "Edit Version";

            if (IsEdit)
            {
                Version = version;

                VersionNameTextBox.Text = Version.Name;
                ActiveModsPathTextBox.Text = Version.ActiveFolderPath;
                StorageModsPathTextBox.Text = Version.StorageFolderPath;

                CreateVersionButton.Text = "Save";
            }
        }

        #endregion

        #region Button Clicks
        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateVersionButton_Click(object sender, EventArgs e)
        {
            string name = VersionNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                _ = MessageBox.Show("Version Name not specified.", "Warning");
                return;
            }

            string activePath = ActiveModsPathTextBox.Text;
            if (string.IsNullOrWhiteSpace(activePath))
            {
                _ = MessageBox.Show("Active Mods Directory Path not specified.", "Warning");
                return;
            }
            else if (!Directory.Exists(activePath))
            {
                _ = MessageBox.Show("Specified Active Mods Directory does not exist!", "Warning");
                return;
            }

            string storagePath = StorageModsPathTextBox.Text;
            if (string.IsNullOrWhiteSpace(storagePath))
            {
                _ = MessageBox.Show("Storage Mods Directory Path not specified.", "Warning");
                return;
            }
            else if (storagePath == activePath)
            {
                _ = MessageBox.Show("Active and Storage Directories cannot be the same!", "Warning");
                return;
            }
            else if (!Directory.Exists(storagePath))
            {
                _ = MessageBox.Show("Specified Storage Directory does not exist!", "Warning");
                return;
            }

            if (IsEdit)
            {
                Version.Name = name;
                Version.ActiveFolderPath = activePath;
                Version.StorageFolderPath = storagePath;

                ReferenceMain.EditVersionInTable(Version);

                logger.LogMessage($"Version {Version.Name}:{Version.Id} edited", LogLevel.Debug);
            }
            else
            {
                ReferenceMain.AddVersion(new MinecraftVersion() { Id = Tools.CreateId(), Name = name, ActiveFolderPath = activePath, StorageFolderPath = storagePath });
                logger.LogMessage($"Version {name} created", LogLevel.Debug);
            }

            logger.LogMessage($"\tVersion Name: \"{name}\"", LogLevel.Verbose);
            logger.LogMessage($"\tVersion ActiveFolderPath: \"{activePath}\"", LogLevel.Verbose);
            logger.LogMessage($"\tVersion StorageFolderPath: \"{storagePath}\"", LogLevel.Verbose);

            ReferenceMain.Show();
            Close();
        }

        private void CreateVersion_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceMain.Show();
        }

        private void activeDirSearchButton_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    ActiveModsPathTextBox.Text = folderBrowser.SelectedPath;
                }
            }
        }

        private void storageDirSearchButton_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    StorageModsPathTextBox.Text = folderBrowser.SelectedPath;
                }
            }
        }

        #endregion
    }
}
