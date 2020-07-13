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
using System.Net;

namespace Project2020_1
{
    public partial class GAME_INFO : Form
    {
        int focus_text = -1;
        DataGridViewRow data;
        string origin_name, origin_type, origin_price, origin_maker, origin_publisher  , origin_rate, origin_rate_num, origin_metacritic;
        DateTime origin_date;
        //int origin_rate, origin_rate_num, origin_metacritic;
        string origin_link, origin_desc, origin_genre_1, origin_genre_2, origin_genre_3;
        string update_sql_1, update_sql_2, update_sql_3;
        Form1 dlg = new Form1();

        private void button_rate_Click(object sender, EventArgs e)
        {
            if (Form1.login)
            {
                RATE_GAME dlg = new RATE_GAME(origin_name);
                dlg.ShowDialog();
            }
            else
            {
                MessageBox.Show("평가를 위해서는 로그인이 필요합니다.");
            }
        }

        private void button_see_rate_Click(object sender, EventArgs e)
        {
            USERS_RATE dlg = new USERS_RATE(data);
            dlg.Show();
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

        private void textBox_rate_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox_rate.Text) > 100)
            {
                MessageBox.Show("100 이하의 수만 입력 가능합니다");
                textBox_rate.Text = "0";
            }
        }

        private void textBox_meta_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox_meta.Text) > 100)
            {
                MessageBox.Show("100 이하의 수만 입력 가능합니다");
                textBox_meta.Text = "0";
            }
        }

        private void textBox_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        int id;
        private void button_log_Click(object sender, EventArgs e)
        {
            SHOW_LOG dlg = new SHOW_LOG(data, this.dlg);
            dlg.Show();
        }

        bool sql1, sql2, sql3;

        public GAME_INFO(DataGridViewRow name, Form1 dlg)
        {
            InitializeComponent();
            this.data = name;
            this.dlg = dlg;
            id = Int32.Parse(data.Cells[14].Value.ToString());
            initiate();
        }

        private void initiate()
        {
            textBox_name.Text = data.Cells[0].Value.ToString();
            if (data.Cells[1].Value.ToString() == "GAME")
            {
                radioButton_game.Checked = true;
                origin_type = "GAME";
            }

            else
            {
                radioButton_dlc.Checked = true;
                origin_type = "DLC";
            }
            textBox_price.Text = data.Cells[2].Value.ToString();
            textBox_maker.Text = data.Cells[3].Value.ToString();
            textBox_publisher.Text = data.Cells[4].Value.ToString();
            try { dateTimePicker1.Value = DateTime.Parse(data.Cells[5].Value.ToString()); }
            catch { dateTimePicker1.Value = DateTime.ParseExact("1901,01,01", "yyyy,mm,dd", null); }            
            textBox_rate.Text = data.Cells[6].Value.ToString();
            textBox_rate_num.Text = data.Cells[7].Value.ToString();
            textBox_meta.Text = data.Cells[8].Value.ToString();
            textBox1_desc.Text = data.Cells[9].Value.ToString();
            textBox_site.Text = data.Cells[10].Value.ToString();
            textBox_genre1.Text = data.Cells[11].Value.ToString();
            textBox_genre2.Text = data.Cells[12].Value.ToString();
            textBox_genre3.Text = data.Cells[13].Value.ToString();

            origin_name = textBox_name.Text;
            origin_price = textBox_price.Text;
            origin_maker = textBox_maker.Text;
            origin_publisher = textBox_publisher.Text;
            origin_date = dateTimePicker1.Value;
            origin_rate = textBox_rate.Text;//Int32.Parse(textBox_rate.Text);
            origin_rate_num = textBox_rate_num.Text;//Int32.Parse(textBox_rate_num.Text);
            origin_metacritic = textBox_meta.Text;//Int32.Parse(textBox_meta.Text);
            origin_link = textBox_site.Text;
            origin_desc = textBox1_desc.Text;
            origin_genre_1 = textBox_genre1.Text;
            origin_genre_2 = textBox_genre2.Text;
            origin_genre_3 = textBox_genre3.Text;


            sql1 = false;
            sql2 = false;
            sql3 = false;
        }

        private void textBox_site_Click(object sender, EventArgs e)
        {
            if (textBox_site.ReadOnly == false) return;
            System.Diagnostics.Process.Start(textBox_site.Text);
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            set_readonly(false);
        }

        private void set_readonly(bool input)
        {
            textBox_name.ReadOnly = input;
            radioButton_dlc.Enabled = !input;
            radioButton_game.Enabled = !input;
            textBox_price.ReadOnly = input;
            textBox_maker.ReadOnly = input;
            textBox_publisher.ReadOnly = input;
            dateTimePicker1.Enabled = !input;
            textBox_rate.ReadOnly = input;
            textBox_rate_num.ReadOnly = input;
            textBox_meta.ReadOnly = input;
            textBox_genre1.ReadOnly = input;
            textBox_genre2.ReadOnly = input;
            textBox_genre3.ReadOnly = input;
            textBox_site.ReadOnly = input;
            textBox1_desc.ReadOnly = input;
            button_accept.Visible = !input;
            button_cancel.Visible = !input;
            dataGridView1.Visible = !input;
        }

        private void button_accept_Click(object sender, EventArgs e)
        {
            set_readonly(true);
            check_change();
            origin_name = textBox_name.Text;
            origin_price = textBox_price.Text;
            origin_maker = textBox_maker.Text;
            origin_publisher = textBox_publisher.Text;
            origin_date = dateTimePicker1.Value;
            origin_rate = textBox_rate.Text;//Int32.Parse(textBox_rate.Text);
            origin_rate_num = textBox_rate_num.Text;//Int32.Parse(textBox_rate_num.Text);
            origin_metacritic = textBox_meta.Text;//Int32.Parse(textBox_meta.Text);
            origin_link = textBox_site.Text;
            origin_desc = textBox1_desc.Text;
            origin_genre_1 = textBox_genre1.Text;
            origin_genre_2 = textBox_genre2.Text;
            origin_genre_3 = textBox_genre3.Text;
            dlg.import_database();
            dlg.update_datagridview();
            data.Cells[0].Value = textBox_name.Text;
            data.Cells[14].Value = id;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소하였습니다."); 
            textBox_name.Text = origin_name;
            textBox_price.Text = origin_price;
            textBox_maker.Text = origin_maker;
            textBox_publisher.Text = origin_publisher;
            dateTimePicker1.Value = origin_date;
            textBox_rate.Text = origin_rate;//Int32.Parse(textBox_rate.Text);
            textBox_rate_num.Text = origin_rate_num;//Int32.Parse(textBox_rate_num.Text);
            textBox_meta.Text = origin_metacritic;//Int32.Parse(textBox_meta.Text);
            textBox_site.Text = origin_link;
            textBox1_desc.Text = origin_desc;
            textBox_genre1.Text = origin_genre_1;
            textBox_genre2.Text = origin_genre_2;
            textBox_genre3.Text = origin_genre_3;
            set_readonly(true);
        }

        private void check_change()
        {
            update_sql_1 = "update game_info set ";
            update_sql_2 = "update game_genre set ";
            update_sql_3 = "insert into change_Log values (NULL, ";
            MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
            conn.Open();
            string temp = String.Format("select id from game_info where name = '{0}'", origin_name);
            MySqlCommand cmd = new MySqlCommand(temp, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            string id="NULL";
            if (rdr.Read())
            {
                id = rdr["id"].ToString();
            }
            rdr.Close();
            update_sql_3 = update_sql_3 + id + ", '";
            update_sql_3 = update_sql_3 + GetIP() + "', '";

            update_sql_3 = update_sql_3 + System.DateTime.Now.ToString("yyyy-MM-dd, HH:mm:ss") + "', ";
            if(origin_name == textBox_name.Text)
            {
                update_sql_3 += "NULL, ";
            }
            else
            {
                update_sql_1 += String.Format("name = '{0}', ", textBox_name.Text.Replace("'","\\'"));
                update_sql_2 += String.Format("name = '{0}', ", textBox_name.Text.Replace("'","\\'"));
                update_sql_3 += String.Format("'{0}/{1}', ", origin_name,textBox_name.Text.Replace("'","\\'"));
                sql1 = true; sql2 = true; sql3 = true;
            }

            if (radioButton_dlc.Checked)
            {
                if(origin_type == "DLC")
                {
                    update_sql_3 += "NULL, ";
                }
                else
                {
                    update_sql_1 += "type = 'DLC', ";
                    update_sql_3 += "'GAME/DLC', ";
                    sql1 = true; sql3 = true;
                }
            }
            else
            {
                if(origin_type == "GAME")
                {
                    update_sql_3 += "NULL, ";
                }
                else
                {
                    update_sql_1 += "type = 'GAME', ";
                    update_sql_3 += "'DLC/GAME', ";
                    sql1 = true; sql3 = true;
                }
            }

            if(origin_price == textBox_price.Text)
            {
                update_sql_3 += "NULL, ";
            }
            else
            {
                update_sql_1 += String.Format("price = '{0}', ", textBox_price.Text.Replace("'","\\'"));
                update_sql_3 += String.Format("'{0}/{1}', ", origin_price, textBox_price.Text.Replace("'","\\'"));
                sql1 = true; sql3 = true;
            }

            if(origin_maker == textBox_maker.Text)
            {
                update_sql_3 += "NULL, ";
            }
            else
            {
                update_sql_1 += String.Format("maker = '{0}', ", textBox_maker.Text.Replace("'","\\'"));
                update_sql_3 += String.Format("'{0}/{1}', ", origin_maker, textBox_maker.Text.Replace("'","\\'"));
                sql1 = true; sql3 = true;
            }

            if(origin_publisher == textBox_publisher.Text)
            {
                update_sql_3 += "NULL, ";
            }
            else
            {
                update_sql_1 += String.Format("publisher = '{0}', ", textBox_publisher.Text.Replace("'","\\'"));
                update_sql_3 += String.Format("'{0}/{1}', ", origin_publisher, textBox_publisher.Text.Replace("'","\\'"));
                sql1 = true; sql3 = true;
            }

            if(origin_date == dateTimePicker1.Value)
            {
                update_sql_3 += "NULL, ";
            }
            else
            {
                update_sql_1 += String.Format("date = '{0}', ", dateTimePicker1.Value);
                update_sql_3 += String.Format("'{0}/{1}', ", origin_date, dateTimePicker1.Value);
                sql1 = true; sql3 = true;
            }

            if(origin_rate == /*Int32.Parse(*/textBox_rate.Text/*)*/)
            {
                update_sql_3 += "NULL, ";
            }
            else
            {
                update_sql_1 += String.Format("rating = '{0}', ", /*Int32.Parse(*/textBox_rate.Text.Replace("'","\\'")/*)*/);
                update_sql_3 += String.Format("'{0}/{1}', ", origin_rate, textBox_rate.Text.Replace("'","\\'"));
                sql1 = true; sql3 = true;
            }


            if(origin_rate_num == /*Int32.Parse(*/textBox_rate_num.Text/*)*/)
            {
                update_sql_3 += "NULL, ";
            }
            else
            {
                update_sql_1 += String.Format("rating_num = '{0}', ", textBox_rate_num.Text.Replace("'","\\'"));
                update_sql_3 += String.Format("'{0}/{1}', ", origin_rate_num, textBox_rate_num.Text.Replace("'","\\'"));
                sql1 = true; sql3 = true;
            }

            if(origin_metacritic == /*Int32.Parse(*/textBox_meta.Text/*)*/)
            {
                update_sql_3 += "NULL, ";
            }
            else
            {
                update_sql_1 += String.Format("metacritic = '{0}', ", textBox_meta.Text.Replace("'","\\'"));
                update_sql_3 += String.Format("'{0}/{1}', ", origin_metacritic, textBox_meta.Text.Replace("'","\\'"));
                sql1 = true; sql3 = true;
            }

            if(origin_link == textBox_site.Text)
            {
                update_sql_3 += "NULL, ";
            }
            else
            {
                update_sql_1 += String.Format("link = '{0}', ", textBox_site.Text.Replace("'","\\'"));
                update_sql_3 += String.Format("'{0}/{1}', ", origin_link, textBox_site.Text.Replace("'","\\'"));
                sql1 = true; sql3 = true;
            }

            if(origin_desc == textBox1_desc.Text)
            {
                update_sql_3 += "NULL, ";
            }
            else
            {
                update_sql_1 += String.Format("text = '{0}', ", textBox1_desc.Text.Replace("'","\\'"));
                update_sql_3 += String.Format("'{0}/{1}', ", origin_desc, textBox1_desc.Text.Replace("'","\\'"));
                sql1 = true; sql3 = true;
            }

            update_sql_1 = update_sql_1.Substring(0, update_sql_1.Length - 2);
            update_sql_1 += String.Format(" where name = '{0}'", origin_name);

            if(origin_genre_1 == textBox_genre1.Text)
            {
                update_sql_3 += "NULL, ";
            }
            else
            {
                update_sql_2 += String.Format("genre_1 = '{0}', ", textBox_genre1.Text.Replace("'","\\'"));
                update_sql_3 += String.Format("'{0}/{1}', ", origin_genre_1, textBox_genre1.Text.Replace("'","\\'"));
                sql2 = true; sql3 = true;
            }

            if(origin_genre_2 == textBox_genre2.Text)
            {
                update_sql_3 += "NULL, ";
            }
            else
            {
                update_sql_2 += String.Format("genre_2 = '{0}', ",textBox_genre2.Text.Replace("'","\\'"));
                update_sql_3 += String.Format("'{0}/{1}', ", origin_genre_2, textBox_genre2.Text.Replace("'","\\'"));
                sql2 = true; sql3 = true;
            }

            if(origin_genre_3 == textBox_genre3.Text)
            {
                update_sql_3 += "NULL)";
            }
            else
            {
                update_sql_2 += String.Format("genre_3 = '{0}', ", textBox_genre3.Text.Replace("'","\\'"));
                update_sql_3 += String.Format("'{0}/{1}')", origin_genre_3,textBox_genre3.Text.Replace("'","\\'"));
                sql2 = true; sql3 = true;
            }

            update_sql_2 = update_sql_2.Substring(0, update_sql_2.Length - 2);
            update_sql_2 += String.Format(" where name = '{0}'", origin_name);
            
            if(sql1)
            {
                cmd.CommandText = update_sql_1;
                //MessageBox.Show(update_sql_1);
                cmd.ExecuteNonQuery();
            }
            if(sql2)
            {
                cmd.CommandText = update_sql_2;
                cmd.ExecuteNonQuery();
            }
            if(sql3)
            {
                cmd.CommandText = update_sql_3;
                //MessageBox.Show(update_sql_3);
                cmd.ExecuteNonQuery();
            }
        }

        private string GetIP() { 
            string strHostName = ""; 
            strHostName = System.Net.Dns.GetHostName(); 
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName); 
            IPAddress[] addr = ipEntry.AddressList; 
            return addr[addr.Length - 1].ToString(); 
        }

        
    }
}
