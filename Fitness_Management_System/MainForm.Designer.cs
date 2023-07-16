namespace Fitness_Management_System
{
    partial class MainForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LbDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LbToday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSale = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnStcok = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnMembership = new System.Windows.Forms.Button();
            this.btnPackage = new System.Windows.Forms.Button();
            this.btnTrainer = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LbDate
            // 
            this.LbDate.BackColor = System.Drawing.Color.Transparent;
            this.LbDate.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold);
            this.LbDate.ForeColor = System.Drawing.Color.Black;
            this.LbDate.Location = new System.Drawing.Point(1656, 9);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(48, 29);
            this.LbDate.TabIndex = 2;
            this.LbDate.Text = "Date";
            // 
            // LbToday
            // 
            this.LbToday.BackColor = System.Drawing.Color.Transparent;
            this.LbToday.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold);
            this.LbToday.ForeColor = System.Drawing.Color.Black;
            this.LbToday.Location = new System.Drawing.Point(1528, 9);
            this.LbToday.Name = "LbToday";
            this.LbToday.Size = new System.Drawing.Size(69, 29);
            this.LbToday.TabIndex = 1;
            this.LbToday.Text = "Today:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(370, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1553, 1010);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bohemian Soul", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "SENGVIXAY GYM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LbDate);
            this.panel1.Controls.Add(this.LbToday);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1940, 41);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1637, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "|";
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Black;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Noto Sans Lao UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::Fitness_Management_System.Properties.Resources.user;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(23, 823);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(330, 60);
            this.btnUser.TabIndex = 14;
            this.btnUser.Text = "ສະໝັກຜູ້ໃຊ້";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Black;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Black;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(-1, -8);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(1924, 53);
            this.guna2PictureBox2.TabIndex = 16;
            this.guna2PictureBox2.TabStop = false;
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.Black;
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Noto Sans Lao UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.Image = global::Fitness_Management_System.Properties.Resources.sell;
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(23, 747);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(330, 60);
            this.btnSale.TabIndex = 13;
            this.btnSale.Text = "ຂາຍສິນຄ້າ";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fitness_Management_System.Properties.Resources.sengvixay_gym_logo;
            this.pictureBox1.Location = new System.Drawing.Point(105, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Black;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Noto Sans Lao UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Image = global::Fitness_Management_System.Properties.Resources.purchase;
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.Location = new System.Drawing.Point(23, 670);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(330, 60);
            this.btnPurchase.TabIndex = 12;
            this.btnPurchase.Text = "ສັ່ງຊື້ສິນຄ້າ";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Black;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Noto Sans Lao UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Fitness_Management_System.Properties.Resources.Dashboard_logo1_removebg_preview;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(23, 240);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(330, 60);
            this.btnDashboard.TabIndex = 9;
            this.btnDashboard.Text = "ໜ້າຫຼັກ";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnStcok
            // 
            this.btnStcok.BackColor = System.Drawing.Color.Black;
            this.btnStcok.FlatAppearance.BorderSize = 0;
            this.btnStcok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnStcok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStcok.Font = new System.Drawing.Font("Noto Sans Lao UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnStcok.ForeColor = System.Drawing.Color.White;
            this.btnStcok.Image = global::Fitness_Management_System.Properties.Resources.stock;
            this.btnStcok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStcok.Location = new System.Drawing.Point(23, 440);
            this.btnStcok.Name = "btnStcok";
            this.btnStcok.Size = new System.Drawing.Size(330, 60);
            this.btnStcok.TabIndex = 11;
            this.btnStcok.Text = "ສະຕ໋ອກ";
            this.btnStcok.UseVisualStyleBackColor = false;
            this.btnStcok.Click += new System.EventHandler(this.btnDailymembers_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Black;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Noto Sans Lao UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Image = global::Fitness_Management_System.Properties.Resources.payment_logo_removebg_preview;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(23, 592);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(330, 60);
            this.btnPayment.TabIndex = 8;
            this.btnPayment.Text = "ຈ່າຍເງີນສໍາລັບສະມາຊິກ";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnMembership
            // 
            this.btnMembership.BackColor = System.Drawing.Color.Black;
            this.btnMembership.FlatAppearance.BorderSize = 0;
            this.btnMembership.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembership.Font = new System.Drawing.Font("Noto Sans Lao UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnMembership.ForeColor = System.Drawing.Color.White;
            this.btnMembership.Image = global::Fitness_Management_System.Properties.Resources.member_logo1_removebg_preview;
            this.btnMembership.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembership.Location = new System.Drawing.Point(23, 306);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Size = new System.Drawing.Size(330, 60);
            this.btnMembership.TabIndex = 5;
            this.btnMembership.Text = "ສະມາຊິກ";
            this.btnMembership.UseVisualStyleBackColor = false;
            this.btnMembership.Click += new System.EventHandler(this.btnMembership_Click);
            // 
            // btnPackage
            // 
            this.btnPackage.BackColor = System.Drawing.Color.Black;
            this.btnPackage.FlatAppearance.BorderSize = 0;
            this.btnPackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackage.Font = new System.Drawing.Font("Noto Sans Lao UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPackage.ForeColor = System.Drawing.Color.White;
            this.btnPackage.Image = global::Fitness_Management_System.Properties.Resources.package;
            this.btnPackage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPackage.Location = new System.Drawing.Point(23, 516);
            this.btnPackage.Name = "btnPackage";
            this.btnPackage.Size = new System.Drawing.Size(330, 60);
            this.btnPackage.TabIndex = 7;
            this.btnPackage.Text = "ແພັກເກັດ";
            this.btnPackage.UseVisualStyleBackColor = false;
            this.btnPackage.Click += new System.EventHandler(this.btnPackage_Click);
            // 
            // btnTrainer
            // 
            this.btnTrainer.BackColor = System.Drawing.Color.Black;
            this.btnTrainer.FlatAppearance.BorderSize = 0;
            this.btnTrainer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainer.Font = new System.Drawing.Font("Noto Sans Lao UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnTrainer.ForeColor = System.Drawing.Color.White;
            this.btnTrainer.Image = global::Fitness_Management_System.Properties.Resources.trainer_logo3_removebg_preview;
            this.btnTrainer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainer.Location = new System.Drawing.Point(23, 369);
            this.btnTrainer.Name = "btnTrainer";
            this.btnTrainer.Size = new System.Drawing.Size(330, 60);
            this.btnTrainer.TabIndex = 6;
            this.btnTrainer.Text = "ເທັນເນີ້";
            this.btnTrainer.UseVisualStyleBackColor = false;
            this.btnTrainer.Click += new System.EventHandler(this.btnTrainer_Click_1);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 25;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Black;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 198);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(352, 738);
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnStcok);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnMembership);
            this.Controls.Add(this.btnPackage);
            this.Controls.Add(this.btnTrainer);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LbDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel LbToday;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Button btnMembership;
        private System.Windows.Forms.Button btnTrainer;
        private System.Windows.Forms.Button btnPackage;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnStcok;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}