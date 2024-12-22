using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LethalPostersCreator
{
    public partial class Tips : Form
    {
        Image img;
        bool multiselect = false;
        bool painting = false;
        int maxHeight = 1024;
        string modPath = "";
        string tipsPath = "";
        string paintingsPath = "";

        public Tips(string path)
        {
            modPath = path;
            tipsPath = path + "/BepInEx/plugins/LethalPosters/tips/";
            paintingsPath = path + "/BepInEx/plugins/LethalPaintings/";
            InitializeComponent();
            if (modPath == "")
            {
                label1.Visible = true;
                textBox1.Visible = true;
            }
            img = new Bitmap(1, 1); // Initialize img to avoid CS8618
        }
        private int HighestNumberInDirectory(string directory)
        {
            int result = 0;
            string[] files = System.IO.Directory.GetFiles(directory);
            foreach (string file in files)
            {
                string fileName = System.IO.Path.GetFileName(file);
                if (fileName.Contains(".png"))
                {
                    string[] split = fileName.Split('.');
                    string[] split2 = split[0].Split('_');
                    if (int.TryParse(split2[0], out int number))
                    {
                        if (number > result)
                        {
                            result = number;
                        }
                    }
                }
            }
            return result;
        }
        private Image CropToPainting(Image image)
        {


            Bitmap bmp = new Bitmap(512, 512);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 264, 19, 243, 324);
            }
            return bmp;
        }

        // Crop the image to the aspect ratio of 0.77734375
        private Image cropToTipsAspect(Image image, int maxHeight)
        {
            int width = image.Width;
            int height = image.Height;
            int newWidth = width;
            int newHeight = height;

            // Determine new width and height based on the aspect ratio
            if (width > height)
            {
                newWidth = (int)(height * 0.77734375);
            }
            else
            {
                newHeight = (int)(width / 0.77734375);
            }

            // Ensure the new height does not exceed maxHeight
            if (newHeight > maxHeight)
            {
                double scale = (double)maxHeight / newHeight;
                newWidth = (int)(newWidth * scale);
                newHeight = maxHeight;
            }

            // Calculate cropping rectangle
            int x = (width - newWidth) / 2;
            int y = (height - newHeight) / 2;
            Rectangle cropRect = new Rectangle(x, y, newWidth, newHeight);

            // Create the cropped image
            Bitmap croppedImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(croppedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, new Rectangle(0, 0, newWidth, newHeight), cropRect, GraphicsUnit.Pixel);
            }

            return croppedImage;
        }


        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png;";
            openFileDialog.Title = "Select an image file";
            openFileDialog.Multiselect = multiselect;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            bool v = int.TryParse(maxHeightText.Text, out maxHeight);
            if (!v)
            {
                MessageBox.Show("Please enter a valid number for the max height");
                return;
            }
            // If multiple selected, convert all to tips aspect and save to the same directory as numbers, starting from the one in the textbox
            if (multiselect && openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string newFilePath;
                if (modPath == "")
                {
                    string[] filePaths = openFileDialog.FileNames;
                    int number = int.Parse(textBox1.Text);
                    foreach (string filePath in filePaths)
                    {
                        Image img; 
                        if (painting) img = CropToPainting(Image.FromFile(filePath));
                        else img = cropToTipsAspect(Image.FromFile(filePath), maxHeight);
                        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                        folderBrowserDialog.Description = "Select the folder to save the images to";
                        folderBrowserDialog.ShowNewFolderButton = true;
                        folderBrowserDialog.ShowDialog();
                        if (folderBrowserDialog.SelectedPath == "")
                        {
                            return;
                        }
                        if (painting) newFilePath = Path.Combine(folderBrowserDialog.SelectedPath, number + ".png");
                        else newFilePath = Path.Combine(folderBrowserDialog.SelectedPath, number + ".png");
                        img.Save(newFilePath);
                        number++;
                    }
                    MessageBox.Show("Images saved");
                }
                else
                {
                    string[] filePaths = openFileDialog.FileNames;
                    foreach (string filePath in filePaths)
                    {
                        if (painting)
                        {
                            img = CropToPainting(Image.FromFile(filePath));
                            int highestNumber = HighestNumberInDirectory(paintingsPath);
                            newFilePath = Path.Combine(paintingsPath, (highestNumber + 1) + ".png");
                        }
                        else
                        {
                            img = cropToTipsAspect(Image.FromFile(filePath), maxHeight);
                            int highestNumber = HighestNumberInDirectory(tipsPath);
                            newFilePath = Path.Combine(tipsPath, (highestNumber + 1) + ".png");
                        }
                        img.Save(newFilePath);
                    }
                    MessageBox.Show("Images saved to " + tipsPath);
                }
            }

            if (!multiselect && openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (painting) img = CropToPainting(Image.FromFile(filePath));
                else img = cropToTipsAspect(Image.FromFile(filePath), maxHeight);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = img;
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (modPath == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png;";
                saveFileDialog.Title = "Save the image";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    img.Save(saveFileDialog.FileName);
                }
            }
            else
            {
                if (painting)
                {
                    int highestNumber = HighestNumberInDirectory(paintingsPath);
                    string newFilePath = Path.Combine(paintingsPath, (highestNumber + 1) + ".png");
                    img.Save(newFilePath);
                }
                else
                {
                    int highestNumber = HighestNumberInDirectory(tipsPath);
                    string newFilePath = Path.Combine(tipsPath, (highestNumber + 1) + ".png");
                    img.Save(newFilePath);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            multiselect = checkBox1.Checked;
            button1.Enabled = !multiselect;
            chooseFileButton.Text = multiselect ? "Choose files and auto-save..." : "Choose file...";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            painting = checkBox2.Checked;
        }
    }
}
