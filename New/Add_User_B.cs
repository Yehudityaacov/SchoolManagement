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
    public partial class Add_User_B : Form
    {
        public Add_User_B()
        {
            InitializeComponent();
        }
        
        private void ID_Box_TextChanged(object sender, EventArgs e)
        {
            string tString = ID_Box.Text;
            if (tString.Trim() == "") return;
            if (tString.Length > 9)
            {
                MessageBox.Show("Please enter a valid number");
                ID_Box.Text = "";
                return;
            }

            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter NUMBERS only");
                    ID_Box.Text = "";
                    return;
                }

            }
        }
        private void ID_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
        }
        private void Last_Name_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void First_Name_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_User_click_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Return_Connection_String_Class.Return_Connection_String());
            connect.Open();
            if (connect.State == System.Data.ConnectionState.Open)
            {

                int type = 0, semester = 0, Idepartment = 7000, max = 0;
                char year = 'a';
                string department = "";
                string command, command2, command3;
                string curItem = Type_list.SelectedItem.ToString();
                if (curItem == "Student")
                {
                    type = 1;
                    DepartmentList.Show();
                    if (DepartmentList.SelectedItem.ToString() == "Software Engineering")
                    {
                        department = "Software Engineering";
                        Idepartment = 7000;
                    }
                    else if (DepartmentList.SelectedItem.ToString() == "Electrical Engineering")
                    {
                        department = "Electrical Engineering";
                        Idepartment = 7001;
                    }
                    else if (DepartmentList.SelectedItem.ToString() == "Structural Engineering")
                    {
                        department = "Structural Engineering";
                        Idepartment = 7002;
                    }
                    else if (DepartmentList.SelectedItem.ToString() == "Mechanical Engineering")
                    {
                        department = "Mechanical Engineering";
                        Idepartment = 7003;
                    }
                    else if (DepartmentList.SelectedItem.ToString() == "Physics")
                    {
                        department = "Physics";
                        Idepartment = 7006;
                    }
                    else if (DepartmentList.SelectedItem.ToString() == "Mathematics")
                    {
                        department = "Mathematics";
                        Idepartment = 7004;
                    }
                    else if (DepartmentList.SelectedItem.ToString() == "Chemistry")
                    { 
                        department = "Chemistry";
                        Idepartment = 7005;
                    }
                    else
                        MessageBox.Show("Please Choose Department");
                    Year_list.Show();
                    if (Year_list.SelectedItem.ToString() == "Year 1")
                        year = 'a';
                    else if (Year_list.SelectedItem.ToString() == "Year 2")
                        year = 'b';
                    else if (Year_list.SelectedItem.ToString() == "Year 3")
                        year = 'c';
                    else if (Year_list.SelectedItem.ToString() == "Year 4")
                        year = 'd';
                    else
                        MessageBox.Show("Please Choose Year");
                    SemesterBox.Show();
                    if (SemesterBox.SelectedItem.ToString() == "Semester a")
                        semester = 1;
                    else if (SemesterBox.SelectedItem.ToString() == "Semester b")
                        semester = 2;
                    else if (SemesterBox.SelectedItem.ToString() == "Summer")
                        semester = 3;
                    else
                        MessageBox.Show("Please Choose Semester");
                    /*insert users (student)*/
                    command = "insert into Users(ID,FirstName,LastName,Type,Password,Year,Departments,Semester)values('" + ID_Box.Text.ToString() + "','" + First_Name_Box.Text.ToString() + "','" + Last_Name_Box.Text.ToString() + "','" + type + "','" + Password_Box.Text.ToString() + "','" + year + "','" + department + "','" + semester + "')";
                }
                else
                {//1=student //2=a metargel //3=professor //4=a secretary //5 = secretary //6= Tech
                    if (curItem == "Secretary")
                        type = 5;
                    if (curItem == "Tech")
                        type = 6;
                    /*insert users (secretary and tech)*/
                    command = "insert into Users(ID,FirstName,LastName,Type,Password)values('" + ID_Box.Text.ToString() + "','" + First_Name_Box.Text.ToString() + "','" + Last_Name_Box.Text.ToString() + "','" + type + "','" + Password_Box.Text.ToString() + "')";
                }
                if (ID_Box.TextLength != 9)
                {
                    MessageBox.Show("Wrong ID please Fill Correct Data");
                    ID_Box.Text = "";
                }
                else
                {
                    SqlCommand readMaxNum = new SqlCommand("SELECT MAX(Num) as Max_NUM FROM UsersDepartment", connect);
                    readMaxNum.CommandType = CommandType.Text;
                    max = Int32.Parse(readMaxNum.ExecuteScalar().ToString());
                    /*insert userDepartment*/
                    command2 = "insert into UsersDepartment(Num,ID,IDdepartment)values('" + (max + 1) + "','" + ID_Box.Text.ToString() + "','" + Idepartment + "')";
                    SqlCommand readMaxseriannum = new SqlCommand("SELECT MAX(SerialNum) as MAX_NUM FROM Messege_Box", connect);
                    readMaxseriannum.CommandType = CommandType.Text;
                    max = Int32.Parse(readMaxNum.ExecuteScalar().ToString());
                    /*insert Messege_Box*/
                    command3 = "insert into Messege_Box(SerialNum,ID,Type)values('" + (max + 1) + "','" + ID_Box.Text.ToString() + "','" + type + "')";
                    SqlCommand cmd = new SqlCommand(command, connect);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand(command2, connect);
                    cmd1.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand(command3, connect);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Create new user made Successfuly");
                }
            }
        }

        private void button_Yellow1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Type_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = Type_list.SelectedItem.ToString();
            if (curItem == "Student")
            {
                SemesterBox.Show();
                Year_list.Show();
                DepartmentList.Show();
            }
            else
            {
                SemesterBox.Hide();
                Year_list.Hide();
                DepartmentList.Show();
            }
        }

        private void Year_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DepartmentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_User_B_Load(object sender, EventArgs e)
        {

        }
    }
}
