namespace WindowsFormsApp_QuaySo
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
            this.label1 = new System.Windows.Forms.Label();
            this.picSo2 = new System.Windows.Forms.PictureBox();
            this.picSo3 = new System.Windows.Forms.PictureBox();
            this.picSo1 = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btPlay = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSo1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "2251052119-Trần Thị Thuong";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSo2
            // 
            this.picSo2.Location = new System.Drawing.Point(311, 116);
            this.picSo2.Name = "picSo2";
            this.picSo2.Size = new System.Drawing.Size(157, 152);
            this.picSo2.TabIndex = 1;
            this.picSo2.TabStop = false;
            // 
            // picSo3
            // 
            this.picSo3.Location = new System.Drawing.Point(536, 116);
            this.picSo3.Name = "picSo3";
            this.picSo3.Size = new System.Drawing.Size(157, 152);
            this.picSo3.TabIndex = 1;
            this.picSo3.TabStop = false;
            // 
            // picSo1
            // 
            this.picSo1.Location = new System.Drawing.Point(97, 116);
            this.picSo1.Name = "picSo1";
            this.picSo1.Size = new System.Drawing.Size(157, 152);
            this.picSo1.TabIndex = 1;
            this.picSo1.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(314, 306);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(144, 50);
            this.lblResult.TabIndex = 2;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btPlay.Location = new System.Drawing.Point(188, 390);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(148, 48);
            this.btPlay.TabIndex = 3;
            this.btPlay.Text = "Quay Số";
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btClose.Location = new System.Drawing.Point(426, 390);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(148, 48);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.picSo3);
            this.Controls.Add(this.picSo1);
            this.Controls.Add(this.picSo2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picSo2;
        private System.Windows.Forms.PictureBox picSo3;
        private System.Windows.Forms.PictureBox picSo1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btClose;
    }
}

