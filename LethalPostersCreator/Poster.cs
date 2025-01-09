using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LethalPostersCreator
{
    public partial class Poster : Form
    {
        private string[] fileNames = new string[] { "", "", "", "", "" };
        private string[] imageNames = new string[] { "", "", "", "", "" };

        private readonly Button[] imageShowers = new Button[5];
        private readonly Button[] imagePickers = new Button[5];
        private readonly Label[] imageLabels = new Label[5];
        private readonly PictureBox[] imagePicBoxes = new PictureBox[5];
        private readonly ComboBox[] comboBoxes = new ComboBox[5];

        private readonly string modPath = "";
        private readonly string posterPath = "";

        public Poster(string path = "")
        {
            InitializeComponent();

            imageShowers = new[] { showImg1, showImg2, showImg3, showImg4, showImg5 };
            imagePickers = new[] { imgSingleSelect1, imgSingleSelect2, imgSingleSelect3, imgSingleSelect4, imgSingleSelect5 };
            imageLabels = new[] { image1Name, image2Name, image3Name, image4Name, image5Name };
            imagePicBoxes = new[] { topLeftPicBox, topMidPicBox, topRightPicBox, bottomLeftPicBox, bottomRightPicBox };
            comboBoxes = new[] { topLeftCombobox, topMidCombobox, topRightCombobox, bottomLeftCombobox, bottomRightCombobox };

            modPath = path;
            posterPath = $"{modPath}\\BepInEx\\plugins\\LethalPosters\\posters\\";
        }

        private void ClearAllImages()
        {
            fileNames = ["", "", "", "", ""];
            imageNames = ["", "", "", "", ""];

            for (int i = 0; i < imageShowers.Length; i++)
            {
                imageShowers[i].Enabled = false;
                comboBoxes[i].Items.Clear();
                imageLabels[i].Text = "";
                imagePicBoxes[i].Image = null;
            }

        }

        private static Bitmap CropToFitCanvas(PictureBox pictureBox, Image img, double sizeMultiplier = 1.0)
        {
            // Calculate the scale factor to ensure the image completely covers the PictureBox
            double widthRatio = (double)img.Width / pictureBox.Width;
            double heightRatio = (double)img.Height / pictureBox.Height;
            double scaleFactor = Math.Min(widthRatio, heightRatio); // Use Min to ensure no empty space

            // Calculate the dimensions of the cropped area
            int cropWidth = (int)(pictureBox.Width * scaleFactor);
            int cropHeight = (int)(pictureBox.Height * scaleFactor);

            // Center the crop area within the original image
            int cropX = (img.Width - cropWidth) / 2;
            int cropY = (img.Height - cropHeight) / 2;

            // Define the crop rectangle
            Rectangle cropRect = new(cropX, cropY, cropWidth, cropHeight);

            // Calculate the output size based on the multiplier
            int outputWidth = (int)(pictureBox.Width * sizeMultiplier);
            int outputHeight = (int)(pictureBox.Height * sizeMultiplier);

            // Create a bitmap with the scaled dimensions
            Bitmap resultImage = new(outputWidth, outputHeight);

            using (Graphics g = Graphics.FromImage(resultImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, new Rectangle(0, 0, outputWidth, outputHeight), cropRect, GraphicsUnit.Pixel);
            }

            return resultImage;
        }
        private static int HighestNumberInDirectory(string directory)
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
        private void SaveAllPositions()
        {
            int highest = 0;
            if (modPath != "")
            {
                highest = HighestNumberInDirectory(posterPath);
            }
            for (int i = 0; i < comboBoxes.Length; i++)
            {
                // Save the current canvas
                SaveCanvas(posterPath + (int)(i + highest + 1) + ".png");

                // Rotate the combobox selections to the right
                int lastIndex = comboBoxes[^1].SelectedIndex; // Save the last ComboBox's selected index
                for (int j = comboBoxes.Length - 1; j > 0; j--)
                {
                    comboBoxes[j].SelectedIndex = comboBoxes[j - 1].SelectedIndex;
                }
                comboBoxes[0].SelectedIndex = lastIndex; // Set the first ComboBox's selected index
            }
        }

        private void SaveCanvas(string filePath = "")
        {
            if (fileNames.Contains("") || fileNames.Contains(null) || fileNames.Length != 5)
            {
                MessageBox.Show("Please select 5 images.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bitmap canvas = new Bitmap(1024, 1024);
            Graphics g = Graphics.FromImage(canvas);
            g.Clear(Color.Transparent);
            g.DrawImage(CropToFitCanvas(topLeftPicBox, Image.FromFile(fileNames[topLeftCombobox.SelectedIndex]), 2.0), 0, 0);
            g.DrawImage(CropToFitCanvas(topMidPicBox, Image.FromFile(fileNames[topMidCombobox.SelectedIndex]), 2.0), 346, 0);
            g.DrawImage(CropToFitCanvas(topRightPicBox, Image.FromFile(fileNames[topRightCombobox.SelectedIndex]), 2.0), 641, 58);
            g.DrawImage(CropToFitCanvas(bottomLeftPicBox, Image.FromFile(fileNames[bottomLeftCombobox.SelectedIndex]), 2.0), 184, 620);
            g.DrawImage(CropToFitCanvas(bottomRightPicBox, Image.FromFile(fileNames[bottomRightCombobox.SelectedIndex]), 2.0), 632, 320);
            if (modPath == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png;";
                saveFileDialog.Title = "Save the poster";
                saveFileDialog.ShowDialog();
                canvas.Save(saveFileDialog.FileName);
            }
            else
            {
                int highest = HighestNumberInDirectory(posterPath);
                canvas.Save(posterPath + (highest + 1) + ".png");
            }
        }
        private static string SelectSingleImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png;";
            openFileDialog.Title = "Select an image file";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();
            return openFileDialog.FileName;
        }

        private void selectFiles_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fileNames.Length; i++)
            {
                fileNames[i] = "";
                imageNames[i] = "";
            }
            int fileCount;
            fileCount = 0;
            // Open the dialogue to select exactly 5 images
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png;";
            openFileDialog.Title = "Select 5 image files";
            openFileDialog.Multiselect = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.ShowDialog();
            fileNames = openFileDialog.FileNames;
            fileCount = fileNames.Length;

            if (fileCount != 5)
            {
                MessageBox.Show("Please select exactly 5 images.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Display the selected images

            for (int i = 0; i < imageNames.Length; i++)
            {
                imageNames[i] = Path.GetFileName(fileNames[i]);
            }

            for (int i = 0; i < fileNames.Length; i++)
            {
                imageLabels[i].Text = imageNames[i];
                imageShowers[i].Visible = true;
                comboBoxes[i].Visible = true;
                UpdateComboboxes();
                imagePicBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                imagePicBoxes[i].Image = CropToFitCanvas(imagePicBoxes[i], Image.FromFile(fileNames[i]));
            }
        }

        private void UpdateComboboxes()
        {
            string[] imageRange = new string[5];
            int loadedImages = 0;

            for (int i = 0; i < imageNames.Length; i++)
            {
                if (imageNames[i] != "")
                {
                    loadedImages++;
                }
                imageRange[i] = imageNames[i];
            }

            for (int i = 0; i < imagePickers.Length; i++)
            {
                imagePickers[i].Enabled = loadedImages > i - 1;
                imageShowers[i].Enabled = loadedImages > i;
            }

            for (int i = 0; i < comboBoxes.Length; i++)
            {
                comboBoxes[i].Items.Clear();
                comboBoxes[i].Items.AddRange(imageRange);
                if (comboBoxes[i].SelectedIndex == -1)
                {
                    comboBoxes[i].SelectedIndex = Math.Clamp(i, 0, loadedImages - 1);
                }
            }
        }

        private void showImg1_Click(object sender, EventArgs e)
        {
            var processStartInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = fileNames[0],
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(processStartInfo);
        }

        private void showImg2_Click(object sender, EventArgs e)
        {
            var processStartInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = fileNames[1],
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(processStartInfo);
        }

        private void showImg3_Click(object sender, EventArgs e)
        {
            var processStartInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = fileNames[2],
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(processStartInfo);
        }

        private void showImg4_Click(object sender, EventArgs e)
        {
            var processStartInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = fileNames[3],
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(processStartInfo);
        }

        private void showImg5_Click(object sender, EventArgs e)
        {
            var processStartInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = fileNames[4],
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(processStartInfo);
        }
        private void topLeftCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            topLeftPicBox.Image = CropToFitCanvas(topLeftPicBox, Image.FromFile(fileNames[topLeftCombobox.SelectedIndex]));
        }

        private void topMidCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            topMidPicBox.Image = CropToFitCanvas(topMidPicBox, Image.FromFile(fileNames[topMidCombobox.SelectedIndex]));
        }

        private void topRightCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            topRightPicBox.Image = CropToFitCanvas(topRightPicBox, Image.FromFile(fileNames[topRightCombobox.SelectedIndex]));
        }

        private void bottomRightCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bottomRightPicBox.Image = CropToFitCanvas(bottomRightPicBox, Image.FromFile(fileNames[bottomRightCombobox.SelectedIndex]));
        }

        private void bottomLeftCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bottomLeftPicBox.Image = CropToFitCanvas(bottomLeftPicBox, Image.FromFile(fileNames[bottomLeftCombobox.SelectedIndex]));
        }

        private void imgSingleSelect1_Click(object sender, EventArgs e)
        {
            string filePath = SelectSingleImage();
            if (filePath == "" || filePath == null) return;
            fileNames[0] = filePath;
            imageNames[0] = Path.GetFileName(filePath);
            image1Name.Text = imageNames[0];
            showImg1.Visible = true;
            UpdateComboboxes();
        }

        private void imgSingleSelect2_Click(object sender, EventArgs e)
        {
            string filePath = SelectSingleImage();
            if (filePath == "" || filePath == null) return;
            fileNames[1] = filePath;
            imageNames[1] = Path.GetFileName(filePath);
            image2Name.Text = imageNames[1];
            showImg2.Visible = true;
            UpdateComboboxes();
        }

        private void imgSingleSelect3_Click(object sender, EventArgs e)
        {
            string filePath = SelectSingleImage();
            if (filePath == "" || filePath == null) return;
            fileNames[2] = filePath;
            imageNames[2] = Path.GetFileName(filePath);
            image3Name.Text = imageNames[2];
            showImg3.Visible = true;
            UpdateComboboxes();
        }

        private void imgSingleSelect4_Click(object sender, EventArgs e)
        {
            string filePath = SelectSingleImage();
            if (filePath == "" || filePath == null) return;
            fileNames[3] = filePath;
            imageNames[3] = Path.GetFileName(filePath);
            image4Name.Text = imageNames[3];
            showImg4.Visible = true;
            UpdateComboboxes();
        }

        private void imgSingleSelect5_Click(object sender, EventArgs e)
        {
            string filePath = SelectSingleImage();
            if (filePath == "" || filePath == null) return;
            fileNames[4] = filePath;
            imageNames[4] = Path.GetFileName(filePath);
            image5Name.Text = imageNames[4];
            showImg5.Visible = true;
            UpdateComboboxes();
        }

        private void savePosterCanvasButton_Click(object sender, EventArgs e)
        {
            SaveCanvas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveAllPositions();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAllImages();
        }
    }
}
