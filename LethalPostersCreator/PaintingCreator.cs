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
    public partial class PaintingCreator : Form
    {
        private string modPath = "";
        private string paintingsPath = "";
        private List<ImageData> images = new();
        private List<string> imageNames = new();
        private int currentImageIndex;

        public PaintingCreator(string modPath)
        {
            this.modPath = modPath;
            paintingsPath = Path.Combine(modPath, "BepInEx\\plugins\\LethalPaintings");
            InitializeComponent();
        }

        private void UpdateImageList()
        {
            imgNamesListbox.Items.Clear();
            imgNamesListbox.Items.AddRange([.. imageNames]);
        }

        private Image CropToCanvas(Image image, int xOffset, int yOffset, int maxHeight = 324)
        {
            double widthRatio = (double)image.Width / (maxHeight * 0.77734375);
            double heightRatio = (double)image.Height / maxHeight;
            double scaleFactor = Math.Min(widthRatio, heightRatio);
            int cropWidth = (int)(maxHeight * 0.77734375 * scaleFactor);
            int cropHeight = (int)(maxHeight * scaleFactor);
            int leftoverWidth = image.Width - cropWidth;
            int leftoverHeight = image.Height - cropHeight;
            int cropX = (int)(leftoverWidth * (xOffset / 100.0));
            int cropY = (int)(leftoverHeight * (yOffset / 100.0));
            cropX = Math.Max(0, Math.Min(cropX, image.Width - cropWidth));
            cropY = Math.Max(0, Math.Min(cropY, image.Height - cropHeight));
            Rectangle cropRect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
            int outputWidth = (int)(maxHeight * 0.77734375);
            int outputHeight = maxHeight;
            Bitmap output = new Bitmap(outputWidth, outputHeight);
            using (Graphics g = Graphics.FromImage(output))
            {
                g.DrawImage(image, new Rectangle(0, 0, outputWidth, outputHeight), cropRect, GraphicsUnit.Pixel);
            }
            return output;
        }

        private void chooseFilesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image Files|*.png;*.jpg;*.jpeg";
            fd.Multiselect = true;
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.Title = "Select images to add as paintings";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in fd.FileNames)
                {
                    Image image = Image.FromFile(fileName);
                    images.Add(new ImageData(image));
                    imageNames.Add(Path.GetFileName(fileName));
                    UpdateImageList();
                }
            }
        }

        private void saveFilesButton_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ImageData image = images[currentImageIndex];
            image.xOffsetPercentage = (int)numericUpDown2.Value;
            pictureBox1.Image = CropToCanvas(image.image, image.xOffsetPercentage, image.yOffsetPercentage);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
