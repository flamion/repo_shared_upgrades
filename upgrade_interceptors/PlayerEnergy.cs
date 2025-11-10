using HarmonyLib;

namespace shared_upgrades.upgrade_interceptors;

[HarmonyPatch(typeof(ItemUpgradePlayerEnergy))]
public class PlayerEnergy
{
    [HarmonyPatch("Upgrade")]
    [HarmonyPrefix]
    internal static bool Prefix()
    {
        foreach (var player in SemiFunc.PlayerGetAll())
        {
            PunManager.instance.UpgradePlayerEnergy(SemiFunc.PlayerGetSteamID(player));
            shared_upgrades.Logger.LogInfo($"Player Energy Upgrade added to player {SemiFunc.PlayerGetName(player)}");
        }

        return false; // Prevent the original function also adding an upgrade
    }
}
