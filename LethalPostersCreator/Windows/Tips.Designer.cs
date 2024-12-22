namespace LethalPostersCreator.Windows
{
    partial class Tips
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            fileChooseButton = new Button();
            saveFilesButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            imgNamesText = new ListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            yOffsetNumber = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            xOffsetNumber = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yOffsetNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xOffsetNumber).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 658);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(fileChooseButton, 0, 0);
            tableLayoutPanel1.Controls.Add(saveFilesButton, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 826);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(488, 55);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // fileChooseButton
            // 
            fileChooseButton.Location = new Point(3, 3);
            fileChooseButton.Name = "fileChooseButton";
            fileChooseButton.Size = new Size(238, 49);
            fileChooseButton.TabIndex = 0;
            fileChooseButton.Text = "Select files...";
            fileChooseButton.UseVisualStyleBackColor = true;
            fileChooseButton.Click += fileChooseButton_Click;
            // 
            // saveFilesButton
            // 
            saveFilesButton.Location = new Point(247, 3);
            saveFilesButton.Name = "saveFilesButton";
            saveFilesButton.Size = new Size(238, 49);
            saveFilesButton.TabIndex = 1;
            saveFilesButton.Text = "Save files...";
            saveFilesButton.UseVisualStyleBackColor = true;
            saveFilesButton.Click += saveFilesButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 782);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "1024";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 785);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "Max height:";
            // 
            // imgNamesText
            // 
            imgNamesText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            imgNamesText.FormattingEnabled = true;
            imgNamesText.ItemHeight = 15;
            imgNamesText.Items.AddRange(new object[] { "Image file names:" });
            imgNamesText.Location = new Point(12, 664);
            imgNamesText.Name = "imgNamesText";
            imgNamesText.Size = new Size(488, 94);
            imgNamesText.TabIndex = 4;
            imgNamesText.SelectedIndexChanged += imgNamesText_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.2689056F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7310925F));
            tableLayoutPanel2.Controls.Add(yOffsetNumber, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(xOffsetNumber, 1, 0);
            tableLayoutPanel2.Location = new Point(259, 764);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(238, 56);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // yOffsetNumber
            // 
            yOffsetNumber.DecimalPlaces = 1;
            yOffsetNumber.Location = new Point(175, 31);
            yOffsetNumber.Name = "yOffsetNumber";
            yOffsetNumber.Size = new Size(60, 23);
            yOffsetNumber.TabIndex = 3;
            yOffsetNumber.Value = new decimal(new int[] { 50, 0, 0, 0 });
            yOffsetNumber.ValueChanged += yOffsetNumber_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(55, 6);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 0;
            label2.Text = "X Offset Percentage:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(55, 34);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 1;
            label3.Text = "Y Offset Percentage:";
            // 
            // xOffsetNumber
            // 
            xOffsetNumber.DecimalPlaces = 1;
            xOffsetNumber.Location = new Point(175, 3);
            xOffsetNumber.Name = "xOffsetNumber";
            xOffsetNumber.Size = new Size(60, 23);
            xOffsetNumber.TabIndex = 2;
            xOffsetNumber.Value = new decimal(new int[] { 50, 0, 0, 0 });
            xOffsetNumber.ValueChanged += xOffsetNumber_ValueChanged;
            // 
            // Tips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 893);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(imgNamesText);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Name = "Tips";
            Text = "Tips";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yOffsetNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)xOffsetNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button fileChooseButton;
        private Button saveFilesButton;
        private TextBox textBox1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private ListBox imgNamesText;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label3;
        private NumericUpDown yOffsetNumber;
        private NumericUpDown xOffsetNumber;
    }
}