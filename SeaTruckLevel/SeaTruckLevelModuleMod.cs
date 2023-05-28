using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeaTruckLevel
{
    public class SeaTruckLevelModuleMod
    {
        [HarmonyPatch(typeof(SeaTruckUpgrades))]
        [HarmonyPostfix]
        public static void Start_Postfix(SeaTruckUpgrades __instance)
        {
            // Double the knife damage
            float knifeDamage = __instance;
            float newKnifeDamage = knifeDamage * 2.0f;
            __instance.damage = newKnifeDamage;
            KnifeDamagePlugin_BZ.logger.LogInfo($"Knife damage was: {knifeDamage}, is now {newKnifeDamage}");
        }
    }
}


/*
 create module
    - figure out how to track up and down
    - figure out how to make a seatruck upgrade
 need to add tech type
 */