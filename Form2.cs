using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_DKP_2020
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string Nama;
        public static string Email;
        public static long Jumlah;
        public static long Nomor;

        private void Nama1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Nama = Nama1.Text;
            Email = Email1.Text;
            Jumlah = long.Parse(Jumlah1.Text);
            Nomor = long.Parse(Telpon1.Text);
        }
    }
}
