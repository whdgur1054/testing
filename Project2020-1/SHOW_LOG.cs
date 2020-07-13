using MySql.Data.MySqlClient;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Project2020_1
{
    public partial class SHOW_LOG : Form
    {
        DataGridViewRow data;
        Form1 dlg;
        string ori_id, ori_name;
        string name, type, price, maker, publisher, date, rating, rating_num, metacritic, link, text, genre_1, genre_2, genre_3;
        public SHOW_LOG()
        {
            InitializeComponent();
            
        }
        public SHOW_LOG(DataGridViewRow data, Form1 dlg)
        {
            InitializeComponent();
            this.data = data;
            this.dlg = dlg;
            textBox_name.Text = data.Cells[0].Value.ToString();
            name = ""; price = ""; maker = ""; publisher = ""; date = ""; rating = ""; rating_num = ""; metacritic = ""; link = ""; text = ""; genre_1 = ""; genre_2 = ""; genre_3 = "";
            update();
            ori_id = data.Cells[14].Value.ToString();
            ori_name = data.Cells[0].Value.ToString();
        }
        private void update()
        {
            MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
            conn.Open();
            string temp = String.Format("select id, time from change_log where gid = '{0}' order by time desc", data.Cells[14].Value.ToString());
            MySqlDataAdapter adapter = new MySqlDataAdapter(temp, conn); 
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 173;
            dataGridView1.Columns[1].Name = "변경시각";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
                conn.Open();
                string temp = String.Format("select * from change_log where id = {0}", dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                MySqlCommand cmd = new MySqlCommand(temp, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if(rdr.Read())
                {
                    temp = "수정한 IP : " + rdr["ip"].ToString() + "\r\n\r\n";
                    temp += String.Format("수정한 시각 : {0} \r\n\r\n", rdr["time"].ToString());
                    if(rdr["name"].ToString() != "")
                    {
                        int index = rdr["name"].ToString().IndexOf('/');
                        temp += String.Format("수정 전 이름 : {0} \r\n수정 후 이름 : {1} \r\n\r\n", rdr["name"].ToString().Substring(0, index), rdr["name"].ToString().Substring(index+1));
                        name = rdr["name"].ToString().Substring(0, index);
                    }
                    if(rdr["type"].ToString() != "")
                    {
                        int index = rdr["type"].ToString().IndexOf('/');
                        temp += String.Format("수정 전 타입 : {0} \r\n수정 후 타입 : {1} \r\n\r\n", rdr["type"].ToString().Substring(0, index), rdr["type"].ToString().Substring(index+1));
                        type = rdr["type"].ToString().Substring(0, index);
                    }
                    if (rdr["price"].ToString() != "")
                    {
                        int index = rdr["price"].ToString().IndexOf('/');
                        temp += String.Format("수정 전 가격 : {0} \r\n수정 후 가격 : {1} \r\n\r\n", rdr["price"].ToString().Substring(0, index), rdr["price"].ToString().Substring(index+1));
                        price = rdr["price"].ToString().Substring(0, index);
                    }
                    if (rdr["maker"].ToString() != "")
                    {
                        int index = rdr["maker"].ToString().IndexOf('/');
                        temp += String.Format("수정 전 제작사 : {0} \r\n수정 후 제작사 : {1} \r\n\r\n", rdr["maker"].ToString().Substring(0, index), rdr["maker"].ToString().Substring(index+1));
                        maker = rdr["maker"].ToString().Substring(0, index);
                    }
                    if (rdr["publisher"].ToString() != "")
                    {
                        int index = rdr["publisher"].ToString().IndexOf('/');
                        temp += String.Format("수정 전 배급사 : {0} \r\n수정 후 배급사 : {1} \r\n\r\n", rdr["publisher"].ToString().Substring(0, index), rdr["publisher"].ToString().Substring(index+1));
                        publisher = rdr["publisher"].ToString().Substring(0, index);
                    }
                    if (rdr["date"].ToString() != "")
                    {
                        int index = rdr["date"].ToString().IndexOf('/');
                        temp += String.Format("수정 전 출시 날짜 : {0} \r\n수정 후 출시 날짜 : {1} \r\n\r\n", rdr["date"].ToString().Substring(0, index), rdr["date"].ToString().Substring(index+1));
                        date = rdr["date"].ToString().Substring(0, index);
                    }
                    if (rdr["rating"].ToString() != "")
                    {
                        int index = rdr["rating"].ToString().IndexOf('/');
                        temp += String.Format("수정 전 평점 : {0} \r\n수정 후 평점 : {1} \r\n\r\n", rdr["rating"].ToString().Substring(0, index), rdr["rating"].ToString().Substring(index+1));
                        rating = rdr["rating"].ToString().Substring(0, index);
                    }
                    if (rdr["rating_num"].ToString() != "")
                    {
                        int index = rdr["rating_num"].ToString().IndexOf('/');
                        temp += String.Format("수정 전 평가인원 : {0} \r\n수정 후 평가인원 : {1} \r\n\r\n", rdr["rating_num"].ToString().Substring(0, index), rdr["rating_num"].ToString().Substring(index+1));
                        rating_num = rdr["rating_num"].ToString().Substring(0, index);
                    }
                    if (rdr["metacritic"].ToString() != "")
                    {
                        int index = rdr["metacritic"].ToString().IndexOf('/');
                        temp += String.Format("수정 전 MetaCritic점수 : {0} \r\n수정 후 MetaCritic점수 : {1} \r\n\r\n", rdr["metacritic"].ToString().Substring(0, index), rdr["metacritic"].ToString().Substring(index+1));
                        metacritic = rdr["metacritic"].ToString().Substring(0, index);
                    }
                    if (rdr["link"].ToString() != "")
                    {
                        int index = rdr["link"].ToString().IndexOf('/');
                        temp += String.Format("수정 전 참고 링크 : {0} \r\n수정 후 참고 링크 : {1} \r\n\r\n", rdr["link"].ToString().Substring(0, index), rdr["link"].ToString().Substring(index+1));
                        link = rdr["link"].ToString().Substring(0, index);
                    }
                    if (rdr["text"].ToString() != "")
                    {
                        int index = rdr["text"].ToString().IndexOf('/');
                        temp += String.Format("수정 전 상품 설명 : {0} \r\n수정 후 상품 설명 : {1} \r\n\r\n", rdr["text"].ToString().Substring(0, index), rdr["text"].ToString().Substring(index+1));
                        text = rdr["text"].ToString().Substring(0, index);
                    }
                    if (rdr["genre_1"].ToString() != "")
                    {
                        int index = rdr["genre_1"].ToString().IndexOf('/');
                        temp += String.Format("수정 전 장르1 : {0} \r\n수정 후 제작사 : {1} \r\n\r\n", rdr["genre_1"].ToString().Substring(0, index), rdr["genre_1"].ToString().Substring(index+1));
                        genre_1 = rdr["genre_1"].ToString().Substring(0, index);
                    }
                    if (rdr["genre_2"].ToString() != "")
                    {
                        int index = rdr["genre_2"].ToString().IndexOf('/');
                        temp += String.Format("수정 전 장르2 : {0} \r\n수정 후 장르2 : {1} \r\n\r\n", rdr["genre_2"].ToString().Substring(0, index), rdr["genre_2"].ToString().Substring(index+1));
                        genre_2 = rdr["genre_2"].ToString().Substring(0, index);
                    }
                    if (rdr["genre_3"].ToString() != "")
                    {
                        int index = rdr["genre_3"].ToString().IndexOf('/');
                        temp += String.Format("수정 전 장르3 : {0} \r\n수정 후 장르3 : {1} \r\n\r\n", rdr["genre_3"].ToString().Substring(0, index), rdr["genre_3"].ToString().Substring(index+1));
                        genre_3 = rdr["genre_3"].ToString().Substring(0, index);
                    }
                }
                textBox1.Text = temp;
                button_return.Visible = true;
            }
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            bool sql1 = false, sql2 = false;
            MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
            conn.Open();
            string temp = String.Format("select * from  game_info inner join game_genre on game_info.name = game_genre.name where game_info.id = '{0}'", data.Cells[14].Value.ToString());
            MySqlCommand cmd = new MySqlCommand(temp, conn);
            MySqlDataReader rdr= cmd.ExecuteReader();
            rdr.Read() ;
            temp = "update game_info set ";
            string temp_genre = "update game_genre set ";
            string temp_log = "insert into change_log values(NULL, ";
            temp_log = temp_log + String.Format("'{0}','", data.Cells[14].Value.ToString()) + GetIP() + "','" + System.DateTime.Now.ToString("yyyy-MM-dd, HH:mm:ss") + "', ";

            if (name != "")
            { temp += String.Format("name = '{0}',", name); temp_log += String.Format("'{0}/{1}',", rdr["name"].ToString(), name); sql1 = true; }
            else temp_log += "NULL,";
            if (type != "") { temp += String.Format("type = '{0}',", type); temp_log += String.Format("'{0}/{1}',",rdr["type"].ToString(),type); sql1 = true; }
            else temp_log += "NULL,";
            if (price != "") { temp += String.Format("price = '{0}',", price); temp_log += String.Format("'{0}/{1}',", rdr["type"].ToString(), type); sql1 = true; }
            else temp_log += "NULL,";
            if (maker != "") { temp += String.Format("maker = '{0}',", maker); temp_log += String.Format("'{0}/{1}',", rdr["maker"].ToString(), maker); sql1 = true; }
            else temp_log += "NULL,";
            if (publisher != "") { temp += String.Format("publisher = '{0}',", publisher); temp_log += String.Format("'{0}/{1}',", rdr["publisher"].ToString(), publisher); sql1 = true; }
            else temp_log += "NULL,"; 
            if (date != "") { temp += String.Format("date = '{0}',",date); temp_log += String.Format("'{0}/{1}',", rdr["date"].ToString(), date); sql1 = true; }
            else temp_log += "NULL,"; 
            if (rating != "") { temp += String.Format("rating = '{0}',",rating); temp_log += String.Format("'{0}/{1}',", rdr["rating"].ToString(), rating); sql1 = true; }
            else temp_log += "NULL,"; 
            if (rating_num != "") { temp += String.Format("rating_num = '{0}',",rating_num); temp_log += String.Format("'{0}/{1}',", rdr["rating_num"].ToString(), rating_num); sql1 = true; }
            else temp_log += "NULL,"; 
            if (metacritic != "") { temp += String.Format("metacritic = '{0}',",metacritic); temp_log += String.Format("'{0}/{1}',", rdr["metacritic"].ToString(), metacritic); sql1 = true; }
            else temp_log += "NULL,"; 
            if (text != "") { temp += String.Format("link = '{0}',",text); temp_log += String.Format("'{0}/{1}',", rdr["text"].ToString(), text); sql1 = true; }
            else temp_log += "NULL,"; 
            if (link != "") { temp += String.Format("text = '{0}',", link); temp_log += String.Format("'{0}/{1}',", rdr["link"].ToString(), link); sql1 = true; }
            else temp_log += "NULL,"; 
            if (genre_1 != "") { temp_genre += String.Format("genre_1 = '{0}',",genre_1); temp_log += String.Format("'{0}/{1}',", rdr["genre_1"].ToString(), genre_1); sql2 = true; }
            else temp_log += "NULL,"; 
            if (genre_2 != "") { temp_genre += String.Format("genre_2 = '{0}',",genre_2); temp_log += String.Format("'{0}/{1}',", rdr["genre_2"].ToString(), genre_2); sql2 = true; }
            else temp_log += "NULL,"; 
            if (genre_3 != "") { temp_genre += String.Format("genre_3 = '{0}',", genre_3); temp_log += String.Format("'{0}/{1}',", rdr["genre_3"].ToString(), genre_3); sql2 = true; }
            else temp_log += "NULL,";

            temp = temp.Substring(0, temp.Length - 1) + String.Format("where id = '{0}'",data.Cells[14].Value.ToString());
            temp_genre = temp_genre.Substring(0, temp_genre.Length - 1) + String.Format("where name = '{0}'", data.Cells[0].Value.ToString());
            temp_log = temp_log.Substring(0, temp_log.Length - 1) + ")";
            rdr.Close();
            if(sql2)
            {
                cmd.CommandText = temp_genre;
                cmd.ExecuteNonQuery();
            }
            if (sql1)
            {
                cmd.CommandText = temp;
                cmd.ExecuteNonQuery();
            }
            cmd.CommandText = temp_log;
            cmd.ExecuteNonQuery();
            dlg.import_database();
            dlg.update_datagridview();
            data.Cells[0].Value = ori_name;
            data.Cells[14].Value = ori_id;
            update();
        }
        private string GetIP()
        {
            string strHostName = "";
            strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            return addr[addr.Length - 1].ToString();
        }
    }
}
