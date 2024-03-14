namespace WindowsFormsApp_XuLyChuoi
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtS3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChen = new System.Windows.Forms.Button();
            this.txtVtChen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLayChuoiCon = new System.Windows.Forms.Button();
            this.txtSoKiTu = new System.Windows.Forms.TextBox();
            this.txtVtTu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThayThe = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDao = new System.Windows.Forms.Button();
            this.btnChuanHoa = new System.Windows.Forms.Button();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH MINH HỌA XỬ LÝ CHUỖI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chuỗi s1:";
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(144, 82);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(319, 22);
            this.txtS1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chuỗi s2:";
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(144, 133);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(172, 22);
            this.txtS2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chuỗi s3:";
            // 
            // txtS3
            // 
            this.txtS3.Location = new System.Drawing.Point(458, 133);
            this.txtS3.Name = "txtS3";
            this.txtS3.Size = new System.Drawing.Size(141, 22);
            this.txtS3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChen);
            this.groupBox1.Controls.Add(this.txtVtChen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chèn chuỗi s2 vào s1";
            // 
            // btnChen
            // 
            this.btnChen.AutoSize = true;
            this.btnChen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChen.Location = new System.Drawing.Point(189, 36);
            this.btnChen.Name = "btnChen";
            this.btnChen.Size = new System.Drawing.Size(75, 28);
            this.btnChen.TabIndex = 2;
            this.btnChen.Text = "Chèn";
            this.btnChen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChen.UseVisualStyleBackColor = true;
            this.btnChen.Click += new System.EventHandler(this.btnChen_Click);
            // 
            // txtVtChen
            // 
            this.txtVtChen.Location = new System.Drawing.Point(111, 36);
            this.txtVtChen.Name = "txtVtChen";
            this.txtVtChen.Size = new System.Drawing.Size(46, 27);
            this.txtVtChen.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vị trí chèn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLayChuoiCon);
            this.groupBox2.Controls.Add(this.txtSoKiTu);
            this.groupBox2.Controls.Add(this.txtVtTu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 85);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lấy chuỗi con trong s1";
            // 
            // btnLayChuoiCon
            // 
            this.btnLayChuoiCon.AutoSize = true;
            this.btnLayChuoiCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayChuoiCon.Location = new System.Drawing.Point(299, 36);
            this.btnLayChuoiCon.Name = "btnLayChuoiCon";
            this.btnLayChuoiCon.Size = new System.Drawing.Size(110, 28);
            this.btnLayChuoiCon.TabIndex = 2;
            this.btnLayChuoiCon.Text = "Lấy chuỗi con";
            this.btnLayChuoiCon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLayChuoiCon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLayChuoiCon.UseVisualStyleBackColor = true;
            this.btnLayChuoiCon.Click += new System.EventHandler(this.btnLayChuoiCon_Click);
            // 
            // txtSoKiTu
            // 
            this.txtSoKiTu.Location = new System.Drawing.Point(233, 36);
            this.txtSoKiTu.Name = "txtSoKiTu";
            this.txtSoKiTu.Size = new System.Drawing.Size(46, 27);
            this.txtSoKiTu.TabIndex = 1;
            // 
            // txtVtTu
            // 
            this.txtVtTu.Location = new System.Drawing.Point(91, 36);
            this.txtVtTu.Name = "txtVtTu";
            this.txtVtTu.Size = new System.Drawing.Size(46, 27);
            this.txtVtTu.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số kí tự:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Từ vị trí:";
            // 
            // btnThayThe
            // 
            this.btnThayThe.AutoSize = true;
            this.btnThayThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayThe.Location = new System.Drawing.Point(458, 197);
            this.btnThayThe.Name = "btnThayThe";
            this.btnThayThe.Size = new System.Drawing.Size(150, 28);
            this.btnThayThe.TabIndex = 2;
            this.btnThayThe.Text = "Thay thế s2 bằng s3";
            this.btnThayThe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThayThe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThayThe.UseVisualStyleBackColor = true;
            this.btnThayThe.Click += new System.EventHandler(this.btnThayThe_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(458, 254);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 28);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa s2 trong s1";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDao
            // 
            this.btnDao.AutoSize = true;
            this.btnDao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDao.Location = new System.Drawing.Point(658, 197);
            this.btnDao.Name = "btnDao";
            this.btnDao.Size = new System.Drawing.Size(130, 28);
            this.btnDao.TabIndex = 2;
            this.btnDao.Text = "Đảo từ trong s1";
            this.btnDao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDao.UseVisualStyleBackColor = true;
            this.btnDao.Click += new System.EventHandler(this.btnDao_Click);
            // 
            // btnChuanHoa
            // 
            this.btnChuanHoa.AutoSize = true;
            this.btnChuanHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuanHoa.Location = new System.Drawing.Point(658, 254);
            this.btnChuanHoa.Name = "btnChuanHoa";
            this.btnChuanHoa.Size = new System.Drawing.Size(130, 28);
            this.btnChuanHoa.TabIndex = 2;
            this.btnChuanHoa.Text = "Chuẩn hóa chuỗi";
            this.btnChuanHoa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChuanHoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChuanHoa.UseVisualStyleBackColor = true;
            this.btnChuanHoa.Click += new System.EventHandler(this.btnChuanHoa_Click);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.AutoSize = true;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.Location = new System.Drawing.Point(583, 307);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(110, 28);
            this.btnKhoiPhuc.TabIndex = 2;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKhoiPhuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.btnChuanHoa);
            this.Controls.Add(this.btnDao);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThayThe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtS3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Xử lí chuỗi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtS3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChen;
        private System.Windows.Forms.TextBox txtVtChen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLayChuoiCon;
        private System.Windows.Forms.TextBox txtSoKiTu;
        private System.Windows.Forms.TextBox txtVtTu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThayThe;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDao;
        private System.Windows.Forms.Button btnChuanHoa;
        private System.Windows.Forms.Button btnKhoiPhuc;
    }
}

