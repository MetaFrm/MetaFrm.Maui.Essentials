namespace MetaFrm.Maui.Storage
{
    /// <summary>
    /// Provides simple secure storage for key/value pairs.
    /// </summary>
    /// <remarks>Each platform uses the platform provided native API's for storing data securely:
    /// • iOS: Data is stored in KeyChain. Additional information on SecAccessible at:
    /// Security.SecAccessible –
    /// • Android: Encryption keys are stored in KeyStore and encrypted data is stored
    /// in a named shared preference container (PackageId.Microsoft.Maui.Essentials).
    /// –
    /// • UWP: Data is encrypted with DataProtectionProvider and stored in a named ApplicationDataContainer
    /// (with a container name of ApplicationId.Microsoft.Maui.Essentials). –
    /// NOTE: On Android devices running below API 23 (6.0 Marshmallow) there is no AES
    /// available in KeyStore. As a best practice this API will generate an RSA/ECB/PKCS7Padding
    /// key pair stored in KeyStore (the only type supported in KeyStore by these lower
    /// API levels), which is used to wrap an AES key generated at runtime. This wrapped
    /// key is stored in Preferences.</remarks>
    public class SecureStorage : ISecureStorage
    {
        /// <summary>
        /// Gets the decrypted value for a given Key.
        /// </summary>
        /// <param name="key">Storage Key.</param>
        /// <returns>Decrypted string or null if key does not exist.</returns>
        public async Task<string> GetAsync(string key)
        {
            return await Microsoft.Maui.Storage.SecureStorage.Default.GetAsync(key);
        }

        /// <summary>
        /// Removes the encrypted key/value pair for the given key.
        /// </summary>
        /// <param name="key">The key to remove.</param>
        /// <returns>Returns true if the key value pair was removed.</returns>
        public bool Remove(string key)
        {
            return Microsoft.Maui.Storage.SecureStorage.Default.Remove(key);
        }

        /// <summary>
        /// Removes all of the stored encrypted key/value pairs.
        /// </summary>
        public void RemoveAll()
        {
            Microsoft.Maui.Storage.SecureStorage.Default.RemoveAll();
        }

        /// <summary>
        /// SetAsync
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public async Task SetAsync(string key, string value)
        {
            await Microsoft.Maui.Storage.SecureStorage.Default.SetAsync(key, value);
        }
    }
}