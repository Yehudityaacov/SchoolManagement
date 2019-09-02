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
    public partial class A_HD_ExamList : Form
    {
        public static A_HD_ExamList currentA_HD_ExamList;
        SqlConnection cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
        private HeadDepartment dep;
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlDataReader dr;
        SqlDataReader dr1;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        bool exNum = true;
        bool exName = true; 
        bool exDate = true;
        public A_HD_ExamList(HeadDepartment hd)
        {
            InitializeComponent();
            this.dep = hd;
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        //Chack if the field not empty
        {


            if (String.IsNullOrWhiteSpace(ExamNum.Text) || String.IsNullOrWhiteSpace(ExamName.Text) || String.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("All fields REQIRED! please try again");
                this.ExamNum.Clear();
                this.ExamName.Clear();
                dateTimePicker1.Value = DateTime.Now;
                this.Hide();
                A_HD_ExamList.currentA_HD_ExamList.Show(); 
            }
            cn.Open();

            cmd = new SqlCommand("select * from HeadDepartmentExamList ", cn);
            dr = cmd.ExecuteReader();
            //chack not duplicat ExamNum primary key.
            while (dr.Read())
            {
                if (dr["ExamNum"].ToString() == ExamNum.Text)
                {
                    exNum = false;
                    break;

                }

            }
            dr.Close();
            cn.Close();
            if (exNum) {
                SqlConnection cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
                cn.Open();
                cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO HeadDepartmentExamList(ExamNum,ExamName,ExamDate) VALUES('" + ExamNum.Text + "','" + ExamName.Text + "','" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "')";
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record inserted successfully");
                this.Hide();
                ExamNum.Clear();
                ExamName.Clear();
                A_HD_ExamList Examl = new A_HD_ExamList(this.dep);
                Examl.ShowDialog();

            }
            else
            {
                MessageBox.Show("Record already exist in the database!");
                ExamNum.Clear();
                ExamName.Clear();
            }
        }
        public void disp_data()
        {

            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from  HeadDepartmentExamList";
            cmd.ExecuteNonQuery();
            DataTable datt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(datt);
            dataGridView1.DataSource = datt;
            cn.Close();
            ExamNum.Clear();
            ExamName.Clear();
            

        }
        private void A_HD_ExamList_Load(object sender, EventArgs e)
        {
            currentA_HD_ExamList = this;
            disp_data();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_DHedit.currentA_DHedit.Show();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1delet_Click(object sender, EventArgs e)
        {
            if (exNum) {
                cn.Open();
                cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete  from HeadDepartmentExamList where ExamNum ='" + ExamNum.Text + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record deleted successfully");
                this.Hide();
                ExamNum.Clear();
                ExamName.Clear();
               // A_HD_ExamList.currentA_HD_ExamList.Show();
                A_HD_ExamList Examl = new A_HD_ExamList(this.dep);
                Examl.ShowDialog();

            }
          
        }

        private void button1Update_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            try
            {
                cn.Open();
                cmd1 = new SqlCommand("select * from HeadDepartmentExamList ", cn);
                //cmd.Connection = cn;
                dr1 = cmd1.ExecuteReader();
                //chack not duplicat ExamNum primary key.


                while (dr1.Read())
                {
                    if (dr1["ExamNum"].ToString() == ExamNum.Text)
                    {
                        exNum = true;
                        if (dr1["ExamName"].ToString() == ExamName.Text)
                        {
                            exName = true;
                            if (dr1["ExamDate"].ToString() != ExamDate.Text|| dr1["ExamDate"].ToString() == "")
                            {
                                exDate = true;
                                break;
                            }
                        }

                    }


                }
                cn.Close();
                dr1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if ( (exNum&& exName&& !exDate))
            {//in case 
                //cn.Open();
               // da = new SqlDataAdapter("UPDATE HeadDepartmentExamList SET ExamName='" + ExamName.Text + "',ExamDate='" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "'WHERE ExamNum='" + ExamNum.Text + "'", cn);
               //// da.SelectCommand.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("you can't change the exam name or number");
                Hide();
                ExamNum.Clear();
                ExamName.Clear();
                A_HD_ExamList.currentA_HD_ExamList.Show();
            }
            if(exNum && exName&& exDate)
            {//update only the day of the exam
                cn.Open();
                da = new SqlDataAdapter("UPDATE HeadDepartmentExamList SET ExamDate='" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "'WHERE ExamNum='" + ExamNum.Text + "'", cn);
                da.SelectCommand.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("the Day is updated successfully");
                this.Hide();
                ExamNum.Clear();
                ExamName.Clear();

                A_HD_ExamList Examl = new A_HD_ExamList(this.dep);
                Examl.ShowDialog();
            }
         /*   else if (!exNum)
            {
                MessageBox.Show("UPDATE fild");
                MessageBox.Show("it seems the '" + ExamName.Text + "'is Not found in our database or you tring to change the number of the exam");
                ExamNum.Clear();
                ExamName.Clear();
            }*/
            else
            {
                MessageBox.Show("the exam is already Registered in the database");
            }

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //inorder to view the data 
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            ExamNum.Text = row.Cells[0].Value.ToString();
            ExamName.Text = row.Cells[1].Value.ToString();
            dateTimePicker1.Text = row.Cells[2].Value.ToString();
        }

       
    }
}
