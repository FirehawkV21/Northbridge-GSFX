using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Northbridge_Game_SFX
{
    public partial class BaseForm : Form
    {
        //The game's name is placed here.
        private static string GameName = "Example Game";
        //The default path to extract the game files.
        private static string GameXtractPath = Application.StartupPath + "\\" + GameName + "\\";
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
    }
}
