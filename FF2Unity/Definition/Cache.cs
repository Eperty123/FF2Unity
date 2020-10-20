using FF2Unity.Utility;
using System.IO;
using System.Windows.Forms;

namespace FF2Unity.Definition
{
    /// <summary>
    /// The class for parsing a file as a Fusionfall cache file.
    /// </summary>
    public class Cache
    {
        #region Private Variables
        private string _CacheFile;
        private string _CacheName;
        private string _CacheFolderName;

        private bool _IsCacheValid;
        private FileInfo _FileInfo;
        #endregion

        #region Public Variables
        public string CacheFile { get => _CacheFile; protected set => _CacheFile = value; }
        public string CacheName { get => _CacheName; protected set => _CacheName = value; }
        public string CacheFolderName { get => _CacheFolderName; protected set => _CacheFolderName = value; }
        public bool IsCacheValid { get => _IsCacheValid; protected set => _IsCacheValid = value; }
        public FileInfo FileInfo { get => _FileInfo; protected set => _FileInfo = value; }
        #endregion

        #region Constructors
        public Cache()
        {

        }

        public Cache(string file, string cacheFolder)
        {
            LoadCache(file, cacheFolder);
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Load and parse a file as a <see cref="Cache"/>.
        /// </summary>
        /// <param name="file">The input file.</param>
        /// <param name="cacheFolder">The cache folder the file is out in.</param>
        public void LoadCache(string file, string cacheFolder)
        {
            if (File.Exists(file))
            {
                FileInfo fi = new FileInfo(file);
                CacheFile = file;
                CacheName = fi.Name;
                CacheFolderName = this.GetCacheFolderName(cacheFolder);

                IsCacheValid = ValidateCache();
                FileInfo = fi;
            }
        }

        /// <summary>
        /// Make the cache file Unity-readable.
        /// </summary>
        /// <param name="directory">The directory the cache file should be put in.</param>
        public void ToUnity(string directory)
        {
            if (!IsCacheValid || !Directory.Exists(directory))
            {
                MessageBox.Show("Invalid cache file or directory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create the .unity file.
            // Don't know what the .sharedAssets is yet.. we'll see.
            if (!CacheFile.EndsWith(".sharedAssets"))
            {
                File.Copy(CacheFile, Path.Combine(directory, CacheName + ".unity"), true);
                File.Copy(CacheFile, Path.Combine(directory, CacheName + ".asset"), true);
            }
        }

        /// <summary>
        /// Validate the cache file.
        /// </summary>
        /// <returns>Returns true if it is otherwise false.</returns>
        protected bool ValidateCache()
        {
            bool result = false;
            if (CacheName.Contains("CustomAssetBundle-"))
                result = true;
            else if (CacheName.Contains("BuildPlayer-Map"))
                result = true;

            return result;
        }

        /// <summary>
        /// Return the cache file as a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Found cache file: {CacheName} in folder: {CacheFolderName}.";
        }
        #endregion
    }
}
