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
    public partial class A_creditsForCourse_DH : Form
    {
        public static A_creditsForCourse_DH currentA_creditsForCourse_DH;
        HeadDepartment dep;

        public HeadDepartment passValue
        {
            get { return dep; }
            set { dep = value; }
        }

        public A_creditsForCourse_DH(HeadDepartment hd)
        {
            InitializeComponent();
            //this.dep = new HeadDepartment();
            this.dep = hd;
        }

        private void button_SUBMIT_Click(object sender, EventArgs e)
        {
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;

            bool courseExist = false;
            bool validCredits = false;
            bool noCredits = false;



            //check if any of the fields is empty
            if (String.IsNullOrEmpty(textBox_courseID.Text) || String.IsNullOrEmpty(textBox_credits.Text))
            {
                MessageBox.Show("All fields REQIRED! please try again");


                this.Hide();
                //A_creditsForCourse_DH credit = new A_creditsForCourse_DH();
                A_creditsForCourse_DH.currentA_creditsForCourse_DH.Show(); 
            }


            cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            cn.Open();


            cmd = new SqlCommand("SELECT IDcourse,Credits FROM Courses ", cn);

            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                if (dr["IDcourse"].ToString() == textBox_courseID.Text)
                {
                    courseExist = true;
                    if(dr["Credits"].ToString() == "0" || dr["Credits"].ToString() == null)
                    {
                        noCredits = true;
                        break;
                    }

                }
            }
            dr.Close();
            cn.Close();

            int creditsAmount = Int32.Parse(textBox_credits.Text);
            if (creditsAmount >= 1 && creditsAmount <= 8)
                validCredits = true;

            if (courseExist && noCredits && validCredits)
            {
                //in this case we need to edit this course's credits
                cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
                cn.Open();

                

                cmd = new SqlCommand("UPDATE Courses SET Credits =@Credits WHERE IDcourse = @IDcourse", cn);
                cmd.Parameters.AddWithValue("@Credits", textBox_credits.Text);
                cmd.Parameters.AddWithValue("@IDcourse", textBox_courseID.Text);
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show(" *** Set credits for course went SUCCESFULLY! *** ");

                this.Hide();
                //A_DepartmentHead dh = new A_DepartmentHead();
                A_DepartmentHead.currentA_DepartmentHead.Show();




            }
            else
            {
                //in this case - something is wrong and we dont need to change course credits

                if (!courseExist) // means that course does not exist
                {
                    MessageBox.Show("Sorry,this course does not exists");
                    textBox_courseID.Clear();
                    textBox_credits.Clear();

                }
                if(!noCredits)//means that it is already has credits
                {
                    MessageBox.Show("Sorry,this course already has credits");
                    textBox_courseID.Clear();
                    textBox_credits.Clear();

                }
                if(!validCredits)//means that credits value is not valid (should be between 1 to 8)
                {
                    MessageBox.Show("Sorry,amount of credits is not VALID! must be between 1-8 amount of credits");
                    textBox_courseID.Clear();
                    textBox_credits.Clear();
                }

                MessageBox.Show(" *** Set credits for course FAILED! ***");
                


            }




        }

        private void button_BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_DepartmentHead dh = new A_DepartmentHead();
            A_DepartmentHead.currentA_DepartmentHead.Show(); 
        }

        private void A_creditsForCourse_DH_Load(object sender, EventArgs e)
        {
            currentA_creditsForCourse_DH = this;
        }
    }
}
