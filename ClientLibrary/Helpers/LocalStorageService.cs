using Blazored.LocalStorage;

namespace ClientLibrary.Helpers
{
    public class LocalStorageService(ILocalStorageService localStorage)
    {
        private const string StorageKey = "authentication-token";
        public async Task<string> GetToken() => await localStorage.GetItemAsStringAsync(StorageKey);
        public async Task SetToken(string item) => await localStorage.SetItemAsStringAsync(StorageKey, item);
        public async Task RemoveToken() => await localStorage.RemoveItemAsync(StorageKey);
    }
}
