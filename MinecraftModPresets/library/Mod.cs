using System;
using System.Collections.Generic;
using System.Text;

namespace MinecraftModPresets.library
{
    /// <summary>
    /// The Mod that is stored in a Preset that represents a Minecraft Mod file.
    /// </summary>
    public class Mod
    {
        /// <summary>
        /// The Identification of the Mod.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The Name of the Mod.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The File Name of the Mod.
        /// </summary>
        public string FileName { get; set; }
    }
}
