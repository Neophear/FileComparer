namespace FileComparer
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
            this.ofdFile1 = new System.Windows.Forms.OpenFileDialog();
            this.ofdFile2 = new System.Windows.Forms.OpenFileDialog();
            this.txtFile1 = new System.Windows.Forms.TextBox();
            this.lblFile1 = new System.Windows.Forms.Label();
            this.btnFindFile1 = new System.Windows.Forms.Button();
            this.btnFindFile2 = new System.Windows.Forms.Button();
            this.lblFile2 = new System.Windows.Forms.Label();
            this.txtFile2 = new System.Windows.Forms.TextBox();
            this.txtChecksum1 = new System.Windows.Forms.TextBox();
            this.lblChecksum1 = new System.Windows.Forms.Label();
            this.lblChecksum2 = new System.Windows.Forms.Label();
            this.txtChecksum2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdobtnCompareChecksum = new System.Windows.Forms.RadioButton();
            this.rdobtnCompareSize = new System.Windows.Forms.RadioButton();
            this.chkbxRecursive = new System.Windows.Forms.CheckBox();
            this.btnFindDuplicates = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnFindFolder = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ssBottom = new System.Windows.Forms.StatusStrip();
            this.tssBottom = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbBottom = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ssBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFile1
            // 
            this.txtFile1.Location = new System.Drawing.Point(44, 19);
            this.txtFile1.Name = "txtFile1";
            this.txtFile1.Size = new System.Drawing.Size(211, 20);
            this.txtFile1.TabIndex = 0;
            // 
            // lblFile1
            // 
            this.lblFile1.AutoSize = true;
            this.lblFile1.Location = new System.Drawing.Point(6, 22);
            this.lblFile1.Name = "lblFile1";
            this.lblFile1.Size = new System.Drawing.Size(32, 13);
            this.lblFile1.TabIndex = 1;
            this.lblFile1.Text = "File 1";
            // 
            // btnFindFile1
            // 
            this.btnFindFile1.Location = new System.Drawing.Point(261, 17);
            this.btnFindFile1.Name = "btnFindFile1";
            this.btnFindFile1.Size = new System.Drawing.Size(75, 23);
            this.btnFindFile1.TabIndex = 2;
            this.btnFindFile1.Text = "Find file";
            this.btnFindFile1.UseVisualStyleBackColor = true;
            this.btnFindFile1.Click += new System.EventHandler(this.btnFindFile1_Click);
            // 
            // btnFindFile2
            // 
            this.btnFindFile2.Location = new System.Drawing.Point(261, 43);
            this.btnFindFile2.Name = "btnFindFile2";
            this.btnFindFile2.Size = new System.Drawing.Size(75, 23);
            this.btnFindFile2.TabIndex = 5;
            this.btnFindFile2.Text = "Find file";
            this.btnFindFile2.UseVisualStyleBackColor = true;
            this.btnFindFile2.Click += new System.EventHandler(this.btnFindFile2_Click);
            // 
            // lblFile2
            // 
            this.lblFile2.AutoSize = true;
            this.lblFile2.Location = new System.Drawing.Point(6, 48);
            this.lblFile2.Name = "lblFile2";
            this.lblFile2.Size = new System.Drawing.Size(32, 13);
            this.lblFile2.TabIndex = 4;
            this.lblFile2.Text = "File 2";
            // 
            // txtFile2
            // 
            this.txtFile2.Location = new System.Drawing.Point(44, 45);
            this.txtFile2.Name = "txtFile2";
            this.txtFile2.Size = new System.Drawing.Size(211, 20);
            this.txtFile2.TabIndex = 3;
            // 
            // txtChecksum1
            // 
            this.txtChecksum1.Location = new System.Drawing.Point(434, 19);
            this.txtChecksum1.Name = "txtChecksum1";
            this.txtChecksum1.Size = new System.Drawing.Size(211, 20);
            this.txtChecksum1.TabIndex = 7;
            // 
            // lblChecksum1
            // 
            this.lblChecksum1.AutoSize = true;
            this.lblChecksum1.Location = new System.Drawing.Point(371, 22);
            this.lblChecksum1.Name = "lblChecksum1";
            this.lblChecksum1.Size = new System.Drawing.Size(57, 13);
            this.lblChecksum1.TabIndex = 8;
            this.lblChecksum1.Text = "Checksum";
            // 
            // lblChecksum2
            // 
            this.lblChecksum2.AutoSize = true;
            this.lblChecksum2.Location = new System.Drawing.Point(371, 48);
            this.lblChecksum2.Name = "lblChecksum2";
            this.lblChecksum2.Size = new System.Drawing.Size(57, 13);
            this.lblChecksum2.TabIndex = 10;
            this.lblChecksum2.Text = "Checksum";
            // 
            // txtChecksum2
            // 
            this.txtChecksum2.Location = new System.Drawing.Point(434, 45);
            this.txtChecksum2.Name = "txtChecksum2";
            this.txtChecksum2.Size = new System.Drawing.Size(211, 20);
            this.txtChecksum2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFindFile1);
            this.groupBox1.Controls.Add(this.lblChecksum2);
            this.groupBox1.Controls.Add(this.txtFile1);
            this.groupBox1.Controls.Add(this.txtChecksum2);
            this.groupBox1.Controls.Add(this.lblFile1);
            this.groupBox1.Controls.Add(this.lblChecksum1);
            this.groupBox1.Controls.Add(this.txtFile2);
            this.groupBox1.Controls.Add(this.txtChecksum1);
            this.groupBox1.Controls.Add(this.lblFile2);
            this.groupBox1.Controls.Add(this.btnFindFile2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 86);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compare files";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdobtnCompareChecksum);
            this.groupBox2.Controls.Add(this.rdobtnCompareSize);
            this.groupBox2.Controls.Add(this.chkbxRecursive);
            this.groupBox2.Controls.Add(this.btnFindDuplicates);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.btnFindFolder);
            this.groupBox2.Controls.Add(this.txtFolder);
            this.groupBox2.Controls.Add(this.lblFolder);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 464);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find duplicates";
            // 
            // rdobtnCompareChecksum
            // 
            this.rdobtnCompareChecksum.AutoSize = true;
            this.rdobtnCompareChecksum.Checked = true;
            this.rdobtnCompareChecksum.Location = new System.Drawing.Point(226, 45);
            this.rdobtnCompareChecksum.Name = "rdobtnCompareChecksum";
            this.rdobtnCompareChecksum.Size = new System.Drawing.Size(229, 17);
            this.rdobtnCompareChecksum.TabIndex = 21;
            this.rdobtnCompareChecksum.TabStop = true;
            this.rdobtnCompareChecksum.Text = "Compare files with checksum (takes longer)";
            this.rdobtnCompareChecksum.UseVisualStyleBackColor = true;
            // 
            // rdobtnCompareSize
            // 
            this.rdobtnCompareSize.AutoSize = true;
            this.rdobtnCompareSize.Location = new System.Drawing.Point(89, 45);
            this.rdobtnCompareSize.Name = "rdobtnCompareSize";
            this.rdobtnCompareSize.Size = new System.Drawing.Size(131, 17);
            this.rdobtnCompareSize.TabIndex = 20;
            this.rdobtnCompareSize.TabStop = true;
            this.rdobtnCompareSize.Text = "Compare files with size";
            this.rdobtnCompareSize.UseVisualStyleBackColor = true;
            // 
            // chkbxRecursive
            // 
            this.chkbxRecursive.AutoSize = true;
            this.chkbxRecursive.Location = new System.Drawing.Point(9, 45);
            this.chkbxRecursive.Name = "chkbxRecursive";
            this.chkbxRecursive.Size = new System.Drawing.Size(74, 17);
            this.chkbxRecursive.TabIndex = 19;
            this.chkbxRecursive.Text = "Recursive";
            this.chkbxRecursive.UseVisualStyleBackColor = true;
            // 
            // btnFindDuplicates
            // 
            this.btnFindDuplicates.Location = new System.Drawing.Point(537, 17);
            this.btnFindDuplicates.Name = "btnFindDuplicates";
            this.btnFindDuplicates.Size = new System.Drawing.Size(108, 23);
            this.btnFindDuplicates.TabIndex = 18;
            this.btnFindDuplicates.Text = "Find duplicates";
            this.btnFindDuplicates.UseVisualStyleBackColor = true;
            this.btnFindDuplicates.Click += new System.EventHandler(this.btnFindDuplicates_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(3, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(650, 385);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // btnFindFolder
            // 
            this.btnFindFolder.Location = new System.Drawing.Point(261, 17);
            this.btnFindFolder.Name = "btnFindFolder";
            this.btnFindFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFindFolder.TabIndex = 13;
            this.btnFindFolder.Text = "Find folder";
            this.btnFindFolder.UseVisualStyleBackColor = true;
            this.btnFindFolder.Click += new System.EventHandler(this.btnFindFolder_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(57, 19);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(198, 20);
            this.txtFolder.TabIndex = 11;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(6, 22);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(36, 13);
            this.lblFolder.TabIndex = 12;
            this.lblFolder.Text = "Folder";
            // 
            // ssBottom
            // 
            this.ssBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssBottom,
            this.tspbBottom});
            this.ssBottom.Location = new System.Drawing.Point(0, 571);
            this.ssBottom.Name = "ssBottom";
            this.ssBottom.Size = new System.Drawing.Size(682, 22);
            this.ssBottom.SizingGrip = false;
            this.ssBottom.TabIndex = 13;
            this.ssBottom.Text = "ssBottom";
            // 
            // tssBottom
            // 
            this.tssBottom.AutoSize = false;
            this.tssBottom.Name = "tssBottom";
            this.tssBottom.Size = new System.Drawing.Size(465, 17);
            this.tssBottom.Spring = true;
            this.tssBottom.Text = "Made by Stiig Gade";
            this.tssBottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tspbBottom
            // 
            this.tspbBottom.Name = "tspbBottom";
            this.tspbBottom.Size = new System.Drawing.Size(200, 16);
            this.tspbBottom.Step = 1;
            this.tspbBottom.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 593);
            this.Controls.Add(this.ssBottom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ssBottom.ResumeLayout(false);
            this.ssBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdFile1;
        private System.Windows.Forms.OpenFileDialog ofdFile2;
        private System.Windows.Forms.TextBox txtFile1;
        private System.Windows.Forms.Label lblFile1;
        private System.Windows.Forms.Button btnFindFile1;
        private System.Windows.Forms.Button btnFindFile2;
        private System.Windows.Forms.Label lblFile2;
        private System.Windows.Forms.TextBox txtFile2;
        private System.Windows.Forms.TextBox txtChecksum1;
        private System.Windows.Forms.Label lblChecksum1;
        private System.Windows.Forms.Label lblChecksum2;
        private System.Windows.Forms.TextBox txtChecksum2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.Button btnFindFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnFindDuplicates;
        private System.Windows.Forms.StatusStrip ssBottom;
        private System.Windows.Forms.ToolStripStatusLabel tssBottom;
        private System.Windows.Forms.ToolStripProgressBar tspbBottom;
        private System.Windows.Forms.CheckBox chkbxRecursive;
        private System.Windows.Forms.RadioButton rdobtnCompareChecksum;
        private System.Windows.Forms.RadioButton rdobtnCompareSize;
    }
}

