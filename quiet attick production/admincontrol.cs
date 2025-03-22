using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiet_attick_production
{
    public partial class admincontrol : Form
    {
        public admincontrol()
        {
            InitializeComponent();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            staff_uc1.Hide();
            actor_uc1.Hide();
            property_uc1.Hide();
            production_uc1.Hide();
            location_uc1.Hide();
            welcome_uc1.Hide();
            //show client tab
            client_uc1.Show();
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            actor_uc1.Hide();
            property_uc1.Hide();
            production_uc1.Hide();
            location_uc1.Hide();
            client_uc1.Hide();
            welcome_uc1.Hide();

            staff_uc1.Show();
        }

        private void admincontrol_Load(object sender, EventArgs e)
        {
            welcome_uc1.BringToFront();
        }

        private void btn_actor_Click(object sender, EventArgs e)
        {
            actor_uc1.Show();
            property_uc1.Hide();
            production_uc1.Hide();
            location_uc1.Hide();
            client_uc1.Hide();
            welcome_uc1.Hide();
            staff_uc1.Hide();
        }

        private void btn_production_Click(object sender, EventArgs e)
        {
            actor_uc1.Hide();
            property_uc1.Hide();
            location_uc1.Hide();
            client_uc1.Hide();
            welcome_uc1.Hide();
            staff_uc1.Hide();

            production_uc1.Show();
        }

        private void btn_location_Click(object sender, EventArgs e)
        {
            actor_uc1.Hide();
            property_uc1.Hide();
            client_uc1.Hide();
            welcome_uc1.Hide();
            staff_uc1.Hide();
            production_uc1.Hide();

            location_uc1.Show();
        }

        private void btn_property_Click(object sender, EventArgs e)
        {
            actor_uc1.Hide();
            client_uc1.Hide();
            welcome_uc1.Hide();
            staff_uc1.Hide();
            production_uc1.Hide();
            location_uc1.Show();
            property_uc1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure to Logout", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login_form login = new login_form();
                login.Show();
                this.Hide();
            }
        }
    }
}
