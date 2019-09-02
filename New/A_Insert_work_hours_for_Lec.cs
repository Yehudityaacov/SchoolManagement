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
    public partial class A_Insert_work_hours_for_Lec : Form
    {
        public static A_Insert_work_hours_for_Lec CURRENTA_Insert_work_hours_for_Lec;
        Lecturer lec;
        SqlCommand cmd;
        SqlDataReader dr;
        string followNum;
        int index;
        int nextIndex = 0;
        String depID;

        public Lecturer passValue
        {
            get { return lec; }
            set { lec = value; }
        }

        public A_Insert_work_hours_for_Lec(Lecturer lec)
        {
            InitializeComponent();
            this.lec = lec;
            name.Text ="Hello " + lec.getFirstName().ToString()+"!";
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_LecturerMenu.CIRRENTA_LecturerMenu.Show();
            

        }

        private void button_SUBMIT_Click(object sender, EventArgs e)
        {
            bool alreadySigned = false;

            if (String.IsNullOrEmpty(textBox_hoursAmount.Text))
            {
                MessageBox.Show("You dont enter your work hours amount");
                this.Hide();
                A_Insert_work_hours_for_Lec.CURRENTA_Insert_work_hours_for_Lec.Show(); 
               
            }

            SqlConnection cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            cn.Open();
            SqlCommand cmd0 = new SqlCommand("SELECT MAX (Num) FROM staffHours", cn);
            dr = cmd0.ExecuteReader();
            while (dr.Read())
            {
                //getting the last Num in table - in order to know to set next primary key

                followNum = dr[0].ToString();

                index = Int32.Parse(followNum) + 1;
                nextIndex = index; //in order to get the number outside the loop

            }
            dr.Close();

            List<String> dept = new List<string>();

            SqlCommand cmd1 = new SqlCommand("SELECT * FROM UsersDepartment", cn);
            dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                if(dr["ID"].ToString() == lec.getID().ToString())
                {
                    dept.Add(dr["IDdepartment"].ToString());

                }

            }
            dr.Close();


            if (dept.Count() == 0)
            {
                MessageBox.Show("You'r not associated with a department \n You'r not allowed to insert work hours");
                textBox_hoursAmount.Clear();
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM staffHours", cn);
                dr = cmd2.ExecuteReader();
                while (dr.Read())
                {

                    if (dr["ID"].ToString() == lec.getID().ToString())
                    {


                        if (Int32.Parse(dr["month"].ToString()) == numericUpDown_month.Value)
                        {

                            if (Int32.Parse(dr["year"].ToString()) == numericUpDown_year.Value)
                            {

                                alreadySigned = true;
                                break;
                            }
                        }
                    }

                }
                dr.Close();

                if (!alreadySigned)
                {
                    cmd = new SqlCommand("INSERT INTO staffHours(Num,ID,name,Type,IDdepartment,month,year,hoursAmount) VALUES (@Num,@ID,@name,@Type,@IDdepartment,@month,@year,@hoursAmount)", cn);
                    cmd.Parameters.AddWithValue("@Num", nextIndex);
                    cmd.Parameters.AddWithValue("@ID", lec.getID().ToString());
                    cmd.Parameters.AddWithValue("@name", lec.getFirstName().ToString() + " " + lec.getLastName().ToString());
                    cmd.Parameters.AddWithValue("@Type", 2);
                    cmd.Parameters.AddWithValue("@IDdepartment", dept[0]);
                    cmd.Parameters.AddWithValue("@month", numericUpDown_month.Value);
                    cmd.Parameters.AddWithValue("@year", numericUpDown_year.Value);
                    cmd.Parameters.AddWithValue("@hoursAmount", textBox_hoursAmount.Text);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();


                    MessageBox.Show("Your work hours added succesfully!");
                    this.Close();
                    A_LecturerMenu.CIRRENTA_LecturerMenu.Show(); 
                   


                }

                else
                {

                    if (alreadySigned)
                    {
                        MessageBox.Show("You have already enterd your hours for: " + numericUpDown_month.Value + " - " + numericUpDown_year.Value);
                    }
                    textBox_hoursAmount.Clear();
                    MessageBox.Show(" *** PAY ATTENTION: insertion work hours FAILED! ***");


                }
            }

            

            cn.Close();
        }

        private void A_Insert_work_hours_for_Lec_Load(object sender, EventArgs e)
        {
            CURRENTA_Insert_work_hours_for_Lec = this;
        }
    }
}
