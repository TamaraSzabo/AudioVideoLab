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
            this.play = new System.Windows.Forms.Button();
            this.mixAudioFiles = new System.Windows.Forms.Button();
            this.convertToMp3 = new System.Windows.Forms.Button();
            this.convertToWav = new System.Windows.Forms.Button();
            this.monoToStereo = new System.Windows.Forms.Button();
            this.stereoToMono = new System.Windows.Forms.Button();
            this.concatenateAudioFiles = new System.Windows.Forms.Button();
            this.resampler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(560, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(607, 383);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoadImage
            // 
            this.LoadImage.Location = new System.Drawing.Point(87, 25);
            this.LoadImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(176, 63);
            this.LoadImage.TabIndex = 1;
            this.LoadImage.Text = "LoadImg";
            this.LoadImage.UseVisualStyleBackColor = true;
            this.LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // GreyImage
            // 
            this.GreyImage.Location = new System.Drawing.Point(87, 137);
            this.GreyImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GreyImage.Name = "GreyImage";
            this.GreyImage.Size = new System.Drawing.Size(176, 60);
            this.GreyImage.TabIndex = 2;
            this.GreyImage.Text = "GreyImage";
            this.GreyImage.UseVisualStyleBackColor = true;
            this.GreyImage.Click += new System.EventHandler(this.GreyImage_Click);
            // 
            // Histogram
            // 
            this.Histogram.Location = new System.Drawing.Point(87, 248);
            this.Histogram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Histogram.Name = "Histogram";
            this.Histogram.Size = new System.Drawing.Size(176, 57);
            this.Histogram.TabIndex = 3;
            this.Histogram.Text = "Histogram";
            this.Histogram.UseVisualStyleBackColor = true;
            this.Histogram.Click += new System.EventHandler(this.Histogram_Click);
            // 
            // Brightness
            // 
            this.Brightness.Location = new System.Drawing.Point(87, 434);
            this.Brightness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(176, 63);
            this.Brightness.TabIndex = 4;
            this.Brightness.Text = "Brightness";
            this.Brightness.UseVisualStyleBackColor = true;
            this.Brightness.Click += new System.EventHandler(this.Brightness_Click);
            // 
            // Gamma
            // 
            this.Gamma.Location = new System.Drawing.Point(87, 566);
            this.Gamma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gamma.Name = "Gamma";
            this.Gamma.Size = new System.Drawing.Size(176, 57);
            this.Gamma.TabIndex = 5;
            this.Gamma.Text = "Gamma";
            this.Gamma.UseVisualStyleBackColor = true;
            this.Gamma.Click += new System.EventHandler(this.Gamma_Click);
            // 
            // Resize
            // 
            this.Resize.Location = new System.Drawing.Point(327, 18);
            this.Resize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(176, 75);
            this.Resize.TabIndex = 6;
            this.Resize.Text = "Resize";
            this.Resize.UseVisualStyleBackColor = true;
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // Rotate
            // 
            this.Rotate.Location = new System.Drawing.Point(327, 137);
            this.Rotate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(171, 63);
            this.Rotate.TabIndex = 7;
            this.Rotate.Text = "Rotate";
            this.Rotate.UseVisualStyleBackColor = true;
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // BlendingImage
            // 
            this.BlendingImage.Location = new System.Drawing.Point(327, 245);
            this.BlendingImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BlendingImage.Name = "BlendingImage";
            this.BlendingImage.Size = new System.Drawing.Size(171, 60);
            this.BlendingImage.TabIndex = 8;
            this.BlendingImage.Text = "BlendingImage";
            this.BlendingImage.UseVisualStyleBackColor = true;
            this.BlendingImage.Click += new System.EventHandler(this.BlendingImage_Click);
            // 
            // ChangeColorSpace
            // 
            this.ChangeColorSpace.Location = new System.Drawing.Point(327, 342);
            this.ChangeColorSpace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChangeColorSpace.Name = "ChangeColorSpace";
            this.ChangeColorSpace.Size = new System.Drawing.Size(171, 57);
            this.ChangeColorSpace.TabIndex = 9;
            this.ChangeColorSpace.Text = "ChangeColorSpace";
            this.ChangeColorSpace.UseVisualStyleBackColor = true;
            this.ChangeColorSpace.Click += new System.EventHandler(this.ChangeColorSpace_Click);
            // 
            // VideoCapture
            // 
            this.VideoCapture.Location = new System.Drawing.Point(322, 434);
            this.VideoCapture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VideoCapture.Name = "VideoCapture";
            this.VideoCapture.Size = new System.Drawing.Size(171, 52);
            this.VideoCapture.TabIndex = 10;
            this.VideoCapture.Text = "VideoCapture";
            this.VideoCapture.UseVisualStyleBackColor = true;
            this.VideoCapture.Click += new System.EventHandler(this.VideoCapture_Click);
            // 
            // WritingToVideo
            // 
            this.WritingToVideo.Location = new System.Drawing.Point(322, 535);
            this.WritingToVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WritingToVideo.Name = "WritingToVideo";
            this.WritingToVideo.Size = new System.Drawing.Size(171, 63);
            this.WritingToVideo.TabIndex = 11;
            this.WritingToVideo.Text = "WritingToVideo";
            this.WritingToVideo.UseVisualStyleBackColor = true;
            this.WritingToVideo.Click += new System.EventHandler(this.WritingToVideo_Click);
            // 
            // alpha_textBox
            // 
            this.alpha_textBox.Location = new System.Drawing.Point(87, 328);
            this.alpha_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.alpha_textBox.Name = "alpha_textBox";
            this.alpha_textBox.Size = new System.Drawing.Size(174, 26);
            this.alpha_textBox.TabIndex = 12;
            // 
            // beta_textBox
            // 
            this.beta_textBox.Location = new System.Drawing.Point(87, 368);
            this.beta_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.beta_textBox.Name = "beta_textBox";
            this.beta_textBox.Size = new System.Drawing.Size(174, 26);
            this.beta_textBox.TabIndex = 13;
            // 
            // gamma_textBox
            // 
            this.gamma_textBox.Location = new System.Drawing.Point(87, 511);
            this.gamma_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gamma_textBox.Name = "gamma_textBox";
            this.gamma_textBox.Size = new System.Drawing.Size(174, 26);
            this.gamma_textBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 332);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "alpha=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 372);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "beta=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 515);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "gamma=";
            // 
            // BackgroundSubs
            // 
            this.BackgroundSubs.Location = new System.Drawing.Point(322, 625);
            this.BackgroundSubs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackgroundSubs.Name = "BackgroundSubs";
            this.BackgroundSubs.Size = new System.Drawing.Size(171, 71);
            this.BackgroundSubs.TabIndex = 18;
            this.BackgroundSubs.Text = "BackgroundSubstraction";
            this.BackgroundSubs.UseVisualStyleBackColor = true;
            this.BackgroundSubs.Click += new System.EventHandler(this.BackgroundSubstraction);
            // 
            // reddFilter
            // 
            this.reddFilter.Location = new System.Drawing.Point(87, 660);
            this.reddFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reddFilter.Name = "reddFilter";
            this.reddFilter.Size = new System.Drawing.Size(176, 65);
            this.reddFilter.TabIndex = 19;
            this.reddFilter.Text = "redFilter";
            this.reddFilter.UseVisualStyleBackColor = true;
            this.reddFilter.Click += new System.EventHandler(this.RedFilter);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(591, 434);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(103, 44);
            this.play.TabIndex = 20;
            this.play.Text = "playAudio";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.btnPlayAudio);
            // 
            // mixAudioFiles
            // 
            this.mixAudioFiles.Location = new System.Drawing.Point(591, 515);
            this.mixAudioFiles.Name = "mixAudioFiles";
            this.mixAudioFiles.Size = new System.Drawing.Size(124, 44);
            this.mixAudioFiles.TabIndex = 21;
            this.mixAudioFiles.Text = "mixAudioFiles";
            this.mixAudioFiles.UseVisualStyleBackColor = true;
            this.mixAudioFiles.Click += new System.EventHandler(this.btnMixAudioFiles);
            // 
            // convertToMp3
            // 
            this.convertToMp3.Location = new System.Drawing.Point(591, 579);
            this.convertToMp3.Name = "convertToMp3";
            this.convertToMp3.Size = new System.Drawing.Size(124, 44);
            this.convertToMp3.TabIndex = 22;
            this.convertToMp3.Text = "convertToMp3";
            this.convertToMp3.UseVisualStyleBackColor = true;
            this.convertToMp3.Click += new System.EventHandler(this.btnConvertToMp3);
            // 
            // convertToWav
            // 
            this.convertToWav.Location = new System.Drawing.Point(829, 443);
            this.convertToWav.Name = "convertToWav";
            this.convertToWav.Size = new System.Drawing.Size(124, 44);
            this.convertToWav.TabIndex = 23;
            this.convertToWav.Text = "convertToWav";
            this.convertToWav.UseVisualStyleBackColor = true;
            this.convertToWav.Click += new System.EventHandler(this.btnConvertToWav);
            // 
            // monoToStereo
            // 
            this.monoToStereo.Location = new System.Drawing.Point(829, 515);
            this.monoToStereo.Name = "monoToStereo";
            this.monoToStereo.Size = new System.Drawing.Size(124, 44);
            this.monoToStereo.TabIndex = 24;
            this.monoToStereo.Text = "monoToStereo";
            this.monoToStereo.UseVisualStyleBackColor = true;
            this.monoToStereo.Click += new System.EventHandler(this.btnMonoToStereo);
            // 
            // stereoToMono
            // 
            this.stereoToMono.Location = new System.Drawing.Point(829, 591);
            this.stereoToMono.Name = "stereoToMono";
            this.stereoToMono.Size = new System.Drawing.Size(124, 44);
            this.stereoToMono.TabIndex = 25;
            this.stereoToMono.Text = "stereoToMono";
            this.stereoToMono.UseVisualStyleBackColor = true;
            this.stereoToMono.Click += new System.EventHandler(this.btnStereoToMono);
            // 
            // concatenateAudioFiles
            // 
            this.concatenateAudioFiles.Location = new System.Drawing.Point(1043, 443);
            this.concatenateAudioFiles.Name = "concatenateAudioFiles";
            this.concatenateAudioFiles.Size = new System.Drawing.Size(175, 44);
            this.concatenateAudioFiles.TabIndex = 26;
            this.concatenateAudioFiles.Text = "concatenateVideoFiles";
            this.concatenateAudioFiles.UseVisualStyleBackColor = true;
            this.concatenateAudioFiles.Click += new System.EventHandler(this.btnConcatenateAudioFiles);
            // 
            // resampler
            // 
            this.resampler.Location = new System.Drawing.Point(1034, 515);
            this.resampler.Name = "resampler";
            this.resampler.Size = new System.Drawing.Size(175, 44);
            this.resampler.TabIndex = 27;
            this.resampler.Text = "resampler";
            this.resampler.UseVisualStyleBackColor = true;
            this.resampler.Click += new System.EventHandler(this.btnResampler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 829);
            this.Controls.Add(this.resampler);
            this.Controls.Add(this.concatenateAudioFiles);
            this.Controls.Add(this.stereoToMono);
            this.Controls.Add(this.monoToStereo);
            this.Controls.Add(this.convertToWav);
            this.Controls.Add(this.convertToMp3);
            this.Controls.Add(this.mixAudioFiles);
            this.Controls.Add(this.play);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button PlayAudio;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button mixAudioFiles;
        private System.Windows.Forms.Button convertToMp3;
        private System.Windows.Forms.Button convertToWav;
        private System.Windows.Forms.Button monoToStereo;
        private System.Windows.Forms.Button stereoToMono;
        private System.Windows.Forms.Button concatenateAudioFiles;
        private System.Windows.Forms.Button resampler;
        // private System.Windows.Forms.Button Playback;
        //private System.Windows.Forms.Button RedFilter;
        //private System.Windows.Forms.Button BackgroundSubstraction;
    }
}

