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
            this.pbNegative = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNegative)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImages
            // 
            this.btnLoadImages.Location = new System.Drawing.Point(12, 12);
            this.btnLoadImages.Name = "btnLoadImages";
            this.btnLoadImages.Size = new System.Drawing.Size(130, 30);
            this.btnLoadImages.TabIndex = 0;
            this.btnLoadImages.Text = "Select images";
            this.btnLoadImages.UseVisualStyleBackColor = true;
            this.btnLoadImages.Click += new System.EventHandler(this.btnLoadImages_Click);
            // 
            // rbAssembly
            // 
            this.rbAssembly.AutoSize = true;
            this.rbAssembly.Checked = true;
            this.rbAssembly.Location = new System.Drawing.Point(12, 47);
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
            this.rbCsharp.Location = new System.Drawing.Point(12, 77);
            this.rbCsharp.Name = "rbCsharp";
            this.rbCsharp.Size = new System.Drawing.Size(142, 24);
            this.rbCsharp.TabIndex = 2;
            this.rbCsharp.Text = "Convert using C#";
            this.rbCsharp.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 107);
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
            this.lbTimeElapsedConst.Location = new System.Drawing.Point(12, 140);
            this.lbTimeElapsedConst.Name = "lbTimeElapsedConst";
            this.lbTimeElapsedConst.Size = new System.Drawing.Size(170, 20);
            this.lbTimeElapsedConst.TabIndex = 4;
            this.lbTimeElapsedConst.Text = "Function execution time:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(12, 160);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(17, 20);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "0";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbThreads
            // 
            this.lbThreads.AutoSize = true;
            this.lbThreads.Location = new System.Drawing.Point(217, 9);
            this.lbThreads.Name = "lbThreads";
            this.lbThreads.Size = new System.Drawing.Size(102, 20);
            this.lbThreads.TabIndex = 7;
            this.lbThreads.Text = "Used threads: ";
            // 
            // nupThreads
            // 
            this.nupThreads.Location = new System.Drawing.Point(217, 32);
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
            // pbNegative
            // 
            this.pbNegative.Location = new System.Drawing.Point(423, 131);
            this.pbNegative.Name = "pbNegative";
            this.pbNegative.Size = new System.Drawing.Size(365, 307);
            this.pbNegative.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNegative.TabIndex = 10;
            this.pbNegative.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbNegative);
            this.Controls.Add(this.nupThreads);
            this.Controls.Add(this.lbThreads);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbTimeElapsedConst);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rbCsharp);
            this.Controls.Add(this.rbAssembly);
            this.Controls.Add(this.btnLoadImages);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nupThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNegative)).EndInit();
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
        private PictureBox pbNegative;
    }
}