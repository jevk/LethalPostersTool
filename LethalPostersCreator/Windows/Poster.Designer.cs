namespace LethalPostersCreator
{
    partial class Poster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poster));
            templateBox = new PictureBox();
            selectFiles = new Button();
            topLeftPicBox = new PictureBox();
            topMidPicBox = new PictureBox();
            topRightPicBox = new PictureBox();
            bottomLeftPicBox = new PictureBox();
            bottomRightPicBox = new PictureBox();
            image1Name = new Label();
            image2Name = new Label();
            image3Name = new Label();
            image4Name = new Label();
            image5Name = new Label();
            showImg1 = new Button();
            showImg2 = new Button();
            showImg3 = new Button();
            showImg4 = new Button();
            showImg5 = new Button();
            topLeftCombobox = new ComboBox();
            topMidCombobox = new ComboBox();
            topRightCombobox = new ComboBox();
            bottomLeftCombobox = new ComboBox();
            bottomRightCombobox = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            savePosterCanvasButton = new Button();
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            imgSingleSelect1 = new Button();
            imgSingleSelect2 = new Button();
            imgSingleSelect3 = new Button();
            imgSingleSelect4 = new Button();
            imgSingleSelect5 = new Button();
            ((System.ComponentModel.ISupportInitialize)templateBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topLeftPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topMidPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topRightPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottomLeftPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottomRightPicBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // templateBox
            // 
            templateBox.Image = Properties.Resources.posterTemplate;
            templateBox.Location = new Point(0, 0);
            templateBox.Name = "templateBox";
            templateBox.Size = new Size(512, 512);
            templateBox.SizeMode = PictureBoxSizeMode.StretchImage;
            templateBox.TabIndex = 0;
            templateBox.TabStop = false;
            // 
            // selectFiles
            // 
            selectFiles.Location = new Point(3, 3);
            selectFiles.Name = "selectFiles";
            selectFiles.Size = new Size(157, 42);
            selectFiles.TabIndex = 1;
            selectFiles.Text = "Select files...";
            selectFiles.UseVisualStyleBackColor = true;
            selectFiles.Click += selectFiles_Click;
            // 
            // topLeftPicBox
            // 
            topLeftPicBox.Location = new Point(0, 0);
            topLeftPicBox.Name = "topLeftPicBox";
            topLeftPicBox.Size = new Size(171, 279);
            topLeftPicBox.TabIndex = 2;
            topLeftPicBox.TabStop = false;
            // 
            // topMidPicBox
            // 
            topMidPicBox.Location = new Point(172, 0);
            topMidPicBox.Name = "topMidPicBox";
            topMidPicBox.Size = new Size(142, 280);
            topMidPicBox.TabIndex = 3;
            topMidPicBox.TabStop = false;
            // 
            // topRightPicBox
            // 
            topRightPicBox.Location = new Point(320, 28);
            topRightPicBox.Name = "topRightPicBox";
            topRightPicBox.Size = new Size(139, 125);
            topRightPicBox.TabIndex = 4;
            topRightPicBox.TabStop = false;
            // 
            // bottomLeftPicBox
            // 
            bottomLeftPicBox.Location = new Point(91, 309);
            bottomLeftPicBox.Name = "bottomLeftPicBox";
            bottomLeftPicBox.Size = new Size(207, 184);
            bottomLeftPicBox.TabIndex = 5;
            bottomLeftPicBox.TabStop = false;
            // 
            // bottomRightPicBox
            // 
            bottomRightPicBox.Location = new Point(316, 160);
            bottomRightPicBox.Name = "bottomRightPicBox";
            bottomRightPicBox.Size = new Size(186, 336);
            bottomRightPicBox.TabIndex = 6;
            bottomRightPicBox.TabStop = false;
            // 
            // image1Name
            // 
            image1Name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            image1Name.AutoSize = true;
            image1Name.BackColor = SystemColors.Control;
            image1Name.Location = new Point(38, 7);
            image1Name.MaximumSize = new Size(380, 20);
            image1Name.Name = "image1Name";
            image1Name.Size = new Size(380, 15);
            image1Name.TabIndex = 7;
            image1Name.Text = "img1.png";
            image1Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // image2Name
            // 
            image2Name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            image2Name.AutoSize = true;
            image2Name.Location = new Point(38, 36);
            image2Name.MaximumSize = new Size(240, 20);
            image2Name.Name = "image2Name";
            image2Name.Size = new Size(240, 15);
            image2Name.TabIndex = 8;
            image2Name.Text = "img2.png";
            image2Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // image3Name
            // 
            image3Name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            image3Name.AutoSize = true;
            image3Name.Location = new Point(38, 65);
            image3Name.MaximumSize = new Size(240, 20);
            image3Name.Name = "image3Name";
            image3Name.Size = new Size(240, 15);
            image3Name.TabIndex = 9;
            image3Name.Text = "img3.png";
            image3Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // image4Name
            // 
            image4Name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            image4Name.AutoSize = true;
            image4Name.Location = new Point(38, 95);
            image4Name.MaximumSize = new Size(240, 20);
            image4Name.Name = "image4Name";
            image4Name.Size = new Size(240, 15);
            image4Name.TabIndex = 10;
            image4Name.Text = "img4.png";
            image4Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // image5Name
            // 
            image5Name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            image5Name.AutoSize = true;
            image5Name.Location = new Point(38, 123);
            image5Name.MaximumSize = new Size(240, 20);
            image5Name.Name = "image5Name";
            image5Name.Size = new Size(240, 15);
            image5Name.TabIndex = 11;
            image5Name.Text = "img5.png";
            image5Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // showImg1
            // 
            showImg1.Enabled = false;
            showImg1.Location = new Point(430, 3);
            showImg1.Name = "showImg1";
            showImg1.Size = new Size(54, 23);
            showImg1.TabIndex = 12;
            showImg1.Text = "Show";
            showImg1.UseVisualStyleBackColor = true;
            showImg1.Click += showImg1_Click;
            // 
            // showImg2
            // 
            showImg2.Enabled = false;
            showImg2.Location = new Point(430, 32);
            showImg2.Name = "showImg2";
            showImg2.Size = new Size(54, 23);
            showImg2.TabIndex = 13;
            showImg2.Text = "Show";
            showImg2.UseVisualStyleBackColor = true;
            showImg2.Click += showImg2_Click;
            // 
            // showImg3
            // 
            showImg3.Enabled = false;
            showImg3.Location = new Point(430, 61);
            showImg3.Name = "showImg3";
            showImg3.Size = new Size(54, 23);
            showImg3.TabIndex = 14;
            showImg3.Text = "Show";
            showImg3.UseVisualStyleBackColor = true;
            showImg3.Click += showImg3_Click;
            // 
            // showImg4
            // 
            showImg4.Enabled = false;
            showImg4.Location = new Point(430, 91);
            showImg4.Name = "showImg4";
            showImg4.Size = new Size(54, 23);
            showImg4.TabIndex = 15;
            showImg4.Text = "Show";
            showImg4.UseVisualStyleBackColor = true;
            showImg4.Click += showImg4_Click;
            // 
            // showImg5
            // 
            showImg5.Enabled = false;
            showImg5.Location = new Point(430, 120);
            showImg5.Name = "showImg5";
            showImg5.Size = new Size(54, 22);
            showImg5.TabIndex = 16;
            showImg5.Text = "Show";
            showImg5.UseVisualStyleBackColor = true;
            showImg5.Click += showImg5_Click;
            // 
            // topLeftCombobox
            // 
            topLeftCombobox.FormattingEnabled = true;
            topLeftCombobox.Location = new Point(0, 280);
            topLeftCombobox.Name = "topLeftCombobox";
            topLeftCombobox.Size = new Size(171, 23);
            topLeftCombobox.TabIndex = 22;
            topLeftCombobox.SelectedIndexChanged += topLeftCombobox_SelectedIndexChanged;
            // 
            // topMidCombobox
            // 
            topMidCombobox.FormattingEnabled = true;
            topMidCombobox.Location = new Point(172, 280);
            topMidCombobox.Name = "topMidCombobox";
            topMidCombobox.Size = new Size(142, 23);
            topMidCombobox.TabIndex = 23;
            topMidCombobox.SelectedIndexChanged += topMidCombobox_SelectedIndexChanged;
            // 
            // topRightCombobox
            // 
            topRightCombobox.FormattingEnabled = true;
            topRightCombobox.Location = new Point(320, 0);
            topRightCombobox.Name = "topRightCombobox";
            topRightCombobox.Size = new Size(192, 23);
            topRightCombobox.TabIndex = 24;
            topRightCombobox.SelectedIndexChanged += topRightCombobox_SelectedIndexChanged;
            // 
            // bottomLeftCombobox
            // 
            bottomLeftCombobox.FormattingEnabled = true;
            bottomLeftCombobox.Location = new Point(91, 489);
            bottomLeftCombobox.Name = "bottomLeftCombobox";
            bottomLeftCombobox.Size = new Size(207, 23);
            bottomLeftCombobox.TabIndex = 25;
            bottomLeftCombobox.SelectedIndexChanged += bottomLeftCombobox_SelectedIndexChanged;
            // 
            // bottomRightCombobox
            // 
            bottomRightCombobox.FormattingEnabled = true;
            bottomRightCombobox.Location = new Point(316, 489);
            bottomRightCombobox.Name = "bottomRightCombobox";
            bottomRightCombobox.Size = new Size(186, 23);
            bottomRightCombobox.TabIndex = 26;
            bottomRightCombobox.SelectedIndexChanged += bottomRightCombobox_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.096386F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.903614F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel1.Controls.Add(selectFiles, 0, 0);
            tableLayoutPanel1.Controls.Add(savePosterCanvasButton, 2, 0);
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 670);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(488, 48);
            tableLayoutPanel1.TabIndex = 27;
            // 
            // savePosterCanvasButton
            // 
            savePosterCanvasButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            savePosterCanvasButton.Location = new Point(335, 3);
            savePosterCanvasButton.Name = "savePosterCanvasButton";
            savePosterCanvasButton.Size = new Size(150, 42);
            savePosterCanvasButton.TabIndex = 2;
            savePosterCanvasButton.Text = "Save Poster Canvas...";
            savePosterCanvasButton.UseVisualStyleBackColor = true;
            savePosterCanvasButton.Click += savePosterCanvasButton_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(166, 3);
            button1.Name = "button1";
            button1.Size = new Size(163, 42);
            button1.TabIndex = 3;
            button1.Text = "Save All Positions";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.AutoScrollMinSize = new Size(0, 20);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.219178F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.78082F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.Controls.Add(showImg5, 2, 4);
            tableLayoutPanel2.Controls.Add(showImg4, 2, 3);
            tableLayoutPanel2.Controls.Add(showImg3, 2, 2);
            tableLayoutPanel2.Controls.Add(showImg2, 2, 1);
            tableLayoutPanel2.Controls.Add(showImg1, 2, 0);
            tableLayoutPanel2.Controls.Add(image1Name, 1, 0);
            tableLayoutPanel2.Controls.Add(image2Name, 1, 1);
            tableLayoutPanel2.Controls.Add(image3Name, 1, 2);
            tableLayoutPanel2.Controls.Add(image4Name, 1, 3);
            tableLayoutPanel2.Controls.Add(image5Name, 1, 4);
            tableLayoutPanel2.Controls.Add(imgSingleSelect1, 0, 0);
            tableLayoutPanel2.Controls.Add(imgSingleSelect2, 0, 1);
            tableLayoutPanel2.Controls.Add(imgSingleSelect3, 0, 2);
            tableLayoutPanel2.Controls.Add(imgSingleSelect4, 0, 3);
            tableLayoutPanel2.Controls.Add(imgSingleSelect5, 0, 4);
            tableLayoutPanel2.Location = new Point(12, 518);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.Size = new Size(488, 145);
            tableLayoutPanel2.TabIndex = 28;
            // 
            // imgSingleSelect1
            // 
            imgSingleSelect1.Location = new Point(3, 3);
            imgSingleSelect1.Name = "imgSingleSelect1";
            imgSingleSelect1.Size = new Size(24, 23);
            imgSingleSelect1.TabIndex = 22;
            imgSingleSelect1.Text = "..";
            imgSingleSelect1.UseVisualStyleBackColor = true;
            imgSingleSelect1.Click += imgSingleSelect1_Click;
            // 
            // imgSingleSelect2
            // 
            imgSingleSelect2.Enabled = false;
            imgSingleSelect2.Location = new Point(3, 32);
            imgSingleSelect2.Name = "imgSingleSelect2";
            imgSingleSelect2.Size = new Size(24, 23);
            imgSingleSelect2.TabIndex = 23;
            imgSingleSelect2.Text = "..";
            imgSingleSelect2.UseVisualStyleBackColor = true;
            imgSingleSelect2.Click += imgSingleSelect2_Click;
            // 
            // imgSingleSelect3
            // 
            imgSingleSelect3.Enabled = false;
            imgSingleSelect3.Location = new Point(3, 61);
            imgSingleSelect3.Name = "imgSingleSelect3";
            imgSingleSelect3.Size = new Size(24, 23);
            imgSingleSelect3.TabIndex = 24;
            imgSingleSelect3.Text = "..";
            imgSingleSelect3.UseVisualStyleBackColor = true;
            imgSingleSelect3.Click += imgSingleSelect3_Click;
            // 
            // imgSingleSelect4
            // 
            imgSingleSelect4.Enabled = false;
            imgSingleSelect4.Location = new Point(3, 91);
            imgSingleSelect4.Name = "imgSingleSelect4";
            imgSingleSelect4.Size = new Size(24, 23);
            imgSingleSelect4.TabIndex = 25;
            imgSingleSelect4.Text = "..";
            imgSingleSelect4.UseVisualStyleBackColor = true;
            imgSingleSelect4.Click += imgSingleSelect4_Click;
            // 
            // imgSingleSelect5
            // 
            imgSingleSelect5.Enabled = false;
            imgSingleSelect5.Location = new Point(3, 120);
            imgSingleSelect5.Name = "imgSingleSelect5";
            imgSingleSelect5.Size = new Size(24, 22);
            imgSingleSelect5.TabIndex = 26;
            imgSingleSelect5.Text = "..";
            imgSingleSelect5.UseVisualStyleBackColor = true;
            imgSingleSelect5.Click += imgSingleSelect5_Click;
            // 
            // Poster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 730);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(bottomRightCombobox);
            Controls.Add(bottomLeftCombobox);
            Controls.Add(topRightCombobox);
            Controls.Add(topMidCombobox);
            Controls.Add(topLeftCombobox);
            Controls.Add(bottomRightPicBox);
            Controls.Add(bottomLeftPicBox);
            Controls.Add(topRightPicBox);
            Controls.Add(topMidPicBox);
            Controls.Add(topLeftPicBox);
            Controls.Add(templateBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Poster";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Poster Creator";
            ((System.ComponentModel.ISupportInitialize)templateBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)topLeftPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)topMidPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)topRightPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)bottomLeftPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)bottomRightPicBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox templateBox;
        private Button selectFiles;
        private PictureBox topLeftPicBox;
        private PictureBox topMidPicBox;
        private PictureBox topRightPicBox;
        private PictureBox bottomLeftPicBox;
        private PictureBox bottomRightPicBox;
        private Label image1Name;
        private Label image2Name;
        private Label image3Name;
        private Label image4Name;
        private Label image5Name;
        private Button showImg1;
        private Button showImg2;
        private Button showImg3;
        private Button showImg4;
        private Button showImg5;
        private ComboBox topLeftCombobox;
        private ComboBox topMidCombobox;
        private ComboBox topRightCombobox;
        private ComboBox bottomLeftCombobox;
        private ComboBox bottomRightCombobox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button savePosterCanvasButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Button imgSingleSelect1;
        private Button imgSingleSelect2;
        private Button imgSingleSelect3;
        private Button imgSingleSelect4;
        private Button imgSingleSelect5;
        private Button button1;
    }
}