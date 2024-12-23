using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LethalPostersCreator
{
    public partial class ModConfig : Form
    {
        string modPath;
        public ModConfig(string path)
        {
            modPath = path;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png;";
            openFileDialog.Title = "Select an image file";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.ShowDialog();
            string iconPath = openFileDialog.FileName;
            if (iconPath != "")
            {
                pictureBox1.Image = Image.FromFile(iconPath);
                System.IO.File.Copy(iconPath, modPath + "/icon.png", true);
                return;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (modName.Text == "" || modAuthor.Text == "" || modVersion.Text == "" || modDescription.Text == "")
            {
                MessageBox.Show("Please fill in all the fields");
                return;
            }

            System.IO.Directory.CreateDirectory(modPath + "/BepInEx");
            System.IO.Directory.CreateDirectory(modPath + "/BepInEx/plugins");
            System.IO.Directory.CreateDirectory(modPath + "/BepInEx/plugins/LethalPaintings");
            System.IO.Directory.CreateDirectory(modPath + "/BepInEx/plugins/LethalPosters");
            System.IO.Directory.CreateDirectory(modPath + "/BepInEx/plugins/LethalPosters/tips");
            System.IO.Directory.CreateDirectory(modPath + "/BepInEx/plugins/LethalPosters/posters");

            Manifest manifest = new Manifest();
            manifest.Name = modName.Text;
            manifest.Author = modAuthor.Text;
            manifest.Version = modVersion.Text;
            manifest.Description = modDescription.Text;

            string json = JsonSerializer.Serialize(manifest);
            System.IO.File.WriteAllText(modPath + "/manifest.json", json);

            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
