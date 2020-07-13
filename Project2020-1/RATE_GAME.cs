using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project2020_1
{
    public partial class RATE_GAME : Form
    {
        public RATE_GAME(string name)
        {
            InitializeComponent();
            textBox_name.Text = name;
            DataGridViewCellEventArgs e = new DataGridViewCellEventArgs(0,0);
            object sender = new object();
            dataGridView1_CellClick(sender, e);
        }
        public RATE_GAME()
        {
            InitializeComponent();
        }

        bool check = false;
        bool update = false;

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
            conn.Open();
            string temp = String.Format("select name, id from game_info where name like '%{0}%'",textBox_name.Text.Replace("'","\\'"));
            MySqlDataAdapter adapter = new MySqlDataAdapter(temp, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "이름";
            dataGridView1.Columns[0].Width = 760;
            dataGridView1.Columns[1].Visible = false;
            check = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                textBox_name.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                check = true;
            }
            MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
            conn.Open();
            string temp = String.Format("select * from game_rate where g_name = '{0}' and u_name = '{1}'", dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),Form1.login_id);
            MySqlCommand cmd = new MySqlCommand(temp, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                update = true;
                if (rdr["rate"].ToString() == "1") radioButton_good.Checked = true;
                else radioButton_bad.Checked = true;

                textBox_desc.Text = rdr["text"].ToString();
            }
            else update = false;
            
        }

        private void button_accept_Click(object sender, EventArgs e)
        {
            if(check && !update)
            {
                MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
                conn.Open();
                int rate;
                if (radioButton_good.Checked) rate = 1;
                else rate = 0;

                string temp = String.Format("insert into game_rate values('{0}', '{1}', '{2}', '{3}')", Form1.login_id, textBox_name.Text.Replace("'","\\'"), rate, textBox_desc.Text.Replace("'","\\'"));
                MySqlCommand cmd = new MySqlCommand(temp, conn);
                cmd.CommandText = temp;
                cmd.ExecuteNonQuery();

                MessageBox.Show("평가하였습니다.");
            }
            else if (check && update)
            {
                MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
                conn.Open();
                int rate;
                if (radioButton_good.Checked) rate = 1;
                else rate = 0;

                string temp = String.Format("update game_rate set rate = '{2}', text = '{3}' where g_name = '{1}' and u_name = '{0}'", Form1.login_id, textBox_name.Text.Replace("'","\\'"), rate, textBox_desc.Text.Replace("'","\\'"));
                MySqlCommand cmd = new MySqlCommand(temp, conn);
                cmd.CommandText = temp;
                cmd.ExecuteNonQuery();

                MessageBox.Show("평가를 수정하였습니다.");
            }
        }
    }
}
