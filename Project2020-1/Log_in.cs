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
    public partial class Log_in : Form
    {
        
        public Log_in()
        {
            InitializeComponent();
        }

        private void button_LOG_IN_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text != "" && textBox_PW.Text != "")
            {
                MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
                conn.Open();
                string temp = String.Format("select * from user_info where name = \'{0}\'", textBox_ID.Text.Replace("'","\\'"));
                MySqlCommand cmd = new MySqlCommand(temp, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();  //오류
                temp = "";
                if (rdr.Read())
                    temp += rdr["password"].ToString();
                if (temp == textBox_PW.Text)
                {
                    MessageBox.Show("로그인되었습니다.");
                    Form1.login = true;
                    Form1.login_id = textBox_ID.Text;
                    Close();

                }
                else
                    MessageBox.Show("아이디와 비밀번호를 확인하시오.");
            }
            else
                MessageBox.Show("아이디와 비밀번호를 확인하시오.");
        }

        private void button_SIGN_IN_Click(object sender, EventArgs e)
        {
            SIGN_IN dlg = new SIGN_IN();
            dlg.ShowDialog();
        }
    }
}
