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
    public partial class A_displayMenuSecretary : Form
    {
        public static A_displayMenuSecretary CurrentA_displayMenuSecretary;
        public A_displayMenuSecretary()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_menuForSecretary.CurrentA_menuForSecretary.Show(); 
        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_filterClass_to_seats_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_FilterClassSeatsSecretary f = new A_FilterClassSeatsSecretary();
            f.ShowDialog();
        }

        private void button_filter_students_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_FilterStudentsPreCourseSecretary f = new A_FilterStudentsPreCourseSecretary();
            f.ShowDialog();
        }

        private void button_displayClasses_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_view_list_of_classes_Secretary x = new A_view_list_of_classes_Secretary();
            x.ShowDialog();
        }

        private void A_displayMenuSecretary_Load(object sender, EventArgs e)
        {
            CurrentA_displayMenuSecretary = this;
        }
    }
}
