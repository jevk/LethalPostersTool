namespace LethalPostersCreator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            tableLayoutPanel1 = new TableLayoutPanel();
            tipsLauncher = new Button();
            postersLauncher = new Button();
            paintingsLauncher = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 256F));
            tableLayoutPanel1.Controls.Add(tipsLauncher, 0, 0);
            tableLayoutPanel1.Controls.Add(postersLauncher, 1, 0);
            tableLayoutPanel1.Controls.Add(paintingsLauncher, 2, 0);
            tableLayoutPanel1.Location = new Point(12, 373);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(776, 65);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tipsLauncher
            // 
            tipsLauncher.Enabled = false;
            tipsLauncher.Location = new Point(3, 3);
            tipsLauncher.Name = "tipsLauncher";
            tipsLauncher.Size = new Size(254, 59);
            tipsLauncher.TabIndex = 0;
            tipsLauncher.Text = "Tips";
            tipsLauncher.UseVisualStyleBackColor = true;
            tipsLauncher.Click += tipsLauncher_Click;
            // 
            // postersLauncher
            // 
            postersLauncher.Enabled = false;
            postersLauncher.Location = new Point(263, 3);
            postersLauncher.Name = "postersLauncher";
            postersLauncher.Size = new Size(254, 59);
            postersLauncher.TabIndex = 1;
            postersLauncher.Text = "Posters";
            postersLauncher.UseVisualStyleBackColor = true;
            postersLauncher.Click += postersLauncher_Click;
            // 
            // paintingsLauncher
            // 
            paintingsLauncher.Enabled = false;
            paintingsLauncher.Location = new Point(523, 3);
            paintingsLauncher.Name = "paintingsLauncher";
            paintingsLauncher.Size = new Size(250, 59);
            paintingsLauncher.TabIndex = 2;
            paintingsLauncher.Text = "Paintings";
            paintingsLauncher.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(275, 192);
            button1.Name = "button1";
            button1.Size = new Size(254, 51);
            button1.TabIndex = 1;
            button1.Text = "Select an existing poster mod";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(275, 135);
            button2.Name = "button2";
            button2.Size = new Size(254, 51);
            button2.TabIndex = 2;
            button2.Text = "Create a new poster mod";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(770, 34);
            label1.TabIndex = 3;
            label1.Text = "Selected mod: null";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(12, 284);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(776, 34);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "LethalCompany Custom Poster Addon Creator";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button tipsLauncher;
        private Button postersLauncher;
        private Button paintingsLauncher;
        private Button button1;
        private Button button2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}