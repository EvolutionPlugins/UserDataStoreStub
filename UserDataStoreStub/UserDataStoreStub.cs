using OpenMod.API.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EvolutionPlugins.UserDataStoreStub;

internal class StubUserDataStore : IUserDataStore
{
    public Task<UserData?> GetUserDataAsync(string userId, string userType)
    {
        return Task.FromResult<UserData?>(null);
    }

    public Task<T?> GetUserDataAsync<T>(string userId, string userType, string key)
    {
        return Task.FromResult<T?>(default);
    }

    public Task<IReadOnlyCollection<UserData>> GetUsersDataAsync(string type)
    {
        return Task.FromResult<IReadOnlyCollection<UserData>>(new List<UserData>());
    }

    public Task SetUserDataAsync<T>(string userId, string userType, string key, T? value)
    {
        return Task.CompletedTask;
    }

    public Task SetUserDataAsync(UserData userData)
    {
        return Task.CompletedTask;
    }
}
