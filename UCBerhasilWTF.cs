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
    public partial class UCBerhasilWTF : UserControl
    {
        public UCBerhasilWTF()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "QR CODE TIDAK AKAN AKTIF HINGGA PEMBAYARAN TELAH DILAKUKAN";
            MessageBox.Show(message);
            
        }
    }
}
