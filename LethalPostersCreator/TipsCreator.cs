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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LethalPostersCreator
{
    public partial class TipsCreator : Form
    {
        private string modPath = "";
        private string tipsPath = "";
        private List<ImageData> images = new();
        private List<string> imageNames = new();
        private int selectedImage = 0;

        public TipsCreator(string modPath)
        {
            this.modPath = modPath;
            tipsPath = Path.Combine(modPath, "BepInEx\\plugins\\LethalPosters\\tips");
            Debug.WriteLine(tipsPath);
            InitializeComponent();
        }

        private Image CropToCanvas(Image img, int xOffsetPercentage = 50, int yOffsetPercentage = 50, int maxHeight = 512)
        {
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

        private void UpdateImageList()
        {
            imgList.Items.Clear();
            imgList.Items.AddRange(imageNames.ToArray());
        }

        private int HighestInDirectory(string path)
        {
            int result = 0;
            foreach (string file in Directory.GetFiles(path))
            {
                string fileName = Path.GetFileName(file);
                if (fileName.EndsWith(".png"))
                {
                    string number = fileName.Substring(0, fileName.Length - 4);
                    if (int.TryParse(number, out int numberInt))
                    {
                        result = Math.Max(result, numberInt);
                    }
                }
            }
            return result;
        }

        private void chooseFilesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image files|*.png;*.jpg;*.jpeg;*.bmp";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.ShowDialog();
            foreach (string fileName in openFileDialog.FileNames)
            {
                Image image = Image.FromFile(fileName);
                images.Add(new ImageData(image));
                pictureBox1.Image = CropToCanvas(images[0].image);
                imageNames.Add(Path.GetFileName(fileName));
                UpdateImageList();
            }
        }

        private void imgList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedImage = imgList.SelectedIndex;
            ImageData currentImg = images[selectedImage];
            numericUpDown1.Value = currentImg.xOffsetPercentage;
            numericUpDown2.Value = currentImg.yOffsetPercentage;
            pictureBox1.Image = CropToCanvas(currentImg.image, currentImg.xOffsetPercentage, currentImg.yOffsetPercentage);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ImageData image = images[selectedImage];
            image.xOffsetPercentage = (int)numericUpDown1.Value;
            pictureBox1.Image = CropToCanvas(image.image, image.xOffsetPercentage, image.yOffsetPercentage);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ImageData image = images[selectedImage];
            image.yOffsetPercentage = (int)numericUpDown2.Value;
            pictureBox1.Image = CropToCanvas(image.image, image.xOffsetPercentage, image.yOffsetPercentage);
        }

        private void saveFilesButton_Click(object sender, EventArgs e)
        {
            int highest = HighestInDirectory(tipsPath);
            foreach (ImageData imageData in images)
            {
                highest++;
                string fileName = highest.ToString() + ".png";
                string filePath = Path.Combine(tipsPath, fileName);
                Image croppedImage = CropToCanvas(imageData.image, imageData.xOffsetPercentage, imageData.yOffsetPercentage);
                croppedImage.Save(filePath);
            }
        }
    }
}
