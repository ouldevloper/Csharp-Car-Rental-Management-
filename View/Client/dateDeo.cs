using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeLocationVoiture.View.Client
{
    public partial class dateDeo : Form
    {
        public bool isok = false;
        public dateDeo()
        {
            InitializeComponent();
        }

        private void dateDeo_Load(object sender, EventArgs e)
        {
            dtstart.Value = DateTime.Today;
            dtend.Value = DateTime.Today.AddDays(1);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (dtstart.Value.Day < DateTime.Today.Day && dtend.Value.Day < DateTime.Today.AddDays(1).Day)
            {
                MessageBox.Show("Cant do this");
                return;
            }
            else
            {
                isok = true;
                this.Close();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            isok = false;
            this.Close();
        }
    }
}
