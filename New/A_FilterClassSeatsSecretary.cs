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

namespace New
{
    public partial class A_FilterClassSeatsSecretary : Form
    {
        public static A_FilterClassSeatsSecretary currentA_FilterClassSeatsSecretary;
        public A_FilterClassSeatsSecretary()
        {
            InitializeComponent();
            Fillcombo();
        }

        void Fillcombo()
        {
            string constring = "Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017";
            string Query = "select * from Classes";
            SqlConnection cn = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, cn);
            SqlDataReader dr;

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string cName = dr["Seats"].ToString();
                    cmb_numberSeats.Items.Add(cName);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void cmb_numberSeats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void A_FilterClassSeatsSecretary_Load(object sender, EventArgs e)
        {
            currentA_FilterClassSeatsSecretary = this;
        }

        DataTable data;

        private void button1_choose_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017";
            string Query = "select * from Classes where Seats = '"+ cmb_numberSeats.Text+"' ;";
            SqlConnection cn = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, cn);
            SqlDataReader dr;

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string cName = dr["Seats"].ToString();
                    //cmb_numberSeats.Items.Add(cName);
                    //string cName = dr.GetString("seats");

                }
                cn.Close();
                dr.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            

            data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);   // fill the new data table

            dataGridView1.DataSource = data;



        }

        private void button1_seeall_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "SELECT * FROM Classes";

            data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);   // fill the new data table

            dataGridView1.DataSource = data;

        }

        private void button_bcktpp_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_displayMenuSecretary.CurrentA_displayMenuSecretary.Show();
        }
    }
}
