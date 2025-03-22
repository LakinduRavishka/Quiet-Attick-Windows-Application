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
    public partial class client_uc : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RUSH-DESKTOP\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True;Encrypt=False");

        int cid,mobno,ccid;
        string fname, lname, email, protitle;
        public client_uc()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string update = "update client set First_Name= '" + fname + "',Last_Name= '" + lname + "',E_Mail='" + email + "',Mobil_No='" + mobno + "',Production_Title='" + protitle + "' where Client_Id='" + cid + "'";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data update Successfully");
            conn.Close();
            Loaddgv();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cid = int.Parse(txt_search.Text);
            conn.Open();
            string delete = "delete from Client where Client_Id = '" + ccid + "'";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data delete Successfully");
            conn.Close();
            Loaddgv();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            ccid = int.Parse(txt_search.Text);
            conn.Open();
            string search = "select * from  client where Client_Id = '" + ccid + "'";
            SqlCommand cmd = new SqlCommand(search, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txt_fname.Text = read["First_Name"].ToString();
                txt_lname.Text = read["Last_Name"].ToString();
                txt_email.Text = read["E_Mail"].ToString();
                txt_no.Text = read["Mobil_No"].ToString();
                txt_protitle.Text = read["Production_Title"].ToString();
            }
            conn.Close();
            Loaddgv();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_fname.Clear();
            txt_lname.Clear();
            txt_email.Clear();
            txt_no.Clear();
            txt_protitle.Clear();
            txt_id.Focus();
        }

        private void dgv_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Loadelement()
        {
            cid = int.Parse(txt_id.Text.ToString());
            mobno = int.Parse(txt_no.Text.ToString());
            fname = txt_fname.Text;
            lname = txt_lname.Text;
            email = txt_email.Text;
            protitle = txt_protitle.Text;
        }
        private void Loaddgv()
        {
            conn.Open();
            string querry = "select * from Client";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgv_client.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void client_uc_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string insert = "Insert into Client (Client_Id, First_Name, Last_Name, E_Mail, Mobil_No, Production_Title) values ('" + cid + "','" + fname + "','" + lname + "','" + email + "','" + mobno + "','" + protitle + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data add successfully");
            conn.Close();
            Loaddgv();
        }
    }
}
