using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MinecraftModPresets.library;
using MinecraftModPresets.interfaces;

namespace MinecraftModPresets
{
    public partial class StartWindow : Form
    {
        #region Class Declarations

        /// <summary>
        /// List of the Minecraft Versions.
        /// </summary>
        public List<MinecraftVersion> Versions { get; set; }

        /// <summary>
        /// DataTable that contains the Versions List and displays it.
        /// </summary>
        private DataTable versionsTable;
        
        /// <summary>
        /// The Logger.
        /// </summary>
        private ILogger logger = Tools.GetLogger();

        #endregion

        #region Constructor and Loader
        public StartWindow()
        {
            InitializeComponent();

            logger.LogMessage("Startup\n", LogLevel.Critical);
            Tools.BaseDir();

            Versions = new List<MinecraftVersion>();

            Tools.LoadAll(Versions, logger);
        }

        /// <summary>
        /// Called when the Window Loads.
        /// </summary>
        private void StartWindow_Load(object sender, EventArgs e)
        {
            versionsTable = new DataTable();
            versionsTable.Columns.Add("Name", typeof(string));
            versionsTable.Columns.Add("Id", typeof(int));

            VersionsDataGridView.DataSource = versionsTable;

            RefreshVersionDataGridView(Versions);

            VersionsDataGridView.Columns["Name"].Width = VersionsDataGridView.Width;
            VersionsDataGridView.Columns["Name"].SortMode = DataGridViewColumnSortMode.NotSortable;
            VersionsDataGridView.Columns["Id"].Visible = false;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Refreshes the DataTable that displays the Versions.
        /// </summary>
        /// <param name="versions"> The List of Minecraft Versions to read from. </param>
        public void RefreshVersionDataGridView(List<MinecraftVersion> versions)
        {
            versionsTable.Rows.Clear();

            VersionsDataGridView.CurrentCell = null;

            foreach (var version in versions)
            {
                versionsTable.Rows.Add(version.Name, version.Id);
                logger.LogMessage($"Added Version {version.Name}", LogLevel.Verbose);
            }
        }

        /// <summary>
        /// Removes a Minecraft Version from the List Versions.
        /// </summary>
        /// <param name="version"> The MinecraftVersion to remove. </param>
        /// <param name="index"> The Index of the versionTable to remove. </param>
        public void RemoveVersion(MinecraftVersion version, int index)
        {
            Versions.Remove(version);
            versionsTable.Rows[index].Delete();
        }

        public void EditVersionInTable(MinecraftVersion version)
        {
            foreach (DataRow row in versionsTable.Rows)
            {
                if (row["Id"].ToString() == version.Id.ToString())
                {
                    row["Name"] = version.Name;
                }
            }
            
        }

        /// <summary>
        /// Adds a Minecraft Version to the List Versions.
        /// </summary>
        /// <param name="version"></param>
        public void AddVersion(MinecraftVersion version)
        {
            Versions.Add(version);
            version.Presets = new List<Preset>();
            version.ForeverMods = new List<Mod>();

            versionsTable.Rows.Add(version.Name, version.Id);
        }

        #endregion

        #region Button Clicks

        /// <summary>
        /// Deletes the Minecraft Version.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteVersionButton_Click(object sender, EventArgs e)
        {
            var versionToDelete = Versions[VersionsDataGridView.CurrentCell.RowIndex];

            DialogResult dr = MessageBox.Show($"Are you sure you want to delete {versionToDelete.Name}?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                RemoveVersion(versionToDelete, VersionsDataGridView.CurrentCell.RowIndex);

                logger.LogMessage($"Deleted {versionToDelete.Name}", LogLevel.Debug);
            }
        }

        /// <summary>
        /// Executes when the Form is closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to save your progress?", "Save?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Tools.SaveAll(Versions, logger);
                logger.LogMessage("Saved", LogLevel.Debug);
            }

            logger.LogMessage("Exiting\n", LogLevel.Critical);
        }

        /// <summary>
        /// Opens the CreateVersion window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateVersionButton_Click(object sender, EventArgs e)
        {
            var createVersion = new CreateVersion(this);
            createVersion.Show();
            Hide();
        }

        /// <summary>
        /// Opens the CreateVersion window to edit an existing Version.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditVersionButton_Click(object sender, EventArgs e)
        {
            int versionSelectedIndex = VersionsDataGridView.CurrentCell.RowIndex;
            var versionToEdit = Versions[versionSelectedIndex];
            var editVersion = new CreateVersion(this, true, versionToEdit, versionSelectedIndex);

            editVersion.Show();
            Hide();

        }

        /// <summary>
        /// Opens the Version into the PresetsPage window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenVersionButton_Click(object sender, EventArgs e)
        {
            int versionSelectedIndex = VersionsDataGridView.CurrentCell.RowIndex;
            var versionToOpen = Versions[versionSelectedIndex];

            var openVersion = new PresetsPage(this, versionToOpen);

            openVersion.Show();
            Hide();
        }

        #endregion
    }
}
