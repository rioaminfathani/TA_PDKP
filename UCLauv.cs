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
    public partial class UCLauv : UserControl
    {
        public UCLauv()
        {
            InitializeComponent();
        }

        private void btnPesan2_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCBayarLauv"))
            {
                UCBayarLauv un = new UCBayarLauv();
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UCBayarLauv"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }
    }
}
