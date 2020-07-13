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
    public partial class Form1 : Form
    {
        static public bool login;
        static public string login_id;
        static public string MYSQL_LOG_IN = "server = localhost; database = test2; uid = test; pwd = testing;convert zero datetime=True";
        static public DataTable origin_datatable = new DataTable(); 
        static public DataTable refine_datatable = new DataTable();
        static public string query = "";

        static public int asd_once = 0;             //체크 -> 체크해제,  체크해제 -> 체크 로 인해 2번 발생하는것을 막기위해 asd_once 사용
        static public int passing_from_asd = 0;     //체크리스트_장르의 정렬을할때 임의로 setitemChecked 사용시 checkedListBox_GENRE_ItemCheck 이벤트가 일어나는것을 방지
        //public ArrayList genre_all = new ArrayList();


        /*struct Genre
        {
            public string name;
            public int count;
        };*/


        public Form1()
        {
            InitializeComponent();
            update_genre();
            import_database();
            refine_datatable = origin_datatable.Clone();
            radioButton_ALL.Checked = true;
        }

        static List<Genre> genre_all = new List<Genre>();
        static List<Genre> sorted_genre_all = new List<Genre>();
        public ArrayList selected_gerne = new ArrayList();

        private void toolStrip_LOG_IN_Click(object sender, EventArgs e)
        {
            Log_in dlg = new Log_in();
            dlg.ShowDialog();
            if (login)
            {
                string name = String.Format("{0}님 로그인 되었습니다.", login_id);
                toolStripStatusLabel1.Text = name;
            }
        }

        private void toolStrip_LOG_OUT_Click(object sender, EventArgs e)
        {
            if(login == true)
            {
                login = false;
                MessageBox.Show("로그아웃 되었습니다.");
                toolStripStatusLabel1.Text = "로그인해주십시오.";
            }
        }

        private void update_genre()
        {
            MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
            conn.Open();
            string temp = "call genre_all('%%')";
            MySqlCommand cmd = new MySqlCommand(temp, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            genre_all.Clear();
            while (rdr.Read())
            {
                string str_temp = String.Format("{0}({1})",rdr["genre_1"].ToString(),rdr["count(*)"].ToString());
                Genre genre = new Genre(str_temp,rdr["genre_1"].ToString(), Int32.Parse(rdr["count(*)"].ToString()));
                genre_all.Add(genre);
            }
            sorted_genre_all = genre_all;
            foreach (Genre list in sorted_genre_all)
            {
                checkedListBox_GENRE.Items.Add(list.show_name);
            }
        }

        private void checkedListBox_GENRE_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /*this.BeginInvoke(new Action(() =>
            {
                selected_gerne.Clear();
                for (int i = 0; i < (checkedListBox_GENRE.Items.Count); i++)
                {
                    if (checkedListBox_GENRE.GetItemChecked(i))
                    {
                        selected_gerne.Add(checkedListBox_GENRE.Items[i].ToString());
                    }
                }

                
            }));*/

            if(passing_from_asd == 1) { passing_from_asd = 0; return; }      
                                        //체크리스트_장르의 정렬을할때 임의로 setitemChecked 사용시 checkedListBox_GENRE_ItemCheck 이벤트가 일어나는것을 방지

            if (e.NewValue == CheckState.Checked)
                selected_gerne.Add(checkedListBox_GENRE.Items[e.Index].ToString());
            else
                if (selected_gerne.Contains(checkedListBox_GENRE.Items[e.Index].ToString()))
                    selected_gerne.Remove(checkedListBox_GENRE.Items[e.Index].ToString());

            update_datagridview();

        }

        public void import_database()
        {
            MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
            conn.Open();
            string temp = "select game_info.name, game_info.type, game_info.price, game_info.maker, game_info.publisher, game_info.date, game_info.rating, game_info.rating_num, game_info.metacritic, game_info.link, game_info.text, " +
                "game_genre.genre_1, game_genre.genre_2, game_genre.genre_3, game_info.id from game_info inner join game_genre on game_info.name = game_genre.name";
            MySqlDataAdapter adapter = new MySqlDataAdapter(temp, conn);
            //DataTable ds = new DataTable();
            origin_datatable.Clear();
            adapter.Fill(origin_datatable);
            dataGridView1.DataSource = origin_datatable;
            dataGridView1.Columns[0].HeaderText = "이름";
            dataGridView1.Columns[0].Width = 350;
            dataGridView1.Columns[1].HeaderText = "타입";
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].HeaderText = "가격";
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].HeaderText = "제작사";
            dataGridView1.Columns[4].HeaderText = "배급사";
            dataGridView1.Columns[5].HeaderText = "출시날짜";
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].HeaderText = "평점";
            dataGridView1.Columns[6].Width = 53;
            dataGridView1.Columns[7].Visible = false;           //평가 인원수
            dataGridView1.Columns[8].HeaderText = "MetaScore";
            dataGridView1.Columns[8].Width = 70;
            dataGridView1.Columns[10].Visible = false;          //게임 링크
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[14].Visible = false;          //g_id

        }

        private void radioButton_GAME_CheckedChanged(object sender, EventArgs e)
        {
            string temp = origin_datatable.Columns[1].ToString();
            string type = "";
            if (radioButton_GAME.Checked)
                type = String.Format("{1} = '{0}'", radioButton_GAME.Text, temp);
            else if (radioButton_DLC.Checked)
                type = String.Format("{1} = '{0}'", radioButton_DLC.Text, temp);
            else
                type = String.Format("{0} like '%%'", temp);

            refine_datatable = origin_datatable;
            refine_datatable.DefaultView.RowFilter = type;
            //dataGridView1.DataSource = refine_datatable;

            update_datagridview();
        }

        public void update_datagridview()
        { 
            if (query == "")
                query = "TRUE";
            DataTable tmp = new DataTable();
            tmp = refine_datatable.Clone();
            string temp = "";

            if (selected_gerne.Count == 0)
            {
                if (radioButton_GAME.Checked)
                {
                    temp = String.Format("{4} AND ({2} like '%{3}%') AND {1} = '{0}'", radioButton_GAME.Text, refine_datatable.Columns[1].ToString(),
                        refine_datatable.Columns[0], textBox1.Text.Replace("'", "''").Replace("[", "[[]"), query);
                    selecting_rows(tmp, temp);
                }
                else if (radioButton_DLC.Checked)
                {
                    temp = String.Format("{4} AND ({2} like '%{3}%') AND {1} = '{0}'", radioButton_DLC.Text, refine_datatable.Columns[1].ToString(),
                        refine_datatable.Columns[0], textBox1.Text.Replace("'", "''").Replace("[", "[[]"), query);
                    selecting_rows(tmp, temp);
                }
                else
                {
                    temp = @String.Format("({4} AND [{2}] like '%{3}%') AND {1} like '%%'", radioButton_ALL.Text, refine_datatable.Columns[1].ToString(),
                        refine_datatable.Columns[0], textBox1.Text.Replace("'","''").Replace("[","[[]"), query) ;
                    selecting_rows(tmp, temp);
                }
                dataGridView1.DataSource = tmp;
                label_count.Text = String.Format("{0}개의 항목이 있습니다.", dataGridView1.Rows.Count);
                return ;
            }
            // 11 12 13
            if (radioButton_GAME.Checked)
                for (int i = 0; i < selected_gerne.Count; i++)
                {
                    temp = String.Format("({8}) AND ({6} like '%{7}%' AND ({4} = '{5}')) AND ({0} = '{1}' OR {2} = '{1}' OR {3} = '{1}')", refine_datatable.Columns[11].ToString(), selected_gerne[i].ToString().Substring(0, selected_gerne[i].ToString().IndexOf('('))
                        , refine_datatable.Columns[12].ToString(), refine_datatable.Columns[13].ToString(), refine_datatable.Columns[1].ToString()
                        , radioButton_GAME.Text, refine_datatable.Columns[0], textBox1.Text.Replace("'", "''").Replace("[", "[[]"), query);
                    selecting_rows(tmp, temp);
                }
            else if (radioButton_DLC.Checked)
                for (int i = 0; i < selected_gerne.Count; i++)
                {
                    temp = String.Format("({8}) AND ({6} like '%{7}%' AND ({4} = '{5}')) AND ({0} = '{1}' OR {2} = '{1}' OR {3} = '{1}')", refine_datatable.Columns[11].ToString(), selected_gerne[i].ToString().Substring(0, selected_gerne[i].ToString().IndexOf('('))
                        , refine_datatable.Columns[12].ToString(), refine_datatable.Columns[13].ToString(), refine_datatable.Columns[1].ToString()
                        , radioButton_DLC.Text, refine_datatable.Columns[0], textBox1.Text.Replace("'", "''").Replace("[", "[[]"), query);
                    selecting_rows(tmp, temp);
                }
            else
                for (int i = 0; i < selected_gerne.Count; i++)
                {
                    temp = String.Format("({6}) AND ({4} like '%{5}%') AND ({0} = '{1}' OR {2} = '{1}' OR {3} = '{1}')", refine_datatable.Columns[11].ToString(),  selected_gerne[i].ToString().Substring(0, selected_gerne[i].ToString().IndexOf('('))
                        , refine_datatable.Columns[12].ToString(), refine_datatable.Columns[13].ToString(), refine_datatable.Columns[0]
                        , textBox1.Text.Replace("'", "''").Replace("[", "[[]"), query);
                    selecting_rows(tmp, temp);
                }
            //tmp.DefaultView.ToTable(true);
            dataGridView1.DataSource = tmp;
            label_count.Text = String.Format("{0}개의 항목이 있습니다.", dataGridView1.Rows.Count);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            update_datagridview();
        }

        private void selecting_rows(DataTable tmp ,string temp)
        {
            //MessageBox.Show(temp);
            DataRow[] rowArray = refine_datatable.Select(temp);
            foreach (DataRow row in rowArray)
            {
                tmp.ImportRow(row);
            }
        }

        private void toolStrip_ACCOUNT_INFO_Click(object sender, EventArgs e)
        {
            if (login)
            {
                ACCOUNT_INFO dlg = new ACCOUNT_INFO();
                dlg.Show();
            }
            else
                MessageBox.Show("로그인을 해주십시오.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filter dlg = new Filter(this);
            dlg.Show();
        }

        private void radioButton_asd_CheckedChanged(object sender, EventArgs e)
        {
            if (asd_once == 0)      //체크 -> 체크해제,  체크해제 -> 체크 로 인해 2번 발생하는것을 막기위해 asd_once 사용
            {
                checkedListBox_GENRE.Items.Clear();
                if (radioButton_asd.Checked == true)
                {
                    sorted_genre_all = genre_all.OrderBy(x => x.name).ToList();
                }
                else if (radioButton_dec.Checked == true)
                {
                    sorted_genre_all = genre_all.OrderByDescending(x => x.count).ToList();
                }
                else
                {
                    sorted_genre_all = genre_all.OrderBy(x => x.count).ToList();
                }

                foreach (Genre list in sorted_genre_all)
                {
                    checkedListBox_GENRE.Items.Add(list.show_name);
                }

                for (int i = 0; i < selected_gerne.Count; i++)
                {
                    passing_from_asd = 1;           //체크리스트_장르의 정렬을할때 임의로 setitemChecked 사용시 checkedListBox_GENRE_ItemCheck 이벤트가 일어나는것을 방지
                    checkedListBox_GENRE.SetItemChecked(checkedListBox_GENRE.Items.IndexOf(selected_gerne[i].ToString()), true);
                }
                asd_once = 1;
            }
            else
                asd_once = 0;

        }

        private void toolStrip_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStrip_GAME_ADD_Click(object sender, EventArgs e)
        {
            ADD_GAME dlg = new ADD_GAME(this);
            dlg.ShowDialog();
        }

        private void toolStrip_GAME_RATE_Click(object sender, EventArgs e)
        {
            if(login)
            {
                RATE_GAME dlg = new RATE_GAME();
                dlg.ShowDialog();
            }
            else
            {
                MessageBox.Show("평가를 위해서는 로그인이 필요합니다.");
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            origin_datatable.Clear();
            genre_all.Clear();
            update_genre();
            import_database();
            refine_datatable = origin_datatable.Clone();
            radioButton_GAME_CheckedChanged(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                GAME_INFO dlg = new GAME_INFO(dataGridView1.Rows[e.RowIndex], this);
                dlg.Show();
            }
        }
    }
    class Genre
    {
        public string show_name;
        public string name;
        public int count;

        public Genre(string name1, string name2, int count)
        {
            this.show_name = name1;
            this.name = name2;
            this.count = count;
        }
    }
}
