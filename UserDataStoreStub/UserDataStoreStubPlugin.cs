using OpenMod.API.Plugins;
using OpenMod.Unturned.Plugins;
using System;

[assembly: PluginMetadata("EvolutionPlugins.UserDataStoreStub", DisplayName = "UserDataStoreStub")]

namespace EvolutionPlugins.UserDataStoreStub;

public class UserDataStoreStubPlugin : OpenModUnturnedPlugin
{
    public UserDataStoreStubPlugin(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
}
