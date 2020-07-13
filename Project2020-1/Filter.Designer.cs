namespace Project2020_1
{
    partial class Filter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_price_start = new System.Windows.Forms.TextBox();
            this.textBox_price_end = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_MetaScore = new System.Windows.Forms.TextBox();
            this.textBox_maker = new System.Windows.Forms.TextBox();
            this.textBox_publisher = new System.Windows.Forms.TextBox();
            this.textBox_rate_num = new System.Windows.Forms.TextBox();
            this.textBox_rate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "가격";
            // 
            // textBox_price_start
            // 
            this.textBox_price_start.Location = new System.Drawing.Point(131, 18);
            this.textBox_price_start.Name = "textBox_price_start";
            this.textBox_price_start.Size = new System.Drawing.Size(102, 21);
            this.textBox_price_start.TabIndex = 1;
            this.textBox_price_start.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // textBox_price_end
            // 
            this.textBox_price_end.Location = new System.Drawing.Point(259, 18);
            this.textBox_price_end.Name = "textBox_price_end";
            this.textBox_price_end.Size = new System.Drawing.Size(102, 21);
            this.textBox_price_end.TabIndex = 2;
            this.textBox_price_end.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "출시날짜";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(52, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "MetaScore 유/무";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "~";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "~";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "적용";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(131, 66);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker_start.TabIndex = 9;
            this.dateTimePicker_start.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(357, 66);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker_end.TabIndex = 10;
            this.dateTimePicker_end.Value = new System.DateTime(2109, 12, 31, 0, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "적용해제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_MetaScore
            // 
            this.textBox_MetaScore.Enabled = false;
            this.textBox_MetaScore.Location = new System.Drawing.Point(203, 115);
            this.textBox_MetaScore.Name = "textBox_MetaScore";
            this.textBox_MetaScore.Size = new System.Drawing.Size(100, 21);
            this.textBox_MetaScore.TabIndex = 12;
            this.textBox_MetaScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // textBox_maker
            // 
            this.textBox_maker.Location = new System.Drawing.Point(131, 152);
            this.textBox_maker.Name = "textBox_maker";
            this.textBox_maker.Size = new System.Drawing.Size(172, 21);
            this.textBox_maker.TabIndex = 13;
            // 
            // textBox_publisher
            // 
            this.textBox_publisher.Location = new System.Drawing.Point(131, 195);
            this.textBox_publisher.Name = "textBox_publisher";
            this.textBox_publisher.Size = new System.Drawing.Size(172, 21);
            this.textBox_publisher.TabIndex = 14;
            // 
            // textBox_rate_num
            // 
            this.textBox_rate_num.Location = new System.Drawing.Point(483, 195);
            this.textBox_rate_num.Name = "textBox_rate_num";
            this.textBox_rate_num.Size = new System.Drawing.Size(100, 21);
            this.textBox_rate_num.TabIndex = 15;
            this.textBox_rate_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // textBox_rate
            // 
            this.textBox_rate.Location = new System.Drawing.Point(483, 152);
            this.textBox_rate.Name = "textBox_rate";
            this.textBox_rate.Size = new System.Drawing.Size(100, 21);
            this.textBox_rate.TabIndex = 16;
            this.textBox_rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "제작사";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "배급사";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "평가점수";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "평가 인원";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(589, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "이상";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(589, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "이상";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "이상";
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 403);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_rate);
            this.Controls.Add(this.textBox_rate_num);
            this.Controls.Add(this.textBox_publisher);
            this.Controls.Add(this.textBox_maker);
            this.Controls.Add(this.textBox_MetaScore);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_price_end);
            this.Controls.Add(this.textBox_price_start);
            this.Controls.Add(this.label1);
            this.Name = "Filter";
            this.Text = "Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_price_start;
        private System.Windows.Forms.TextBox textBox_price_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_MetaScore;
        private System.Windows.Forms.TextBox textBox_maker;
        private System.Windows.Forms.TextBox textBox_publisher;
        private System.Windows.Forms.TextBox textBox_rate_num;
        private System.Windows.Forms.TextBox textBox_rate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}