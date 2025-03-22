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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace quiet_attick_production
{
    public partial class property_uc : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RUSH-DESKTOP\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True;Encrypt=False");
        int id, iid;
        string name, des, type;
        public property_uc()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string update = "update Property set Name= '" + name + "',Description= '" + des + "',Type='" + type + "' where Property_Id='" + id + "'";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Successfully");
            conn.Close();
            Loadgrid();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            id = int.Parse(txt_search.Text);
            conn.Open();
            string delete = "delete from Property where Property_Id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Successfully");
            conn.Close();
            Loadgrid();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            iid = int.Parse(txt_search.Text);
            conn.Open();
            string search = "select * from  Property where Property_Id = '" + iid + "'";
            SqlCommand cmd = new SqlCommand(search, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txt_name.Text = read["Name"].ToString();
                txt_descrip.Text = read["Description"].ToString();
                cmb_type.Text = read["Type"].ToString();
            }
            conn.Close();
            Loadgrid();
        }

        private void property_uc_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_descrip.Clear();
            cmb_type.ResetText();
        }

        private void Loadelement()
        {
            id = int.Parse(txt_id.Text.ToString());
            name = txt_name.Text;
            des = txt_descrip.Text;
            type = cmb_type.Text;
        }
        private void Loadgrid()
        {
            conn.Open();
            string querry = "select * from Property";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgv_property.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string insert = "Insert into Property (Property_Id, Name, description, Type) values ('" + id + "','" + name + "','" + des + "','" + type + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add Successfully");
            conn.Close();
            Loadgrid();
        }
    }
}
