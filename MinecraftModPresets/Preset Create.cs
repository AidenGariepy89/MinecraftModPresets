using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using MinecraftModPresets.library;
using MinecraftModPresets.interfaces;

namespace MinecraftModPresets
{
    public partial class Preset_Create : Form
    {
        #region Class Declarations
        private PresetsPage ReferencePresets { get; set; }
        private MinecraftVersion Version { get; set; }
        //private List<Mod> ModsToAdd { get; set; }

        private List<string> ModsToAdd { get; set; }

        private DataTable modsTable;

        private ILogger logger = Tools.GetLogger();

        #endregion

        #region Constructor and Loader
        public Preset_Create(PresetsPage presetsPage, MinecraftVersion version)
        {
            ReferencePresets = presetsPage;
            Version = version;
            //ModsToAdd = new List<Mod>();
            ModsToAdd = new List<string>();

            InitializeComponent();
        }

        private void Preset_Create_Load(object sender, EventArgs e)
        {
            modsTable = new DataTable();
            modsTable.Columns.Add("Name", typeof(string));
            modsTable.Columns.Add("Id", typeof(int));

            ModsInPresetDataGridView.DataSource = modsTable;

            ModsInPresetDataGridView.Columns["Name"].Width = ModsInPresetDataGridView.Width;
            ModsInPresetDataGridView.Columns["Name"].SortMode = DataGridViewColumnSortMode.NotSortable;
            ModsInPresetDataGridView.Columns["Id"].Visible = false;
        }

        #endregion

        #region Methods

        private void AddMod(string mod)
        {
            ModsToAdd.Add(mod);

            modsTable.Rows.Add(Path.GetFileName(mod));
        }

        /* private void AddMod(Mod mod)
        {
            ModsToAdd.Add(mod);

            modsTable.Rows.Add(mod.Name, mod.Id);
        } */

        #endregion

        #region Button Clicks
        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Preset_Create_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferencePresets.Show();
        }

        private void CreateVersionButton_Click(object sender, EventArgs e)
        {
            string name = PresetNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                _ = MessageBox.Show("Preset Name not specified.", "Warning");
                return;
            }

            if (ModsToAdd.Count == 0)
            {
                _ = MessageBox.Show("This preset is empty!", "Warning");
                return;
            }

            //Version.Presets.Add(new Preset() { Name = name , Mods = ModsToAdd, Id = Tools.CreateId() });
            Version.Presets.Add(new Preset() { Name = name, ModPaths = ModsToAdd, Id = Tools.CreateId() });

            ReferencePresets.RefreshPresetsDataGridView();
            ReferencePresets.Show();
            Close();
        }

        private void AddActiveMods_Click(object sender, EventArgs e)
        {
            foreach (var modFile in Version.ModsInActiveFolder)
            {
                bool addFile = true;

                if (IgnoreForeverModsCheckBox.Checked == true)
                {
                    foreach (var foreverMod in Version.ForeverMods)
                    {
                        if (foreverMod == modFile)
                            addFile = false;
                    }
                }

                if (addFile)
                    AddMod(modFile);
                //ModsToAdd.Add(modFile);
            }

            AddActiveModsButton.Enabled = false;
        }

        /* private void AddActiveMods_Click(object sender, EventArgs e)
        {
            var activeDir = Version.ActiveFolderPath;
            string[] modJarFiles = Directory.GetFiles(activeDir, "*.jar");
            string[] modZipFiles = Directory.GetFiles(activeDir, "*.zip");

            foreach (var modJarFile in modJarFiles)
            {
                if (IgnoreForeverModsCheckBox.Checked == true)
                {
                    bool isForeverMod = false;

                    foreach (var foreverMod in Version.ForeverMods)
                    {
                        if (Path.GetFileName(modJarFile) == Path.GetFileName(foreverMod.Name))
                        {
                            isForeverMod = false;
                        }
                    }

                    if (!isForeverMod)
                    {
                        AddMod(new Mod() { Name = Path.GetFileName(modJarFile), FileName = modJarFile, Id = Tools.CreateId() });
                    }
                }
                else
                {
                    AddMod(new Mod() { Name = Path.GetFileName(modJarFile), FileName = modJarFile, Id = Tools.CreateId() });
                }
            }

            foreach (var modZipFile in modZipFiles)
            {
                if (IgnoreForeverModsCheckBox.Checked == true)
                {
                    bool isForeverMod = false;

                    foreach (var foreverMod in Version.ForeverMods)
                    {
                        if (Path.GetFileName(modZipFile) == Path.GetFileName(foreverMod.Name))
                        {
                            isForeverMod = false;
                        }
                    }

                    if (!isForeverMod)
                    {
                        AddMod(new Mod() { Name = Path.GetFileName(modZipFile), FileName = modZipFile, Id = Tools.CreateId() });
                    }
                }
                else
                {
                    AddMod(new Mod() { Name = Path.GetFileName(modZipFile), FileName = modZipFile, Id = Tools.CreateId() });
                }
            }

            AddActiveModsButton.Enabled = false;
        } */

        private void AddStoredMods_Click(object sender, EventArgs e)
        {
            foreach (var modFile in Version.ModsInStorageFolder)
            {
                bool addFile = true;

                if (IgnoreForeverModsCheckBox.Checked == true)
                {
                    foreach (var foreverMod in Version.ForeverMods)
                    {
                        if (foreverMod == modFile)
                            addFile = false;
                    }
                }

                if (addFile)
                    AddMod(modFile);
            }

            AddStoredModsButton.Enabled = false;
        }

        /* private void AddStoredMods_Click(object sender, EventArgs e)
        {
            var activeDir = Version.StorageFolderPath;
            string[] modJarFiles = Directory.GetFiles(activeDir, "*.jar");
            string[] modZipFiles = Directory.GetFiles(activeDir, "*.zip");

            foreach (var modJarFile in modJarFiles)
            {
                if (IgnoreForeverModsCheckBox.Checked == true)
                {
                    bool isForeverMod = false;

                    foreach (var foreverMod in Version.ForeverMods)
                    {
                        if (Path.GetFileName(modJarFile) == Path.GetFileName(foreverMod.Name))
                        {
                            isForeverMod = false;
                        }
                    }

                    if (!isForeverMod)
                    {
                        AddMod(new Mod() { Name = Path.GetFileName(modJarFile), FileName = modJarFile, Id = Tools.CreateId() });
                    }
                }
                else
                {
                    AddMod(new Mod() { Name = Path.GetFileName(modJarFile), FileName = modJarFile, Id = Tools.CreateId() });
                }
            }

            foreach (var modZipFile in modZipFiles)
            {
                if (IgnoreForeverModsCheckBox.Checked == true)
                {
                    bool isForeverMod = false;

                    foreach (var foreverMod in Version.ForeverMods)
                    {
                        if (Path.GetFileName(modZipFile) == Path.GetFileName(foreverMod.Name))
                        {
                            isForeverMod = false;
                        }
                    }

                    if (!isForeverMod)
                    {
                        AddMod(new Mod() { Name = Path.GetFileName(modZipFile), FileName = modZipFile, Id = Tools.CreateId() });
                    }
                }
                else
                {
                    AddMod(new Mod() { Name = Path.GetFileName(modZipFile), FileName = modZipFile, Id = Tools.CreateId() });
                }
            }

            AddStoredModsButton.Enabled = false;
        } */

        private void ClearModsButton_Click(object sender, EventArgs e)
        {
            ModsToAdd.Clear();
            modsTable.Rows.Clear();

            AddActiveModsButton.Enabled = true;
            AddStoredModsButton.Enabled = true;
        }

        #endregion
    }
}
