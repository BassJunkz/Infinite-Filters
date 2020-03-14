
using Assets.Scripts;
using Assets.Scripts.Networking;
using Assets.Scripts.Objects;
using Assets.Scripts.Objects.Entities;
using Assets.Scripts.Objects.Items;
using HarmonyLib;
using UnityEngine;

namespace InfiniteFilters
{

    [HarmonyPatch(typeof(GasFilter), "CheckUsedTicks")]
    class GasFilterInfinitePatch
    {
        static bool Prefix()
        {
            return false;//Tell Harmony that the function isn't allowed to run
        }

    }
}