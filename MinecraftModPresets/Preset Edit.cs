using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MinecraftModPresets.interfaces;
using MinecraftModPresets.library;
using System.IO;

namespace MinecraftModPresets
{
    public partial class Preset_Edit : Form
    {
        #region Class Declarations
        private PresetsPage ReferencePresets { get; set; }
        private MinecraftVersion Version { get; set; }
        private Preset PresetToEdit { get; set; }

        private List<string> ModsToEdit { get; set; }
        //private List<Mod> ModsToEdit { get; set; }

        private DataTable modsTable;

        private ILogger logger = Tools.GetLogger();

        #endregion

        #region Constructor and Loader
        public Preset_Edit(PresetsPage presetsPage, MinecraftVersion version, Preset preset)
        {
            ReferencePresets = presetsPage;
            Version = version;
            PresetToEdit = preset;
            //ModsToEdit = new List<Mod>();
            ModsToEdit = new List<string>();

            InitializeComponent();
        }

        private void Preset_Edit_Load(object sender, EventArgs e)
        {
            modsTable = new DataTable();
            modsTable.Columns.Add("Name", typeof(string));

            ModsInPresetDataGridView.DataSource = modsTable;

            ModsInPresetDataGridView.Columns["Name"].Width = ModsInPresetDataGridView.Width;
            ModsInPresetDataGridView.Columns["Name"].SortMode = DataGridViewColumnSortMode.NotSortable;

            PresetNameTextBox.Text = PresetToEdit.Name;
            /* foreach (var mod in PresetToEdit.Mods)
            {
                AddMod(mod);
            } */
            foreach (var mod in PresetToEdit.ModPaths)
            {
                AddMod(mod);
            }

            AddActiveModsButton.Enabled = false;
            AddStoredModsButton.Enabled = false;
        }

        #endregion

        #region Methods

        /* private void AddMod(Mod mod)
        {
            ModsToEdit.Add(mod);

            modsTable.Rows.Add(mod.Name);
        } */

        private void AddMod(string mod)
        {
            ModsToEdit.Add(mod);

            modsTable.Rows.Add(Path.GetFileName(mod));
        }

        #endregion

        #region Button Clicks

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Preset_Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferencePresets.Show();
        }

        private void EditVersionButton_Click(object sender, EventArgs e)
        {
            string name = PresetNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                _ = MessageBox.Show("Preset Name note specified.", "Warning");
                return;
            }

            if (ModsToEdit.Count == 0)
            {
                _ = MessageBox.Show("This preset is empty!", "Warning");
                return;
            }

            PresetToEdit.Name = name;
            //PresetToEdit.Mods = ModsToEdit;
            PresetToEdit.ModPaths = ModsToEdit;

            ReferencePresets.RefreshPresetsDataGridView();
            ReferencePresets.Show();
            Close();
        }

        private void AddActiveModsButton_Click(object sender, EventArgs e)
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
            }

            AddActiveModsButton.Enabled = false;
        }

        /* private void AddActiveModsButton_Click(object sender, EventArgs e)
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

        private void AddStoredModsButton_Click(object sender, EventArgs e)
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

        /* private void AddStoredModsButton_Click(object sender, EventArgs e)
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
            ModsToEdit.Clear();
            modsTable.Rows.Clear();

            AddActiveModsButton.Enabled = true;
            AddStoredModsButton.Enabled = true;
        }

        #endregion
    }
}
