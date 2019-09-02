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
    public partial class A_addLecturer_DH : Form
    {
        public static A_addLecturer_DH currentA_addLecturer_DH;
        SqlConnection cn;
        SqlCommand cmd, cmd1;
        string followNum;
        int index;
        int nextIndex = 0;
        string depName;
        HeadDepartment dep;

        public HeadDepartment passValue
        {
            get { return dep; }

            set { dep = value; }
        }

        public A_addLecturer_DH(HeadDepartment hd)
        {
            InitializeComponent();
            this.dep = new HeadDepartment();
            this.dep = hd;
        }



        private void buttonBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_DHadd back = new A_DHadd();
            A_DHadd.currentA_DHadd.Show();
        }

        private void A_addLecturer_DH_Load(object sender, EventArgs e)
        {
            currentA_addLecturer_DH = this;

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            int flag = 0;
            int depFlag = 0;



            //check fields are not empty
            if (String.IsNullOrEmpty(LecturerID_txt.Text) ||
                String.IsNullOrEmpty(firstName_txtbox.Text) ||
                String.IsNullOrEmpty(lastName_txtbox.Text) ||
                String.IsNullOrEmpty(password_textBox.Text) ||
                String.IsNullOrEmpty(ID_Department_txtbox.Text))

            {
                MessageBox.Show("All fields REQIRED! please try again");
                this.LecturerID_txt.Clear();
                this.firstName_txtbox.Clear();
                this.lastName_txtbox.Clear();
                this.password_textBox.Clear();
                this.ID_Department_txtbox.Clear();


                this.Hide();
                //A_addLecturer_DH lec = new A_addLecturer_DH();
                A_addLecturer_DH.currentA_addLecturer_DH.Show();



                cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
                cn.Open();

                cmd = new SqlCommand("SELECT* FROM Departments", cn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() == ID_Department_txtbox.Text)
                    {
                        depName = dr[1].ToString();
                        depFlag++;
                        break;
                    }
                }
                dr.Close();

                cmd = new SqlCommand("select * from Users ", cn);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr[0].ToString() == LecturerID_txt.Text)
                        flag++;
                }
                dr.Close();

                cmd = new SqlCommand("SELECT * FROM UsersDepartment", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //getting the last Num in table - in order to know to set next primary key

                    followNum = dr[0].ToString();

                    index = Int32.Parse(followNum) + 1;
                    nextIndex = index; //in order to get the number outside the loop

                }

                cn.Close();

                if (depFlag == 0)
                {
                    MessageBox.Show("Department not exists in database!");
                    this.LecturerID_txt.Clear();
                    this.firstName_txtbox.Clear();
                    this.lastName_txtbox.Clear();
                    this.password_textBox.Clear();
                    this.ID_Department_txtbox.Clear();
                }
                else
                {
                    if (flag > 0)
                    {
                        MessageBox.Show("Lecturer allready exists in database!");
                        this.LecturerID_txt.Clear();
                        this.firstName_txtbox.Clear();
                        this.lastName_txtbox.Clear();
                        this.password_textBox.Clear();
                        this.ID_Department_txtbox.Clear();



                    }
                    else
                    {
                        cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
                        cn.Open();
                        cmd = new SqlCommand("INSERT INTO Users(ID,FirstName,LastName,Type,Password,Departments) VALUES (@ID,@FirstName,@LastName,@Type,@Password,@Departments)", cn);
                        cmd.Parameters.AddWithValue("@ID", LecturerID_txt.Text);
                        cmd.Parameters.AddWithValue("@FirstName", firstName_txtbox.Text);
                        cmd.Parameters.AddWithValue("@LastName", lastName_txtbox.Text);
                        cmd.Parameters.AddWithValue("@Type", 2);
                        cmd.Parameters.AddWithValue("@Password", password_textBox.Text);
                        cmd.Parameters.AddWithValue("@Departments", depName);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        cmd1 = new SqlCommand("INSERT INTO UsersDepartment(Num,ID,IDdepartment) VALUES (@Num,@ID,@IDdepartment)", cn);
                        cmd1.Parameters.AddWithValue("@Num", nextIndex);
                        cmd1.Parameters.AddWithValue("@ID", LecturerID_txt.Text);
                        cmd1.Parameters.AddWithValue("@IDdepartment", ID_Department_txtbox.Text);
                        cmd1.ExecuteNonQuery();
                        cmd1.Parameters.Clear();

                        MessageBox.Show("New Lecturer [" + firstName_txtbox.Text + "] added succesfully!");
                        this.Hide();
                        A_DHadd.currentA_DHadd.Show();


                    }
                }

                dr.Close();
                cn.Close();
            }
        }
    }
}
