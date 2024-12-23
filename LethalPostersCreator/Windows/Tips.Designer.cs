namespace LethalPostersCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tips));
            chooseFileButton = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            maxHeightText = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // chooseFileButton
            // 
            chooseFileButton.Location = new Point(3, 3);
            chooseFileButton.Name = "chooseFileButton";
            chooseFileButton.Size = new Size(247, 45);
            chooseFileButton.TabIndex = 0;
            chooseFileButton.Text = "Choose file...";
            chooseFileButton.UseVisualStyleBackColor = true;
            chooseFileButton.Click += chooseFileButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(530, 682);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Enabled = false;
            button1.Location = new Point(257, 3);
            button1.Name = "button1";
            button1.Size = new Size(246, 45);
            button1.TabIndex = 2;
            button1.Text = "Save file...";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 707);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(51, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "0";
            textBox1.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 688);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(79, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Batch edit";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 710);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 5;
            label1.Text = "Batch starting number: ";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 710);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 6;
            label2.Text = "Max output height:";
            // 
            // maxHeightText
            // 
            maxHeightText.Location = new Point(384, 707);
            maxHeightText.Name = "maxHeightText";
            maxHeightText.Size = new Size(131, 23);
            maxHeightText.TabIndex = 7;
            maxHeightText.Text = "1024";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(chooseFileButton, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 740);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(506, 52);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(269, 688);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(104, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Painting mode";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Tips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 804);
            Controls.Add(checkBox2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(maxHeightText);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Tips";
            Text = "Tips Poster Creator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chooseFileButton;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private TextBox maxHeightText;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox checkBox2;
    }
}