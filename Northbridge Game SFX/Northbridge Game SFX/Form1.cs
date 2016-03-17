using Ionic.Zip;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Northbridge_Game_SFX
{
    public partial class BaseForm : Form
    {
        //The game's name is placed here.
        private static string GameName = "Example Game";
        //The default path to extract the game files.
        private static string GameXtractPath = Application.StartupPath + "\\" + GameName + "\\";
        //The game's executable file.
        private static string GameFile = "Game.exe";
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            var dl = GameExtractPicker.ShowDialog();
            if (dl != DialogResult.OK) return;
            GameXtractPath = GameExtractPicker.SelectedPath;
            GamePathBox.Text = GameXtractPath;
        }

        private void GamePathBox_TextChanged(object sender, EventArgs e)
        {
            GameXtractPath = GamePathBox.Text;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            GamePathBox.Text = GameXtractPath;
        }
        private void CopyResource(string resourceName, string file)
        {
            using (Stream resource = GetType().Assembly
                                              .GetManifestResourceStream(resourceName))
            {
                if (resource == null)
                {
                    throw new ArgumentException("No such resource", "resourceName");
                }
                using (Stream output = File.OpenWrite(file))
                {
                    resource.CopyTo(output);
                }
            }
        }

        private void ExtractButton_Click(object sender, EventArgs e)
        {
            BrowseButton.Enabled = false;
            ExtractButton.Enabled = false;

            try
            {
                CopyResource("GameData.zip", GameXtractPath);
                ZipFile patchFile = ZipFile.Read(GameXtractPath + "\\GameData.zip");
                patchFile.ExtractAll(GameXtractPath);
                File.Delete(GameXtractPath + "\\GameData.zip");
                MessageBox.Show("Extraction Complete!");
                if (AutoLaunchButton.Checked) Process.Start(GameXtractPath + "\\" + GameFile);
            }
            catch (Exception)
            {
                MessageBox.Show("Extraction Failed."); 
            }
            Close();
        }
    }
}
