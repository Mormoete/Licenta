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
    public partial class Produs : Form
    {
        public Produs()
        {
            InitializeComponent();
        }
      
        private bool Dacaexistaprodus()
        {
            return true;
        }
        public void cauta()
        {     
              SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Stoc;Integrated Security=True");

                SqlDataAdapter sda = new SqlDataAdapter("select * from  Produs where Numeprodus like '" + textBox3.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["Codprodus"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["Numeprodus"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["Cantitate"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["Dataexpirare"].ToString();


                if ((bool)item["Statusprodus"])
                    {
                        dataGridView1.Rows[n].Cells[4].Value = "Activ";
                    }
                    else
                    {
                        dataGridView1.Rows[n].Cells[4].Value = "Inactiv";
                    }
              
                textBox3.Clear();
            }
        }

        private void Produs_Load(object sender, EventArgs e)
        {
          

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Stoc;Integrated Security=True");
            //inserare
            con.Open();

            bool status = false;
            if (comboBox1.SelectedIndex == 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Produs]
           ([Numeprodus]
           ,[Cantitate]
           ,[Statusprodus])
     VALUES
           ('" + textBox2.Text + "','"+textBox4.Text+"','"
           + status + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            //Afiseaza datele

            cauta();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Stoc;Integrated Security=True");
            dataGridView1.Rows.Clear();
            con.Open();

          
            
                SqlCommand cmd = new SqlCommand(@"delete from Produs where CodProdus='" + textBox1.Text + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                cauta();
            


        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();


            if (dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "Active")
            {
                comboBox1.SelectedIndex = 1;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Stoc;Integrated Security=True");
            dataGridView1.Rows.Clear();
            bool status = false;
            if (comboBox1.SelectedIndex == 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand(@"update produs set  Numeprodus='" + textBox2.Text + "',Statusprodus='" + status + "', Cantitate='" + textBox4.Text + "' where CodProdus='" + textBox1.Text + "'", con);

            
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter("select * from  Produs where Numeprodus like '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["Codprodus"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Numeprodus"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Cantitate"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Dataexpirare"].ToString();


                if ((bool)item["Statusprodus"])
                {
                    dataGridView1.Rows[n].Cells[4].Value = "Activ";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[4].Value = "Inactiv";
                }
            }
            con.Close();





        }

        

        private void TextBox3_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode ==Keys.Enter)
            {
                cauta();
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            cauta();
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
        }

        
    }
}
