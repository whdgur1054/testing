namespace Project2020_1
{
    partial class ADD_GAME
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_maker = new System.Windows.Forms.TextBox();
            this.textBox_publisher = new System.Windows.Forms.TextBox();
            this.textBox_genre1 = new System.Windows.Forms.TextBox();
            this.textBox_genre2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_genre3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_dlc = new System.Windows.Forms.RadioButton();
            this.radioButton_game = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_site = new System.Windows.Forms.TextBox();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_check = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_metascore = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "게임이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "가격";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "제작사";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "배급사";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "출시 날짜";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "장르1";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(81, 26);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(200, 21);
            this.textBox_name.TabIndex = 6;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(81, 53);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 21);
            this.textBox_price.TabIndex = 7;
            this.textBox_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // textBox_maker
            // 
            this.textBox_maker.Location = new System.Drawing.Point(81, 80);
            this.textBox_maker.Name = "textBox_maker";
            this.textBox_maker.Size = new System.Drawing.Size(200, 21);
            this.textBox_maker.TabIndex = 8;
            // 
            // textBox_publisher
            // 
            this.textBox_publisher.Location = new System.Drawing.Point(81, 107);
            this.textBox_publisher.Name = "textBox_publisher";
            this.textBox_publisher.Size = new System.Drawing.Size(200, 21);
            this.textBox_publisher.TabIndex = 9;
            // 
            // textBox_genre1
            // 
            this.textBox_genre1.Location = new System.Drawing.Point(81, 161);
            this.textBox_genre1.Name = "textBox_genre1";
            this.textBox_genre1.Size = new System.Drawing.Size(200, 21);
            this.textBox_genre1.TabIndex = 10;
            this.textBox_genre1.TextChanged += new System.EventHandler(this.textBox_genre1_TextChanged);
            this.textBox_genre1.Enter += new System.EventHandler(this.textBox_genre1_TextChanged);
            // 
            // textBox_genre2
            // 
            this.textBox_genre2.Location = new System.Drawing.Point(81, 188);
            this.textBox_genre2.Name = "textBox_genre2";
            this.textBox_genre2.Size = new System.Drawing.Size(200, 21);
            this.textBox_genre2.TabIndex = 11;
            this.textBox_genre2.TextChanged += new System.EventHandler(this.textBox_genre2_TextChanged);
            this.textBox_genre2.Enter += new System.EventHandler(this.textBox_genre2_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // textBox_genre3
            // 
            this.textBox_genre3.Location = new System.Drawing.Point(81, 215);
            this.textBox_genre3.Name = "textBox_genre3";
            this.textBox_genre3.Size = new System.Drawing.Size(200, 21);
            this.textBox_genre3.TabIndex = 11;
            this.textBox_genre3.TextChanged += new System.EventHandler(this.textBox_genre3_TextChanged);
            this.textBox_genre3.Enter += new System.EventHandler(this.textBox_genre3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "장르2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "장르3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_dlc);
            this.groupBox1.Controls.Add(this.radioButton_game);
            this.groupBox1.Location = new System.Drawing.Point(287, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 74);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "종류";
            // 
            // radioButton_dlc
            // 
            this.radioButton_dlc.AutoSize = true;
            this.radioButton_dlc.Location = new System.Drawing.Point(6, 42);
            this.radioButton_dlc.Name = "radioButton_dlc";
            this.radioButton_dlc.Size = new System.Drawing.Size(47, 16);
            this.radioButton_dlc.TabIndex = 1;
            this.radioButton_dlc.TabStop = true;
            this.radioButton_dlc.Text = "DLC";
            this.radioButton_dlc.UseVisualStyleBackColor = true;
            // 
            // radioButton_game
            // 
            this.radioButton_game.AutoSize = true;
            this.radioButton_game.Location = new System.Drawing.Point(6, 20);
            this.radioButton_game.Name = "radioButton_game";
            this.radioButton_game.Size = new System.Drawing.Size(59, 16);
            this.radioButton_game.TabIndex = 0;
            this.radioButton_game.TabStop = true;
            this.radioButton_game.Text = "GAME";
            this.radioButton_game.UseVisualStyleBackColor = true;
            this.radioButton_game.CheckedChanged += new System.EventHandler(this.radioButton_game_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "관련 주소";
            // 
            // textBox_site
            // 
            this.textBox_site.Location = new System.Drawing.Point(81, 242);
            this.textBox_site.Name = "textBox_site";
            this.textBox_site.Size = new System.Drawing.Size(437, 21);
            this.textBox_site.TabIndex = 11;
            // 
            // textBox_desc
            // 
            this.textBox_desc.Location = new System.Drawing.Point(81, 269);
            this.textBox_desc.Multiline = true;
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(437, 141);
            this.textBox_desc.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "설명";
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(306, 24);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(75, 23);
            this.button_check.TabIndex = 15;
            this.button_check.Text = "중복확인";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(245, 416);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 16;
            this.button_add.Text = "추가";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(304, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "MetaScore 점수";
            // 
            // textBox_metascore
            // 
            this.textBox_metascore.Location = new System.Drawing.Point(404, 80);
            this.textBox_metascore.Name = "textBox_metascore";
            this.textBox_metascore.Size = new System.Drawing.Size(100, 21);
            this.textBox_metascore.TabIndex = 18;
            this.textBox_metascore.TextChanged += new System.EventHandler(this.textBox_metascore_TextChanged);
            this.textBox_metascore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(368, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(136, 129);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ADD_GAME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_metascore);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.textBox_site);
            this.Controls.Add(this.textBox_genre3);
            this.Controls.Add(this.textBox_genre2);
            this.Controls.Add(this.textBox_genre1);
            this.Controls.Add(this.textBox_publisher);
            this.Controls.Add(this.textBox_maker);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ADD_GAME";
            this.Text = "ADD_GAME";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_maker;
        private System.Windows.Forms.TextBox textBox_publisher;
        private System.Windows.Forms.TextBox textBox_genre1;
        private System.Windows.Forms.TextBox textBox_genre2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_genre3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_dlc;
        private System.Windows.Forms.RadioButton radioButton_game;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_site;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_metascore;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}