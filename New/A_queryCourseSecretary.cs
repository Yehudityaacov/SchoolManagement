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
    public partial class A_queryCourseSecretary : Form
    {
        public static A_queryCourseSecretary currantA_queryCourseSecretary;
        DataTable data;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
        Course c = new Course();
        public A_queryCourseSecretary()
        {
            InitializeComponent();
            FillCombo();
        }

        // to fill comboBox1 in the courses
        public void FillCombo()
        {
            //this.c.setCourseName(comboBox1.Text);
            try
            {
                string Query = "select Name,IDcourse from Courses  ;";
                cmd = new SqlCommand(Query, cn);
                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // to show the comboBox2 - list of lecturer
                    //this.c.SetCourseID(Int32.Parse(dr["IDcourse"].ToString()));
                    this.c.setCourseName(dr["Name"].ToString());
                    this.comboBox1.Items.Add(this.c.getCourseName());
                }
                cn.Close();
                dr.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
       

        private void A_queryCourseSecretary_Load(object sender, EventArgs e)
        {
            currantA_queryCourseSecretary = this;
        }
       
        private void button1_search_Click(object sender, EventArgs e)
        {
            //to clear the data grid
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();

            this.c.setCourseName(comboBox1.Text);

            try
            {
                cn.Open();
                cmd = new SqlCommand("select * from Courses where Name ='" + this.c.getCourseName() + "'", cn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.c.SetCourseID(Int32.Parse(dr["IDcourse"].ToString()));
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try
            {
                cn.Open();
                cmd = new SqlCommand("select C.Name, C.IDcourse,C.Credits,C.PreCondition from Courses C where Name ='" + this.c.getCourseName() + "'", cn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                dr.Close();
                cn.Close();

            } catch (Exception ex) { MessageBox.Show(ex.Message); }

            data = new DataTable();
                // for fill the table
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);   // fill the new data table
                // to show specific course with the detail that secretary choose
                DataView dv = new DataView(data);
                //dv.RowFilter = "IDcourse like '%" + courseID_text.Text + "%'";
                //dv.RowFilter = "Convert(IDcourse, 'System.String') LIKE '%" + courseID_text.Text + "%'";
                dataGridView1.DataSource = dv;

        }

        private void courseID_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Backtpp_Click(object sender, EventArgs e)
        {
            // Back to previous page
            Aqueries.currentAqueries.Show();//nead to chainge in evre form
            this.Hide();
          
        }

        private void seeAll_Click(object sender, EventArgs e)
        {
            //to clear the data grid
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();

            //SqlConnection con = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.CommandText = "SELECT C.Name, C.IDcourse,C.Credits,C.PreCondition FROM Courses C";

            //DataTable data = new DataTable();
            data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);   // fill the new data table

            dataGridView1.DataSource = data;
 

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
