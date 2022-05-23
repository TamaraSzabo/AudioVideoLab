namespace AudioVideoLab
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadImage = new System.Windows.Forms.Button();
            this.GreyImage = new System.Windows.Forms.Button();
            this.Histogram = new System.Windows.Forms.Button();
            this.Brightness = new System.Windows.Forms.Button();
            this.Gamma = new System.Windows.Forms.Button();
            this.Resize = new System.Windows.Forms.Button();
            this.Rotate = new System.Windows.Forms.Button();
            this.BlendingImage = new System.Windows.Forms.Button();
            this.ChangeColorSpace = new System.Windows.Forms.Button();
            this.VideoCapture = new System.Windows.Forms.Button();
            this.WritingToVideo = new System.Windows.Forms.Button();
            this.alpha_textBox = new System.Windows.Forms.TextBox();
            this.beta_textBox = new System.Windows.Forms.TextBox();
            this.gamma_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackgroundSubs = new System.Windows.Forms.Button();
            this.reddFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(382, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoadImage
            // 
            this.LoadImage.Location = new System.Drawing.Point(58, 16);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(117, 41);
            this.LoadImage.TabIndex = 1;
            this.LoadImage.Text = "LoadImage";
            this.LoadImage.UseVisualStyleBackColor = true;
            this.LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // GreyImage
            // 
            this.GreyImage.Location = new System.Drawing.Point(58, 89);
            this.GreyImage.Name = "GreyImage";
            this.GreyImage.Size = new System.Drawing.Size(117, 39);
            this.GreyImage.TabIndex = 2;
            this.GreyImage.Text = "GreyImage";
            this.GreyImage.UseVisualStyleBackColor = true;
            this.GreyImage.Click += new System.EventHandler(this.GreyImage_Click);
            // 
            // Histogram
            // 
            this.Histogram.Location = new System.Drawing.Point(58, 161);
            this.Histogram.Name = "Histogram";
            this.Histogram.Size = new System.Drawing.Size(117, 37);
            this.Histogram.TabIndex = 3;
            this.Histogram.Text = "Histogram";
            this.Histogram.UseVisualStyleBackColor = true;
            this.Histogram.Click += new System.EventHandler(this.Histogram_Click);
            // 
            // Brightness
            // 
            this.Brightness.Location = new System.Drawing.Point(58, 282);
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(117, 41);
            this.Brightness.TabIndex = 4;
            this.Brightness.Text = "Brightness";
            this.Brightness.UseVisualStyleBackColor = true;
            this.Brightness.Click += new System.EventHandler(this.Brightness_Click);
            // 
            // Gamma
            // 
            this.Gamma.Location = new System.Drawing.Point(58, 368);
            this.Gamma.Name = "Gamma";
            this.Gamma.Size = new System.Drawing.Size(117, 37);
            this.Gamma.TabIndex = 5;
            this.Gamma.Text = "Gamma";
            this.Gamma.UseVisualStyleBackColor = true;
            this.Gamma.Click += new System.EventHandler(this.Gamma_Click);
            // 
            // Resize
            // 
            this.Resize.Location = new System.Drawing.Point(218, 12);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(117, 49);
            this.Resize.TabIndex = 6;
            this.Resize.Text = "Resize";
            this.Resize.UseVisualStyleBackColor = true;
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // Rotate
            // 
            this.Rotate.Location = new System.Drawing.Point(218, 89);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(114, 41);
            this.Rotate.TabIndex = 7;
            this.Rotate.Text = "Rotate";
            this.Rotate.UseVisualStyleBackColor = true;
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // BlendingImage
            // 
            this.BlendingImage.Location = new System.Drawing.Point(218, 159);
            this.BlendingImage.Name = "BlendingImage";
            this.BlendingImage.Size = new System.Drawing.Size(114, 39);
            this.BlendingImage.TabIndex = 8;
            this.BlendingImage.Text = "BlendingImage";
            this.BlendingImage.UseVisualStyleBackColor = true;
            this.BlendingImage.Click += new System.EventHandler(this.BlendingImage_Click);
            // 
            // ChangeColorSpace
            // 
            this.ChangeColorSpace.Location = new System.Drawing.Point(218, 222);
            this.ChangeColorSpace.Name = "ChangeColorSpace";
            this.ChangeColorSpace.Size = new System.Drawing.Size(114, 37);
            this.ChangeColorSpace.TabIndex = 9;
            this.ChangeColorSpace.Text = "ChangeColorSpace";
            this.ChangeColorSpace.UseVisualStyleBackColor = true;
            this.ChangeColorSpace.Click += new System.EventHandler(this.ChangeColorSpace_Click);
            // 
            // VideoCapture
            // 
            this.VideoCapture.Location = new System.Drawing.Point(215, 282);
            this.VideoCapture.Name = "VideoCapture";
            this.VideoCapture.Size = new System.Drawing.Size(114, 34);
            this.VideoCapture.TabIndex = 10;
            this.VideoCapture.Text = "VideoCapture";
            this.VideoCapture.UseVisualStyleBackColor = true;
            this.VideoCapture.Click += new System.EventHandler(this.VideoCapture_Click);
            // 
            // WritingToVideo
            // 
            this.WritingToVideo.Location = new System.Drawing.Point(215, 348);
            this.WritingToVideo.Name = "WritingToVideo";
            this.WritingToVideo.Size = new System.Drawing.Size(114, 41);
            this.WritingToVideo.TabIndex = 11;
            this.WritingToVideo.Text = "WritingToVideo";
            this.WritingToVideo.UseVisualStyleBackColor = true;
            this.WritingToVideo.Click += new System.EventHandler(this.WritingToVideo_Click);
            // 
            // alpha_textBox
            // 
            this.alpha_textBox.Location = new System.Drawing.Point(58, 213);
            this.alpha_textBox.Name = "alpha_textBox";
            this.alpha_textBox.Size = new System.Drawing.Size(117, 20);
            this.alpha_textBox.TabIndex = 12;
            // 
            // beta_textBox
            // 
            this.beta_textBox.Location = new System.Drawing.Point(58, 239);
            this.beta_textBox.Name = "beta_textBox";
            this.beta_textBox.Size = new System.Drawing.Size(117, 20);
            this.beta_textBox.TabIndex = 13;
            // 
            // gamma_textBox
            // 
            this.gamma_textBox.Location = new System.Drawing.Point(58, 332);
            this.gamma_textBox.Name = "gamma_textBox";
            this.gamma_textBox.Size = new System.Drawing.Size(117, 20);
            this.gamma_textBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "alpha=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "beta=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "gamma=";
            // 
            // BackgroundSubs
            // 
            this.BackgroundSubs.Location = new System.Drawing.Point(215, 406);
            this.BackgroundSubs.Name = "BackgroundSubs";
            this.BackgroundSubs.Size = new System.Drawing.Size(114, 46);
            this.BackgroundSubs.TabIndex = 18;
            this.BackgroundSubs.Text = "BackgroundSubstraction";
            this.BackgroundSubs.UseVisualStyleBackColor = true;
            this.BackgroundSubs.Click += new System.EventHandler(this.BackgroundSubstraction);
            // 
            // reddFilter
            // 
            this.reddFilter.Location = new System.Drawing.Point(58, 429);
            this.reddFilter.Name = "reddFilter";
            this.reddFilter.Size = new System.Drawing.Size(117, 42);
            this.reddFilter.TabIndex = 19;
            this.reddFilter.Text = "redFilter";
            this.reddFilter.UseVisualStyleBackColor = true;
            this.reddFilter.Click += new System.EventHandler(this.RedFilter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 539);
            this.Controls.Add(this.reddFilter);
            this.Controls.Add(this.BackgroundSubs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamma_textBox);
            this.Controls.Add(this.beta_textBox);
            this.Controls.Add(this.alpha_textBox);
            this.Controls.Add(this.WritingToVideo);
            this.Controls.Add(this.VideoCapture);
            this.Controls.Add(this.ChangeColorSpace);
            this.Controls.Add(this.BlendingImage);
            this.Controls.Add(this.Rotate);
            this.Controls.Add(this.Resize);
            this.Controls.Add(this.Gamma);
            this.Controls.Add(this.Brightness);
            this.Controls.Add(this.Histogram);
            this.Controls.Add(this.GreyImage);
            this.Controls.Add(this.LoadImage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoadImage;
        private System.Windows.Forms.Button GreyImage;
        private System.Windows.Forms.Button Histogram;
        private System.Windows.Forms.Button Brightness;
        private System.Windows.Forms.Button Gamma;
        private System.Windows.Forms.Button Resize;
        private System.Windows.Forms.Button Rotate;
        private System.Windows.Forms.Button BlendingImage;
        private System.Windows.Forms.Button ChangeColorSpace;
        private System.Windows.Forms.Button VideoCapture;
        private System.Windows.Forms.Button WritingToVideo;
        private System.Windows.Forms.TextBox alpha_textBox;
        private System.Windows.Forms.TextBox beta_textBox;
        private System.Windows.Forms.TextBox gamma_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackgroundSubs;
        private System.Windows.Forms.Button reddFilter;
        //private System.Windows.Forms.Button RedFilter;
        //private System.Windows.Forms.Button BackgroundSubstraction;
    }
}

