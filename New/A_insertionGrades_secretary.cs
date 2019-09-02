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
using System.Collections; //needed?

namespace New
{
    public partial class A_insertionGrades_secretary : Form
    {
        public static A_insertionGrades_secretary CURRENTA_insertionGrades_secretary;
        public A_insertionGrades_secretary()
        {
            InitializeComponent();
        }

        private void button_BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_insertForSecretary.CURRENTA_insertForSecretary.Show(); 
        }

        private void button_SUBMIT_Click(object sender, EventArgs e)
        {

            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            SqlDataAdapter da;

            bool userExist = false;
            bool userIsStudent = false;
            bool deptExist = false;
            bool courseExist = false;
            bool courseBelongDept = false;
            bool studentSignedCourse = false;
            bool studentBelongDept = false;
            bool graded = false;

            //check if any field is empty
            if (String.IsNullOrEmpty(textBox_studentID.Text) || String.IsNullOrEmpty(textBox_deptID.Text) || String.IsNullOrEmpty(textBox_courseID.Text))
            {
                MessageBox.Show("*** all fields required! ***");
                this.textBox_deptID.Clear();

                this.Hide();
                A_insertionGrades_secretary.CURRENTA_insertionGrades_secretary.Show(); 
               

            }



            cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            cn.Open();
            cmd = new SqlCommand("select Users.ID,Users.Type,Departments.IDdepartment,Courses.IDcourse FROM Users,Departments,Courses", cn);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["ID"].ToString() == textBox_studentID.Text)//check user exist & user is student
                {
                    userExist = true;
                    if (dr["Type"].ToString() == "1")
                        userIsStudent = true;
                }
                if (dr["IDdepartment"].ToString() == textBox_deptID.Text) //check department exist
                {
                    deptExist = true;
                }
                if (dr["IDcourse"].ToString() == textBox_courseID.Text)//check course exist
                {
                    courseExist = true;
                }

            }
            dr.Close();
            cn.Close();


            cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            cn.Open();
            cmd = new SqlCommand("select CoursesDepartment.*,UsersDepartment.* FROM CoursesDepartment,UsersDepartment", cn);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["IDdepartment"].ToString() == textBox_deptID.Text)//check if course belong to department
                {
                    if (dr["IDcourse"].ToString() == textBox_courseID.Text)
                        courseBelongDept = true;
                }
                if (dr["ID"].ToString() == textBox_studentID.Text)//check if student belong to department
                {
                    if (dr["IDdepartment"].ToString() == textBox_deptID.Text)
                        studentBelongDept = true;
                }


            }
            dr.Close();
            cn.Close();


            cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM StudentsCourses ", cn);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["ID"].ToString() == textBox_studentID.Text)
                {
                    if (dr["IDcourse"].ToString() == textBox_courseID.Text)
                    {
                        studentSignedCourse = true;
                        break;
                    }
                }
                
            }
            dr.Close();
            cn.Close();

            cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM studentsGrades ", cn);

            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                if(dr["ID"].ToString() == textBox_studentID.Text)
                {
                    if(dr["IDcourse"].ToString() == textBox_courseID.Text)
                    {
                        graded = true;
                        break;
                    }
                }



            }
            dr.Close();
            cn.Close();






            if (userExist && userIsStudent && deptExist && courseExist && courseBelongDept && studentBelongDept && studentSignedCourse && !graded)
            {
                //in this case - need to add student's grade

                cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
                cn.Open();

                int index;
                int nextIndex = 0;
                cmd = new SqlCommand("SELECT Num FROM studentsGrades ", cn);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //getting the last Num in table - in order to know to set next primary key

                    index = Int32.Parse(dr[0].ToString()) + 1;
                    nextIndex = index; //in order to get the number outside the loop

                }
                dr.Close();
                cn.Close();

                cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
                cn.Open();

                cmd = new SqlCommand("INSERT INTO studentsGrades VALUES (@Num,@ID,@IDdepartment,@IDcourse,@grade)", cn);
                cmd.Parameters.AddWithValue("@Num", nextIndex);
                cmd.Parameters.AddWithValue("@ID", textBox_studentID.Text);
                cmd.Parameters.AddWithValue("@IDdepartment", textBox_deptID.Text);
                cmd.Parameters.AddWithValue("@IDcourse", textBox_courseID.Text);
                cmd.Parameters.AddWithValue("@grade", numericUpDown_grade.Value);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cn.Close();

                MessageBox.Show(" *** insertion grades went SUCCESSFULLY! ***");

                cmd = new SqlCommand("select * FROM studentsGrades WHERE ID ='" +textBox_studentID.Text + "'", cn);
                DataTable data = new DataTable();

                da = new SqlDataAdapter(cmd);
                da.Fill(data);

                DataView dv = new DataView(data);
                dataGridView_grades.DataSource = dv;

               

               
                //this.Hide();
                //A_insertForSecretary insertSec = new A_insertForSecretary();
                //insertSec.ShowDialog();


            }
            else
            {
                //in this case -  no need to add student's grade
                if (!userExist)//user does not exist
                {
                    MessageBox.Show("Sorry, this user is NOT exist");
                    textBox_studentID.Clear();
                    textBox_deptID.Clear();
                    textBox_courseID.Clear();


                }
                else if (!userIsStudent)//user is not a student
                {
                    MessageBox.Show("Sorry, this user is NOT a student");
                    textBox_studentID.Clear();
                    textBox_deptID.Clear();
                    textBox_courseID.Clear();


                }
                else if (!deptExist)//department does not exist
                {
                    MessageBox.Show("Sorry, this department is NOT exist");
                    textBox_studentID.Clear();
                    textBox_deptID.Clear();
                    textBox_courseID.Clear();


                }
                else if (!courseExist)//course does not exist
                {
                    MessageBox.Show("Sorry, this course is NOT exist");
                    textBox_studentID.Clear();
                    textBox_deptID.Clear();
                    textBox_courseID.Clear();


                }
                else if (!courseBelongDept)//course does not belong to department
                {
                    MessageBox.Show("Sorry, this course is not belong to this department");
                    textBox_studentID.Clear();
                    textBox_deptID.Clear();
                    textBox_courseID.Clear();

                }
                else if (!studentBelongDept)//student does not belong to this department
                {
                    MessageBox.Show("Sorry, this student is not belong to this department");
                    textBox_studentID.Clear();
                    textBox_deptID.Clear();
                    textBox_courseID.Clear();

                }
                else if (!studentSignedCourse)//student is not signed up for this course
                {
                    MessageBox.Show("Sorry, this student is NOT signed up for this course");
                    textBox_studentID.Clear();
                    textBox_deptID.Clear();
                    textBox_courseID.Clear();

                }
                else if(graded)
                {
                    MessageBox.Show("Sorry, this student is already has grade in this course!");
                    textBox_studentID.Clear();
                    textBox_deptID.Clear();
                    textBox_courseID.Clear();


                }
                MessageBox.Show(" *** grades insertion was FAILED!!! ***");

            }
        }

        private void A_insertionGrades_secretary_Load(object sender, EventArgs e)
        {
            CURRENTA_insertionGrades_secretary = this;
        }
    }
}
