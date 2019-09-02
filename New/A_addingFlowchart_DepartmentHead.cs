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

    public partial class A_addingFlowchart_DepartmentHead : Form
    {
        public static A_addingFlowchart_DepartmentHead currentA_addingFlowchart_DepartmentHead;
         HeadDepartment dep;
        DataTable data;

        public HeadDepartment passValue
        {
            get { return dep; }

            set { dep = value; }
        }

        //private string str;
        public A_addingFlowchart_DepartmentHead(HeadDepartment hd)
        {
            InitializeComponent();
            this.dep = hd;
            //this.dep = new HeadDepartment();
            this.dep = hd;

            label_show.Text = this.dep.getdeparName();
            userName.Text = this.dep.getFirstName();
            lastname.Text = this.dep.getLastName();
            comboBox1.Items.Add("a");
            comboBox1.Items.Add("b");
            comboBox1.Items.Add("c");
            comboBox1.Items.Add("d");

}



        private void A_addingFlowchart_DepartmentHead_Load(object sender, EventArgs e)
        {
            currentA_addingFlowchart_DepartmentHead = this;
        }

        private void button1Ok_Click(object sender, EventArgs e)
        {
            

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_show_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_bcktpp_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_DHadd.currentA_DHadd.Show();
        }

        private void button1_ok_Click(object sender, EventArgs e)
        {
            Course course_details = new Course();
            course_details.setCourseName(textBox1_course.Text.ToString());
            course_details.setPreCourse(textBox1_pre.Text.ToString());
            course_details.setBlockCourse(textBox1_block.Text.ToString());
            if (textBoxCredits.Text.ToString() != null && textBoxCredits.Text.ToString() !="")
            {
                float number = float.Parse(textBoxCredits.Text.ToString());   // convert string to int
                course_details.setCredits(number);
            }

            
            string year = comboBox1.Text.ToString();

            string constring = "Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017";
            string Query = "select num,CourseName from Asyllabus ";
            SqlConnection cn = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, cn);
            SqlDataReader dr;

            string num1;
            int numVal = 0;
            bool flag = true;

            // check for course name - that the user insert course name -> must to be!
            if (course_details.getCourseName() == null || course_details.getCourseName() == "")
            {
                MessageBox.Show("you must need to insert course name");
                flag = false;
                textBox1_course.Clear();
                textBox1_pre.Clear();
                textBox1_block.Clear();
                textBoxCredits.Clear();
            }
            // check that insert creidits - must to be!
            if (flag)
            {
                if (course_details.getCredits() <0 || course_details.getCredits() >7 || course_details.getCredits() == -1)
                {
                    MessageBox.Show("Credits course not in the limit you need to insert between 0-6");
                    flag = false;
                    //textBox1_course.Clear();
                    textBox1_pre.Clear();
                    textBox1_block.Clear();
                    textBoxCredits.Clear();
                }
            }
            // check for duplicate names of course -> cannot to be!
            if (flag)
            {
                if (textBox1_course.Text.ToString() == textBox1_pre.Text.ToString() || textBox1_pre.Text.ToString() == textBox1_block.Text.ToString() || textBox1_block.Text.ToString() == textBox1_course.Text.ToString())
                {
                    if (textBox1_pre.Text.ToString() != "" || textBox1_block.Text.ToString() != "")
                    {
                        MessageBox.Show("You insert two courses with the same name!");
                        flag = false;
                        //textBox1_course.Clear();
                        textBox1_pre.Clear();
                        textBox1_block.Clear();
                        //textBoxCredits.Clear();
                    }
                }
            }
            // check that the main course that inserted not insert again!
            if (flag)
            {
                try
                {
                    cn.Open();
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        num1 = dr["num"].ToString();
                        numVal = Int32.Parse(num1);  // to convert string to int 
                        //string cName = dr.GetString("num");
                        string name = dr["CourseName"].ToString();
                        if (name == textBox1_course.Text.ToString())
                        {
                            MessageBox.Show("The course already exist!");
                            flag = false;
                            textBox1_course.Clear();
                            textBox1_pre.Clear();
                            textBox1_block.Clear();
                            //textBoxCredits.Clear();
                            break;
                        }

                    }
                    cn.Close();
                    dr.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
           

            if (flag )
            {
                numVal++;

                string Query1 = "insert into [Asyllabus] (num ,DepName , Year , CourseName , Precourse , Blockscourse , CreditCourseName) values ('" + numVal.ToString() + "' ,'" + this.dep.getdeparName() + "' , '" + year + "' , '" + course_details.getCourseName() + "' , '" + course_details.getPreName() + "' , '" + course_details.getBlockCourse() + "' , '"+ course_details.getCredits() +"')";
                cn.Open();
                cmd = new SqlCommand(Query1, cn);
                dr = cmd.ExecuteReader();
                MessageBox.Show("Insert");

                cn.Close();
                dr.Close();

                // clear text box           
                textBox1_course.Clear();
                textBox1_pre.Clear();
                textBox1_block.Clear();
                textBoxCredits.Clear();
            }

        }

        private void textBox1_course_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_pre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_block_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_see_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "SELECT DepName, Year, CourseName, Precourse, Blockscourse,CreditCourseName FROM Asyllabus WHERE DepName = '" + this.dep.getdeparName() + "'";

            //DataTable data = new DataTable();
            data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);   // fill the new data table

            dataGridView1.DataSource = data;

            textBox1_course.Clear();
            textBox1_pre.Clear();
            textBox1_block.Clear();
        }

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void lastname_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCredits_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
