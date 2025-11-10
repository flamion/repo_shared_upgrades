using HarmonyLib;

namespace shared_upgrades.upgrade_interceptors;

[HarmonyPatch(typeof(ItemUpgradePlayerTumbleWings))]
public class PlayerTumbleWings
{
    [HarmonyPatch("Upgrade")]
    [HarmonyPrefix]
    internal static bool Prefix()
    {
        foreach (var player in SemiFunc.PlayerGetAll())
        {
            PunManager.instance.UpgradePlayerTumbleWings(SemiFunc.PlayerGetSteamID(player));
            shared_upgrades.Logger.LogInfo($"Player Tumble Wings Upgrade added to player {SemiFunc.PlayerGetName(player)}");
        }

        return false; // Prevent the original function also adding an upgrade
    }
}