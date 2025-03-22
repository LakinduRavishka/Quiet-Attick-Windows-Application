using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quiet_attick_production
{
    public partial class paymentuc : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RUSH-DESKTOP\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True;Encrypt=False");
        int bid,cid, amount;
        string proname;
        DateTime date;
        public paymentuc()
        {
            InitializeComponent();
        }
        private void LoadConvert() 
        {
            cid = int.Parse(txt_clientid.Text.ToString());
            bid = int.Parse(txt_bid.Text.ToString());
            amount = int.Parse(txt_amount.Text.ToString());
            proname = txt_proid.Text;
            date = pik_date.Value.Date;
        }

        private void dgv_payment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_bid.Clear();
            txt_amount.Clear();
            txt_proid.Clear();
            txt_clientid.Clear();
        }

        private void paymentuc_Load(object sender, EventArgs e)
        {

        }

        private void btn_adpay_Click(object sender, EventArgs e)
        {
            LoadConvert();
            conn.Open();
            string insert = "Insert into NPayment (Bill_Id, Client_Id, Amount, Date, Production_Name) Values ('" + bid + "','" + cid + "','" + amount + "', '" + date + "','" + proname + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Payment successful");
            conn.Close();
            Loadgrid();
            
        }
        private void Loadgrid()
        {
            conn.Open();
            string querry = "select * from NPayment";
            SqlDataAdapter adapt = new SqlDataAdapter(querry, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dgv_payment.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }

    }
}
