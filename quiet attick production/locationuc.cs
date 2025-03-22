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
using System.Data.SqlClient;

namespace quiet_attick_production
{
    public partial class locationuc : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RUSH-DESKTOP\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True;Encrypt=False");
        public locationuc()
        {
            InitializeComponent();
        }

        private void locationuc_Load(object sender, EventArgs e)
        {
            conn.Open();
            string querry = "select * from Location";
            SqlDataAdapter adapt = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dgv_location.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }
    }
}
