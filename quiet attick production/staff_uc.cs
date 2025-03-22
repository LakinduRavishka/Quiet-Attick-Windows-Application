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
using System.Runtime.InteropServices;

namespace quiet_attick_production
{
    public partial class staff_uc : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RUSH-DESKTOP\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True;Encrypt=False");
        int sid, mobno, ssid;
        string fname, lname, email, address, type;
        DateTime dob;

        private void staff_uc_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            ssid = int.Parse(txt_search.Text);
            conn.Open();
            string search = "select * from Staff where Staff_Id ='" + ssid + "'";
            SqlCommand cmd = new SqlCommand(search, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txt_id.Text = read["Staff_Id"].ToString();
                txt_fname.Text = read["First_Name"].ToString();
                txt_lname.Text = read["Last_Name"].ToString();
                txt_email.Text = read["E_Mail"].ToString();
                txt_mobilno.Text = read["Mobil_No"].ToString();
                txt_address.Text = read["Address"].ToString() ;
                dtp_dob.Text = read["Dob"].ToString();
                cmb_type.Text= read["Type"].ToString();
            }
            conn.Close();
            Loadgrid();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_fname.Clear();
            txt_lname.Clear();
            txt_email.Clear();
            txt_mobilno.Clear();
            txt_address.Clear();
            cmb_type.ResetText();
            txt_id.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ssid = int.Parse(txt_search.Text);
            conn.Open();
            string delete = "delete from Staff where Staff_Id='" + sid + "'";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data delete Successfully");
            conn.Close();
            Loadgrid();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string update = "update Staff set First_Name='" + fname + "',Last_Name='" + lname + "',Mobil_No='" + mobno + "',E_Mail='" + email + "',Address='" + address + "',Type='" + type + "',Dob='" + dob + "' where Staff_Id='" + ssid + "'";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data update Successfully");
            conn.Close();
            Loadgrid();
        }
        public staff_uc()
        {
            InitializeComponent();
        }
        private void Loadelement()
        {
            sid = int.Parse(txt_id.Text);
            mobno = int.Parse(txt_mobilno.Text);
            fname = txt_fname.Text;
            lname = txt_lname.Text;
            email = txt_email.Text;
            address = txt_address.Text;
            type = cmb_type.Text;
            dob = dtp_dob.Value.Date;
            //ssid = int.Parse(txt_search.Text);
        }
        private void Loadgrid()
        {
            conn.Open();
            string querry = "select * from Staff";
            SqlDataAdapter adapt =new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dgv_staff.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string insert = "Insert into Staff (Staff_Id, First_Name, Last_Name, Mobil_No, E_Mail, Address, Type, Dob) values('" + sid + "','" + fname + "','" + lname + "','" + mobno + "','" + email + "','" + address + "','" + type + "','" + dob + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Add Successfully");
            conn.Close();
            Loadgrid();
        }
    }
}
