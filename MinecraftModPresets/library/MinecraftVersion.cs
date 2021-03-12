using System;
using System.Collections.Generic;
using System.Text;

namespace MinecraftModPresets.library
{
    /// <summary>
    /// The Version of Minecraft that will store the presets of Mods.
    /// </summary>
    public class MinecraftVersion
    {
        /// <summary>
        /// The Identification of the Minecraft Version.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The Name of the Minecraft Version.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Path to the Mods Directory.
        /// </summary>
        public string ActiveFolderPath { get; set; }
        /// <summary>
        /// The Path to the Directory to store the Mods.
        /// </summary>
        public string StorageFolderPath { get; set; }
        /// <summary>
        /// A Container of the Presets stored in this Minecraft Version.
        /// </summary>
        public List<Preset> Presets { get; set; }
        /// <summary>
        /// A Container of the Forever Mods.
        /// </summary>
        public List<Mod> ForeverMods { get; set; }
    }
}
