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
    public partial class A_addCourse_secretary : Form
    {
        public static A_addCourse_secretary currentA_addCourse_secretary;
        public A_addCourse_secretary()
        {
            InitializeComponent();
        }

        private void label_submit_Click(object sender, EventArgs e)
        {
            // new change 12/6

            //new changes 10.06.17
            bool flag = false;



            SqlCommand cmd;
            SqlConnection cn;
            SqlDataReader dr;
            string followNum;
            int parsedValue;


            //check fields are not empty
            if (String.IsNullOrEmpty(courseName_txt.Text) || String.IsNullOrEmpty(courseID_txt.Text) || String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("All fields REQIRED! please try again");
                this.courseName_txt.Clear();
                this.courseID_txt.Clear();
                this.textBox1.Clear();

                this.Hide();
                A_addCourse_secretary.currentA_addCourse_secretary.Show();
            }


            if (!int.TryParse(courseID_txt.Text, out parsedValue) || !int.TryParse(textBox1.Text, out parsedValue))
            {
                MessageBox.Show("Course ID & Department ID can NOT contain letters! numbers only!");
               
                this.courseName_txt.Clear();
                this.courseID_txt.Clear();
                this.textBox1.Clear();
                this.Hide();
                A_addCourse_secretary.currentA_addCourse_secretary.Show();
            }




            cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            cn.Open();

            cmd = new SqlCommand("SELECT Courses.IDcourse,Departments.IDdepartment FROM Courses,Departments ", cn);

            dr = cmd.ExecuteReader();



            while (dr.Read())
            {
                if (dr["IDcourse"].ToString() == courseID_txt.Text)
                {
                    MessageBox.Show("*** Course already exist in our database ***");
                    flag = false;
                    break;
                }

                if (dr["IDdepartment"].ToString() == textBox1.Text)
                {
                    flag = true;
                }
            }

            dr.Close();
            cn.Close();

            if (!flag)//in case department does not exist
            {
                MessageBox.Show("This department NOT registered in our database");
            }

            if (flag)
            {
                //in case need to be add new course to DB

                cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
                cn.Open();
                cmd = new SqlCommand("SELECT MAX (Num) FROM CoursesDepartment ", cn);
                dr = cmd.ExecuteReader();

                int index;
                int nextIndex = 0;

                while (dr.Read())
                {
                    //getting the last Num in table - in order to know to set next primary key

                    followNum = dr[0].ToString();

                    index = Int32.Parse(followNum) + 1;
                    nextIndex = index; //in order to get the number outside the loop


                }


                dr.Close();
                cn.Close();

                cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
                cn.Open();

                cmd = new SqlCommand("INSERT INTO Courses(IDcourse,Name,Credits) VALUES (@IDcourse, @Name, @Credits)", cn);
                cmd.Parameters.AddWithValue("@IDcourse", courseID_txt.Text);
                cmd.Parameters.AddWithValue("@Name", courseName_txt.Text);
                cmd.Parameters.AddWithValue("@Credits", 0); // start credits at 0
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();


                SqlCommand cmd1 = new SqlCommand("INSERT INTO CoursesDepartment(Num,IDcourse,IDdepartment) VALUES (@Num,@IDcourse, @IDdepartment)", cn);
                cmd1.Parameters.AddWithValue("@Num", nextIndex);
                cmd1.Parameters.AddWithValue("@IDcourse", courseID_txt.Text);
                cmd1.Parameters.AddWithValue("@IDdepartment", textBox1.Text);
                cmd1.ExecuteNonQuery();
                cmd1.Parameters.Clear();

                cn.Close();


                MessageBox.Show("*** New course [" + courseName_txt.Text + "] added succesfully to our database! ***");
                // in case of successfull
                this.Hide();
                add_MenuSecretary.currentadd_MenuSecretary.Show();

            }


            else
            {
                // in case NO need to add new course to DB
                MessageBox.Show("adding course operation FAILED! ");
                this.textBox1.Clear();
                this.courseID_txt.Clear();
                this.courseName_txt.Clear();
                this.Hide();
                add_MenuSecretary.currentadd_MenuSecretary.Show();


            }







            ////new changes 10.06.17
            //bool flag = false;



            //SqlCommand cmd;
            //SqlConnection cn;
            //SqlDataReader dr;
            //string followNum;
            //int parsedValue;


            ////check fields are not empty
            //if (String.IsNullOrEmpty(courseName_txt.Text) || String.IsNullOrEmpty(courseID_txt.Text) || String.IsNullOrEmpty(textBox1.Text))
            //{
            //    MessageBox.Show("All fields REQIRED! please try again");
            //    this.courseName_txt.Clear();
            //    this.courseID_txt.Clear();
            //    this.textBox1.Clear();

            //    this.Hide();
            //    A_addCourse_secretary.currentA_addCourse_secretary.Show();
            //}


            //if (!int.TryParse(courseID_txt.Text, out parsedValue) || !int.TryParse(textBox1.Text, out parsedValue))
            //{
            //    MessageBox.Show("Course ID & Department ID can NOT contain letters! numbers only!");
            //    this.Hide();
            //    A_addCourse_secretary.currentA_addCourse_secretary.Show();
            //}




            //cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            //cn.Open();

            //cmd = new SqlCommand("SELECT Courses.IDcourse,Departments.IDdepartment FROM Courses,Departments ", cn);

            //dr = cmd.ExecuteReader();



            //while (dr.Read())
            //{
            //    if (dr["IDcourse"].ToString() == courseID_txt.Text)
            //    {
            //        MessageBox.Show("*** Course already exist in our database ***");
            //        flag = false;
            //        break;
            //    }

            //    if (dr["IDdepartment"].ToString() == textBox1.Text)
            //    {
            //        flag = true;
            //    }
            //}

            //dr.Close();
            //cn.Close();

            //if (!flag)//in case department does not exist
            //{
            //    MessageBox.Show("This department NOT registered in our database");
            //}

            //if (flag)
            //{
            //    //in case need to be add new course to DB

            //    cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            //    cn.Open();
            //    cmd = new SqlCommand("SELECT MAX (Num) FROM CoursesDepartment ", cn);
            //    dr = cmd.ExecuteReader();

            //    int index;
            //    int nextIndex = 0;

            //    while (dr.Read())
            //    {
            //        //getting the last Num in table - in order to know to set next primary key

            //        followNum = dr[0].ToString();

            //        index = Int32.Parse(followNum) + 1;
            //        nextIndex = index; //in order to get the number outside the loop


            //    }


            //    dr.Close();
            //    cn.Close();

            //    cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            //    cn.Open();

            //    cmd = new SqlCommand("INSERT INTO Courses(IDcourse,Name,Credits) VALUES (@IDcourse, @Name, @Credits)", cn);
            //    cmd.Parameters.AddWithValue("@IDcourse", courseID_txt.Text);
            //    cmd.Parameters.AddWithValue("@Name", courseName_txt.Text);
            //    cmd.Parameters.AddWithValue("@Credits", 0); // start credits at 0
            //    cmd.ExecuteNonQuery();

            //    cmd.Parameters.Clear();


            //    SqlCommand cmd1 = new SqlCommand("INSERT INTO CoursesDepartment(Num,IDcourse,IDdepartment) VALUES (@Num,@IDcourse, @IDdepartment)", cn);
            //    cmd1.Parameters.AddWithValue("@Num", nextIndex);
            //    cmd1.Parameters.AddWithValue("@IDcourse", courseID_txt.Text);
            //    cmd1.Parameters.AddWithValue("@IDdepartment", textBox1.Text);
            //    cmd1.ExecuteNonQuery();
            //    cmd1.Parameters.Clear();

            //    cn.Close();


            //    MessageBox.Show("*** New course [" + courseName_txt.Text + "] added succesfully to our database! ***");
            //    // in case of successfull
            //    this.Hide();
            //    add_MenuSecretary.currentadd_MenuSecretary.Show();

            //}


            //else
            //{
            //    // in case NO need to add new course to DB
            //    MessageBox.Show("adding course operation FAILED! ");
            //    this.textBox1.Clear();
            //    this.courseID_txt.Clear();
            //    this.courseName_txt.Clear();
            //    this.Hide();
            //    add_MenuSecretary.currentadd_MenuSecretary.Show();


            //}

















            //bool flag = false;



            //SqlCommand cmd;
            //SqlConnection cn;
            //SqlDataReader dr;
            //string followNum;


            ////check fields are not empty
            //if (String.IsNullOrEmpty(courseName_txt.Text) || String.IsNullOrEmpty(courseID_txt.Text) || String.IsNullOrEmpty(textBox1.Text))
            //{
            //    MessageBox.Show("All fields REQIRED! please try again");
            //    this.courseName_txt.Clear();
            //    this.courseID_txt.Clear();
            //    this.textBox1.Clear();

            //    this.Hide();
            //    A_addCourse_secretary addCourse = new A_addCourse_secretary();
            //    addCourse.ShowDialog();
            //}



            //cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            //cn.Open();

            //cmd = new SqlCommand("SELECT Courses.IDcourse,Departments.IDdepartment FROM Courses,Departments ", cn);

            //dr = cmd.ExecuteReader();



            //while (dr.Read())
            //{
            //    if (dr["IDcourse"].ToString() == courseID_txt.Text)
            //    {
            //        MessageBox.Show("*** Course already exist in our database ***");
            //        flag = false;
            //        break;
            //    }

            //    if (dr["IDdepartment"].ToString() == textBox1.Text)
            //    {
            //        flag = true;
            //    }
            //}

            //dr.Close();
            //cn.Close();

            //if (!flag)//in case department does not exist
            //{
            //    MessageBox.Show("This department NOT registered in our database");
            //}

            //if (flag)
            //{
            //    //in case need to be add new course to DB

            //    cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            //    cn.Open();
            //    cmd = new SqlCommand("SELECT MAX (Num) FROM CoursesDepartment ", cn);
            //    dr = cmd.ExecuteReader();

            //    int index;
            //    int nextIndex = 0;

            //    while (dr.Read())
            //    {
            //        //getting the last Num in table - in order to know to set next primary key

            //        followNum = dr[0].ToString();

            //        index = Int32.Parse(followNum) + 1;
            //        nextIndex = index; //in order to get the number outside the loop


            //    }


            //    dr.Close();
            //    cn.Close();

            //    cn = new SqlConnection ("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            //    cn.Open();

            //    cmd = new SqlCommand ("INSERT INTO Courses(IDcourse,Name,Credits) VALUES (@IDcourse, @Name, @Credits)", cn);
            //    cmd.Parameters.AddWithValue("@IDcourse", courseID_txt.Text);
            //    cmd.Parameters.AddWithValue("@Name", courseName_txt.Text);
            //    cmd.Parameters.AddWithValue("@Credits", 0); // start credits at 0
            //    cmd.ExecuteNonQuery();

            //    cmd.Parameters.Clear();


            //    SqlCommand cmd1 = new SqlCommand("INSERT INTO CoursesDepartment(Num,IDcourse,IDdepartment) VALUES (@Num,@IDcourse, @IDdepartment)", cn);
            //    cmd1.Parameters.AddWithValue("@Num", nextIndex);
            //    cmd1.Parameters.AddWithValue("@IDcourse", courseID_txt.Text);
            //    cmd1.Parameters.AddWithValue("@IDdepartment", textBox1.Text);
            //    cmd1.ExecuteNonQuery();
            //    cmd1.Parameters.Clear();

            //    cn.Close();


            //    MessageBox.Show("*** New course [" + courseName_txt.Text + "] added succesfully to our database! ***");
            //    // in case of successfull
            //    this.Hide();
            //    add_MenuSecretary addSec = new add_MenuSecretary();
            //    addSec.ShowDialog();

            //}


            //else
            //{
            //    // in case NO need to add new course to DB
            //    MessageBox.Show("adding course operation FAILED! ");
            //    this.textBox1.Clear();
            //    this.courseID_txt.Clear();
            //    this.courseName_txt.Clear();
            //    this.Hide();
            //    add_MenuSecretary addSec = new add_MenuSecretary();
            //    addSec.ShowDialog();


            //}





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_MenuSecretary.currentadd_MenuSecretary.Show();
        }

        private void A_addCourse_secretary_Load(object sender, EventArgs e)
        {
            currentA_addCourse_secretary = this;
        }
    }
}
