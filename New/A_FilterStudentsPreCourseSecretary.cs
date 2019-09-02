using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace New
{
    public partial class A_FilterStudentsPreCourseSecretary : Form
    {
        public static A_FilterStudentsPreCourseSecretary currentA_FilterStudentsPreCourseSecretary;
        DataTable data;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection cn;
        Student[] arr;


        public A_FilterStudentsPreCourseSecretary()
        {
            InitializeComponent();
            Fillcombo();

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ID student";
            dataGridView1.Columns[1].Name = "First name";
            dataGridView1.Columns[2].Name = "Last name";
            dataGridView1.Columns[3].Name = "Year";
            dataGridView1.Columns[4].Name = "Department";

        }


        void Fillcombo()
        {
            string constring = "Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017";
            string Query = "select * from Courses C";
            cn = new SqlConnection(constring);
            cmd = new SqlCommand(Query, cn);
            //SqlDataReader dr;

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string cName = dr["Name"].ToString();
                    comboBox1.Items.Add(cName);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void A_FilterStudentsPreCourseSecretary_Load(object sender, EventArgs e)
        {
            currentA_FilterStudentsPreCourseSecretary = this;
        }


        //private void search_Click(object sender, EventArgs e)
        //{
        //    //to clean the data grid
        //    this.dataGridView1.DataSource = null;
        //    this.dataGridView1.Rows.Clear();


        //    string constring = "Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017";


        //    string idCourse = null;
        //    // to save the ID course that choosen
        //    try
        //    {
        //        string Query = "select * from Courses where Name = '" + comboBox1.Text + "' ;";
        //        cn = new SqlConnection(constring);
        //        cmd = new SqlCommand(Query, cn);
        //        cn.Open();
        //        dr = cmd.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            idCourse = dr["IDcourse"].ToString();
        //            //cmb_numberSeats.Items.Add(cName);
        //            //string cName = dr.GetString("seats");

        //        }
        //        cn.Close();
        //        dr.Close();
        //    }
        //    catch (Exception e1)
        //    {
        //        MessageBox.Show(e1.Message);
        //    }
        //    int size = 0;  // size for arr students
        //    string idStudent = null;
        //    // with the ID course to save the ID student 
        //    try
        //    {
        //        string Query1 = "select * from StudentsCourses where IDcourse = '" + idCourse + "' ;";
        //        cn = new SqlConnection(constring);
        //        cmd = new SqlCommand(Query1, cn);
        //        cn.Open();
        //        dr = cmd.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            size++;
        //        }
        //        cn.Close();
        //        dr.Close();
        //    }
        //    catch (Exception e1)
        //    {
        //        MessageBox.Show(e1.Message);
        //    }
        //    // to save the studentsin arr of students
        //    try
        //    {
        //        string Query2 = "select * from Users U, StudentsCourses SC  where U.ID=SC.ID and IDcourse = '" + idCourse + "' ;";
        //        //string Query2 = "select * from StudentsCourses where IDcourse = '" + idCourse + "' ;";
        //        cn = new SqlConnection(constring);
        //        cmd = new SqlCommand(Query2, cn);
        //        cn.Open();
        //        dr = cmd.ExecuteReader();

        //        arr = new Student[size];
        //        for (int j = 0; j < size; j++)
        //            arr[j] = new Student();

        //        int i = 0;
        //        while (dr.Read())
        //        {
        //            string student = dr["ID"].ToString();
        //            arr[i].setID(int.Parse(student));
        //            arr[i].setFirstName(dr["FirstName"].ToString());
        //            arr[i].setLastName(dr["LastName"].ToString());
        //            arr[i].setYear(dr["Year"].ToString());
        //            arr[i].setDep(dr["Departments"].ToString());
        //            i++;
        //        }
        //        cn.Close();
        //        dr.Close();
        //    }
        //    catch (Exception e1)
        //    {
        //        MessageBox.Show(e1.Message);
        //    }

        //    data = new DataTable();

        //    for (int i = 0; i < size; i++)
        //    {
        //        dataGridView1.Rows.Add(arr[i].getID().ToString(), arr[i].getFirstName(), arr[i].getLastName(), arr[i].getYear(), arr[i].getdepName());

        //    }


        //}

        private void bctkpp_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_displayMenuSecretary.CurrentA_displayMenuSecretary.Show(); 
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //to clear the data grid
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();

            string constring = "Data Source=p17server.database.windows.net;Initial Catalog=P17DATABASE;Persist Security Info=True;User ID=P17;Password=Hadas@2017";

            string idCourse = null;
            // to save the ID course that choosen
            try
            {
                string Query = "select * from Courses where Name = '" + comboBox1.Text + "' ;";
                cn = new SqlConnection(constring);
                cmd = new SqlCommand(Query, cn);
                cn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    idCourse = dr["IDcourse"].ToString();
                    //cmb_numberSeats.Items.Add(cName);
                    //string cName = dr.GetString("seats");

                }
                cn.Close();
                dr.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            string pre = null, preId = null;
            // to check if have pre course - if yes -> to save the id course
            try
            {
                string QueryPre = "select * from Courses C  where C.IDcourse = '" + idCourse + "' ;";
                cn = new SqlConnection(constring);
                cmd = new SqlCommand(QueryPre, cn);
                cn.Open();
                dr = cmd.ExecuteReader();

                int i = 0;
                while (dr.Read())
                {
                    pre = dr["Precondition"].ToString();
                }
                cn.Close();
                dr.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            if (pre == null || pre =="")
            {
                MessageBox.Show("To this course doesn't have Pre-condition");
            }
            else
            {
                MessageBox.Show("To this course have Pre-condition: the course is " + pre.ToString());

                // to check the id of the pre- course

                try
                {
                    string Query = "select * from Courses where Name = '" + pre.ToString() + "' ;";
                    cn = new SqlConnection(constring);
                    cmd = new SqlCommand(Query, cn);
                    cn.Open();
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        preId = dr["IDcourse"].ToString();

                    }
                    cn.Close();
                    dr.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }


                int size = 0;  // size for arr students
                string idStudent = null;
                // with the ID course to save the ID student 
                try
                {
                    //string Query1 = "select * from StudentsCourses where IDcourse = '" + idCourse + "' ;";
                    //string QuerySize = "select * from Courses C, Users U, StudentsCourses SC, studentsGrades SG  where U.ID=SC.ID and SC.ID = SG.ID and SG.grade > 55 and SG.grade < 101 and SG.ID = '" + preId + "' and C.IDcourse = '" + idCourse + "' ;";
                    string QuerySize = "select * from Courses C, Users U, studentsGrades SG where U.ID=SG.ID and SG.grade > 55 and SG.grade < 101 and SG.IDcourse = '" + preId + "' and C.IDcourse = '"+ preId + "' ;";
                    cn = new SqlConnection(constring);
                    cmd = new SqlCommand(QuerySize, cn);
                    cn.Open();
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        size++;
                    }
                    cn.Close();
                    dr.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }

                // to save the students in arr of students
                try
                {
                    //string Query2 = "select * from Courses C, Users U, StudentsCourses SC, studentsGrades SG  where U.ID=SC.ID and SC.ID = SG.ID and SG.grade > 55 and SG.grade < 101 and SG.ID = '" + preId + "' and C.IDcourse = '"+ idCourse +"' ;";
                    string Query2 = "select * from Courses C, Users U, studentsGrades SG where U.ID=SG.ID and SG.grade > 55 and SG.grade < 101 and SG.IDcourse = '" + preId + "' and C.IDcourse = '" + preId + "' ;";
                    cn = new SqlConnection(constring);
                    cmd = new SqlCommand(Query2, cn);
                    cn.Open();
                    dr = cmd.ExecuteReader();

                    arr = new Student[size];
                    for (int j = 0; j < size; j++)
                        arr[j] = new Student();

                    int i = 0;
                    while (dr.Read())
                    {
                        string student = dr["ID"].ToString();
                        arr[i].setID(int.Parse(student));
                        arr[i].setFirstName(dr["FirstName"].ToString());
                        arr[i].setLastName(dr["LastName"].ToString());
                        arr[i].setYear(dr["Year"].ToString());
                        arr[i].setDep(dr["Departments"].ToString());
                        i++;
                    }
                    cn.Close();
                    dr.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }

                data = new DataTable();

                for (int i = 0; i < size; i++)
                {
                    dataGridView1.Rows.Add(arr[i].getID().ToString(), arr[i].getFirstName(), arr[i].getLastName(), arr[i].getYear(), arr[i].getdepName());

                }
            }
           



        }
    }



}
