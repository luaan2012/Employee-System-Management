using System.Text.Json;

namespace ClientLibrary.Helpers
{
    public static class Serialization
    {
        public static string SerializeObj<T>(T obj) => JsonSerializer.Serialize(obj);
        public static T DeserializeJsonString<T>(string obj) => JsonSerializer.Deserialize<T>(obj);
        public static IList<T> DeserializeJsonStringList<T>(string obj) => JsonSerializer.Deserialize<IList<T>>(obj);
    }
}
