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
using Microsoft.VisualBasic;


namespace New
{
    public partial class A_editingFlowchart_DepartmentHead : Form
    {
        public static A_editingFlowchart_DepartmentHead currA_editingFlowchart_DepartmentHead;
        private HeadDepartment dep;
        DataTable data;
        SqlDataAdapter sda;
        SqlCommandBuilder cmdbld;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        int selectedRowIndex;

        public A_editingFlowchart_DepartmentHead(HeadDepartment hd)
        {
            InitializeComponent();
            //this.dep = hd;
            this.dep = new HeadDepartment();
            this.dep = hd;

            label1.Text = this.dep.getdeparName();
            label2_last.Text = this.dep.getLastName();
            label2_first.Text = this.dep.getFirstName();

            con = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");

            sda = new SqlDataAdapter("SELECT num,Year, CourseName, Precourse, Blockscourse,CreditCourseName FROM Asyllabus WHERE DepName = '" + this.dep.getdeparName() + "'", con);
            data = new DataTable();

            data.Columns.Add("num", typeof(int));
            data.Columns.Add("Year", typeof(string));
            data.Columns.Add("CourseName", typeof(string));
            data.Columns.Add("Precourse", typeof(string));
            data.Columns.Add("Blockscourse", typeof(string));
            data.Columns.Add("CreditCourseName", typeof(int));

            sda.Fill(data);
            dataGridView1.DataSource = data;

        }

        private void A_editingFlowchart_DepartmentHead_Load(object sender, EventArgs e)
        {
            currA_editingFlowchart_DepartmentHead = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_last_Click(object sender, EventArgs e)
        {

        }

        private void label2_first_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_backtpp_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_DHedit.currentA_DHedit.Show(); 
        }

        private void button1_save_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    cmdbld = new SqlCommandBuilder(sda);
            //    sda.Update(data);
            //    MessageBox.Show("success");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            DataGridViewRow row = new DataGridViewRow();

            row = dataGridView1.Rows[selectedRowIndex];
            bool flag = false;
            string year = Interaction.InputBox("Enter the year:", "Change" , row.Cells[1].Value.ToString() , -1 , -1);
            string CourseName = Interaction.InputBox("Enter the course name:", "Change", row.Cells[2].Value.ToString(), -1, -1);
            string Precourse = Interaction.InputBox("Enter the Precourse:", "Change", row.Cells[3].Value.ToString(), -1, -1);
            string Blockscourse = Interaction.InputBox("Enter the block course:", "Change", row.Cells[4].Value.ToString(), -1, -1);
            string CreditCourseName = Interaction.InputBox("Enter the Credit for the CourseName:", "Change", row.Cells[5].Value.ToString(), -1, -1);
            // check input !!!
            if (year.Trim() == "a" || year.Trim() == "b" || year.Trim() == "c" || year.Trim() == "d")
                row.Cells[1].Value = year;
            else
                MessageBox.Show("The year can be: a / b / c / d" , "Attention: Not update");
            if (CourseName == Precourse || CourseName == Blockscourse)
            {
                if (CourseName == "")
                    MessageBox.Show("You must need to insert course name!", "Attention: not update");
                else
                    MessageBox.Show("Duplicate names course!", "Attention: not update");
            }
               
            else
            {
                row.Cells[2].Value = CourseName;
                flag = true;
            }
                
            if (CourseName == Precourse || Precourse == Blockscourse)
            {
                if (CourseName == "")
                    MessageBox.Show("You must need to insert course name!", "Attention: not update");
                //else if (Blockscourse != "" && Precourse != "")
                //    MessageBox.Show("Duplicate names course!", "Attention: not update");
            }
            else
            {
                row.Cells[3].Value = Precourse;
                flag = true;
            }
                
            if ((CourseName == Blockscourse || Precourse == Blockscourse))
            {
                if (CourseName == "" || (Blockscourse != "" && Precourse != "") )
                    MessageBox.Show("Duplicate names course!", "Attention: not update");
            }
            else
            {
                row.Cells[4].Value = Blockscourse;
                flag = true;
            }
              
            if (CreditCourseName == "" || (int.Parse(CreditCourseName) > 7 || int.Parse(CreditCourseName) < 0))
                MessageBox.Show("THe limit of credits course : 0-6", "Attention: not update");
            else
            {
                row.Cells[5].Value = CreditCourseName;
                flag = true;
            }

            if (flag)
            {
                // now we change the details in the data base
                try
                {
                    string Query = "delete from Asyllabus where Asyllabus.num = '" + row.Cells[0].Value + "';";
                    con.Open();
                    cmd = new SqlCommand(Query, con);
                    dr = cmd.ExecuteReader();
                    //MessageBox.Show("delete");

                    con.Close();
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    string Query1 = "insert into [Asyllabus] (num ,DepName , Year , CourseName , Precourse , Blockscourse , CreditCourseName) values ('" + row.Cells[0].Value + "' ,'" + this.dep.getdeparName() + "' , '" + row.Cells[1].Value + "' , '" + row.Cells[2].Value + "' , '" + row.Cells[3].Value + "' , '" + row.Cells[4].Value + "' , '" + row.Cells[5].Value + "')";
                    con.Open();
                    cmd = new SqlCommand(Query1, con);
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Insert the new changes" , "Update changes");
                    //
                    con.Close();
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Wrong details , you can to try again!" , "Not update");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }



    }
}
