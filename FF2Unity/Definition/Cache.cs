using System.IO;
using System.Windows.Forms;

namespace FF2Unity.Definition
{
    public class Cache
    {
        #region Private Variables
        private string _CacheFile;
        private string _CacheName;
        private string _CacheFolder;

        private bool _IsCacheValid;
        private FileInfo _FileInfo;
        #endregion

        #region Public Variables
        public string CacheFile { get => _CacheFile; protected set => _CacheFile = value; }
        public string CacheName { get => _CacheName; protected set => _CacheName = value; }
        public string CacheFolder { get => _CacheFolder; protected set => _CacheFolder = value; }
        public bool IsCacheValid { get => _IsCacheValid; protected set => _IsCacheValid = value; }
        public FileInfo FileInfo { get => _FileInfo; protected set => _FileInfo = value; }
        #endregion

        #region Constructors
        public Cache()
        {

        }

        public Cache(string file)
        {
            LoadCache(file);
        }
        #endregion

        #region Public Methods
        public void LoadCache(string file)
        {
            if (File.Exists(file))
            {
                FileInfo fi = new FileInfo(file);
                CacheFile = file;
                CacheName = fi.Name;
                CacheFolder = fi.DirectoryName;

                IsCacheValid = ValidateCache();
                FileInfo = fi;
            }
        }

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

        protected bool ValidateCache()
        {
            bool result = false;
            if (CacheName.Contains("CustomAssetBundle-"))
                result = true;
            else if (CacheName.Contains("BuildPlayer-Map"))
                result = true;

            return result;
        }

        public override string ToString()
        {
            return $"Found cache file: {CacheName} in folder: {CacheFolder}.";
        }
        #endregion
    }
}
