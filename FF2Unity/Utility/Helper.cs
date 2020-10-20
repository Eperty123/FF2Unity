using FF2Unity.Definition;

namespace FF2Unity.Utility
{
    public static class Helper
    {
        /// <summary>
        /// Get the cache's cache folder name.
        /// </summary>
        /// <param name="cache">The cache to use.</param>
        /// <param name="cacheFolder">The input cache folder the cache file is found in.</param>
        /// <returns></returns>
        public static string GetCacheFolderName(this Cache cache, string cacheFolder)
        {
            return cache.CacheFolderName.Replace(cacheFolder + "\\", "");
        }
    }
}
