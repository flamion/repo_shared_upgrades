# About this mod
This mod allows you to share upgrades with the other players.

Last tested with Repo 0.3.0 (Monster Update)

Only the host needs to have the mod installed, though note that (currently) when a player consumes an upgrade, it's 
not immediately visible in the interface of the other players, they will be active but only show up in the other 
players interfaces after the next scene change (eg. waiting-in-cart -> level starting).

# Manual installation
To manually install the mod you need a copy of [BepInEx](https://github.com/BepInEx/BepInEx/releases/tag/v5.4.23.4)

Follow these steps:
- Download [BepInEx](https://github.com/BepInEx/BepInEx/releases/tag/v5.4.23.4)
- Unzip the contents of the BepInEx zip into your game folder (there should now be a `BepInEx` folder next to a
`MonoBleedingEdge` and `REPO_Data` folder)
- Download the mod (either from here or from the 
[GitHub Release](https://github.com/flamion/repo_shared_upgrades/releases/latest) (you will most likely want the 
non-debug) version, i.e. `shared_upgrades-vX.Y.Z.dll`)
- Throw the DLL into `GAMEFOLDER/BepInEx/plugins` (the plugins folder might not exist yet, if it's not there 
just create it)
- That's it, the mod should be installed. 
- To make really sure it's installed, open the games data folder while the game is running 
(e.g. `%USERPROFILE%\AppData\LocalLow\semiwork\Repo` on Windows)
- Open the `Player.log` file and search for a line that looks similar to this:
`[Info   :shared_upgrades] flamion.shared_upgrades vX.Y.Z has loaded!`
