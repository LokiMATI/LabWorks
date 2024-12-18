namespace LabWork_34
{
    partial class TheWORLDOfCapibaraForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheWORLDOfCapibaraForm));
            Capibara = new PictureBox();
            Timer = new System.Windows.Forms.Timer(components);
            ImageList = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)Capibara).BeginInit();
            SuspendLayout();
            // 
            // Capibara
            // 
            Capibara.BackColor = Color.Transparent;
            Capibara.BackgroundImage = Properties.Resources.charlieTheCapybaraAnimationSheet__1_;
            Capibara.BackgroundImageLayout = ImageLayout.Zoom;
            Capibara.Location = new Point(604, 330);
            Capibara.Name = "Capibara";
            Capibara.Size = new Size(113, 108);
            Capibara.TabIndex = 0;
            Capibara.TabStop = false;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Tick += Timer_Tick;
            // 
            // ImageList
            // 
            ImageList.ColorDepth = ColorDepth.Depth32Bit;
            ImageList.ImageStream = (ImageListStreamer)resources.GetObject("ImageList.ImageStream");
            ImageList.TransparentColor = Color.Transparent;
            ImageList.Images.SetKeyName(0, "charlieTheCapybaraAnimationSheet (1).png");
            ImageList.Images.SetKeyName(1, "charlieTheCapybaraAnimationSheet (2).png");
            ImageList.Images.SetKeyName(2, "charlieTheCapybaraAnimationSheet (3).png");
            ImageList.Images.SetKeyName(3, "charlieTheCapybaraAnimationSheet (4).png");
            ImageList.Images.SetKeyName(4, "charlieTheCapybaraAnimationSheet (5).png");
            ImageList.Images.SetKeyName(5, "charlieTheCapybaraAnimationSheet (6).png");
            ImageList.Images.SetKeyName(6, "charlieTheCapybaraAnimationSheet (7).png");
            ImageList.Images.SetKeyName(7, "charlieTheCapybaraAnimationSheet (8).png");
            // 
            // TheWORLDOfCapibaraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(Capibara);
            Name = "TheWORLDOfCapibaraForm";
            Text = "МИР Капибары";
            ((System.ComponentModel.ISupportInitialize)Capibara).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Capibara;
        private System.Windows.Forms.Timer Timer;
        private ImageList ImageList;
    }
}