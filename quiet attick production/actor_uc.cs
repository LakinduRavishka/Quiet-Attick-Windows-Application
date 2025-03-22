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
using System.Security.Cryptography;

namespace quiet_attick_production
{
    public partial class actor_uc : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RUSH-DESKTOP\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True;Encrypt=False");
        int id, mobilno,aid;
        string fname, lname, email;

        private void btn_update_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string update = "update Actor set First_Name='" + fname + "',Last_Name='" + lname + "',Mobil_No='" + mobilno + "',E_Mail='" + email + "' where Actor_Id='" + id + "'";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Successfully");
            conn.Close();
            Loadgrid();
        }

        public actor_uc()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            id = int.Parse(txt_search.Text);
            conn.Open();
            string delete = "delete from Actor where Actor_Id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Successfully");
            conn.Close();
            Loadgrid();
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            aid = int.Parse(txt_search.Text);
            conn.Open();
            string search = "select * from  Actor where Actor_Id = '" + aid + "'";
            SqlCommand cmd = new SqlCommand(search, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txt_fname.Text = read["First_Name"].ToString();
                txt_lname.Text = read["Last_Name"].ToString();
                txt_email.Text = read["E_Mail"].ToString();
                txt_mobilno.Text = read["Mobil_No"].ToString();
            }
            conn.Close();
            Loadgrid();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_id.Clear();
            txt_email.Clear();
            txt_mobilno.Clear();
            txt_fname.Focus();

        }

        private void actor_uc_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string insert = "Insert into Actor(Actor_Id,First_Name,Last_Name,Mobil_No,E_Mail) values ('" + id + "','" + fname + "','" + lname + "','" + mobilno + "','" + email + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add Successfully");
            conn.Close();
            Loadgrid();
        }
        private void Loadelement()
        {
            id = int.Parse(txt_id.Text);
            fname = txt_fname.Text;
            lname = txt_lname.Text;
            email = txt_email.Text;
            mobilno = int.Parse(txt_mobilno.Text);
        }
        private void Loadgrid()
        {
            conn.Open();
            string querry = "select * from Actor";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgv_actor.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }
    }
}
