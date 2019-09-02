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
    public partial class A_DHview : Form
    {
        public static A_DHview currentA_DHview;
        HeadDepartment dep;

        public HeadDepartment passValue
        {
            get { return dep; }
            set { dep = value; }
        }

        public A_DHview(HeadDepartment hd)
        {
            InitializeComponent();
           // this.dep = new HeadDepartment();
            this.dep = hd;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_DepartmentHead x = new A_DepartmentHead();
            A_DepartmentHead.currentA_DepartmentHead.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Students_Report_Click(object sender, EventArgs e)
        {
            // this.Close();
            //A_student_report_forDH x = new A_student_report_forDH();
            this.Hide();
            A_student_report_forDH x = new A_student_report_forDH(this.dep);
            x.passValue = dep;
            x.Show();

        }

        private void per_year_report_Click(object sender, EventArgs e)
        {
            // this.Close();
            //A_stutent_report_perYear x = new A_stutent_report_perYear();
            this.Hide();
            A_stutent_report_perYear x = new A_stutent_report_perYear(this.dep);
            x.passValue = dep;
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_viewReportHoursOf_TA_forDH taRep = new A_viewReportHoursOf_TA_forDH();
            A_viewReportHoursOf_TA_forDH taRep = new A_viewReportHoursOf_TA_forDH(this.dep);
            taRep.passValue = dep;
            taRep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_viewReportHoursOf_Lecturer_forDH Rep = new A_viewReportHoursOf_Lecturer_forDH();
            A_viewReportHoursOf_Lecturer_forDH Rep = new A_viewReportHoursOf_Lecturer_forDH(this.dep);
            Rep.passValue = dep;
            Rep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_AverageGradesInCoursses_HD Eve = new A_AverageGradesInCoursses_HD();
            A_AverageGradesInCoursses_HD Eve = new A_AverageGradesInCoursses_HD(this.dep);
            Eve.passValue = dep;
            Eve.Show();

        }

        private void A_DHview_Load(object sender, EventArgs e)
        {
            currentA_DHview = this;
        }
    }
}
