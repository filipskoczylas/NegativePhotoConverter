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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rbCsharp);
            this.Controls.Add(this.rbAssembly);
            this.Controls.Add(this.btnLoadImages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button btnLoadImages;
        private RadioButton rbAssembly;
        private RadioButton rbCsharp;
        private Button btnStart;
    }
}