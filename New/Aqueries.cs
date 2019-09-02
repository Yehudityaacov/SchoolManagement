using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New
{
    public partial class Aqueries : Form
    {
        public static Aqueries currentAqueries;
        public Aqueries()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            A_menuForSecretary.CurrentA_menuForSecretary.Show();
            this.Hide();

           
        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_course_query_Click(object sender, EventArgs e)
        {

            
            this.Hide();
            A_queryCourseSecretary x = new A_queryCourseSecretary();
            x.Show();
        }

        private void button_student_query_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_queryStudentSecretary x = new A_queryStudentSecretary();
            x.Show();
        }

        private void button_lecturer_query_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_QueryLecturer_secretary x = new A_QueryLecturer_secretary();
            x.Show();
        }

        private void butoon_TA_query_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_queryTeachingAssistantSecretary x = new A_queryTeachingAssistantSecretary();
            x.Show();
        }

        private void Aqueries_Load(object sender, EventArgs e)
        {
            currentAqueries = this;
        }
    }
}
