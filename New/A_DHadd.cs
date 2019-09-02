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
    public partial class A_DHadd : Form
    {
         HeadDepartment dep;
        public  static A_DHadd currentA_DHadd;
        public HeadDepartment passValue
        {
            get { return dep; }

            set { dep = value; }
        }

        //private string str;
        public A_DHadd(HeadDepartment hd)
        {
            InitializeComponent();
            //if (strId != null)
            //    this.str = strId;
            //this.dep = strId;
           // this.dep = new HeadDepartment();
            this.dep = hd;

        }
        public A_DHadd()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            A_DepartmentHead.currentA_DepartmentHead.Show(); 
        }
        //private void button8_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    A_DepartmentHead x = new A_DepartmentHead();  /// to check if to change and send with the id department head
        //    x.Show();
        //}

        private void add_lecturer_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_addLecturer_DH lecturer = new A_addLecturer_DH();
            A_addLecturer_DH lecturer = new A_addLecturer_DH(this.dep);
            lecturer.passValue = dep;
            lecturer.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_assistant_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_addTA_DH ta = new A_addTA_DH();
            A_addTA_DH ta = new A_addTA_DH(this.dep);
            ta.passValue = dep;
            ta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void A_DHadd_Load(object sender, EventArgs e)
        {
            currentA_DHadd = this;
        }

        private void add_flowchart_button_Click(object sender, EventArgs e)
        {
            /// to check ------------------- eden !!!!!!!!
            /// 
            if (this.dep.getdeparName() != null && this.dep.getdeparName() != "")
            {
                this.Hide();
                A_addingFlowchart_DepartmentHead head = new A_addingFlowchart_DepartmentHead(this.dep);
                head.passValue = dep;
                head.Show();
            }
            else
            {
                MessageBox.Show("You are not allowed to this option!");
                this.Close();
                A_DHadd.currentA_DHadd.Show();
                //x.Show();
                //this.Hide();
                //A_addTA_DH ta = new A_addTA_DH();
                //ta.ShowDialog();
            }
        }
    }
}
