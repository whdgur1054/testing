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
using System.Runtime.InteropServices;

namespace Project2020_1
{
    public partial class ADD_GAME : Form
    {
        int focus_text = -1;
        bool check = false;
        string type = "";
        Form1 dlg = new Form1();
        public ADD_GAME(Form1 dlg)
        {
            InitializeComponent();
            this.dlg = dlg;
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
            conn.Open();
            string temp = String.Format("select name from game_info where name = '{0}'",textBox_name.Text);
            MySqlCommand cmd = new MySqlCommand(temp, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            
            if (rdr.Read())
            {
                if(textBox_name.Text == rdr["name"].ToString())
                {
                    MessageBox.Show("이미 존재하는 게임입니다.");
                }
                
            }
            else
            {
                MessageBox.Show("확인되었습니다.");
                check = true;
            }
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            check = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (type == "") MessageBox.Show("타입을 선택하여 주십시오.");

            else if (check)
            {
                string temp = @String.Format("insert into game_info values(NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', 0, 0, '{6}', '{7}', '{8}');", textBox_name.Text.Replace("'", "\\'"), type, textBox_price.Text, textBox_maker.Text.Replace("'", "\\'"), textBox_publisher.Text.Replace("'", "\\'")
                    , dateTimePicker1.Value, textBox_metascore.Text.Replace("'", "\\'"), textBox_desc.Text.Replace("'", "\\'"), textBox_site.Text.Replace("'", "\\'"));

                temp += @String.Format("insert into game_genre values(NULL, '{0}', '{1}', '{2}', '{3}')", textBox_name.Text.Replace("'", "\\'"), textBox_genre1.Text.Replace("'", "\\'"), textBox_genre2.Text.Replace("'", "\\'"), textBox_genre3.Text.Replace("'", "\\'"));

                MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(temp, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("추가되었습니다.");
                dlg.import_database();
                dlg.update_datagridview();
            }
            else
            {
                MessageBox.Show("중복확인을 해주십시오.");
            }
        }

        private void radioButton_game_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_game.Checked == true)
                type = "GAME";
            else
                type = "DLC";

        }

        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void textBox_metascore_TextChanged(object sender, EventArgs e)
        {
            if(Int32.Parse(textBox_metascore.Text) > 100)
            {
                MessageBox.Show("100 이하의 수만 입력 가능합니다");
                textBox_metascore.Text = "0";
            }
        }

        private void textBox_genre1_TextChanged(object sender, EventArgs e)
        {
            focus_text = 1;
            MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
            conn.Open();
            string temp = String.Format("call genre_all(\'%{0}%\');", textBox_genre1.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(temp, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "장르";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void textBox_genre2_TextChanged(object sender, EventArgs e)
        {

            focus_text = 2;
            MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
            conn.Open();
            string temp = String.Format("call genre_all(\'%{0}%\');", textBox_genre2.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(temp, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "장르";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void textBox_genre3_TextChanged(object sender, EventArgs e)
        {

            focus_text = 3;
            MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
            conn.Open();
            string temp = String.Format("call genre_all(\'%{0}%\');", textBox_genre3.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(temp, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "장르";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (focus_text)
            {
                case 1:
                    textBox_genre1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    break;
                case 2:
                    textBox_genre2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    break;
                case 3:
                    textBox_genre3.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    break;

            }
        }
    }
}
