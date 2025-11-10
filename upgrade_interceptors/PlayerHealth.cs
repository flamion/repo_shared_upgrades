using HarmonyLib;

namespace shared_upgrades.upgrade_interceptors;

[HarmonyPatch(typeof(ItemUpgradePlayerHealth))]
public class PlayerHealth
{
    [HarmonyPatch("Upgrade")]
    [HarmonyPrefix]
    internal static bool Prefix()
    {
        foreach (var player in SemiFunc.PlayerGetAll())
        {
            PunManager.instance.UpgradePlayerHealth(SemiFunc.PlayerGetSteamID(player));
            shared_upgrades.Logger.LogInfo($"Player Health Upgrade added to player {SemiFunc.PlayerGetName(player)}");
        }

        return false; // Prevent the original function also adding an upgrade
    }
}
