namespace PhotoAlbum
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
            this.treeFolder = new System.Windows.Forms.TreeView();
            this.picView = new System.Windows.Forms.PictureBox();
            this.pnThum = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            this.SuspendLayout();
            // 
            // treeFolder
            // 
            this.treeFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeFolder.ImageIndex = 0;
            this.treeFolder.ImageList = this.imageList1;
            this.treeFolder.Location = new System.Drawing.Point(7, 7);
            this.treeFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeFolder.Name = "treeFolder";
            this.treeFolder.SelectedImageIndex = 0;
            this.treeFolder.Size = new System.Drawing.Size(174, 403);
            this.treeFolder.TabIndex = 0;
            this.treeFolder.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeFolder_BeforeCollapse);
            this.treeFolder.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeFolder_BeforeExpand);
            this.treeFolder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeFolder_AfterSelect);
            // 
            // picView
            // 
            this.picView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picView.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.picView.Location = new System.Drawing.Point(191, 7);
            this.picView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(475, 288);
            this.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picView.TabIndex = 1;
            this.picView.TabStop = false;
            // 
            // pnThum
            // 
            this.pnThum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnThum.BackColor = System.Drawing.Color.MistyRose;
            this.pnThum.Location = new System.Drawing.Point(191, 309);
            this.pnThum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnThum.Name = "pnThum";
            this.pnThum.Size = new System.Drawing.Size(475, 99);
            this.pnThum.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folderClose.png");
            this.imageList1.Images.SetKeyName(1, "folderExpand.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 419);
            this.Controls.Add(this.pnThum);
            this.Controls.Add(this.picView);
            this.Controls.Add(this.treeFolder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "PhotoAlbum";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeFolder;
        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.FlowLayoutPanel pnThum;
        private System.Windows.Forms.ImageList imageList1;
    }
}

