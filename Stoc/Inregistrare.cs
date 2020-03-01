using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stoc
{
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
        }

        public string st()
        {
            return textBox1.Text;
        }

        
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void Inregistrare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }
        }

        public void iast()
        {
            Inregistrare inr = new Inregistrare();
            string str1 = inr.st();
            MessageBox.Show(str1);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Stoc;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT Rol FROM Inregistrare where Nume = '"+textBox1.Text + "' and Parola = '"+textBox2.Text +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            if (dt.Rows.Count == 1)
                //verifica nume si parola
                
                {
                    this.Hide();
                    StocPrincipal prin = new StocPrincipal();
                
                    prin.Show();

                Produs prod = new Produs();
                prod.MdiParent = prin;
                prod.Show();
               
                }
            else
            {
               
                MessageBox.Show("Nume sau parola gresita","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
