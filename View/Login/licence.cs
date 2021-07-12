using GestionDeLocationVoiture.Control.Classes;
using GestionDeLocationVoiture.Control.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeLocationVoiture.View.Login
{
    public partial class licence : Form
    {
        IUser u;
        public licence()
        {
            InitializeComponent();
            u = new user();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                u.InsertSerial(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Invalide Serial");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
