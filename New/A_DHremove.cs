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
    public partial class A_DHremove : Form
    {
        HeadDepartment dep;
        public static A_DHremove currentA_DHremove;
        public HeadDepartment passValue  
        {
            get { return dep; }
            set { dep = value; }
        }

        public A_DHremove(HeadDepartment hd)
        {
            InitializeComponent();
            this.dep = new HeadDepartment();
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
            //A_remove_Lecturer_DH lecRemove = new A_remove_Lecturer_DH();
            A_remove_Lecturer_DH lecRemove = new A_remove_Lecturer_DH(this.dep);
            lecRemove.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_remove_TA_DH TAremove = new A_remove_TA_DH();
            A_remove_TA_DH TAremove = new A_remove_TA_DH(this.dep);
            TAremove.ShowDialog();
        }

        private void A_DHremove_Load(object sender, EventArgs e)
        {
            currentA_DHremove = this;
        }
    }
}
