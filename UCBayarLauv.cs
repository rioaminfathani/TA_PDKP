using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_DKP_2020
{
    public partial class UCBayarLauv : UserControl
    {
        public UCBayarLauv()
        {
            InitializeComponent();
        }

        public static string Jenis;
        public static string Nama;
        public static string Email;
        public static long Nomor;
        public static int Jumlah;
        public static string Metode;

        UCCheckout3 c = new UCCheckout3();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Jenis = Jenis3.Text;
            Nama = Nama3.Text;
            Email = Email3.Text;
            Nomor = long.Parse(Nomor3.Text);
            Jumlah = int.Parse(Jumlah3.Text);
            Metode = Metode3.Text;

            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCCheckout3"))
            {
                UCCheckout3 un = new UCCheckout3();
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UCCHeckout3"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }

        private void Jenis3_DropDown(object sender, EventArgs e)
        {
            
        }
    }
}
