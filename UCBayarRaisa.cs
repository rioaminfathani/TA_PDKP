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
    public partial class UCBayarRaisa : UserControl
    {
        public UCBayarRaisa()
        {
            InitializeComponent();
        }

        public static string Jenis2;
        public static string Nama;
        public static string Email;
        public static long Nomor;
        public static int Jumlah;
        public static string Metode2;

        UCCheckout3 c = new UCCheckout3();
        private void UCBayarRaisa_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Jenis2 = Jenis.Text;
            Nama = Nama2.Text;
            Email = Email2.Text;
            Nomor = long.Parse(Nomor2.Text);
            Jumlah = int.Parse(Jumlah2.Text);
            Metode2 = Metode.Text;
            
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCCheckout2"))
            {
                UCCheckout2 un = new UCCheckout2();
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UCCHeckout2"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }
    }
}
