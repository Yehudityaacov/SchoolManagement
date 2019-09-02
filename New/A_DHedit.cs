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
    public partial class A_DHedit : Form
    {
        public static A_DHedit currentA_DHedit;
        HeadDepartment dep;

        public HeadDepartment passValue 
        {
            get { return dep; }
            set { dep = value; }
        }

        public A_DHedit(HeadDepartment hd)
        {
            InitializeComponent();
            //this.dep = new HeadDepartment();
            this.dep = hd;
        }
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_DepartmentHead x = new A_DepartmentHead();
            A_DepartmentHead.currentA_DepartmentHead.Show();
        }

        private void A_DHedit_Load(object sender, EventArgs e)
        {
            currentA_DHedit = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.dep.getdeparName() != null && this.dep.getdeparName() != "")
            {
                this.Hide();
                A_HD_ExamList edit = new A_HD_ExamList(this.dep);
                edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("you are not allowed to this option!");
                this.Hide();
                A_HD_ExamList x = new A_HD_ExamList(this.dep);
                x.ShowDialog();
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.dep.getdeparName() != null && this.dep.getdeparName() != "")
            {
                this.Hide();
                A_editingFlowchart_DepartmentHead edit = new A_editingFlowchart_DepartmentHead(this.dep);
                edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("you are not allowed to this option!");
                this.Hide();
                A_DHedit x = new A_DHedit(this.dep);
                x.ShowDialog();
            }

        }
    }
}
