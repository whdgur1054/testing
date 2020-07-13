using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2020_1
{
    public partial class USERS_RATE : Form
    {
        DataGridViewRow data;
        DataTable ds = new DataTable();
        public USERS_RATE(DataGridViewRow data)
        {
            InitializeComponent();
            this.data = data;

            
            add_rows();            
        }

        public void add_rows()
        {
            MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
            conn.Open();
            string temp = String.Format("select * from game_rate where g_name = '{0}'", data.Cells[0].Value.ToString());
            //MessageBox.Show(temp);
            MySqlDataAdapter adapter = new MySqlDataAdapter(temp, conn);
            adapter.Fill(ds);
            MySqlCommand cmd = new MySqlCommand(temp, conn);
            for(int i = 0; i< ds.Rows.Count; i++)
            {
                string rate;
                if (ds.Rows[i][2].ToString() == "1") rate = "좋아요";
                else rate = "싫어요";
                string[] row = { ds.Rows[i][0].ToString(), rate, ds.Rows[i][3].ToString() };
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
