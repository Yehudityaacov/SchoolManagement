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
    public partial class A_allocateNumSeatsToCourse_DH : Form
    {
        public static A_allocateNumSeatsToCourse_DH CURRENTA_allocateNumSeatsToCourse_DH;
        HeadDepartment dep;

        public HeadDepartment passValue
        {
            get { return dep; }
            set { dep = value; }
        }

        public A_allocateNumSeatsToCourse_DH(HeadDepartment hd)
        {
            InitializeComponent();
          //  this.dep = new HeadDepartment();
            this.dep = hd;
        }

        private void button_BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_DepartmentHead dep = new A_DepartmentHead();
            A_DepartmentHead.currentA_DepartmentHead.Show(); 
            
        }

        private void button_SUBMIT_Click(object sender, EventArgs e)
        {
            //// new changes - 10.06.17
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;

            bool courseExist = false;
            bool allocateNotExist = false;
            bool validAmount = false;


            //check if any field is empty
            if (String.IsNullOrEmpty(textBox_courseID.Text) || String.IsNullOrEmpty(textBox_seatsAmount.Text))
            {
                MessageBox.Show("All fields REQIRED! please try again");
                textBox_courseID.Clear();
                this.Close();
                this.Hide();
                //A_allocateNumSeatsToCourse_DH all = new A_allocateNumSeatsToCourse_DH();
                A_allocateNumSeatsToCourse_DH.CURRENTA_allocateNumSeatsToCourse_DH.Show(); 
            }

            cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            cn.Open();

            cmd = new SqlCommand("SELECT IDcourse,Name,seatsAmount FROM Courses ", cn);

            List<string> courseName = new List<string>();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["IDcourse"].ToString() == textBox_courseID.Text)
                {
                    courseExist = true;
                    courseName.Add(dr["Name"].ToString()); //in order to get course name
                    if (String.IsNullOrEmpty(dr["seatsAmount"].ToString()))
                        allocateNotExist = true;
                }

            }
            dr.Close();
            cn.Close();

            if (courseExist && allocateNotExist)
            {
                int wantedAmount = Int32.Parse(textBox_seatsAmount.Text);

                if (wantedAmount >= 20 && wantedAmount <= 400) //check amount is truely valid(between 20-400)
                    validAmount = true;

                if (validAmount)
                {
                    cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
                    cn.Open();

                    cmd = new SqlCommand("UPDATE Courses SET seatsAmount = @seatsAmount WHERE IDcourse = @IDcourse ", cn);
                    cmd.Parameters.AddWithValue("@seatsAmount", textBox_seatsAmount.Text);
                    cmd.Parameters.AddWithValue("@IDcourse", textBox_courseID.Text);
                    cmd.ExecuteNonQuery();

                    cn.Close();

                    MessageBox.Show("*** allocation of students capacity for this course went SUCCESSFULLY! ***");

                    this.Hide();
                    //A_DepartmentHead dep = new A_DepartmentHead();
                    A_DepartmentHead.currentA_DepartmentHead.Show(); 
                }
                else
                {
                    //amount is not valid!!!
                    MessageBox.Show("Sorry, the amount of seats is NOT valid! should be between 20 - 400");
                    textBox_courseID.Clear();
                    textBox_seatsAmount.Clear();


                    MessageBox.Show("*** add allocation of students amount has FAILED! ***");
                }
            }




            else
            {
                //in this case - no need to add allocation capacity
                if (!courseExist)
                {
                    MessageBox.Show("Sorry, this course does not exist");
                    textBox_courseID.Clear();
                    textBox_seatsAmount.Clear();
                }
                else if (!allocateNotExist)//if there is already allocation for this course
                {
                    MessageBox.Show("Sorry, there is already amount allocation of students for this course");
                    textBox_courseID.Clear();
                    textBox_seatsAmount.Clear();

                }
                //else if (!validAmount)//if amount of students is NOT valid
                //{
                //    MessageBox.Show("Sorry, the amount of seats is NOT valid! should be between 20 - 400");
                //    textBox_courseID.Clear();
                //    textBox_seatsAmount.Clear();
                //}

                MessageBox.Show("*** add allocation of students amount has FAILED! ***");

            }






            //SqlConnection cn;
            //SqlCommand cmd;
            //SqlDataReader dr;

            //bool courseExist = false;
            //bool allocateNotExist = false;
            //bool validAmount = false;


            //check if any field is empty
            //if (String.IsNullOrEmpty(textBox_courseID.Text) || String.IsNullOrEmpty(textBox_seatsAmount.Text))
            //{
            //    MessageBox.Show("All fields REQIRED! please try again");

            //    this.Hide();
            //    A_allocateNumSeatsToCourse_DH all = new A_allocateNumSeatsToCourse_DH();
            //    A_allocateNumSeatsToCourse_DH all = new A_allocateNumSeatsToCourse_DH(this.dep);
            //    all.ShowDialog();
            //}

            //cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            //cn.Open();

            //cmd = new SqlCommand("SELECT IDcourse,Name,seatsAmount FROM Courses ", cn);

            //List<string> courseName = new List<string>();
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    if (dr["IDcourse"].ToString() == textBox_courseID.Text)
            //    {
            //        courseExist = true;
            //        courseName.Add(dr["Name"].ToString()); //in order to get course name
            //        if (String.IsNullOrEmpty(dr["seatsAmount"].ToString()))
            //            allocateNotExist = true;
            //    }

            //}
            //dr.Close();
            //cn.Close();

            //int wantedAmount = Int32.Parse(textBox_seatsAmount.Text);
            //add in here
            //check if good
            //Course course = new Course(Int32.Parse(textBox_courseID.Text), courseName[0]);

            //if (course.validCapacity(wantedAmount))
            //    validAmount = true;

            //course.validCapacity(wantedAmount);


            //if (wantedAmount >= 20 && wantedAmount <= 400) //check amount is truely valid(between 20-400)
            //    validAmount = true;

            //if (courseExist && allocateNotExist && validAmount)
            //{
            //    in this case -need to add allocation capacity of students for this course

            //   cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            //   cn.Open();

            //   cmd = new SqlCommand("UPDATE Courses SET seatsAmount = @seatsAmount WHERE IDcourse = @IDcourse ", cn);
            //    cmd.Parameters.AddWithValue("@seatsAmount", textBox_seatsAmount.Text);
            //    cmd.Parameters.AddWithValue("@IDcourse", textBox_courseID.Text);
            //    cmd.ExecuteNonQuery();

            //    cn.Close();

            //    MessageBox.Show("*** allocation of students capacity for this course went SUCCESSFULLY! ***");

            //    this.Hide();
            //    A_DepartmentHead dep = new A_DepartmentHead();
            //    A_DepartmentHead dep = new A_DepartmentHead(this.dep);
            //    dep.ShowDialog();

            //}
            //else
            //{
            //    in this case -no need to add allocation capacity
            //    if (!courseExist)
            //    {
            //        MessageBox.Show("Sorry, this course does not exist");
            //        textBox_courseID.Clear();
            //        textBox_seatsAmount.Clear();
            //    }
            //    else if (!allocateNotExist)//if there is already allocation for this course
            //    {
            //        MessageBox.Show("Sorry, there is already amount allocation of students for this course");
            //        textBox_courseID.Clear();
            //        textBox_seatsAmount.Clear();

            //    }
            //    else if (!validAmount)//if amount of students is NOT valid
            //    {
            //        MessageBox.Show("Sorry, the amount of seats is NOT valid! should be between 20 - 400");
            //        textBox_courseID.Clear();
            //        textBox_seatsAmount.Clear();
            //    }

            //    MessageBox.Show("*** add allocation of students amount has FAILED! ***");

            //}


        }

        private void A_allocateNumSeatsToCourse_DH_Load(object sender, EventArgs e)
        {
            CURRENTA_allocateNumSeatsToCourse_DH = this;
        }
    }
}
