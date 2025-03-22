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
    public partial class clientuc : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RUSH-DESKTOP\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True;Encrypt=False");
        string fname, lname, email, pro_title;
        int cid, mobil_no;

        private void btn_update_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string update = "update Client set First_Name='" + fname + "',Last_Name='" + lname + "',E_mail='" + email + "',Production_Title='" + pro_title + "' where Client_Id = '" + cid + "'";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Successfully");
            conn.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            cid = int.Parse(txt_search.Text);
            conn.Open();
            string search = "select * from Client where Client_Id = '" + cid + "'";
            SqlCommand cmd = new SqlCommand(search, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txt_clentfn.Text = read["First_Name"].ToString();
                txt_lname .Text = read["Last_Name"].ToString();
                txt_email.Text = read["E_Mail"].ToString();
                txt_mobilno.Text = read["Mobil_No"].ToString();
                txt_protitle.Text = read["Production_Title"].ToString();
            }
            conn.Close();
        }

        private void clientuc_Load(object sender, EventArgs e)
        {


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_clientid.Clear();
            txt_clentfn.Clear();
            txt_lname.Clear();
            txt_email.Clear();
            txt_mobilno.Clear();
            txt_protitle.Clear();
            txt_clientid.Focus();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            viewform view = new viewform();
            view.Show();
            this.Hide();
        }

        public clientuc()
        {
            InitializeComponent();
        }
        private void Loadelement()
        {
            cid = int.Parse(txt_clientid.Text.ToString());
            fname = txt_clentfn.Text;
            lname = txt_lname.Text;
            email = txt_email.Text;
            mobil_no = int.Parse(txt_mobilno.Text);
            pro_title = txt_protitle.Text;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string insert = "Insert into Client (Client_Id, First_Name, Last_Name, E_Mail, Mobil_No, Production_Title) values ('" + cid + "','" + fname + "','" + lname + "','" + email + "','" + mobil_no + "','" + pro_title + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("add successfully");
            conn.Close();
        }
    }
}
