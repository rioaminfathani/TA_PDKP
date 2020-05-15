using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace TA_DKP_2020
{
    public partial class UCBayarWTF : UserControl
    {
        public UCBayarWTF()
        {
            InitializeComponent();
        }

        public static string Jenis1;
        public static string Nama;
        public static string Email;
        public static long Nomor;
        public static int Jumlah;
        public static string Metode1;

        UCCheckout c = new UCCheckout();
        private void Nama1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Telpon1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Email1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Jumlah1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Jenis1 = JTiket1.Text;           
            Nama = Nama1.Text;
            Email = Email1.Text;
            Nomor = long.Parse(Telpon1.Text);
            Jumlah = int.Parse(Jumlah1.Text);
            Metode1 = Bayar1.Text;

            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCCheckout"))
            {
                UCCheckout un = new UCCheckout();
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UCCHeckout"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }

        private void Bayar1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void JTiket1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
