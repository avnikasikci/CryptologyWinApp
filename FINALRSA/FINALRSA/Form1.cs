using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALRSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void fill(UserControl uc)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;

        }
        private void btnSenerioWinFrom_Click(object sender, EventArgs e)
        {
            fill(new UCWinSenerioController());
        }
        //private void btnMesai_Click(object sender, EventArgs e)
        //{
        //    fill(new UCMesai());
        //}
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSenerio1_Click(object sender, EventArgs e)
        {
            fill(new UCESignatureSenerioController());
        }

        private void btnSenerioVigenere_Click(object sender, EventArgs e)
        {
            fill(new UCVigenereCipherController());

        }
    }
}
