﻿namespace WindowsFormsApp_SimplePaint
{
    partial class FrmDrawMouse
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
            this.SuspendLayout();
            // 
            // FrmDrawMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.DoubleBuffered = true;
            this.Name = "FrmDrawMouse";
            this.Text = "FrmDrawMouse";
            this.Load += new System.EventHandler(this.FrmDrawMouse_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmDrawMouse_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmDrawMouse_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmDrawMouse_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}