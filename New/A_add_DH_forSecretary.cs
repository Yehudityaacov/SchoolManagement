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
    public partial class A_add_DH_forSecretary : Form
    {
        public static A_add_DH_forSecretary currentA_add_DH_forSecretary;
        public A_add_DH_forSecretary()
        {
            InitializeComponent();
        }

        private void button_SUBMIT_Click(object sender, EventArgs e)
        {
            // new change
            bool flag = false;
            int deptFlag = 0;
            int usersFlag = 0;
            int countHD = 0;
            string followNum;

            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;

            //check if any of the fields is empty
            if (String.IsNullOrEmpty(textBox_UserID.Text) || String.IsNullOrEmpty(textBox_DeptID.Text) || String.IsNullOrEmpty(textBox_FirstName.Text) || String.IsNullOrEmpty(textBox_LastName.Text) || String.IsNullOrEmpty(textBox_PASSWORD.Text))
            {
                MessageBox.Show("All fields REQIRED! please try again");


                this.Hide();
                A_add_DH_forSecretary.currentA_add_DH_forSecretary.Show();

            }


            cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            cn.Open();


            cmd = new SqlCommand("SELECT IDdepartment FROM Departments ", cn);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //first we want to make sure this department exists

                if (dr["IDdepartment"].ToString() == textBox_DeptID.Text)
                {
                    deptFlag++;
                    break;
                }

            }

            dr.Close();
            cn.Close();


            cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            cn.Open();


            cmd = new SqlCommand("SELECT ID FROM Users ", cn);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                //second we want to make sure this user does NOT exist
                if (dr["ID"].ToString() == textBox_UserID.Text)
                {
                    usersFlag++;
                    MessageBox.Show("WARNING: user ID allready exist in our database!");
                    break;
                }


            }
            dr.Close();
            cn.Close();



            if (deptFlag == 1 && usersFlag == 0)
            {
                cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
                cn.Open();


                cmd = new SqlCommand("SELECT ID,Type FROM USERS ", cn);

                dr = cmd.ExecuteReader();

                List<string> ID_list = new List<string>();

                while (dr.Read())
                {
                    if (dr["Type"].ToString() == "4")// if its head department
                    {
                        ID_list.Add((string)dr["ID"].ToString()); // creating ID Array - only of head departments


                    }
                }

                dr.Close();
                cn.Close();

                cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
                cn.Open();


                cmd = new SqlCommand("SELECT ID,IDdepartment FROM UsersDepartment ", cn);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    for (int i = 0; i < ID_list.Count(); i++)
                    {
                        if (dr["ID"].ToString() == ID_list[i])
                        {
                            if (dr["IDdepartment"].ToString() != textBox_DeptID.Text)
                            {
                                countHD++;
                            }
                            else if (dr["IDdepartment"].ToString() == textBox_DeptID.Text)
                            {
                                MessageBox.Show("Sorry! in this department allready exist Head Department");
                                break;
                            }

                        }
                    }
                }


                dr.Close();
                cn.Close();


                if (countHD == ID_list.Count())
                    flag = true;

                else
                    flag = false;


            }

            //in order to get last Primary key

            cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            cn.Open();
            cmd = new SqlCommand("SELECT MAX (Num) FROM UsersDepartment ", cn);
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


            if (flag)
            {
                //in this case we need to add new head department

                cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
                cn.Open();


                cmd = new SqlCommand("INSERT INTO Users(ID,FirstName,LastName,Type,Password) VALUES (@ID,@FirstName,@LastName,@Type,@Password)", cn);
                cmd.Parameters.AddWithValue("@ID", textBox_UserID.Text);
                cmd.Parameters.AddWithValue("@FirstName", textBox_FirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", textBox_LastName.Text);
                cmd.Parameters.AddWithValue("@Type", 4); //this is head department Type (4)
                cmd.Parameters.AddWithValue("@Password", textBox_PASSWORD.Text);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                SqlCommand cmd1 = new SqlCommand("INSERT INTO UsersDepartment(Num,ID,IDdepartment) VALUES (@Num,@ID,@IDdepartment)", cn);
                cmd1.Parameters.AddWithValue("@Num", nextIndex);
                cmd1.Parameters.AddWithValue("@ID", textBox_UserID.Text);
                cmd1.Parameters.AddWithValue("@IDdepartment", textBox_DeptID.Text);

                cmd1.ExecuteNonQuery();
                cmd1.Parameters.Clear();


                MessageBox.Show(" *** Congratulations!" + textBox_FirstName.Text + textBox_LastName.Text + "just signed up as new HEAD DEPARTMENT! ***"); //change after

                cn.Close();


            }

            else
            {
                //in this case we DONT need to add new head department

                if (deptFlag == 0)
                    MessageBox.Show("Sorry! this department does NOT exist in our database!");

                textBox_DeptID.Clear();
                textBox_FirstName.Clear();
                textBox_LastName.Clear();
                textBox_PASSWORD.Clear();
                textBox_UserID.Clear();
                MessageBox.Show("*** Adding new Head Department FAILED!!! ***");


            }





            //bool flag = false;
            //int deptFlag = 0;
            //int usersFlag = 0;
            //int countHD = 0;
            //string followNum;

            //SqlConnection cn;
            //SqlCommand cmd;
            //SqlDataReader dr;

            ////check if any of the fields is empty
            //if (String.IsNullOrEmpty(textBox_UserID.Text) || String.IsNullOrEmpty(textBox_DeptID.Text) || String.IsNullOrEmpty(textBox_FirstName.Text) || String.IsNullOrEmpty(textBox_LastName.Text) || String.IsNullOrEmpty(textBox_PASSWORD.Text))
            //{
            //    MessageBox.Show("All fields REQIRED! please try again");


            //    this.Hide();
            //    A_add_DH_forSecretary.currentA_add_DH_forSecretary.Show(); 

            //}


            //cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            //cn.Open();


            //cmd = new SqlCommand("SELECT IDdepartment FROM Departments ", cn);

            //dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    //first we want to make sure this department exists

            //    if (dr["IDdepartment"].ToString() == textBox_DeptID.Text)
            //    {
            //        deptFlag++;
            //        break;
            //    }

            //}

            //dr.Close();
            //cn.Close();


            //cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            //cn.Open();


            //cmd = new SqlCommand("SELECT ID FROM Users ", cn);

            //dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{

            //    //second we want to make sure this user does NOT exist
            //    if (dr["ID"].ToString() == textBox_UserID.Text)
            //    {
            //        usersFlag++;
            //        MessageBox.Show("WARNING: user ID allready exist in our database!");
            //        break;
            //    }


            //}
            //dr.Close();
            //cn.Close();



            //if (deptFlag == 1 && usersFlag == 0)
            //{
            //    cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            //    cn.Open();


            //    cmd = new SqlCommand("SELECT ID,Type FROM USERS ", cn);

            //    dr = cmd.ExecuteReader();

            //    List<string> ID_list = new List<string>();

            //    while (dr.Read())
            //    {
            //        if (dr["Type"].ToString() == "4")// if its head department
            //        {
            //            ID_list.Add((string)dr["ID"].ToString()); // creating ID Array - only of head departments


            //        }
            //    }

            //    dr.Close();
            //    cn.Close();

            //    cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            //    cn.Open();


            //    cmd = new SqlCommand("SELECT ID,IDdepartment FROM UsersDepartment ", cn);

            //    dr = cmd.ExecuteReader();

            //    while (dr.Read())
            //    {
            //        for (int i=0; i<ID_list.Count(); i++)
            //        {
            //            if (dr["ID"].ToString() == ID_list[i])
            //            {
            //                if (dr["IDdepartment"].ToString() != textBox_DeptID.Text)
            //                {
            //                    countHD++;
            //                }
            //                else if (dr["IDdepartment"].ToString() == textBox_DeptID.Text)
            //                {
            //                    MessageBox.Show("Sorry! in this department allready exist Head Department");
            //                    break;
            //                }

            //            }
            //        }
            //    }


            //    dr.Close();
            //    cn.Close();


            //    if (countHD == ID_list.Count())
            //        flag = true;

            //    else
            //        flag = false;


            //}

            ////in order to get last Primary key

            //cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            //cn.Open();
            //cmd = new SqlCommand("SELECT MAX (Num) FROM UsersDepartment ", cn);
            //dr = cmd.ExecuteReader();

            //int index;
            //int nextIndex = 0;

            //while (dr.Read())
            //{
            //    //getting the last Num in table - in order to know to set next primary key
            //    followNum = dr[0].ToString();

            //    index = Int32.Parse(followNum) + 1;
            //    nextIndex = index; //in order to get the number outside the loop

            //}


            //dr.Close();
            //cn.Close();


            //if (flag)
            //{
            //    //in this case we need to add new head department

            //    cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            //    cn.Open();


            //    cmd = new SqlCommand("INSERT INTO Users(ID,FirstName,LastName,Type,Password) VALUES (@ID,@FirstName,@LastName,@Type,@Password)", cn);
            //    cmd.Parameters.AddWithValue("@ID", textBox_UserID.Text);
            //    cmd.Parameters.AddWithValue("@FirstName", textBox_FirstName.Text);
            //    cmd.Parameters.AddWithValue("@LastName",textBox_LastName.Text);
            //    cmd.Parameters.AddWithValue("@Type",4); //this is head department Type (4)
            //    cmd.Parameters.AddWithValue("@Password",textBox_PASSWORD.Text);

            //    cmd.ExecuteNonQuery();
            //    cmd.Parameters.Clear();

            //    SqlCommand cmd1 = new SqlCommand("INSERT INTO UsersDepartment(Num,ID,IDdepartment) VALUES (@Num,@ID,@IDdepartment)", cn);
            //    cmd1.Parameters.AddWithValue("@Num",nextIndex);
            //    cmd1.Parameters.AddWithValue("@ID",textBox_UserID.Text);
            //    cmd1.Parameters.AddWithValue("@IDdepartment", textBox_DeptID.Text);

            //    cmd1.ExecuteNonQuery();
            //    cmd1.Parameters.Clear();


            //    MessageBox.Show(" *** Congratulations!" + textBox_FirstName.Text + textBox_LastName.Text+ "just signed up as new HEAD DEPARTMENT! ***"); //change after

            //    cn.Close();


            //}

            //else
            //{
            //    //in this case we DONT need to add new head department

            //    if (deptFlag == 0)
            //        MessageBox.Show("Sorry! this department does NOT exist in our database!");


            //    MessageBox.Show("*** Adding new Head Department FAILED!!! ***");


            //}


        }

        private void button_BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_MenuSecretary.currentadd_MenuSecretary.Show();
        }

        private void A_add_DH_forSecretary_Load(object sender, EventArgs e)
        {
            currentA_add_DH_forSecretary = this;
        }
    }
}
