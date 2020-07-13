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
    public partial class SIGN_IN : Form
    {
        bool check = false;
        public SIGN_IN()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text.Replace("'","\\'") != "")
            {
                MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
                conn.Open();
                string temp = String.Format("select count(*) from user_info where name = \'{0}\'", textBox_ID.Text.Replace("'","\\'"));
                MySqlCommand cmd = new MySqlCommand(temp, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (Int32.Parse(rdr["count(*)"].ToString()) > 0)
                    {
                        check = false;
                        MessageBox.Show("이미 존재하는 아이디입니다.");
                    }
                    else
                    {
                        check = true;
                        MessageBox.Show("확인되었습니다.");
                    }
                }
            }
            else
                MessageBox.Show("아이디를 입력하여 주십시오.");
            
        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {
            check = false;
        }

        private void button_accept_Click(object sender, EventArgs e)
        {
            if (check)
            {
                if(textBox_PW.Text.Replace("'","\\'") == textBox_PW_2.Text.Replace("'","\\'"))
                {
                    MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
                    conn.Open();
                    string temp = String.Format("insert into user_info values('{0}', '{1}')", textBox_ID.Text.Replace("'","\\'"), textBox_PW.Text.Replace("'","\\'"));
                    MySqlCommand cmd = new MySqlCommand(temp, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("회원가입을 완료하였습니다.");
                    Close();
                }
                else
                {
                    MessageBox.Show("비밀번호를 확인해 주십시오.");
                }
            }
            else
            {
                MessageBox.Show("아이디 확인을 해주십시오.");
            }
        }
    }
}
