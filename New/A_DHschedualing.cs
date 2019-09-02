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
    public partial class A_DHschedualing : Form
    {
        public static A_DHschedualing currentA_DHschedualing;
        HeadDepartment dep;

        public HeadDepartment passValue
        {
            get { return dep; }
            set { dep = value; }
        }

        public A_DHschedualing(HeadDepartment hd)
        {
            InitializeComponent();
           // this.dep = new HeadDepartment();
            this.dep = hd;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            //A_DepartmentHead x = new A_DepartmentHead();
            A_DepartmentHead.currentA_DepartmentHead.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_schedLectToCourse_forDH sched = new A_schedLectToCourse_forDH();
            A_schedLectToCourse_forDH sched = new A_schedLectToCourse_forDH(this.dep);
            sched.passValue = dep;
            sched.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_schedTA_toCourse_forDH sched = new A_schedTA_toCourse_forDH();
            A_schedTA_toCourse_forDH sched = new A_schedTA_toCourse_forDH(this.dep);
            sched.passValue = dep;
            sched.Show();
        }

        private void A_DHschedualing_Load(object sender, EventArgs e)
        {
            currentA_DHschedualing = this;
        }
    }
}
