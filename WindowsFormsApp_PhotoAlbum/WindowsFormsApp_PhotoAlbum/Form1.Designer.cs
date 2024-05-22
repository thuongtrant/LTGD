namespace WindowsFormsApp_PhotoAlbum
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
            this.treeFolder = new System.Windows.Forms.TreeView();
            this.picView = new System.Windows.Forms.PictureBox();
            this.pnThum = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            this.SuspendLayout();
            // 
            // treeFolder
            // 
            this.treeFolder.Location = new System.Drawing.Point(10, 11);
            this.treeFolder.Name = "treeFolder";
            this.treeFolder.Size = new System.Drawing.Size(317, 643);
            this.treeFolder.TabIndex = 0;
            this.treeFolder.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeFolder_BeforeExpand);
            this.treeFolder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeFolder_AfterSelect);
            // 
            // picView
            // 
            this.picView.BackColor = System.Drawing.Color.MistyRose;
            this.picView.Location = new System.Drawing.Point(343, 16);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(601, 416);
            this.picView.TabIndex = 1;
            this.picView.TabStop = false;
            // 
            // pnThum
            // 
            this.pnThum.BackColor = System.Drawing.Color.LightBlue;
            this.pnThum.Location = new System.Drawing.Point(343, 438);
            this.pnThum.Name = "pnThum";
            this.pnThum.Size = new System.Drawing.Size(601, 216);
            this.pnThum.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 678);
            this.Controls.Add(this.pnThum);
            this.Controls.Add(this.picView);
            this.Controls.Add(this.treeFolder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeFolder;
        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.Panel pnThum;
    }
}

