using HarmonyLib;
using OpenMod.Unturned.Users;

namespace EvolutionPlugins.UserDataStoreStub.Patches;
[HarmonyPatch(typeof(UnturnedUserProvider))]
internal static class Patch_UnturnedUserProvider
{
    [HarmonyPatch("UpdateLastSeen")]
    [HarmonyPrefix]
    public static bool UpdateLastSeen() => false; // force skip the method
}
