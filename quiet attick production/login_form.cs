using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quiet_attick_production
{
    public partial class login_form : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8C2UC1P\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True;Encrypt=False; Encrypt=False");
        string un, psw;
        int id;
        public login_form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 100, 100, 100);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you Want to Exit to application", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Error)==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txt_id.Clear();
                txt_un.Clear();
                txt_psw.Clear();
                txt_id.Focus();
            }

        }

        private void btn_panel_Click(object sender, EventArgs e)
        {
            staff stf = new staff();
            stf.Show();
            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_un.Clear();
            txt_psw.Clear();
            txt_id.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string us = txt_un.Text;
            string pw = txt_psw.Text;


            if (us == "Lakindu" && pw == "lakindu" && id == "1499")
            {
                MessageBox.Show("You are now in Staff Dashboard", "Staff login Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                staff staff = new staff();
                staff.Show();
                this.Hide();

            }
            else if (us == "Ravishka" && pw == "ravishka" && id == "7580")
            {
                MessageBox.Show("You are now in Manager Dashboard", "Manager login success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Manager_Dashboard manager = new Manager_Dashboard();
                manager.Show();
                this.Hide();
            }
            else if (us == "Admin" && pw == "admin" && id == "9910")
            {
                MessageBox.Show("You are now in admin Dashboard", "Admin login success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                admincontrol admin = new admincontrol();
                admin.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Login Fail. Check Your Id, Username or Password", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_id.Clear();
                txt_un.Clear();
                txt_psw.Clear();
                txt_un.Focus();
            }
            /*LoadElement();

            conn.Open();
            if(un=="" && psw =="")
            {

                MessageBox.Show("Logging fail");
            }
            else
            {
                string Query = "Select * from Login Where Id='" + id + "'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["User_name"].ToString() == un && dr["Password"].ToString() == psw)
                    {
                        if (dr["Id"].ToString() == "1499")
                        {
                            MessageBox.Show("You are now in Staff Dashboard", "Staff login Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            staff staff = new staff();
                            staff.Show();
                            this.Hide();

                        }
                        else if (dr["Id"].ToString() == "9910")
                        {
                            MessageBox.Show("You are now in admin Dashboard", "Admin login success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            admincontrol admin = new admincontrol();
                            admin.Show();
                            this.Hide();
                            
                        }
                        else if (dr["Id"].ToString() == "7580")
                        {
                            MessageBox.Show("You are now in Manager Dashboard", "Manager login success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Manager_Dashboard manager = new Manager_Dashboard();
                            manager.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Logging fail");
                        }

                    }
                }
            }
            conn.Close();*/
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(10, 10, 100, 100);
        }

        private void LoadElement()
        {
           un=txt_un.Text;
            psw=txt_psw.Text;
            id = int.Parse(txt_id.Text);
        }
    }
}
