using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace quiet_attick_production
{
    public partial class m_Client : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RUSH-DESKTOP\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True;Encrypt=False");
        int id, mobil, seaid;
        string fname, lname, email, address,protitle;

        private void dgv_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_fname.Clear();
            txt_lname.Clear();
            txt_mail.Clear();
            txt_mobil.Clear();
            txt_protitle.Clear();
            txt_fname.Focus();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            seaid = int.Parse(txt_search.Text);
            conn.Open();
            string search = "select * from  Client where Client_Id = '" + seaid + "'";
            SqlCommand cmd = new SqlCommand(search, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txt_id.Text = read["Client_Id"].ToString();
                txt_fname.Text = read["First_Name"].ToString();
                txt_lname.Text = read["Last_Name"].ToString();
                txt_mail.Text = read["E_Mail"].ToString();
                txt_mobil.Text = read["Mobil_No"].ToString();
                txt_protitle.Text = read["Production_Title"].ToString();
            }
            conn.Close();
            Loadgrid();
        }

        public m_Client()
        {
            InitializeComponent();
        }

        private void m_Client_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string update = "update client set First_Name= '" + fname + "',Last_Name= '" + lname + "',E_Mail='" + email + "',Mobil_No='" + mobil + "',Production_Title='" + protitle + "' where Client_Id='" + id + "'";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update");
            conn.Close();
            Loadgrid();
        }
        private void Loadelement()
        {
            id = int.Parse(txt_id.Text.ToString());
            mobil = int.Parse(txt_mobil.Text.ToString());
            fname = txt_fname.Text;
            lname = txt_lname.Text;
            email = txt_mail.Text;
            protitle = txt_protitle.Text;
        }
        private void Loadgrid()
        {
            conn.Open();
            string querry = "select * from Client";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgv_client.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }
    }
}
