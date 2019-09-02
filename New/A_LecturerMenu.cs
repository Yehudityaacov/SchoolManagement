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
    public partial class A_LecturerMenu : Form
    {
        public static A_LecturerMenu CIRRENTA_LecturerMenu;
        Lecturer lec;   
        ProfessorClass PC;
        
        public ProfessorClass passValue
        {
            get { return PC; }
            set { PC = value; }
        }

        public Lecturer passValue1
        {
            get { return lec; }
            set { lec = value; }
        }
        public A_LecturerMenu(Lecturer lec)
        {
            InitializeComponent();
            this.lec = lec;
            
        }

        private void BACKtpp_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Login_B.Current.Show();
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void A_LecturerMenu_Load(object sender, EventArgs e)
        {
            CIRRENTA_LecturerMenu = this;
        }

        private void insertionWork_Click(object sender, EventArgs e)
        {
            // this.Close();
           // this.Hide();
            A_Insert_work_hours_for_Lec x = new A_Insert_work_hours_for_Lec(lec);
            x.passValue = lec;
            x.ShowDialog();
        }

        private void viewArrangment_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Show_Schedualing_lecturer x = new Show_Schedualing_lecturer(lec);
            x.passValue = lec;
            x.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Professor_Student_List_B profList = new Professor_Student_List_B();
            profList.profValue = PC;
            profList.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfessorMassMassege massMassege = new ProfessorMassMassege();
            massMassege.profValue = PC;
            massMassege.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sending_Personal_message_B message = new sending_Personal_message_B();
            message.type = "lecture";
            message.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            professor_percentage_B percentage = new professor_percentage_B();
            percentage.passValue = PC;
            percentage.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            professor_Evaluation_B Evaluation = new professor_Evaluation_B();
            Evaluation.passValue = PC;
            Evaluation.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            professor_Disciplinarity disciplinary = new professor_Disciplinarity();
            disciplinary.passValue = PC;
            disciplinary.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            professor_add_Grade add_grade = new professor_add_Grade();
            add_grade.passValue = PC;
            add_grade.Show();
        }
    }
}
