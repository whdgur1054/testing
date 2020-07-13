using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class ACCOUNT_INFO : Form
    {
        public ACCOUNT_INFO()
        {
            InitializeComponent();
            label_ID.Text = Form1.login_id;
            update_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_pw_change_Click(object sender, EventArgs e)
        {
            PW_CHANGE dlg = new PW_CHANGE();
            dlg.ShowDialog();
        }
        private void update_data()
        {
            ArrayList al = new ArrayList();
            MySqlConnection conn = new MySqlConnection(Form1.MYSQL_LOG_IN);
            conn.Open();
            string temp = String.Format("drop table if exists temp_{0};" +
                "create table temp_{0} (name varchar(50), _rank int);"+
                "call u_rating('{0}')", Form1.login_id);
            MySqlCommand cmd = new MySqlCommand(temp, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string input = String.Format("insert into temp_{3} values (\'{0}\',1),(\'{1}\',1),(\'{2}\',1)"
                    , rdr["genre_1"].ToString(), rdr["genre_2"].ToString(), rdr["genre_3"].ToString(), Form1.login_id);
                al.Add(input);
            }
            rdr.Close();
            for (int i = 0; i < al.Count; i++)
            {
                cmd.CommandText = al[i].ToString();
                cmd.ExecuteNonQuery();
            }
            temp = String.Format("delete from temp_{0} where name = '';select name, sum(_rank) from temp_{0} group by name order by sum(_rank) desc", Form1.login_id);
            cmd.CommandText = temp;
            //rdr = cmd.ExecuteReader();

            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(temp, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "장르";
                dataGridView1.Columns[1].HeaderText = "점수";
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            temp = String.Format("drop table if exists temp_{0}", Form1.login_id);
            cmd.CommandText = temp;
            cmd.ExecuteNonQuery();
        }
    }
}
