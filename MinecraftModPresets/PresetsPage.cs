using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MinecraftModPresets.library;
using MinecraftModPresets.interfaces;
using System.IO;
using System.Linq;

namespace MinecraftModPresets
{
    public partial class PresetsPage : Form
    {
        #region Class Declarations
        private StartWindow ReferenceMain { get; set; }
        private MinecraftVersion Version { get; set; }

        private DataTable presetsTable;

        private DataTable activeModsTable;

        private ILogger logger = Tools.GetLogger();

        #endregion

        #region Constructor and Loader

        public PresetsPage(StartWindow startWindow, MinecraftVersion version)
        {
            ReferenceMain = startWindow;
            Version = version;

            InitializeComponent();

            this.Text = $"{Version.Name} : Presets";
            VersionNameLabel.Text = Version.Name;
        }

        private void PresetsPage_Load(object sender, EventArgs e)
        {
            presetsTable = new DataTable();
            activeModsTable = new DataTable();

            Version.ModsInActiveFolder = new List<string>();
            Version.ModsInStorageFolder = new List<string>();

            presetsTable.Columns.Add("Name", typeof(string));
            presetsTable.Columns.Add("Id", typeof(int));
            activeModsTable.Columns.Add("Name", typeof(string));

            PresetsDataGridView.DataSource = presetsTable;
            ActiveModsDataGridView.DataSource = activeModsTable;

            RefreshPresetsDataGridView();
            RefreshActiveAndStoredMods();
            RefreshActiveModsDataGridView();

            PresetsDataGridView.Columns["Name"].Width = PresetsDataGridView.Width;
            PresetsDataGridView.Columns["Name"].SortMode = DataGridViewColumnSortMode.NotSortable;
            PresetsDataGridView.Columns["Id"].Visible = false;
            ActiveModsDataGridView.Columns["Name"].Width = ActiveModsDataGridView.Width;
            ActiveModsDataGridView.Columns["Name"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        #endregion

        #region Methods

        public void RefreshPresetsDataGridView()
        {
            var presets = Version.Presets;

            presetsTable.Rows.Clear();

            PresetsDataGridView.CurrentCell = null;

            foreach (var preset in presets)
            {
                presetsTable.Rows.Add(preset.Name, preset.Id);
                logger.LogMessage($"Added preset {preset.Name} to Presets Data Grid View", LogLevel.Verbose);
            }
        }

        private void RefreshActiveAndStoredMods()
        {
            Version.ModsInActiveFolder.Clear();
            Version.ModsInStorageFolder.Clear();

            IEnumerable<string> modsInActiveEnumerable =
                from file in Directory.GetFiles(Version.ActiveFolderPath)
                where file.ToLower().EndsWith(".jar") || file.ToLower().EndsWith(".zip")
                select file;
            foreach (var file in modsInActiveEnumerable)
            {
                Version.ModsInActiveFolder.Add(file);
            }

            IEnumerable<string> modsInStorageEnumerable =
                from file in Directory.GetFiles(Version.StorageFolderPath)
                where file.ToLower().EndsWith(".jar") || file.ToLower().EndsWith(".zip")
                select file;
            foreach (var file in modsInStorageEnumerable)
            {
                Version.ModsInStorageFolder.Add(file);
            }
        }

        private void RefreshActiveModsDataGridView()
        {
            activeModsTable.Rows.Clear();
            ActiveModsDataGridView.CurrentCell = null;

            foreach (var mod in Version.ModsInActiveFolder)
            {
                activeModsTable.Rows.Add(Path.GetFileName(mod));
            }
        }

        private void ConfirmModFilesExist(List<string> modFiles)
        {
            for (var i = 0; i < modFiles.Count; i++)
            {
                if (!File.Exists(modFiles[i]))
                {
                    var modMissing = new ModMissing(this, modFiles, i);
                    modMissing.Show();
                    Hide();
                }
            }
        }

        private void LoadPreset(Preset preset)
        {
            ConfirmModFilesExist(preset.ModPaths);

            var moveToActiveMods = GetModsToMoveToActive(preset);
            if (moveToActiveMods.Count > 0)
            {
                if (moveToActiveMods[0] == "--abort--")
                {
                    return;
                }
            }

            foreach (var file in moveToActiveMods)
            {
                MessageBox.Show(file);
            }

            MessageBox.Show("asdf");
        }

        private List<string> GetModsToMoveToActive(Preset preset)
        {
            var modsToMove = new List<string>();

            foreach (var modFile in preset.ModPaths)
            {
                if (Path.GetDirectoryName(modFile) != Version.ActiveFolderPath)
                {
                    foreach (var activeFile in Version.ModsInActiveFolder)
                    {
                        if (Path.GetFileName(activeFile) == Path.GetFileName(modFile))
                        {
                            _ = MessageBox.Show($"A file with the name {Path.GetFileName(modFile)} already exists in the folder you are trying to move the file to. " +
                                $"Aborting preset load.", "Warning", MessageBoxButtons.OK);

                            return new List<string>() { "--abort--" };
                        }
                    }

                    modsToMove.Add(modFile);
                }
            }

            return modsToMove;
        }

        #endregion

        #region Button Clicks
        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PresetsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceMain.Show();
        }

        private void CreatePresetButton_Click(object sender, EventArgs e)
        {
            var presetsPage = new Preset_Create(this, Version);
            
            presetsPage.Show();
            Hide();
        }

        private void DeletePresetButton_Click(object sender, EventArgs e)
        {
            if (PresetsDataGridView.Rows.Count != 0)
            {
                if (PresetsDataGridView.CurrentCell.RowIndex >= 0)
                {
                    var presetToDelete = Version.Presets[PresetsDataGridView.CurrentCell.RowIndex];
                    DialogResult dr = MessageBox.Show($"Are you sure you want to delete preset {presetToDelete.Name}?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Version.Presets.Remove(presetToDelete);
                        RefreshPresetsDataGridView();
                    }
                }
            }
        }

        private void EditPresetButton_Click(object sender, EventArgs e)
        {
            if (PresetsDataGridView.Rows.Count != 0)
            {
                int index = PresetsDataGridView.CurrentCell.RowIndex;
                if (index >= 0)
                {
                    var presetsPage = new Preset_Edit(this, Version, Version.Presets[index]);

                    presetsPage.Show();
                    Hide();
                }
            }
        }

        private void LoadPresetButton_Click(object sender, EventArgs e)
        {
            if (PresetsDataGridView.Rows.Count != 0)
            {
                var index = PresetsDataGridView.CurrentCell.RowIndex;
                if (index >= 0)
                {
                    LoadPreset(Version.Presets[index]);
                }
            }
        }

        #endregion

        private void EditAlwaysModsButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}


/* private void LoadPreset(Preset preset)
        {
            List<string> moveToStorageMods = GetModPathsToMoveIntoStorage(preset);
            List<string> moveToActiveMods = GetModPathsToMoveIntoActive(preset);

            /*foreach (var mod in moveToStorageMods)
            {
                _ = MessageBox.Show($"To Storage: {mod}");
            }

            foreach (var mod in moveToActiveMods)
            {
                _ = MessageBox.Show($"To Active: {mod}");
            }
        } */

/// <summary>
/// Gets the Paths of Mods to Move to the Storage Folder.
/// </summary>
/// <param name="preset"> The Preset of Mods to become Active. </param>
/// <returns> 
/// A list of mod paths that does not have the same path as any active mod's path,
/// or the same file name as any active mod file name. Same for forever mods.
/// </returns>
/* private List<string> GetModPathsToMoveIntoStorage(Preset preset)
{
    var modsToMove = new List<string>();
    var foreverMods = Version.ForeverMods;
    var activeMods = preset.Mods;

    IEnumerable<string> modFilesInActiveEnumerable =
        from file in Directory.GetFiles(Version.ActiveFolderPath, "*.*")
        where file.ToLower().EndsWith(".jar") || file.ToLower().EndsWith(".zip")
        select file;
    var modFilesInActive = new List<string>();
    foreach (var file in modFilesInActiveEnumerable)
    {
        modFilesInActive.Add(file);
    }

    foreach (var file in modFilesInActive)
    {
        bool moveToStorage = true;
        foreach (var activeMod in activeMods)
        {
            if (file == activeMod.FileName || Path.GetFileName(file) == activeMod.Name)
            {
                moveToStorage = false;
            }
        }

        foreach (var foreverMod in foreverMods)
        {
            if (file == foreverMod.FileName || Path.GetFileName(file) == foreverMod.Name)
            {
                moveToStorage = false;
            }
        }

        if (moveToStorage)
        {
            modsToMove.Add(file);
        }
    }

    return modsToMove;
} */

/* private List<string> GetModPathsToMoveIntoActive(Preset preset)
{
    var modsToMove = new List<string>();
    var foreverMods = Version.ForeverMods;
    var activeMods = preset.Mods;

    IEnumerable<string> modFilesInStorageEnumerable =
        from file in Directory.GetFiles(Version.StorageFolderPath, "*.*")
        where file.ToLower().EndsWith(".jar") || file.ToLower().EndsWith(".zip")
        select file;
    var modFilesInStorage = new List<string>();
    foreach (var file in modFilesInStorageEnumerable)
    {
        modFilesInStorage.Add(file);
    }

    foreach (var file in modFilesInStorage)
    {
        bool moveToActive = false;
        foreach (var activeMod in activeMods)
        {
            if (file == activeMod.FileName || Path.GetFileName(file) == activeMod.Name)
            {
                moveToActive = true;
            }
        }

        foreach (var foreverMod in foreverMods)
        {
            if (file == foreverMod.FileName)
            {
                moveToActive = true;
            }
        }

        if (File.Exists(Path.Combine(Version.ActiveFolderPath, Path.GetFileName(file))))
        {
            moveToActive = false;
        }

        if (moveToActive)
        {
            modsToMove.Add(file);
        }
    }

    return modsToMove;
} */

//private void MoveModFiles(List<string> modsToMove, string directoryPath)
//{
//    foreach (var mod in modsToMove)
//    {

//    }
//}