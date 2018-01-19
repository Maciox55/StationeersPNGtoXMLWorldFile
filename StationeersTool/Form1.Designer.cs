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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.layerPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgUpload
            // 
            this.imgUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.imgUpload.FlatAppearance.BorderSize = 0;
            this.imgUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgUpload.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgUpload.Location = new System.Drawing.Point(0, 297);
            this.imgUpload.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.imgUpload.Name = "imgUpload";
            this.imgUpload.Size = new System.Drawing.Size(180, 50);
            this.imgUpload.TabIndex = 0;
            this.imgUpload.Text = "2. Upload Imgs";
            this.imgUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgUpload.UseVisualStyleBackColor = false;
            this.imgUpload.Click += new System.EventHandler(this.imgUpload_Click);
            // 
            // worldFileUpload
            // 
            this.worldFileUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.worldFileUpload.FlatAppearance.BorderSize = 0;
            this.worldFileUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.worldFileUpload.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worldFileUpload.Location = new System.Drawing.Point(0, 244);
            this.worldFileUpload.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.worldFileUpload.Name = "worldFileUpload";
            this.worldFileUpload.Size = new System.Drawing.Size(180, 50);
            this.worldFileUpload.TabIndex = 1;
            this.worldFileUpload.Text = "1. Upload World File";
            this.worldFileUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.worldFileUpload.UseVisualStyleBackColor = false;
            this.worldFileUpload.Click += new System.EventHandler(this.worldFileUpload_Click);
            // 
            // saveNewWorldFile
            // 
            this.saveNewWorldFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.saveNewWorldFile.FlatAppearance.BorderSize = 0;
            this.saveNewWorldFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNewWorldFile.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNewWorldFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveNewWorldFile.Location = new System.Drawing.Point(0, 403);
            this.saveNewWorldFile.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.saveNewWorldFile.Name = "saveNewWorldFile";
            this.saveNewWorldFile.Size = new System.Drawing.Size(180, 50);
            this.saveNewWorldFile.TabIndex = 2;
            this.saveNewWorldFile.Text = "4. Save";
            this.saveNewWorldFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveNewWorldFile.UseVisualStyleBackColor = false;
            this.saveNewWorldFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // imgFileLabel
            // 
            this.imgFileLabel.AutoSize = true;
            this.imgFileLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgFileLabel.Location = new System.Drawing.Point(2, 3);
            this.imgFileLabel.Name = "imgFileLabel";
            this.imgFileLabel.Size = new System.Drawing.Size(108, 15);
            this.imgFileLabel.TabIndex = 3;
            this.imgFileLabel.Text = "Choose PNG file...";
            // 
            // worldDataFileLabel
            // 
            this.worldDataFileLabel.AutoSize = true;
            this.worldDataFileLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worldDataFileLabel.Location = new System.Drawing.Point(2, 18);
            this.worldDataFileLabel.Name = "worldDataFileLabel";
            this.worldDataFileLabel.Size = new System.Drawing.Size(113, 15);
            this.worldDataFileLabel.TabIndex = 4;
            this.worldDataFileLabel.Text = "Choose Save File...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.richTextBox1.Location = new System.Drawing.Point(430, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(405, 322);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(120, 140);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            21,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 23);
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
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Z Index:";
            // 
            // processImg
            // 
            this.processImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.processImg.FlatAppearance.BorderSize = 0;
            this.processImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processImg.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processImg.Location = new System.Drawing.Point(0, 350);
            this.processImg.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.processImg.Name = "processImg";
            this.processImg.Size = new System.Drawing.Size(180, 50);
            this.processImg.TabIndex = 9;
            this.processImg.Text = "3. Convert PNG to XML";
            this.processImg.UseVisualStyleBackColor = false;
            this.processImg.Click += new System.EventHandler(this.processImg_Click);
            // 
            // debug1
            // 
            this.debug1.AutoSize = true;
            this.debug1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.debug1.Location = new System.Drawing.Point(6, 422);
            this.debug1.Name = "debug1";
            this.debug1.Size = new System.Drawing.Size(154, 23);
            this.debug1.TabIndex = 10;
            this.debug1.Text = "Detected Frames";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "WARNING: THIS WILL OVERWRITE YOUR SAVE FILE! ITS IRREVERISBLE WITHOUT BACKUPS!";
            // 
            // structureTypeCombo
            // 
            this.structureTypeCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.structureTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.structureTypeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.structureTypeCombo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.structureTypeCombo.Items.AddRange(new object[] {
            "Iron Frame",
            "Steel Frame"});
            this.structureTypeCombo.Location = new System.Drawing.Point(0, 198);
            this.structureTypeCombo.Name = "structureTypeCombo";
            this.structureTypeCombo.Size = new System.Drawing.Size(180, 31);
            this.structureTypeCombo.TabIndex = 12;
            this.structureTypeCombo.SelectedIndexChanged += new System.EventHandler(this.structureTypeCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Structure Type:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.saveNewWorldFile);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.processImg);
            this.panel1.Controls.Add(this.worldDataFileLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.imgFileLabel);
            this.panel1.Controls.Add(this.structureTypeCombo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.imgUpload);
            this.panel1.Controls.Add(this.worldFileUpload);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 475);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Version: 1.02";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.layerPanel);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.debug1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(180, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 475);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.label6.Location = new System.Drawing.Point(5, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Layers:";
            // 
            // layerPanel
            // 
            this.layerPanel.AutoScroll = true;
            this.layerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.layerPanel.Location = new System.Drawing.Point(3, 350);
            this.layerPanel.Name = "layerPanel";
            this.layerPanel.Size = new System.Drawing.Size(832, 70);
            this.layerPanel.TabIndex = 12;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.closeButton.Location = new System.Drawing.Point(983, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 35);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(153)))), ((int)(((byte)(10)))));
            this.panel3.Location = new System.Drawing.Point(180, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 510);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.closeButton);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1018, 35);
            this.panel4.TabIndex = 3;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.label5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.label5.Location = new System.Drawing.Point(2, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "STATIONEERS PNG CONVERTER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 460);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MX|55\'s PNG to Save File Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel layerPanel;
    }
}

