namespace NegativePhotoConverter
{
    partial class Form1
    {
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadImages = new System.Windows.Forms.Button();
            this.rbAssembly = new System.Windows.Forms.RadioButton();
            this.rbCsharp = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbTimeElapsedConst = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbThreads = new System.Windows.Forms.Label();
            this.nupThreads = new System.Windows.Forms.NumericUpDown();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.gbConfiguration = new System.Windows.Forms.GroupBox();
            this.lbInputImage = new System.Windows.Forms.Label();
            this.lbOutputImage = new System.Windows.Forms.Label();
            this.pbInput = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            this.gbConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImages
            // 
            this.btnLoadImages.Location = new System.Drawing.Point(6, 26);
            this.btnLoadImages.Name = "btnLoadImages";
            this.btnLoadImages.Size = new System.Drawing.Size(130, 30);
            this.btnLoadImages.TabIndex = 0;
            this.btnLoadImages.Text = "Select image";
            this.btnLoadImages.UseVisualStyleBackColor = true;
            this.btnLoadImages.Click += new System.EventHandler(this.btnLoadImages_Click);
            // 
            // rbAssembly
            // 
            this.rbAssembly.AutoSize = true;
            this.rbAssembly.Checked = true;
            this.rbAssembly.Location = new System.Drawing.Point(6, 62);
            this.rbAssembly.Name = "rbAssembly";
            this.rbAssembly.Size = new System.Drawing.Size(180, 24);
            this.rbAssembly.TabIndex = 1;
            this.rbAssembly.TabStop = true;
            this.rbAssembly.Text = "Convet usnig assembly";
            this.rbAssembly.UseVisualStyleBackColor = true;
            // 
            // rbCsharp
            // 
            this.rbCsharp.AutoSize = true;
            this.rbCsharp.Location = new System.Drawing.Point(6, 92);
            this.rbCsharp.Name = "rbCsharp";
            this.rbCsharp.Size = new System.Drawing.Size(142, 24);
            this.rbCsharp.TabIndex = 2;
            this.rbCsharp.Text = "Convert using C#";
            this.rbCsharp.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 200);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 30);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbTimeElapsedConst
            // 
            this.lbTimeElapsedConst.AutoSize = true;
            this.lbTimeElapsedConst.Location = new System.Drawing.Point(12, 233);
            this.lbTimeElapsedConst.Name = "lbTimeElapsedConst";
            this.lbTimeElapsedConst.Size = new System.Drawing.Size(195, 40);
            this.lbTimeElapsedConst.TabIndex = 4;
            this.lbTimeElapsedConst.Text = "Function execution time [us]\r\n:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(12, 253);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(17, 20);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "0";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbThreads
            // 
            this.lbThreads.AutoSize = true;
            this.lbThreads.Location = new System.Drawing.Point(6, 119);
            this.lbThreads.Name = "lbThreads";
            this.lbThreads.Size = new System.Drawing.Size(102, 20);
            this.lbThreads.TabIndex = 7;
            this.lbThreads.Text = "Used threads: ";
            // 
            // nupThreads
            // 
            this.nupThreads.Location = new System.Drawing.Point(6, 142);
            this.nupThreads.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nupThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupThreads.Name = "nupThreads";
            this.nupThreads.Size = new System.Drawing.Size(102, 27);
            this.nupThreads.TabIndex = 9;
            this.nupThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pbOutput
            // 
            this.pbOutput.Location = new System.Drawing.Point(586, 38);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(365, 307);
            this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOutput.TabIndex = 10;
            this.pbOutput.TabStop = false;
            // 
            // gbConfiguration
            // 
            this.gbConfiguration.Controls.Add(this.btnLoadImages);
            this.gbConfiguration.Controls.Add(this.rbAssembly);
            this.gbConfiguration.Controls.Add(this.lbThreads);
            this.gbConfiguration.Controls.Add(this.nupThreads);
            this.gbConfiguration.Controls.Add(this.rbCsharp);
            this.gbConfiguration.Location = new System.Drawing.Point(12, 12);
            this.gbConfiguration.Name = "gbConfiguration";
            this.gbConfiguration.Size = new System.Drawing.Size(197, 182);
            this.gbConfiguration.TabIndex = 11;
            this.gbConfiguration.TabStop = false;
            this.gbConfiguration.Text = "Configuration";
            // 
            // lbInputImage
            // 
            this.lbInputImage.AutoSize = true;
            this.lbInputImage.Location = new System.Drawing.Point(215, 12);
            this.lbInputImage.Name = "lbInputImage";
            this.lbInputImage.Size = new System.Drawing.Size(92, 20);
            this.lbInputImage.TabIndex = 12;
            this.lbInputImage.Text = "Input image:";
            // 
            // lbOutputImage
            // 
            this.lbOutputImage.AutoSize = true;
            this.lbOutputImage.Location = new System.Drawing.Point(586, 12);
            this.lbOutputImage.Name = "lbOutputImage";
            this.lbOutputImage.Size = new System.Drawing.Size(104, 20);
            this.lbOutputImage.TabIndex = 13;
            this.lbOutputImage.Text = "Output image:";
            // 
            // pbInput
            // 
            this.pbInput.Location = new System.Drawing.Point(215, 38);
            this.pbInput.Name = "pbInput";
            this.pbInput.Size = new System.Drawing.Size(365, 307);
            this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInput.TabIndex = 14;
            this.pbInput.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 369);
            this.Controls.Add(this.pbInput);
            this.Controls.Add(this.lbOutputImage);
            this.Controls.Add(this.lbInputImage);
            this.Controls.Add(this.gbConfiguration);
            this.Controls.Add(this.pbOutput);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbTimeElapsedConst);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Negative photo converter";
            ((System.ComponentModel.ISupportInitialize)(this.nupThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            this.gbConfiguration.ResumeLayout(false);
            this.gbConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button btnLoadImages;
        private RadioButton rbAssembly;
        private RadioButton rbCsharp;
        private Button btnStart;
        private Label lbTimeElapsedConst;
        private Label lbTime;
        private Label lbThreads;
        private NumericUpDown nupThreads;
        private PictureBox pbOutput;
        private GroupBox gbConfiguration;
        private Label lbInputImage;
        private Label lbOutputImage;
        private PictureBox pbInput;
    }
}