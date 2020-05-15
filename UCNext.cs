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
    public partial class UCNext : UserControl
    {
        public UCNext()
        {
            InitializeComponent();
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCBayarRaisa"))
            {
                UCBayarRaisa un = new UCBayarRaisa();
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UCBayarRaisa"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }
    }
}
