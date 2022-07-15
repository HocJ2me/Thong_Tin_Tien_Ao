
namespace ThongTinTienAo
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCoinTop3 = new System.Windows.Forms.Label();
            this.lblCoinTop2 = new System.Windows.Forms.Label();
            this.lblCoinTop1 = new System.Windows.Forms.Label();
            this.lblTop3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrUpdateTop3 = new System.Windows.Forms.Timer(this.components);
            this.tbxNameCoin = new System.Windows.Forms.TextBox();
            this.g = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.btnDoThi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 240);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(865, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 414);
            this.panel3.TabIndex = 4;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(925, 55);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(323, 181);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Tìm kiếm và hiển thị lịch sử giá các đồng tiền ảo trên thế giới";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(857, 233);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.lblCoinTop3);
            this.panel2.Controls.Add(this.lblCoinTop2);
            this.panel2.Controls.Add(this.lblCoinTop1);
            this.panel2.Controls.Add(this.lblTop3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(4, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 411);
            this.panel2.TabIndex = 3;
            // 
            // lblCoinTop3
            // 
            this.lblCoinTop3.AutoSize = true;
            this.lblCoinTop3.Location = new System.Drawing.Point(573, 335);
            this.lblCoinTop3.Name = "lblCoinTop3";
            this.lblCoinTop3.Size = new System.Drawing.Size(46, 17);
            this.lblCoinTop3.TabIndex = 4;
            this.lblCoinTop3.Text = "label3";
            // 
            // lblCoinTop2
            // 
            this.lblCoinTop2.AutoSize = true;
            this.lblCoinTop2.Location = new System.Drawing.Point(573, 258);
            this.lblCoinTop2.Name = "lblCoinTop2";
            this.lblCoinTop2.Size = new System.Drawing.Size(46, 17);
            this.lblCoinTop2.TabIndex = 3;
            this.lblCoinTop2.Text = "label2";
            // 
            // lblCoinTop1
            // 
            this.lblCoinTop1.AutoSize = true;
            this.lblCoinTop1.Location = new System.Drawing.Point(573, 186);
            this.lblCoinTop1.Name = "lblCoinTop1";
            this.lblCoinTop1.Size = new System.Drawing.Size(46, 17);
            this.lblCoinTop1.TabIndex = 2;
            this.lblCoinTop1.Text = "label1";
            // 
            // lblTop3
            // 
            this.lblTop3.AutoSize = true;
            this.lblTop3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop3.Location = new System.Drawing.Point(27, 58);
            this.lblTop3.Name = "lblTop3";
            this.lblTop3.Size = new System.Drawing.Size(542, 36);
            this.lblTop3.TabIndex = 1;
            this.lblTop3.Text = "Top 3 đồng tiền ảo giao dịch nhiều nhất";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tmrUpdateTop3
            // 
            this.tmrUpdateTop3.Enabled = true;
            this.tmrUpdateTop3.Interval = 10000;
            this.tmrUpdateTop3.Tick += new System.EventHandler(this.tmrUpdateTop3_Tick);
            // 
            // tbxNameCoin
            // 
            this.tbxNameCoin.Location = new System.Drawing.Point(1056, 300);
            this.tbxNameCoin.Name = "tbxNameCoin";
            this.tbxNameCoin.Size = new System.Drawing.Size(170, 22);
            this.tbxNameCoin.TabIndex = 4;
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Location = new System.Drawing.Point(944, 303);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(96, 17);
            this.g.TabIndex = 5;
            this.g.Text = "Nhập tên coin";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(1014, 339);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(150, 51);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Location = new System.Drawing.Point(955, 469);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(136, 17);
            this.lblGiaTien.TabIndex = 7;
            this.lblGiaTien.Text = "Giá của đồng tiền: $";
            // 
            // btnDoThi
            // 
            this.btnDoThi.Location = new System.Drawing.Point(1003, 586);
            this.btnDoThi.Name = "btnDoThi";
            this.btnDoThi.Size = new System.Drawing.Size(185, 56);
            this.btnDoThi.TabIndex = 8;
            this.btnDoThi.Text = "Hiển thị đồ thị";
            this.btnDoThi.UseVisualStyleBackColor = true;
            this.btnDoThi.Click += new System.EventHandler(this.btnDoThi_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1315, 654);
            this.Controls.Add(this.btnDoThi);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.g);
            this.Controls.Add(this.tbxNameCoin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCoinTop3;
        private System.Windows.Forms.Label lblCoinTop2;
        private System.Windows.Forms.Label lblCoinTop1;
        private System.Windows.Forms.Label lblTop3;
        private System.Windows.Forms.Timer tmrUpdateTop3;
        private System.Windows.Forms.TextBox tbxNameCoin;
        private System.Windows.Forms.Label g;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDoThi;
    }
}

