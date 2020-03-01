using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stoc
{
    public partial class StocPrincipal : Form
    {
       

        public StocPrincipal()
        {

            InitializeComponent();
           
        }

        private void StocPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StocPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produs pro = new Produs();
            pro.MdiParent = this;
            pro.Show();
        }

       
    }
}
