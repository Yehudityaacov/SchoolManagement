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
    public partial class A_DepartmentHead : Form
    {
         HeadDepartment dep;
        public static A_DepartmentHead currentA_DepartmentHead;
        public HeadDepartment passValue
        {
            get { return dep; }
             set { dep = value; }
        }

        public A_DepartmentHead(HeadDepartment hd)   // parametric constructor
        {
            InitializeComponent();

            //this.dep = hd;
            //this.dep = new HeadDepartment();
            this.dep = hd;
        }

        public A_DepartmentHead()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_DHadd x = new A_DHadd();
            x.passValue = dep;
            x.Show();
            //.x.ShowDialog();
        }
        //private void ADD_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    A_DHadd x = new A_DHadd();
        //    x.Show();
        //}

        private void REMOVE_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_DHremove x = new A_DHremove();
            A_DHremove x = new A_DHremove(this.dep);
            x.passValue = dep;
            x.Show();
            
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_DHedit x = new A_DHedit(this.dep);
            x.passValue = dep;
            x.Show();
        }

        private void DETERMINATION_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_creditsForCourse_DH credits = new A_creditsForCourse_DH();
            A_creditsForCourse_DH credits = new A_creditsForCourse_DH(this.dep);
            credits.passValue = dep;
            credits.Show();
        }

        private void SCHEDUALING_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_DHschedualing x = new A_DHschedualing();
            A_DHschedualing x = new A_DHschedualing(this.dep);
            x.passValue = dep;
            x.Show();
        }

        private void VIEWREPORTS_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_DHview x = new A_DHview();
            A_DHview x = new A_DHview(this.dep);
            x.passValue = dep;
            x.Show();
        }

        private void BACKtpp_Click(object sender, EventArgs e)
        {
            this.Hide();
            //ALoginScreen log = new ALoginScreen();
            Login_B.Current.Show();

            
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void A_DepartmentHead_Load(object sender, EventArgs e)
        {
            currentA_DepartmentHead = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ALLOCATION_Click(object sender, EventArgs e)
        {
            this.Hide();
            //A_allocateNumSeatsToCourse_DH allocate = new A_allocateNumSeatsToCourse_DH();
            A_allocateNumSeatsToCourse_DH allocate = new A_allocateNumSeatsToCourse_DH(this.dep);
            allocate.passValue = dep;
            allocate.Show();
        }
    }
}
