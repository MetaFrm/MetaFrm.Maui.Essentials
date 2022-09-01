namespace MetaFrm.Maui.Storage
{
    /// <summary>
    /// A class to interact with the preferences/settings of the native platform.
    /// </summary>
    /// <remarks>Each platform uses the platform provided native APIs for storing application/user
    /// preferences:
    /// • iOS: NSUserDefaults –
    /// • Android: SharedPreferences –
    /// • UWP: ApplicationDataContainer –
    /// </remarks>
    public class Preferences : IPreferences
    {
        /// <summary>
        /// Clears all keys and values.
        /// </summary>
        public void Clear() => Microsoft.Maui.Storage.Preferences.Clear();

        /// <summary>
        /// Clears all keys and values.
        /// </summary>
        /// <param name="sharedName">Shared container name.</param>
        public void Clear(string sharedName) => Microsoft.Maui.Storage.Preferences.Clear(sharedName);

        /// <summary>
        /// Checks the existence of a given key.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <returns>Returns true if the key exists.</returns>
        public bool ContainsKey(string key) => Microsoft.Maui.Storage.Preferences.ContainsKey(key);

        /// <summary>
        /// Checks the existence of a given key.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="sharedName">Shared container name.</param>
        /// <returns>Returns true if the key exists.</returns>
        public bool ContainsKey(string key, string sharedName) => Microsoft.Maui.Storage.Preferences.ContainsKey(key, sharedName);

        /// <summary>
        /// Gets the value for a given key, or the default specified if the key does not exist.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="defaultValue">Default value to return if the key does not exist.</param>
        /// <param name="sharedName">Shared container key.</param>
        /// <returns>Value for the given key, or the default if it does not exist.</returns>
        public DateTime Get(string key, DateTime defaultValue, string sharedName) => Microsoft.Maui.Storage.Preferences.Get(key, defaultValue, sharedName);

        /// <summary>
        /// Gets the value for a given key, or the default specified if the key does not exist.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="defaultValue">Default value to return if the key does not exist.</param>
        /// <returns>Value for the given key, or the default if it does not exist.</returns>
        public DateTime Get(string key, DateTime defaultValue) => Microsoft.Maui.Storage.Preferences.Get(key, defaultValue);

        /// <summary>
        /// Gets the value for a given key, or the default specified if the key does not exist.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="defaultValue">Default value to return if the key does not exist.</param>
        /// <param name="sharedName">Shared container key.</param>
        /// <returns>Value for the given key, or the default if it does not exist.</returns>
        public long Get(string key, long defaultValue, string sharedName) => Microsoft.Maui.Storage.Preferences.Get(key, defaultValue, sharedName);

        /// <summary>
        /// Gets the value for a given key, or the default specified if the key does not exist.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="defaultValue">Default value to return if the key does not exist.</param>
        /// <param name="sharedName">Shared container key.</param>
        /// <returns>Value for the given key, or the default if it does not exist.</returns>
        public float Get(string key, float defaultValue, string sharedName) => Microsoft.Maui.Storage.Preferences.Get(key, defaultValue, sharedName);

        /// <summary>
        /// Gets the value for a given key, or the default specified if the key does not exist.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="defaultValue">Default value to return if the key does not exist.</param>
        /// <param name="sharedName">Shared container key.</param>
        /// <returns>Value for the given key, or the default if it does not exist.</returns>
        public double Get(string key, double defaultValue, string sharedName) => Microsoft.Maui.Storage.Preferences.Get(key, defaultValue, sharedName);

        /// <summary>
        /// Gets the value for a given key, or the default specified if the key does not exist.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="defaultValue">Default value to return if the key does not exist.</param>
        /// <param name="sharedName">Shared container key.</param>
        /// <returns>Value for the given key, or the default if it does not exist.</returns>
        public int Get(string key, int defaultValue, string sharedName) => Microsoft.Maui.Storage.Preferences.Get(key, defaultValue, sharedName);

        /// <summary>
        /// Gets the value for a given key, or the default specified if the key does not exist.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="defaultValue">Default value to return if the key does not exist.</param>
        /// <param name="sharedName">Shared container key.</param>
        /// <returns>Value for the given key, or the default if it does not exist.</returns>
        public bool Get(string key, bool defaultValue, string sharedName) => Microsoft.Maui.Storage.Preferences.Get(key, defaultValue, sharedName);

        /// <summary>
        /// Gets the value for a given key, or the default specified if the key does not exist.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="defaultValue">Default value to return if the key does not exist.</param>
        /// <param name="sharedName">Shared container key.</param>
        /// <returns>Value for the given key, or the default if it does not exist.</returns>
        public string Get(string key, string defaultValue, string sharedName) => Microsoft.Maui.Storage.Preferences.Get(key, defaultValue, sharedName);

        /// <summary>
        /// Gets the value for a given key, or the default specified if the key does not exist.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="defaultValue">Default value to return if the key does not exist.</param>
        /// <returns>Value for the given key, or the default if it does not exist.</returns>
        public double Get(string key, double defaultValue) => Microsoft.Maui.Storage.Preferences.Get(key, defaultValue);

        /// <summary>
        /// Gets the value for a given key, or the default specified if the key does not exist.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="defaultValue">Default value to return if the key does not exist.</param>
        /// <returns>Value for the given key, or the default if it does not exist.</returns>
        public bool Get(string key, bool defaultValue) => Microsoft.Maui.Storage.Preferences.Get(key, defaultValue);

        /// <summary>
        /// Gets the value for a given key, or the default specified if the key does not exist.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="defaultValue">Default value to return if the key does not exist.</param>
        /// <returns>Value for the given key, or the default if it does not exist.</returns>
        public int Get(string key, int defaultValue) => Microsoft.Maui.Storage.Preferences.Get(key, defaultValue);

        /// <summary>
        /// Gets the value for a given key, or the default specified if the key does not exist.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="defaultValue">Default value to return if the key does not exist.</param>
        /// <returns>Value for the given key, or the default if it does not exist.</returns>
        public float Get(string key, float defaultValue) => Microsoft.Maui.Storage.Preferences.Get(key, defaultValue);

        /// <summary>
        /// Gets the value for a given key, or the default specified if the key does not exist.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="defaultValue">Default value to return if the key does not exist.</param>
        /// <returns>Value for the given key, or the default if it does not exist.</returns>
        public long Get(string key, long defaultValue) => Microsoft.Maui.Storage.Preferences.Get(key, defaultValue);

        /// <summary>
        /// Gets the value for a given key, or the default specified if the key does not exist.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="defaultValue">Default value to return if the key does not exist.</param>
        /// <returns>Value for the given key, or the default if it does not exist.</returns>
        public string Get(string key, string defaultValue) => Microsoft.Maui.Storage.Preferences.Get(key, defaultValue);

        /// <summary>
        /// Removes a key and its associated value if it exists.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="sharedName">Shared container name.</param>
        public void Remove(string key, string sharedName) => Microsoft.Maui.Storage.Preferences.Remove(key, sharedName);

        /// <summary>
        /// Removes a key and its associated value if it exists.
        /// </summary>
        /// <param name="key">Preference key.</param>
        public void Remove(string key) => Microsoft.Maui.Storage.Preferences.Remove(key);

        /// <summary>
        /// Sets a value for a given key.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="value">Preference value.</param>
        public void Set(string key, bool value) => Microsoft.Maui.Storage.Preferences.Set(key, value);

        /// <summary>
        /// Sets a value for a given key.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="value">Preference value.</param>
        public void Set(string key, string value) => Microsoft.Maui.Storage.Preferences.Set(key, value);

        /// <summary>
        /// Sets a value for a given key.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="value">Preference value.</param>
        /// <param name="sharedName">Shared container name.</param>
        public void Set(string key, DateTime value, string sharedName) => Microsoft.Maui.Storage.Preferences.Set(key, value, sharedName);

        /// <summary>
        /// Sets a value for a given key.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="value">Preference value.</param>
        public void Set(string key, double value) => Microsoft.Maui.Storage.Preferences.Set(key, value);

        /// <summary>
        /// Sets a value for a given key.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="value">Preference value.</param>
        /// <param name="sharedName">Shared container name.</param>
        public void Set(string key, string value, string sharedName) => Microsoft.Maui.Storage.Preferences.Set(key, value, sharedName);

        /// <summary>
        /// Sets a value for a given key.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="value">Preference value.</param>
        /// <param name="sharedName">Shared container name.</param>
        public void Set(string key, bool value, string sharedName) => Microsoft.Maui.Storage.Preferences.Set(key, value, sharedName);

        /// <summary>
        /// Sets a value for a given key.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="value">Preference value.</param>
        /// <param name="sharedName">Shared container name.</param>
        public void Set(string key, int value, string sharedName) => Microsoft.Maui.Storage.Preferences.Set(key, value, sharedName);

        /// <summary>
        /// Sets a value for a given key.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="value">Preference value.</param>
        /// <param name="sharedName">Shared container name.</param>
        public void Set(string key, double value, string sharedName) => Microsoft.Maui.Storage.Preferences.Set(key, value, sharedName);

        /// <summary>
        /// Sets a value for a given key.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="value">Preference value.</param>
        /// <param name="sharedName">Shared container name.</param>
        public void Set(string key, float value, string sharedName) => Microsoft.Maui.Storage.Preferences.Set(key, value, sharedName);

        /// <summary>
        /// Sets a value for a given key.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="value">Preference value.</param>
        /// <param name="sharedName">Shared container name.</param>
        public void Set(string key, long value, string sharedName) => Microsoft.Maui.Storage.Preferences.Set(key, value, sharedName);

        /// <summary>
        /// Sets a value for a given key.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="value">Preference value.</param>
        public void Set(string key, int value) => Microsoft.Maui.Storage.Preferences.Set(key, value);

        /// <summary>
        /// Sets a value for a given key.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="value">Preference value.</param>
        public void Set(string key, DateTime value) => Microsoft.Maui.Storage.Preferences.Set(key, value);

        /// <summary>
        /// Sets a value for a given key.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="value">Preference value.</param>
        public void Set(string key, long value) => Microsoft.Maui.Storage.Preferences.Set(key, value);

        /// <summary>
        /// Sets a value for a given key.
        /// </summary>
        /// <param name="key">Preference key.</param>
        /// <param name="value">Preference value.</param>
        public void Set(string key, float value) => Microsoft.Maui.Storage.Preferences.Set(key, value);
    }
}