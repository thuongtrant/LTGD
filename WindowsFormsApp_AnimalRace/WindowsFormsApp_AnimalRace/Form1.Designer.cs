namespace WindowsFormsApp_AnimalRace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picLion = new System.Windows.Forms.PictureBox();
            this.picDog = new System.Windows.Forms.PictureBox();
            this.picBird = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picLionRun = new System.Windows.Forms.PictureBox();
            this.picDogRun = new System.Windows.Forms.PictureBox();
            this.picBirdRun = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLionRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDogRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBirdRun)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "ANIMAL RACE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lion.png");
            this.imageList1.Images.SetKeyName(1, "dog-walking.png");
            this.imageList1.Images.SetKeyName(2, "angry-birds.png");
            // 
            // picLion
            // 
            this.picLion.ErrorImage = global::WindowsFormsApp_AnimalRace.Properties.Resources.lion1;
            this.picLion.Image = global::WindowsFormsApp_AnimalRace.Properties.Resources.lion;
            this.picLion.InitialImage = null;
            this.picLion.Location = new System.Drawing.Point(176, 80);
            this.picLion.Name = "picLion";
            this.picLion.Size = new System.Drawing.Size(105, 74);
            this.picLion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLion.TabIndex = 1;
            this.picLion.TabStop = false;
            // 
            // picDog
            // 
            this.picDog.ErrorImage = global::WindowsFormsApp_AnimalRace.Properties.Resources.lion1;
            this.picDog.Image = global::WindowsFormsApp_AnimalRace.Properties.Resources.dog_walking;
            this.picDog.InitialImage = null;
            this.picDog.Location = new System.Drawing.Point(348, 80);
            this.picDog.Name = "picDog";
            this.picDog.Size = new System.Drawing.Size(105, 74);
            this.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDog.TabIndex = 1;
            this.picDog.TabStop = false;
            // 
            // picBird
            // 
            this.picBird.ErrorImage = global::WindowsFormsApp_AnimalRace.Properties.Resources.lion1;
            this.picBird.Image = global::WindowsFormsApp_AnimalRace.Properties.Resources.angry_birds;
            this.picBird.InitialImage = null;
            this.picBird.Location = new System.Drawing.Point(520, 80);
            this.picBird.Name = "picBird";
            this.picBird.Size = new System.Drawing.Size(105, 74);
            this.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBird.TabIndex = 1;
            this.picBird.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.picBirdRun);
            this.panel1.Location = new System.Drawing.Point(0, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 84);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.picDogRun);
            this.panel2.Location = new System.Drawing.Point(0, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 84);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.picLionRun);
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 84);
            this.panel3.TabIndex = 5;
            // 
            // picLionRun
            // 
            this.picLionRun.ErrorImage = global::WindowsFormsApp_AnimalRace.Properties.Resources.lion1;
            this.picLionRun.Image = global::WindowsFormsApp_AnimalRace.Properties.Resources.lion;
            this.picLionRun.InitialImage = null;
            this.picLionRun.Location = new System.Drawing.Point(0, 5);
            this.picLionRun.Name = "picLionRun";
            this.picLionRun.Size = new System.Drawing.Size(105, 74);
            this.picLionRun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLionRun.TabIndex = 1;
            this.picLionRun.TabStop = false;
            // 
            // picDogRun
            // 
            this.picDogRun.ErrorImage = global::WindowsFormsApp_AnimalRace.Properties.Resources.lion1;
            this.picDogRun.Image = global::WindowsFormsApp_AnimalRace.Properties.Resources.dog_walking;
            this.picDogRun.InitialImage = null;
            this.picDogRun.Location = new System.Drawing.Point(0, 7);
            this.picDogRun.Name = "picDogRun";
            this.picDogRun.Size = new System.Drawing.Size(105, 74);
            this.picDogRun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDogRun.TabIndex = 1;
            this.picDogRun.TabStop = false;
            // 
            // picBirdRun
            // 
            this.picBirdRun.ErrorImage = global::WindowsFormsApp_AnimalRace.Properties.Resources.lion1;
            this.picBirdRun.Image = global::WindowsFormsApp_AnimalRace.Properties.Resources.angry_birds;
            this.picBirdRun.InitialImage = null;
            this.picBirdRun.Location = new System.Drawing.Point(0, 7);
            this.picBirdRun.Name = "picBirdRun";
            this.picBirdRun.Size = new System.Drawing.Size(105, 74);
            this.picBirdRun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBirdRun.TabIndex = 1;
            this.picBirdRun.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBird);
            this.Controls.Add(this.picDog);
            this.Controls.Add(this.picLion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLionRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDogRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBirdRun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picLion;
        private System.Windows.Forms.PictureBox picDog;
        private System.Windows.Forms.PictureBox picBird;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBirdRun;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picDogRun;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picLionRun;
    }
}

