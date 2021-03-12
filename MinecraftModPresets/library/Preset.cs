using System;
using System.Collections.Generic;
using System.Text;

namespace MinecraftModPresets.library
{
    /// <summary>
    /// The Preset stored in a Version that stores Mods to be loaded.
    /// </summary>
    public class Preset
    {
        /// <summary>
        /// The Identification of the Preset.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The Name of the Preset.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Container of Mods stored in the Preset.
        /// </summary>
        public List<Mod> Mods { get; set; }
    }
}
