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
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }

        private void staff_Load(object sender, EventArgs e)
        {
            clientuc1.BringToFront();
            actoruc1.Hide();
            //staffuc1.Hide();
            locationuc1.Hide(); 
            paymentuc1.Hide();
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            clientuc1.Hide();
            locationuc1.Hide();
            actoruc1.Hide();
            //show staff form
            //staffuc1.Show();
            staffuc1.Show();
            //staffuc1.BringToFront();
        }

        private void btn_clients_Click(object sender, EventArgs e)
        {
            locationuc1.Hide();
            staffuc1.Hide();
            actoruc1.Hide();
            // show clients form
            clientuc1.Show();
            //clientuc1.BringToFront();
        }

        private void btn_loca_Click(object sender, EventArgs e)
        {
            staffuc1.Hide();
            clientuc1.Hide();
            actoruc1.Hide();

            //show location form
            locationuc1.Show();
            //locationuc1.BringToFront();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            staffuc1.Hide();
            locationuc1.Hide();
            clientuc1.Hide();
            actoruc1.Hide();

            //show payment form
            paymentuc1.Show();
            //paymentuc1.BringToFront();
        }

        private void paymentuc1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                    }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure to logout","Logout");
            login_form lform = new login_form();
            lform.Show();
            this.Hide();
        }

        private void btn_actor_Click(object sender, EventArgs e)
        {
            clientuc1.Hide();
            locationuc1.Hide();
            actoruc1.Hide();
            //show staff form
            //staffuc1.Show();
            staffuc1.Show();
            //staffuc1.BringToFront();
        }

        private void btn_actor_Click_1(object sender, EventArgs e)
        {
            clientuc1.Hide();
            locationuc1.Hide();
            staffuc1.Hide();

            actoruc1.Show();
        }

        private void actoruc1_Load(object sender, EventArgs e)
        {

        }
    }
}
