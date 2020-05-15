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
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!Form1.Instance.PnlContainer.Controls.ContainsKey("UCNext"))
            {
                UCNext un = new UCNext();
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UCNext"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //WTF
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCWtf"))
            {
                UCWtf un = new UCWtf();
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UCWtf"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e) //Lauv
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCLauv"))
            {
                UCLauv un = new UCLauv();
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UCLauv"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
