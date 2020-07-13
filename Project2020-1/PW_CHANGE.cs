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
    public partial class PW_CHANGE : Form
    {
        bool check = false;
        public PW_CHANGE()
        {
            InitializeComponent();
        }

        private void button_accept_Click(object sender, EventArgs e)
        {
            if(check)
            {
                if (textBox_new_pw.Text != textBox_new_pw_2.Text)
                {
                    MessageBox.Show("변경할 비밀번호가 일치하지않습니다.");
                    return;
                }
                else
                {
                    MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
                    conn.Open();
                    string temp = String.Format("update user_info set password = '{0}'", textBox_new_pw.Text);
                    MySqlCommand cmd = new MySqlCommand(temp, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("비밀번호가 변경되었습니다.");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("현재 비밀번호를 확인해주십시오.");
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
            conn.Open();
            string temp = String.Format("select * from user_info where name = '{0}'",Form1.login_id);
            MySqlCommand cmd = new MySqlCommand(temp, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                temp = rdr["password"].ToString();
                if (temp == textBox_past_pw.Text)
                {
                    check = true;
                    textBox_past_pw.Enabled = false;
                    MessageBox.Show("확인되었습니다.");
                }
                else
                {
                    check = false;
                    MessageBox.Show("기존 비밀번호를 확인하십시오.");
                }
            }
        }
    }
}
