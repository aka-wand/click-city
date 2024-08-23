namespace ClickCity.Application.Common
{
    public class ScopeCache : Dictionary<string, object>
    {
        public T? Get<T>(string key)
        {
            if (!TryGetValue(key, out var value))
            {
                return default;
            }

            return (T)value;
        }
    }
}