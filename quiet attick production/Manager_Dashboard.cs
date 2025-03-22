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
    public partial class Manager_Dashboard : Form
    {
        public Manager_Dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            m_staff1.Hide();
            m_Client1.Show();
            m_Client1.BringToFront();
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            m_Client1.Hide();
            m_staff1.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Manager_Dashboard_Load(object sender, EventArgs e)
        {
            m_Client1.BringToFront();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure LogOut", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login_form login = new login_form();
                login.Show();
                this.Hide();
            }
        }
    }
}
