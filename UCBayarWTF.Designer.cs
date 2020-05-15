namespace TA_DKP_2020
{
    partial class UCBayarWTF
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBayarWTF));
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Telpon1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Email1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Jumlah1 = new System.Windows.Forms.TextBox();
            this.Nama1 = new System.Windows.Forms.TextBox();
            this.Bayar1 = new System.Windows.Forms.ComboBox();
            this.JTiket1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(554, 530);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(117, 37);
            this.btnConfirm.TabIndex = 53;
            this.btnConfirm.Text = "Lanjutkan";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(527, 365);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "Nomor Telepon";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Telpon1
            // 
            this.Telpon1.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telpon1.Location = new System.Drawing.Point(532, 401);
            this.Telpon1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Telpon1.Name = "Telpon1";
            this.Telpon1.Size = new System.Drawing.Size(151, 29);
            this.Telpon1.TabIndex = 51;
            this.Telpon1.TextChanged += new System.EventHandler(this.Telpon1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(526, 287);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Alamat E-mail";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Email1
            // 
            this.Email1.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email1.Location = new System.Drawing.Point(531, 322);
            this.Email1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Email1.Name = "Email1";
            this.Email1.Size = new System.Drawing.Size(152, 29);
            this.Email1.TabIndex = 49;
            this.Email1.TextChanged += new System.EventHandler(this.Email1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(526, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Pilih Jenis Tiket";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(526, 444);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Pilih Metode Pembayaran";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(526, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Jumlah Tiket";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(526, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nama Pembeli";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Jumlah1
            // 
            this.Jumlah1.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jumlah1.Location = new System.Drawing.Point(531, 244);
            this.Jumlah1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Jumlah1.Name = "Jumlah1";
            this.Jumlah1.Size = new System.Drawing.Size(152, 29);
            this.Jumlah1.TabIndex = 44;
            this.Jumlah1.TextChanged += new System.EventHandler(this.Jumlah1_TextChanged);
            // 
            // Nama1
            // 
            this.Nama1.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama1.Location = new System.Drawing.Point(531, 165);
            this.Nama1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Nama1.Name = "Nama1";
            this.Nama1.Size = new System.Drawing.Size(152, 29);
            this.Nama1.TabIndex = 43;
            this.Nama1.TextChanged += new System.EventHandler(this.Nama1_TextChanged);
            // 
            // Bayar1
            // 
            this.Bayar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bayar1.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bayar1.FormattingEnabled = true;
            this.Bayar1.Items.AddRange(new object[] {
            "TRANSFER VIRTUAL ACCOUNT "});
            this.Bayar1.Location = new System.Drawing.Point(532, 480);
            this.Bayar1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Bayar1.Name = "Bayar1";
            this.Bayar1.Size = new System.Drawing.Size(229, 29);
            this.Bayar1.TabIndex = 42;
            this.Bayar1.SelectedIndexChanged += new System.EventHandler(this.Bayar1_SelectedIndexChanged);
            // 
            // JTiket1
            // 
            this.JTiket1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JTiket1.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTiket1.FormattingEnabled = true;
            this.JTiket1.Items.AddRange(new object[] {
            "GENERAL ADMISSION (3-DAY PASS) - Rp 1.550.00",
            "V.I.B (3-DAY PASS) - Rp 3.750.000",
            "GA - EARLY ENTRY (3-DAY PASS/ENTRY BEFORE 4 P.M.) - Rp 1.550.000",
            "GROUP PACKAGE (3-DAY PASS/6 TICKETS) - Rp 9.750.000",
            "",
            ""});
            this.JTiket1.Location = new System.Drawing.Point(532, 66);
            this.JTiket1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.JTiket1.Name = "JTiket1";
            this.JTiket1.Size = new System.Drawing.Size(229, 29);
            this.JTiket1.TabIndex = 41;
            this.JTiket1.SelectedIndexChanged += new System.EventHandler(this.JTiket1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(35, 152);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 247);
            this.panel1.TabIndex = 40;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UCBayarWTF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Telpon1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Email1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Jumlah1);
            this.Controls.Add(this.Nama1);
            this.Controls.Add(this.Bayar1);
            this.Controls.Add(this.JTiket1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCBayarWTF";
            this.Size = new System.Drawing.Size(790, 612);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Telpon1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Email1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Jumlah1;
        private System.Windows.Forms.TextBox Nama1;
        private System.Windows.Forms.ComboBox Bayar1;
        private System.Windows.Forms.ComboBox JTiket1;
        private System.Windows.Forms.Panel panel1;
    }
}
