using HarmonyLib;

namespace shared_upgrades.upgrade_interceptors;

[HarmonyPatch(typeof(ItemUpgradeDeathHeadBattery))]
public class DeathHeadBattery
{
    [HarmonyPatch("Upgrade")]
    [HarmonyPrefix]
    internal static bool Prefix()
    {
        foreach (var player in SemiFunc.PlayerGetAll())
        {
            PunManager.instance.UpgradeDeathHeadBattery(SemiFunc.PlayerGetSteamID(player));
            shared_upgrades.Logger.LogInfo(
                $"Death head Battery Upgrade added to player {SemiFunc.PlayerGetName(player)}");
        }

        return false; // Prevent the original function also adding an upgrade
    }
}
