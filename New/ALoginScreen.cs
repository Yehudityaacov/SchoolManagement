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
    public partial class ALoginScreen : Form
    {
        public static ALoginScreen currentA_LoginScreen;
        HeadDepartment dh;
        Lecturer lec;
        TeachingAssitant ta;
      

        public ALoginScreen()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool login = false;
            SqlConnection cn = new SqlConnection("Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Users where ID ='" + this.id_text.Text + "' and Password = '" + this.password_text.Text+"'" ,cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            string headDepartment;
            string userType, user_name;
            int result = 0;

            while (dr.Read())
            {
                login = true;
               
                userType = dr["Type"].ToString();
               
                //We dont have Student - therefor we doesnt need to know his type
                
                if (userType == "2")//for Lecturer Type
                {
                    result = 2;
                    lec = new Lecturer();
                    lec.setID(int.Parse(dr["ID"].ToString()));
                    lec.setdeparName(dr["Departments"].ToString());
                    lec.setFirstName(dr["FirstName"].ToString());
                    lec.setLastName(dr["LastName"].ToString());
                }
                   
                if (userType == "3")//for Teaching Assitant Type
                {
                    result = 3;
                    ta = new TeachingAssitant();
                    ta.setID(int.Parse(dr["ID"].ToString()));
                    ta.setdeparName(dr["Departments"].ToString());
                    ta.setFirstName(dr["FirstName"].ToString());
                    ta.setLastName(dr["LastName"].ToString());
                }

                if (userType == "4")//for Head Department Type
                {
                    result = 4;
                    dh = new HeadDepartment();
                    headDepartment = dr["ID"].ToString();
                    dh.setID(int.Parse(headDepartment));
                    dh.setdeparName(dr["Departments"].ToString());
                    dh.setFirstName(dr["FirstName"].ToString());
                    dh.setLastName(dr["LastName"].ToString());
                }

                if (userType == "5")//for Secretary Type
                    result = 5;
                

            }
            dr.Close();
            cn.Close();

            if (login)
            {

                
                //MessageBox.Show("Connect SUCCESSFULY");

                if (result == 2)// in case user is Lecturer
                {
                    this.Hide();
                    A_LecturerMenu lec = new A_LecturerMenu(this.lec);

                    lec.ShowDialog();

                }

                if (result == 3)//in case user is Teaching Assitant
                {
                    this.Hide();
                    A_TeachingAssistant ta = new A_TeachingAssistant(this.ta);
                    ta.ShowDialog();
                    
                    
                }

                if (result == 4)// in case the user is Department Head
                {
                    this.Hide();
                    //A_DepartmentHead depHead = new A_DepartmentHead();
                    A_DepartmentHead depHead = new A_DepartmentHead(this.dh);
                    depHead.ShowDialog();
                }

                if (result == 5)// in case the user is secretary
                {
                    this.Hide();
                    A_menuForSecretary sec = new A_menuForSecretary();
                    sec.ShowDialog();

                }

            }
            else
                MessageBox.Show("Login FAILED !!! Invalid ID/Password");
            
            this.id_text.Clear();
            this.password_text.Clear();

        }

    

        private void id_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void ALoginScreen_Load(object sender, EventArgs e)
        {
            currentA_LoginScreen = this;
        }
    }
}
