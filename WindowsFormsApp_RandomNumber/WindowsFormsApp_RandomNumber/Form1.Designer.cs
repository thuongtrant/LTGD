namespace WindowsFormsApp_RandomNumber
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd11 = new System.Windows.Forms.RadioButton();
            this.btnQuaySo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(108, 33);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(125, 135);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(248, 33);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(125, 135);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "0";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(379, 33);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(125, 135);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox1.Controls.Add(this.rd11);
            this.groupBox1.Controls.Add(this.rd3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(131, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // rd3
            // 
            this.rd3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rd3.AutoSize = true;
            this.rd3.BackColor = System.Drawing.Color.Ivory;
            this.rd3.Checked = true;
            this.rd3.Location = new System.Drawing.Point(39, 48);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(81, 42);
            this.rd3.TabIndex = 0;
            this.rd3.TabStop = true;
            this.rd3.Text = "3-10";
            this.rd3.UseVisualStyleBackColor = false;
            // 
            // rd11
            // 
            this.rd11.Appearance = System.Windows.Forms.Appearance.Button;
            this.rd11.AutoSize = true;
            this.rd11.BackColor = System.Drawing.Color.Ivory;
            this.rd11.Location = new System.Drawing.Point(193, 48);
            this.rd11.Name = "rd11";
            this.rd11.Size = new System.Drawing.Size(97, 42);
            this.rd11.TabIndex = 0;
            this.rd11.Text = "11-18";
            this.rd11.UseVisualStyleBackColor = false;
            // 
            // btnQuaySo
            // 
            this.btnQuaySo.BackColor = System.Drawing.Color.Ivory;
            this.btnQuaySo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaySo.Location = new System.Drawing.Point(131, 332);
            this.btnQuaySo.Name = "btnQuaySo";
            this.btnQuaySo.Size = new System.Drawing.Size(131, 43);
            this.btnQuaySo.TabIndex = 2;
            this.btnQuaySo.Text = "Quay số";
            this.btnQuaySo.UseVisualStyleBackColor = false;
            this.btnQuaySo.Click += new System.EventHandler(this.btnQuaySo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Điểm";
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.Location = new System.Drawing.Point(451, 336);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(26, 39);
            this.lblDiem.TabIndex = 4;
            this.lblDiem.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(618, 458);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuaySo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Number Random";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd11;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.Button btnQuaySo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiem;
    }
}

