
using System;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace InfiniteFilters
{
    [BepInPlugin("net.BassJunkz.stationeers.InfiniteFilters", "Makes Filters Infinite", "1.0.0.0")]
    public class InfiniteFiltersPlugin : BaseUnityPlugin
    {
        public static InfiniteFiltersPlugin Instance;


        public void Log(string line)
        {
            Debug.Log("[InfiniteFilters]: " + line);
        }

        void Awake()
        {
            InfiniteFiltersPlugin.Instance = this;
            Log("Hello World");

            try
            {
                // Harmony.DEBUG = true;
                var harmony = new Harmony("net.BassJunkz.stationeers.InfiniteFilters");
                harmony.PatchAll();
                Log("Patch succeeded");
            }
            catch (Exception e)
            {
                Log("Patch Failed");
                Log(e.ToString());
            }
        }
    }
}