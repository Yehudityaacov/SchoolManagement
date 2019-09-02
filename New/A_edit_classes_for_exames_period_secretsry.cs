using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace New
{
    public partial class A_edit_classes_for_exames_period_secretsry : Form
    {
        public static A_edit_classes_for_exames_period_secretsry currA_edit_classes_for_exames_period_secretsry;
        SqlConnection cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
        int selectedRowIndex;
        string numClass;
        SqlCommand cmd;
   //     SqlDataReader dr;



        public A_edit_classes_for_exames_period_secretsry()
        {
            InitializeComponent();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Classes ", cn);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_MenuSecretary.currentadd_MenuSecretary.Show(); 

        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

           
            row = dataGridView1.Rows[selectedRowIndex];

            
            bool flag = false;
            string vacant = Interaction.InputBox("Enter V if available:", "Change", row.Cells[2].Value.ToString(), -1, -1);
            // check input !!!
            if (vacant.Trim() == "V" || vacant.Trim() == "")
            {

                numClass = row.Cells[0].Value.ToString();
                row.Cells[2].Value = vacant;
                flag = true;
            }
               
            else
                MessageBox.Show("you can enter only V or leave it empty", "Attention: Not update");

            if (flag)
            {
                try
                {
                    string Query1 = "UPDATE Classes SET examsPeriod = 'V' WHERE NumClass='" + numClass + "'";
                    MessageBox.Show("numClass --> " + numClass);
                    cn.Open();
                    cmd = new SqlCommand(Query1, cn);
                    //dr = cmd.ExecuteReader();
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Insert the new changes", "Update changes");
                    //
                    cn.Close();
                    //dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Wrong details , you can to try again!", "Not update");

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }

        private void A_edit_classes_for_exames_period_secretsry_Load(object sender, EventArgs e)
        {
            currA_edit_classes_for_exames_period_secretsry = this;
        }
    }


}
