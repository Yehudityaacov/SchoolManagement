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
    public partial class A_insertForSecretary : Form
    {
        Secretary sec;
        public static A_insertForSecretary CURRENTA_insertForSecretary;
        public A_insertForSecretary()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_menuForSecretary.CurrentA_menuForSecretary.Show();
            

        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_gradesInsert_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_insertionGrades_secretary insGr=new A_insertionGrades_secretary();
            insGr.ShowDialog();
        }

        private void button_insert_termsForCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_InsertConditionTermsForCourse InsertCo=new A_InsertConditionTermsForCourse();
            InsertCo.ShowDialog();
        }

        private void A_insertForSecretary_Load(object sender, EventArgs e)
        {
            CURRENTA_insertForSecretary = this;
        }

       
    }
}
