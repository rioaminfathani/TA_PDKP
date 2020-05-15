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
    public partial class UCCheckout3 : UserControl
    {
        public UCCheckout3()
        {
            InitializeComponent();
        }

        private void UCCheckout3_Load(object sender, EventArgs e)
        {
            jenis3.Text = UCBayarLauv.Jenis;
            lblNama.Text = UCBayarLauv.Nama;
            lblJumlah.Text = Convert.ToString(UCBayarLauv.Jumlah) + "buah";
            lblNomor.Text = "+62" + Convert.ToString(UCBayarLauv.Nomor);
            lblSurel.Text = UCBayarLauv.Email;
            metode3.Text = UCBayarLauv.Metode;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCBerhasilWTF"))
            {
                UCBerhasilWTF un = new UCBerhasilWTF();
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UCBerhasilWTF"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }

        private void Total3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
