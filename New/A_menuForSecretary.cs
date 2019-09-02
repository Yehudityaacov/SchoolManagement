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
    public partial class A_menuForSecretary : Form
    {
        //Secretary sec;
        public static A_menuForSecretary CurrentA_menuForSecretary;

      /*  internal Secretary passValue
        {
            get { return sec; }
            set { sec = value; }
        }*/

        public A_menuForSecretary()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)//function for Back to prev page - same for all users
        {
           
            Login_B.Current.Show();
            this.Hide();

        }
        
        private void button_EXIT_Click(object sender, EventArgs e)//function EXIT for LOGOUT - same for all users
        {
            Application.Exit();
        }

        private void button_queries_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aqueries cur=new Aqueries();
            cur.ShowDialog();
            
           
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_MenuSecretary add=new add_MenuSecretary();
            add.ShowDialog();
            

        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_removeForSecretary rem =new A_removeForSecretary();
            rem.ShowDialog();
        }

        private void button_schedualing_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_schedForSecretary schad=new A_schedForSecretary() ;
            schad.ShowDialog();
            
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_insertForSecretary insert=new A_insertForSecretary();
            insert.ShowDialog();
            

        }

        private void button_display_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_displayMenuSecretary display=new A_displayMenuSecretary() ;
            display.ShowDialog();
        }

        private void A_menuForSecretary_Load(object sender, EventArgs e)
        {
            CurrentA_menuForSecretary = this;
        }
    }
}
