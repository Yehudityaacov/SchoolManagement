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
    public partial class add_MenuSecretary : Form
    {
        public static add_MenuSecretary currentadd_MenuSecretary;
        public add_MenuSecretary()
        {
            InitializeComponent();
        }

        private void button_add_department_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_addDepartment_secretary addDept = new A_addDepartment_secretary();
            addDept.ShowDialog();
        }

        private void button_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_menuForSecretary.CurrentA_menuForSecretary.Show();
        }

        private void button_add_course_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_addCourse_secretary addCourse = new A_addCourse_secretary();
            addCourse.ShowDialog();
        }

        private void button_add_headDept_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_add_DH_forSecretary add_DH = new A_add_DH_forSecretary();
            add_DH.ShowDialog();
        }

        private void button_edit1_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_edit_classes_for_exames_period_secretsry x = new A_edit_classes_for_exames_period_secretsry();
            x.ShowDialog();

        }

        private void add_MenuSecretary_Load(object sender, EventArgs e)
        {
            currentadd_MenuSecretary = this;
        }
    }
}
