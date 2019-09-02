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
    public partial class A_addDepartment_secretary : Form
    {
        public static A_addDepartment_secretary currentA_addDepartment_secretary;
        SqlConnection cn;
        SqlCommand cmd;

        public A_addDepartment_secretary()
        {
            InitializeComponent();
        }

        private void button_SUBMIT_Click(object sender, EventArgs e)
        {
            int flag = 0;

            if (String.IsNullOrEmpty(textBox_deptName.Text) || String.IsNullOrEmpty(textBox_deptName.Text))
            {
                MessageBox.Show("All fields REQIRED! please try again");

                this.Hide();
                A_addDepartment_secretary.currentA_addDepartment_secretary.Show(); 
                
            }


            //if (!string.IsNullOrWhiteSpace(textBox_IDdept.Text))
            //{
            //    MessageBox.Show(" required field - ID department");
                
            //    this.Hide();
            //    A_addDepartment_secretary addDept = new A_addDepartment_secretary();
            //    addDept.ShowDialog();

            //}

            //if (!string.IsNullOrWhiteSpace(textBox_deptName.Text))
            //{
            //    MessageBox.Show("required field - department name");
                
            //    this.Hide();
            //    A_addDepartment_secretary addDept = new A_addDepartment_secretary();
            //    addDept.ShowDialog();
            //}

            cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            cn.Open();
            
            cmd = new SqlCommand("select * from Departments ", cn);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();

          

            while (dr.Read())
            {
                if (dr[0].ToString() == textBox_IDdept.Text)
                    flag++;

                if (dr[1].ToString() == textBox_deptName.Text)
                    flag++;


            }

            dr.Close();
            cn.Close();

            if (flag == 2 || flag == 1)
            {
                MessageBox.Show("Department allready exists in database!");
                this.textBox_IDdept.Clear();
                this.textBox_deptName.Clear();

                
            }
            else
            {
                cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
                cn.Open();
                cmd = new SqlCommand("INSERT INTO Departments(IDdepartment,Name) VALUES (@IDdepartment,@Name)", cn);
                cmd.Parameters.AddWithValue("@IDdepartment", textBox_IDdept.Text);
                cmd.Parameters.AddWithValue("@Name", textBox_deptName.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("New department [" +textBox_deptName.Text + "] added succesfully!");
                Department newDept = new Department(Int32.Parse(textBox_IDdept.Text), textBox_deptName.Text); //check this
                
            }
            dr.Close();
            cn.Close();
            
        }

        private void buttonBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_MenuSecretary.currentadd_MenuSecretary.Show(); 
        }

        private void A_addDepartment_secretary_Load(object sender, EventArgs e)
        {
            currentA_addDepartment_secretary = this;
        }
    }
}
