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
    public partial class A_AverageGradesInCoursses_HD : Form
    {
        public static A_AverageGradesInCoursses_HD currentA_AverageGradesInCoursses_HD;
        SqlConnection cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");



        SqlCommand cmd1;
        SqlCommand cmd;
        SqlDataReader dr1;
        double everage;
        int grade = 0;
        HeadDepartment dep;

        public HeadDepartment passValue
        {
            get { return dep; }
            set { dep = value; }
        }

        public A_AverageGradesInCoursses_HD(HeadDepartment hd)
        {
            InitializeComponent();
            //this.dep = new HeadDepartment();
            this.dep = hd;
        }

        private void A_changeListVacant_OccupiedClasses_sec_Load(object sender, EventArgs e)
        {
            currentA_AverageGradesInCoursses_HD = this;
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            display();
        }

        public void display()
        {
            //cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Courses.IDcourse , Courses.Name from  Courses";
            cmd.ExecuteNonQuery();
            DataTable datt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(datt);
            dataGridView1desplyclasses.DataSource = datt;

        }


        private void dataGridView1desplyclasses_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        { }
        private void button1LoadChert_Click(object sender, EventArgs e)
        {

            int i = 0, j = 0;
            cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");



            cn.Open();
            cmd1 = cn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select IDcourse, Avg(grade)  from studentsGrades group by IDcourse ,grade";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            int count = 0;
           

                for(i=0;i<dt1.Rows.Count;i++)
            {
                this.chart1.Series["Average "].Points.AddXY(dt1.Rows[i]["IDcourse"].ToString(), Convert.ToInt32(dt1.Rows[i]["column1"]));

            }




            //foreach (DataRow dr1 in dt1.Rows)
            //    {
            //       string avg =dr1["column1"].ToString();
            //       // this.chart1.Series["Average "].XValueMember = dr1["IDcourse"].ToString();
            //        //this.chart1.Series["Average "].YValueMembers = avg;
                    
            //       //// if (dr["IDcourse"].ToString() != null && dr["IDcourse"].ToString() != null && dr["grade"].ToString() != null)
            //       // {
            //        this.chart1.Series["Average "].Points.AddXY(dt1.Select(dr1["IDcourse"].ToString()), Convert.ToInt32(avg));

            //        ///}
            //    }
               
            }
        

        private void button1_BACK_Click(object sender, EventArgs e)
        {
            this.Hide();

            //A_DHview  x = new A_DHview();
            A_DHview.currentA_DHview.Show();
            
        }
    }


}






