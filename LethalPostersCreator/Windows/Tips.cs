using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LethalPostersCreator.Windows
{
    public partial class Tips : Form
    {
        private List<ImageData> images;
        private List<string> imageNames;
        private string modPath = "";
        private string tipsPath = "";
        private int currentImgIndex = 0;

        public Tips(string modPath)
        {
            this.modPath = modPath;
            tipsPath = Path.Combine(modPath, "BepInEx\\plugins\\LethalPosters\\tips");
            images = [];
            imageNames = [];
            InitializeComponent();
        }

        private void UpdateImageList()
        {
            imgNamesText.Items.Clear();
            imgNamesText.Items.AddRange(imageNames.ToArray());
            imgNamesText.SelectedIndex = currentImgIndex;
        }

        private static int HighestNumberInDir(string path)
        {
            int highest = 0;
            foreach (string file in System.IO.Directory.GetFiles(path))
            {
                string fileName = System.IO.Path.GetFileNameWithoutExtension(file);
                int number = 0;
                if (int.TryParse(fileName, out number))
                {
                    if (number > highest)
                    {
                        highest = number;
                    }
                }
            }
            return highest;
        }

        private Image CropToFitCanvas(ImageData imgData)
        {
            Image img = imgData.image;
            int xOffsetPercentage = imgData.xOffsetPercentage;
            int yOffsetPercentage = imgData.yOffsetPercentage;

            bool v = int.TryParse(textBox1.Text, out int maxHeight);
            if (!v)
            {
                maxHeight = 1024;
                MessageBox.Show("Invalid number, using default value of 1024.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Calculate the scale factor to ensure the image completely covers the canvas
            double widthRatio = (double)img.Width / (maxHeight * 0.77734375);
            double heightRatio = (double)img.Height / maxHeight;
            double scaleFactor = Math.Min(widthRatio, heightRatio); // Use Min to ensure no empty space

            // Calculate the dimensions of the cropped area
            int cropWidth = (int)(maxHeight * 0.77734375 * scaleFactor);
            int cropHeight = (int)(maxHeight * scaleFactor);

            // Adjust crop position based on offset percentages
            int leftoverWidth = img.Width - cropWidth;
            int leftoverHeight = img.Height - cropHeight;

            // Calculate cropX and cropY based on the offset percentages
            int cropX = (int)(leftoverWidth * (xOffsetPercentage / 100.0));
            int cropY = (int)(leftoverHeight * (yOffsetPercentage / 100.0));

            // Ensure the crop rectangle is within bounds
            cropX = Math.Max(0, Math.Min(cropX, img.Width - cropWidth));
            cropY = Math.Max(0, Math.Min(cropY, img.Height - cropHeight));

            // Define the crop rectangle
            Rectangle cropRect = new Rectangle(cropX, cropY, cropWidth, cropHeight);

            // Calculate the output size
            int outputWidth = (int)(maxHeight * 0.77734375);
            int outputHeight = maxHeight;

            // Create a bitmap with the scaled dimensions
            Bitmap resultImage = new Bitmap(outputWidth, outputHeight);

            using (Graphics g = Graphics.FromImage(resultImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, new Rectangle(0, 0, outputWidth, outputHeight), cropRect, GraphicsUnit.Pixel);
            }

            return resultImage;
        }


        private void fileChooseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            fileDialog.Title = "Select an image file";
            fileDialog.Multiselect = true;
            fileDialog.CheckPathExists = true;
            fileDialog.CheckFileExists = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in fileDialog.FileNames)
                {
                    Image img = Image.FromFile(file);
                    imageNames.Add(System.IO.Path.GetFileName(file));
                    images.Add(new(img));
                    pictureBox1.Image = CropToFitCanvas(images.Last());
                }
            }
            UpdateImageList();
            timer1.Start();
        }

        private void saveFilesButton_Click(object sender, EventArgs e)
        {
            int highest = HighestNumberInDir(tipsPath);
            foreach (ImageData img in images)
            {
                highest++;
                CropToFitCanvas(img).Save(tipsPath + "\\" + highest + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void imgNamesText_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = CropToFitCanvas(images[imgNamesText.SelectedIndex]);
            currentImgIndex = imgNamesText.SelectedIndex;
            xOffsetNumber.Value = images[currentImgIndex].xOffsetPercentage;
            yOffsetNumber.Value = images[currentImgIndex].yOffsetPercentage;
        }

        private void xOffsetNumber_ValueChanged(object sender, EventArgs e)
        {
            ImageData currentImage = images[imgNamesText.SelectedIndex];
            currentImage.xOffsetPercentage = (int)xOffsetNumber.Value;
            pictureBox1.Image = CropToFitCanvas(currentImage);
        }

        private void yOffsetNumber_ValueChanged(object sender, EventArgs e)
        {
            ImageData currentImage = images[imgNamesText.SelectedIndex];
            currentImage.yOffsetPercentage = (int)yOffsetNumber.Value;
            pictureBox1.Image = CropToFitCanvas(currentImage);
        }
    }
}
