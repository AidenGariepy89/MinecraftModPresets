using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using MinecraftModPresets.interfaces;
using Newtonsoft.Json;

namespace MinecraftModPresets.library
{
    static class Tools
    {
        public static string baseDir = $@"{Directory.GetCurrentDirectory()}\bin";
        private static readonly string logDir = $@"{baseDir}\log";
        private static readonly string saveDir = $@"{baseDir}\save";
        public static int IdNumber { get; set; } = 9275;
        public static void BaseDir()
        {
            // Main Directory
            Directory.CreateDirectory(baseDir);

            // Sub Directories
            Directory.CreateDirectory(logDir);
            Directory.CreateDirectory(saveDir);

        }

        public static void SaveAll(List<MinecraftVersion> versions, ILogger log)
        {
            #region Get Rid of Trash Files

            string[] filesInSaves = Directory.GetFiles(saveDir);
            for (var i = 0; i < filesInSaves.Length; i++)
            {
                string[] fileNamePhrases = filesInSaves[i].Split('_');
                bool foundMatch = false;
                foreach (var version in versions)
                {
                    if (version.Name == fileNamePhrases[0])
                    {
                        foundMatch = true;
                    }
                }

                if (!foundMatch)
                {
                    File.Delete(filesInSaves[i]);
                }
            }

            #endregion

            #region Create Version File

            foreach (var version in versions)
            {
                // Create Version File Path
                string versionJsonPath = Path.Combine(saveDir, $"{version.Name}_{version.Id}_Version.json");

                // Serialize Version into Json
                string versionResultJson = JsonConvert.SerializeObject(version);

                // Write versionResultJson into version.json
                File.WriteAllText(versionJsonPath, versionResultJson);
                log.LogMessage($"Saved Version {version.Name} to {versionJsonPath}", LogLevel.Debug);
            }

            #endregion
        }

        public static void LoadAll(List<MinecraftVersion> versions, ILogger log)
        {
            foreach (var versionJsonFile in Directory.GetFiles(saveDir))
            {
                #region Read Version Files
                // Read Version File
                string versionReadJson = File.ReadAllText(versionJsonFile);

                // Deserialize versionReadJson
                var resultVersion = JsonConvert.DeserializeObject<MinecraftVersion>(versionReadJson);

                // Adds resultVersion to Argument versions
                versions.Add(resultVersion);
                log.LogMessage($"Loaded {resultVersion.Name} from {saveDir}");
                #endregion
            }
        }

        public static int CreateId()
        {
            Random r = new Random();
            int id = IdNumber + r.Next(999999);

            return id;
        }

        public static ILogger GetLogger()
        {
            return new FileLogger($@"{logDir}\log.txt")
            {
                LogLevel = LogLevel.Debug
            };
        }
    }
}
