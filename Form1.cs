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
    public partial class Form1 : Form
    {
        static Form1 _obj;

        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;

            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public Button BackButton
        {
            get { return btnBack; }
            set { btnBack = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            string title = "Perhatian";
            string message = "Kepada pelanggan setia E-Tix yang terhormat, sehubungan adanya pandemi Covid-19, maka acara yang tersedia akan sangat sedikit.\nTerima Kasih atas Perhatiannya";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnBack.Visible = false;
            _obj = this;

            UCHome uc = new UCHome();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["UCHome"].BringToFront();
            btnBack.Visible = false;
        }
    }
}
