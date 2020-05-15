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
    public partial class UCCheckout2 : UserControl
    {
        public UCCheckout2()
        {
            InitializeComponent();
        }

        private void UCCheckout2_Load(object sender, EventArgs e)
        {
            lblJenis2.Text = UCBayarRaisa.Jenis2;
            lblNama.Text = UCBayarRaisa.Nama;
            lblJumlah.Text = Convert.ToString(UCBayarRaisa.Jumlah)+" buah";
            lblNomor.Text = "+62"+Convert.ToString(UCBayarRaisa.Nomor);
            lblSurel.Text = UCBayarRaisa.Email;
            lblMetode2.Text = UCBayarRaisa.Metode2;
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
    }
}
