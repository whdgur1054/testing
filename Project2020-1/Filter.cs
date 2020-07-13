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
using System.Globalization;

namespace Project2020_1
{
    public partial class Filter : Form
    {
        static string min_price = "";
        static string max_price = "";
        static DateTime min_date = new DateTime(1900,1,1);
        static DateTime max_date = new DateTime(2109,12,31);
        static string meta_score = "";
        static string maker = "";
        static string publisher = "";
        static string rate = "";
        static string rate_num = "";
        Form1 dlg;
        public Filter(Form1 dlg)
        {
            InitializeComponent();
            this.dlg = dlg;
            textBox_price_start.Text = min_price;
            textBox_price_end.Text = max_price;
            dateTimePicker_start.Value = min_date;
            dateTimePicker_end.Value = max_date;
            textBox_maker.Text = maker;
            textBox_MetaScore.Text = meta_score;
            textBox_publisher.Text = publisher;
            textBox_rate.Text = rate;
            textBox_rate_num.Text = rate_num;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price_start, price_end;
            if (textBox_price_start.Text == "")
                price_start = Int32.MinValue;
            else
                price_start = Int32.Parse(textBox_price_start.Text);

            if (textBox_price_end.Text == "")
                price_end = Int32.MaxValue;
            else
                price_end = Int32.Parse(textBox_price_end.Text);


            Form1.query = String.Format("({0} >= {2}) AND ({0} <= {3}) AND ({1} >= '{4}') AND ({1} <= '{5}')"
                , Form1.refine_datatable.Columns[2].ToString(), Form1.refine_datatable.Columns[5].ToString(), price_start, price_end,
                dateTimePicker_start.Value, dateTimePicker_end.Value) ;

            if (checkBox1.Checked)
            {
                if (textBox_MetaScore.Text == "")
                    Form1.query += String.Format(" AND ({0} > 0)", Form1.refine_datatable.Columns[8].ToString());
                else
                    Form1.query += String.Format(" AND ({0} > {1})", Form1.refine_datatable.Columns[8].ToString(), Int32.Parse(textBox_MetaScore.Text));

            }

            if (textBox_maker.Text != "")
                Form1.query += String.Format("AND ({0} = '{1}')",Form1.refine_datatable.Columns[3].ToString(),textBox_maker.Text);

            if (textBox_publisher.Text != "")
                Form1.query += String.Format("AND ({0} = '{1}')",Form1.refine_datatable.Columns[4].ToString(), textBox_publisher.Text);

            if (textBox_rate.Text != "")
                Form1.query += String.Format("AND ({0} >= {1})",Form1.refine_datatable.Columns[6].ToString(),textBox_rate.Text);

            if (textBox_rate_num.Text != "")
                Form1.query += String.Format("AND ({0} >= {1})",Form1.refine_datatable.Columns[7].ToString(),textBox_rate_num.Text);

            min_price = textBox_price_start.Text;
            max_price = textBox_price_end.Text;
            min_date = dateTimePicker_start.Value;
            max_date = dateTimePicker_end.Value;
            maker = textBox_maker.Text;
            publisher = textBox_publisher.Text;
            rate = textBox_rate.Text;
            rate_num = textBox_rate_num.Text;
            meta_score = textBox_MetaScore.Text;
            dlg.update_datagridview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            Form1.query = "";
            min_price = "";
            max_price = "";
            min_date = DateTime.ParseExact("1900,01,01", "yyyy,mm,dd", provider);
            max_date = DateTime.ParseExact("2109,12,31", "yyyy,mm,dd", provider); ;
            meta_score = "";
            maker = "";
            publisher = "";
            rate = "";
            rate_num = "";
            dlg.update_datagridview();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_MetaScore.Enabled = true;
        }
        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        
    }
}
