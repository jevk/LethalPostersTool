namespace LethalPostersCreator
{
    partial class TipsCreator
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
            pictureBox1 = new PictureBox();
            imgList = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            chooseFilesButton = new Button();
            saveFilesButton = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            numericUpDown3 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(398, 512);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // imgList
            // 
            imgList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imgList.FormattingEnabled = true;
            imgList.ItemHeight = 15;
            imgList.Location = new Point(12, 579);
            imgList.Name = "imgList";
            imgList.Size = new Size(375, 79);
            imgList.TabIndex = 1;
            imgList.SelectedIndexChanged += imgList_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(chooseFilesButton, 0, 0);
            tableLayoutPanel1.Controls.Add(saveFilesButton, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 664);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(375, 48);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // chooseFilesButton
            // 
            chooseFilesButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chooseFilesButton.Location = new Point(3, 3);
            chooseFilesButton.Name = "chooseFilesButton";
            chooseFilesButton.Size = new Size(181, 42);
            chooseFilesButton.TabIndex = 0;
            chooseFilesButton.Text = "Choose files...";
            chooseFilesButton.UseVisualStyleBackColor = true;
            chooseFilesButton.Click += chooseFilesButton_Click;
            // 
            // saveFilesButton
            // 
            saveFilesButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            saveFilesButton.Location = new Point(190, 3);
            saveFilesButton.Name = "saveFilesButton";
            saveFilesButton.Size = new Size(182, 42);
            saveFilesButton.TabIndex = 1;
            saveFilesButton.Text = "Save files";
            saveFilesButton.UseVisualStyleBackColor = true;
            saveFilesButton.Click += saveFilesButton_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown1.Location = new Point(345, 518);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(42, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown2.Location = new Point(345, 547);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(42, 23);
            numericUpDown2.TabIndex = 4;
            numericUpDown2.Value = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(289, 520);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 5;
            label1.Text = "X offset:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(289, 549);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 7;
            label3.Text = "Y offset:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 520);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 8;
            label2.Text = "Max height:";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(88, 518);
            numericUpDown3.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(62, 23);
            numericUpDown3.TabIndex = 9;
            numericUpDown3.Value = new decimal(new int[] { 1024, 0, 0, 0 });
            // 
            // TipsCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 724);
            Controls.Add(numericUpDown3);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(imgList);
            Controls.Add(pictureBox1);
            Name = "TipsCreator";
            Text = "TipsCreator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox imgList;
        private TableLayoutPanel tableLayoutPanel1;
        private Button chooseFilesButton;
        private Button saveFilesButton;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label1;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDown3;
    }
}