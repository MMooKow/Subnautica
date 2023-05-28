using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Reflection;

namespace SeaTruckLevel
{
    [BepInPlugin(myGUID, pluginName, versionString)]
    public class SeaTruckLevelModulePlugin_BZ : BaseUnityPlugin
    {
        private const string myGUID = "drest.mmookow.seatrucklevelbz";
        private const string pluginName = "Seatruck Level Module Mod BZ";
        private const string versionString = "1.0.0";

        private static readonly Harmony harmony = new Harmony(myGUID);

        public static ManualLogSource logger;

        private void Awake()
        {
            harmony.PatchAll();
            Logger.LogInfo($"{pluginName} {versionString} loaded.");
            logger = Logger;
        }
    }
}