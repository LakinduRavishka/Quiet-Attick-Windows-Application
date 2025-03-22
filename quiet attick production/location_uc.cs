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
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace quiet_attick_production
{
    public partial class location_uc : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RUSH-DESKTOP\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True;Encrypt=False");
        int id,rent,iid;
        string name, type; 
        public location_uc()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string update = "update location set Name= '" + name + "',Type= '" + type + "',Rent_Cost='" + rent + "' where Location_Id='" + id + "'";
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
            string delete = "delete from Location where Location_Id = '" + iid + "'";
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
            string search = "select * from  Location where Location_Id = '" + iid + "'";
            SqlCommand cmd = new SqlCommand(search, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txt_name.Text = read["Name"].ToString();
                txt_rentcost.Text = read["Rent_Cost"].ToString();
                if (read["Type"].ToString() == "Indoor")
                {
                    rdo_indoor.Checked = true;
                }
                else if (read["Type"].ToString() == "Outdoor")
                {
                    rdo_outdoor.Checked = true;
                }
                else
                {
                    rdo_studio.Checked = true;
                }
            }
            conn.Close();
            Loadgrid();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_rentcost.Clear();
            rdo_indoor.Checked = false;
            rdo_outdoor.Checked=false;
            rdo_studio.Checked=false;
        }

        private void location_uc_Load(object sender, EventArgs e)
        {

        }

        private void Loadelement()
        {
            id = int.Parse(txt_id.Text);
            rent = int.Parse(txt_rentcost.Text);
            name = txt_name.Text;
            if (rdo_indoor.Checked == true)
            {
                type = "Indoor";
            }
            else if (rdo_outdoor.Checked == true)
            {
                type = "Outdoor";
            }
            else
            {
                type = "Studio";
            }
        }
        private void Loadgrid()
        {
            conn.Open();
            string querry = "select * from Location";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgv_location.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string insert = "Insert into Location (Location_Id, Name, Type, Rent_Cost) values ('" + id + "','" + name + "','" + type + "','" + rent + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add Successfully");
            conn.Close();
            Loadgrid();
        }
    }
}
