using HarmonyLib;

namespace shared_upgrades.upgrade_interceptors;

[HarmonyPatch(typeof(ItemUpgradePlayerGrabThrow))]
public class PlayerGrabThrow
{
    [HarmonyPatch("Upgrade")]
    [HarmonyPrefix]
    internal static bool Prefix()
    {
        foreach (var player in SemiFunc.PlayerGetAll())
        {
            PunManager.instance.UpgradePlayerThrowStrength(SemiFunc.PlayerGetSteamID(player));
            shared_upgrades.Logger.LogInfo($"Player Grab Throw Upgrade added to player {SemiFunc.PlayerGetName(player)}");
        }

        return false; // Prevent the original function also adding an upgrade
    }
}