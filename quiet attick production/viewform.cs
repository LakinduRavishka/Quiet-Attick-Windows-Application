using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiet_attick_production
{
    public partial class viewform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RUSH-DESKTOP\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True;Encrypt=False");
        public viewform()
        {
            InitializeComponent();
        }

        private void dgv_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewform_Load(object sender, EventArgs e)
        {
            conn.Open();
            string querry = "select * from Client";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgv_client.DataSource = ds.Tables[0].DefaultView;
            conn.Close();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            staff stf = new staff();
            stf.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to exit","Application Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgv_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
