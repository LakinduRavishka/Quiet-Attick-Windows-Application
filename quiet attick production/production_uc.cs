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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace quiet_attick_production
{
    public partial class production_uc : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RUSH-DESKTOP\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True;Encrypt=False");
        int id,pid;
        string title, type;
        DateTime Sdate, edate;
        public production_uc()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void production_uc_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string update = "update Production set Title= '" + title + "',Type= '" + type + "',Start_Date='" + Sdate + "',End_Date='" + edate + "' where Production_Id='" + id + "'";
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
            string delete = "delete from Production where Production_Id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Successfully");
            conn.Close();
            Loadgrid();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            pid = int.Parse(txt_search.Text);
            conn.Open();
            string search = "select * from Production where Production_id = '" + pid + "'";
            SqlCommand cmd = new SqlCommand(search, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txt_title.Text = read["Title"].ToString();
                if (read["Type"].ToString() == "Short_Film")
                {
                    rdo_short.Checked = true;
                }
                else
                {
                    rdo_ads.Checked = true;
                }
                dtp_start.Text = read["Start_Date"].ToString();
                dtp_end.Text = read["End_Date"].ToString();
            }
            conn.Close();
            Loadgrid();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_title.Clear();
            txt_search.Clear();
            rdo_ads.Checked= false;
            rdo_short.Checked= false;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Loadelement();
            conn.Open();
            string insert = "Insert into Production (Production_Id, Title, Type, Start_Date, End_Date) values ('" + id + "','" + title + "','" + type + "','" + Sdate + "','" + edate + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add Successfully");
            conn.Close();
            Loadgrid();
        }
        private void Loadelement()
        {
            id = int.Parse(txt_id.Text);
            title = txt_title.Text;
            if (rdo_short.Checked == true)
            {
                type = "Short";
            }
            else
            {
                type = "Ads";
            }
            Sdate = dtp_start.Value.Date;
            edate = dtp_end.Value.Date;
        }
        private void Loadgrid()
        {
            conn.Open();
            string querry = "select * from Production";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgv_production.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }
    }
}
