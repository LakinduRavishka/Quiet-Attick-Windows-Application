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
    public partial class m_staff : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RUSH-DESKTOP\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True;Encrypt=False");
        int id, sid,mobno;
        string fname, lname, email, address,type;

        private void btn_search_Click(object sender, EventArgs e)
        {
            sid = int.Parse(txt_search.Text);
            conn.Open();
            string search = "select * from Staff where Staff_Id ='" + sid + "'";
            SqlCommand cmd = new SqlCommand(search, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txt_id.Text = read["Staff_Id"].ToString();
                txt_fname.Text = read["First_Name"].ToString();
                txt_lname.Text = read["Last_Name"].ToString();
                txt_email.Text = read["E_Mail"].ToString();
                txt_mobilno.Text = read["Mobil_No"].ToString();
                txt_address.Text = read["Address"].ToString();
                cmb_type.Text = read["Type"].ToString();
            }
            conn.Close();
            Loadgrid();
        }

        public m_staff()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string update = "update Staff set First_Name='" + fname + "',Last_Name='" + lname + "',Mobil_No='" + mobno + "',E_Mail='" + email + "',Address='" + address + "',Type='" + type + "' where Staff_Id='" + id + "'";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update");
            conn.Close();
            Loadgrid();
        }

        private void m_staff_Load(object sender, EventArgs e)
        {

        }
        private void Loadelement()
        {
            id = int.Parse(txt_id.Text);
            mobno=int.Parse(txt_mobilno.Text);
            fname = txt_fname.Text;
            lname = txt_lname.Text;
            email = txt_email.Text;
            address = txt_address.Text;
            type = cmb_type.Text;
        }
        private void Loadgrid()
        {
            conn.Open();
            string querry = "select * from Staff";
            SqlDataAdapter adapt = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dgv_staff.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }
    }
}
