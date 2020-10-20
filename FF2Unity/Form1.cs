using FF2Unity.Definition;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace FF2Unity
{
    public partial class Form1 : Form
    {
        private string cacheFolder;
        private string toUnityFolder;

        private delegate void UpdateRichTextBox(RichTextBox rt, string text);
        private Dictionary<string, Cache> cacheFiles;

        public Form1()
        {
            InitializeComponent();
        }

        private void cacheBrowseBtn_Click(object sender, EventArgs e)
        {
            setupFolders();

            var workerThread = new Thread(() =>
            {
                findCacheFiles();
            });
            workerThread.IsBackground = true;
            workerThread.Start();
        }

        private void setupFolders()
        {
            var ofd = new FolderBrowserDialog();
            var ofd1 = new FolderBrowserDialog();

            ofd.Description = "Browse for the cache folder of Fusionfall.";
            ofd1.Description = "Browse for the folder to put the Unity-ready files.";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                cacheFolder = ofd.SelectedPath;
                cacheTxtBox.Text = cacheFolder;

                if (ofd1.ShowDialog() == DialogResult.OK)
                {
                    toUnityFolder = ofd1.SelectedPath;
                }
            }
        }

        private void findCacheFiles()
        {
            if (!Directory.Exists(cacheFolder) && !string.IsNullOrEmpty(cacheFolder))
            {
                MessageBox.Show($"No valid cache files found in {cacheFolder}!", "No valid cache files found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if(string.IsNullOrEmpty(cacheFolder))
            {
                MessageBox.Show($"Cache folder is not set!", "No cache folder set", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var files = Directory.EnumerateFiles(cacheFolder, "*.*", SearchOption.AllDirectories).ToList();
            cacheTxtBox.Text = cacheFolder;
            cacheFiles = new Dictionary<string, Cache>();

            if (files.Count > 0)
            {
                for (int i = 0; i < files.Count; i++)
                {
                    var file = files[i];
                    var cache = new Cache(file);
                    if (cache.IsCacheValid)
                    {
                        if (!cacheFiles.ContainsKey(cache.CacheName))
                        {
                            cacheFiles.Add(cache.CacheName, cache);
                            WriteToRichTextBox(richTextBox1, cache.ToString());
                        }
                    }
                }
                makeUnityFiles();
            }
        }

        private void makeUnityFiles()
        {
            if (cacheFiles.Count > 0)
            {
                foreach (Cache cache in cacheFiles.Values)
                {
                    cache.ToUnity(toUnityFolder);
                    WriteToRichTextBox(richTextBox1, $"Made unity file: {cache.CacheName} in folder: {toUnityFolder}.");
                }
                WriteToRichTextBox(richTextBox1, "\nBoom! All done.");
            }
            else MessageBox.Show("No valid cache files found!", "No valid cache files found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void WriteToRichTextBox(RichTextBox rt, string text)
        {
            if (rt.InvokeRequired)
            {
                var d = new UpdateRichTextBox(WriteToRichTextBox);
                rt.Invoke(d, new object[] { rt, text });
            }
            else
            {
                rt.AppendText(text + "\n");
            }
        }
    }
}
