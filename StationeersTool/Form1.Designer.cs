namespace StationeersTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgUpload = new System.Windows.Forms.Button();
            this.worldFileUpload = new System.Windows.Forms.Button();
            this.saveNewWorldFile = new System.Windows.Forms.Button();
            this.imgFileLabel = new System.Windows.Forms.Label();
            this.worldDataFileLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.processImg = new System.Windows.Forms.Button();
            this.debug1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.structureTypeCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgUpload
            // 
            this.imgUpload.Location = new System.Drawing.Point(15, 409);
            this.imgUpload.Name = "imgUpload";
            this.imgUpload.Size = new System.Drawing.Size(75, 23);
            this.imgUpload.TabIndex = 0;
            this.imgUpload.Text = "Upload Img";
            this.imgUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imgUpload.UseVisualStyleBackColor = true;
            this.imgUpload.Click += new System.EventHandler(this.imgUpload_Click);
            // 
            // worldFileUpload
            // 
            this.worldFileUpload.Location = new System.Drawing.Point(10, 461);
            this.worldFileUpload.Name = "worldFileUpload";
            this.worldFileUpload.Size = new System.Drawing.Size(135, 23);
            this.worldFileUpload.TabIndex = 1;
            this.worldFileUpload.Text = "Upload World File";
            this.worldFileUpload.UseVisualStyleBackColor = true;
            this.worldFileUpload.Click += new System.EventHandler(this.worldFileUpload_Click);
            // 
            // saveNewWorldFile
            // 
            this.saveNewWorldFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveNewWorldFile.Location = new System.Drawing.Point(931, 484);
            this.saveNewWorldFile.Name = "saveNewWorldFile";
            this.saveNewWorldFile.Size = new System.Drawing.Size(75, 23);
            this.saveNewWorldFile.TabIndex = 2;
            this.saveNewWorldFile.Text = "Save";
            this.saveNewWorldFile.UseVisualStyleBackColor = true;
            this.saveNewWorldFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // imgFileLabel
            // 
            this.imgFileLabel.AutoSize = true;
            this.imgFileLabel.Location = new System.Drawing.Point(12, 393);
            this.imgFileLabel.Name = "imgFileLabel";
            this.imgFileLabel.Size = new System.Drawing.Size(94, 13);
            this.imgFileLabel.TabIndex = 3;
            this.imgFileLabel.Text = "Choose PNG file...";
            // 
            // worldDataFileLabel
            // 
            this.worldDataFileLabel.AutoSize = true;
            this.worldDataFileLabel.Location = new System.Drawing.Point(12, 445);
            this.worldDataFileLabel.Name = "worldDataFileLabel";
            this.worldDataFileLabel.Size = new System.Drawing.Size(99, 13);
            this.worldDataFileLabel.TabIndex = 4;
            this.worldDataFileLabel.Text = "Choose Save File...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(511, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(504, 466);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(277, 31);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Z Index:";
            // 
            // processImg
            // 
            this.processImg.Location = new System.Drawing.Point(277, 170);
            this.processImg.Name = "processImg";
            this.processImg.Size = new System.Drawing.Size(219, 81);
            this.processImg.TabIndex = 9;
            this.processImg.Text = "Convert PNG to XML";
            this.processImg.UseVisualStyleBackColor = true;
            this.processImg.Click += new System.EventHandler(this.processImg_Click);
            // 
            // debug1
            // 
            this.debug1.AutoSize = true;
            this.debug1.Location = new System.Drawing.Point(274, 254);
            this.debug1.Name = "debug1";
            this.debug1.Size = new System.Drawing.Size(88, 13);
            this.debug1.TabIndex = 10;
            this.debug1.Text = "Detected Frames";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "WARNING: THIS WILL OVERWRITE YOUR SAVE FILE! ITS IRREVERISBLE WITHOUT BACKUPS!";
            // 
            // structureTypeCombo
            // 
            this.structureTypeCombo.FormattingEnabled = true;
            this.structureTypeCombo.Items.AddRange(new object[] {
            "Iron Frame",
            "Steel Frame"});
            this.structureTypeCombo.Location = new System.Drawing.Point(277, 87);
            this.structureTypeCombo.Name = "structureTypeCombo";
            this.structureTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.structureTypeCombo.TabIndex = 12;
            this.structureTypeCombo.Text = "Choose Structure";
            this.structureTypeCombo.SelectedIndexChanged += new System.EventHandler(this.structureTypeCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Structure Type:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(5, 273);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(255, 97);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 510);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.structureTypeCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.debug1);
            this.Controls.Add(this.processImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.worldDataFileLabel);
            this.Controls.Add(this.imgFileLabel);
            this.Controls.Add(this.saveNewWorldFile);
            this.Controls.Add(this.worldFileUpload);
            this.Controls.Add(this.imgUpload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 460);
            this.Name = "Form1";
            this.Text = "MX|55\'s PNG to Save File Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button imgUpload;
        private System.Windows.Forms.Button worldFileUpload;
        private System.Windows.Forms.Button saveNewWorldFile;
        private System.Windows.Forms.Label imgFileLabel;
        private System.Windows.Forms.Label worldDataFileLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button processImg;
        private System.Windows.Forms.Label debug1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox structureTypeCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listView1;
    }
}

