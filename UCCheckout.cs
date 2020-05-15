using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Contracts;

namespace TA_DKP_2020
{
    public partial class UCCheckout : UserControl
    {
        public UCCheckout()
        {
            InitializeComponent();
        }
        

        private void UCCheckout_Load(object sender, EventArgs e)
        {
            lblJenis1.Text = UCBayarWTF.Jenis1;
            lblNama.Text = UCBayarWTF.Nama;
            lblJumlah.Text = Convert.ToString(UCBayarWTF.Jumlah)+" buah";
            lblNomor.Text = "+62"+Convert.ToString(UCBayarWTF.Nomor);
            lblSurel.Text = UCBayarWTF.Email;
            lblMetode1.Text = UCBayarWTF.Metode1;
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

        private void Total1_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
