namespace Project2020_1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip_GAME = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_LOG_IN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_LOG_OUT = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_ACCOUNT_INFO = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_EXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_DLC = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_GAME_ADD = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_GAME_RATE = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_ALL = new System.Windows.Forms.RadioButton();
            this.radioButton_DLC = new System.Windows.Forms.RadioButton();
            this.radioButton_GAME = new System.Windows.Forms.RadioButton();
            this.checkedListBox_GENRE = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Filter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_asc = new System.Windows.Forms.RadioButton();
            this.radioButton_dec = new System.Windows.Forms.RadioButton();
            this.radioButton_asd = new System.Windows.Forms.RadioButton();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label_count = new System.Windows.Forms.Label();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_GAME,
            this.toolStrip_DLC});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1177, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip_GAME
            // 
            this.toolStrip_GAME.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_LOG_IN,
            this.toolStrip_LOG_OUT,
            this.toolStripSeparator1,
            this.toolStrip_ACCOUNT_INFO,
            this.toolStripSeparator2,
            this.toolStrip_EXIT});
            this.toolStrip_GAME.Name = "toolStrip_GAME";
            this.toolStrip_GAME.Size = new System.Drawing.Size(43, 20);
            this.toolStrip_GAME.Text = "계정";
            // 
            // toolStrip_LOG_IN
            // 
            this.toolStrip_LOG_IN.Name = "toolStrip_LOG_IN";
            this.toolStrip_LOG_IN.Size = new System.Drawing.Size(122, 22);
            this.toolStrip_LOG_IN.Text = "로그인";
            this.toolStrip_LOG_IN.Click += new System.EventHandler(this.toolStrip_LOG_IN_Click);
            // 
            // toolStrip_LOG_OUT
            // 
            this.toolStrip_LOG_OUT.Name = "toolStrip_LOG_OUT";
            this.toolStrip_LOG_OUT.Size = new System.Drawing.Size(122, 22);
            this.toolStrip_LOG_OUT.Text = "로그아웃";
            this.toolStrip_LOG_OUT.Click += new System.EventHandler(this.toolStrip_LOG_OUT_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // toolStrip_ACCOUNT_INFO
            // 
            this.toolStrip_ACCOUNT_INFO.Name = "toolStrip_ACCOUNT_INFO";
            this.toolStrip_ACCOUNT_INFO.Size = new System.Drawing.Size(122, 22);
            this.toolStrip_ACCOUNT_INFO.Text = "계정정보";
            this.toolStrip_ACCOUNT_INFO.Click += new System.EventHandler(this.toolStrip_ACCOUNT_INFO_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(119, 6);
            // 
            // toolStrip_EXIT
            // 
            this.toolStrip_EXIT.Name = "toolStrip_EXIT";
            this.toolStrip_EXIT.Size = new System.Drawing.Size(122, 22);
            this.toolStrip_EXIT.Text = "종료";
            this.toolStrip_EXIT.Click += new System.EventHandler(this.toolStrip_EXIT_Click);
            // 
            // toolStrip_DLC
            // 
            this.toolStrip_DLC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_GAME_ADD,
            this.toolStrip_GAME_RATE});
            this.toolStrip_DLC.Name = "toolStrip_DLC";
            this.toolStrip_DLC.Size = new System.Drawing.Size(43, 20);
            this.toolStrip_DLC.Text = "게임";
            // 
            // toolStrip_GAME_ADD
            // 
            this.toolStrip_GAME_ADD.Name = "toolStrip_GAME_ADD";
            this.toolStrip_GAME_ADD.Size = new System.Drawing.Size(122, 22);
            this.toolStrip_GAME_ADD.Text = "게임등록";
            this.toolStrip_GAME_ADD.Click += new System.EventHandler(this.toolStrip_GAME_ADD_Click);
            // 
            // toolStrip_GAME_RATE
            // 
            this.toolStrip_GAME_RATE.Name = "toolStrip_GAME_RATE";
            this.toolStrip_GAME_RATE.Size = new System.Drawing.Size(122, 22);
            this.toolStrip_GAME_RATE.Text = "게임평가";
            this.toolStrip_GAME_RATE.Click += new System.EventHandler(this.toolStrip_GAME_RATE_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 568);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1177, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel1.Text = "로그인해주십시오.";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(13, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(526, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton_ALL);
            this.groupBox1.Controls.Add(this.radioButton_DLC);
            this.groupBox1.Controls.Add(this.radioButton_GAME);
            this.groupBox1.Location = new System.Drawing.Point(1014, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "타입";
            // 
            // radioButton_ALL
            // 
            this.radioButton_ALL.AutoSize = true;
            this.radioButton_ALL.Location = new System.Drawing.Point(6, 20);
            this.radioButton_ALL.Name = "radioButton_ALL";
            this.radioButton_ALL.Size = new System.Drawing.Size(45, 16);
            this.radioButton_ALL.TabIndex = 2;
            this.radioButton_ALL.TabStop = true;
            this.radioButton_ALL.Text = "ALL";
            this.radioButton_ALL.UseVisualStyleBackColor = true;
            this.radioButton_ALL.CheckedChanged += new System.EventHandler(this.radioButton_GAME_CheckedChanged);
            // 
            // radioButton_DLC
            // 
            this.radioButton_DLC.AutoSize = true;
            this.radioButton_DLC.Location = new System.Drawing.Point(6, 64);
            this.radioButton_DLC.Name = "radioButton_DLC";
            this.radioButton_DLC.Size = new System.Drawing.Size(47, 16);
            this.radioButton_DLC.TabIndex = 1;
            this.radioButton_DLC.TabStop = true;
            this.radioButton_DLC.Text = "DLC";
            this.radioButton_DLC.UseVisualStyleBackColor = true;
            this.radioButton_DLC.CheckedChanged += new System.EventHandler(this.radioButton_GAME_CheckedChanged);
            // 
            // radioButton_GAME
            // 
            this.radioButton_GAME.AutoSize = true;
            this.radioButton_GAME.Location = new System.Drawing.Point(6, 42);
            this.radioButton_GAME.Name = "radioButton_GAME";
            this.radioButton_GAME.Size = new System.Drawing.Size(59, 16);
            this.radioButton_GAME.TabIndex = 0;
            this.radioButton_GAME.TabStop = true;
            this.radioButton_GAME.Text = "GAME";
            this.radioButton_GAME.UseVisualStyleBackColor = true;
            this.radioButton_GAME.CheckedChanged += new System.EventHandler(this.radioButton_GAME_CheckedChanged);
            // 
            // checkedListBox_GENRE
            // 
            this.checkedListBox_GENRE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox_GENRE.CheckOnClick = true;
            this.checkedListBox_GENRE.FormattingEnabled = true;
            this.checkedListBox_GENRE.Location = new System.Drawing.Point(1014, 212);
            this.checkedListBox_GENRE.Name = "checkedListBox_GENRE";
            this.checkedListBox_GENRE.Size = new System.Drawing.Size(150, 356);
            this.checkedListBox_GENRE.TabIndex = 4;
            this.checkedListBox_GENRE.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_GENRE_ItemCheck);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(995, 509);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button_Filter
            // 
            this.button_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Filter.Location = new System.Drawing.Point(607, 28);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(75, 23);
            this.button_Filter.TabIndex = 6;
            this.button_Filter.Text = "상세필터";
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.radioButton_asc);
            this.groupBox2.Controls.Add(this.radioButton_dec);
            this.groupBox2.Controls.Add(this.radioButton_asd);
            this.groupBox2.Location = new System.Drawing.Point(1014, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 87);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "장르 정렬방법";
            // 
            // radioButton_asc
            // 
            this.radioButton_asc.AutoSize = true;
            this.radioButton_asc.Location = new System.Drawing.Point(6, 64);
            this.radioButton_asc.Name = "radioButton_asc";
            this.radioButton_asc.Size = new System.Drawing.Size(111, 16);
            this.radioButton_asc.TabIndex = 2;
            this.radioButton_asc.Text = "항목수 올림차순";
            this.radioButton_asc.UseVisualStyleBackColor = true;
            this.radioButton_asc.CheckedChanged += new System.EventHandler(this.radioButton_asd_CheckedChanged);
            // 
            // radioButton_dec
            // 
            this.radioButton_dec.AutoSize = true;
            this.radioButton_dec.Location = new System.Drawing.Point(6, 42);
            this.radioButton_dec.Name = "radioButton_dec";
            this.radioButton_dec.Size = new System.Drawing.Size(111, 16);
            this.radioButton_dec.TabIndex = 1;
            this.radioButton_dec.Text = "항목수 내림차순";
            this.radioButton_dec.UseVisualStyleBackColor = true;
            this.radioButton_dec.CheckedChanged += new System.EventHandler(this.radioButton_asd_CheckedChanged);
            // 
            // radioButton_asd
            // 
            this.radioButton_asd.AutoSize = true;
            this.radioButton_asd.Checked = true;
            this.radioButton_asd.Location = new System.Drawing.Point(6, 20);
            this.radioButton_asd.Name = "radioButton_asd";
            this.radioButton_asd.Size = new System.Drawing.Size(71, 16);
            this.radioButton_asd.TabIndex = 0;
            this.radioButton_asd.TabStop = true;
            this.radioButton_asd.Text = "가나다순";
            this.radioButton_asd.UseVisualStyleBackColor = true;
            this.radioButton_asd.CheckedChanged += new System.EventHandler(this.radioButton_asd_CheckedChanged);
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_refresh.Location = new System.Drawing.Point(742, 28);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 8;
            this.button_refresh.Text = "새로고침";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label_count
            // 
            this.label_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(823, 33);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(69, 12);
            this.label_count.TabIndex = 9;
            this.label_count.Text = "label_count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 590);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Filter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkedListBox_GENRE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_GAME;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_DLC;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_DLC;
        private System.Windows.Forms.RadioButton radioButton_GAME;
        private System.Windows.Forms.CheckedListBox checkedListBox_GENRE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_LOG_IN;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_LOG_OUT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_ACCOUNT_INFO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_EXIT;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_GAME_ADD;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_GAME_RATE;
        private System.Windows.Forms.RadioButton radioButton_ALL;
        private System.Windows.Forms.Button button_Filter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_asc;
        private System.Windows.Forms.RadioButton radioButton_dec;
        private System.Windows.Forms.RadioButton radioButton_asd;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label_count;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
    }
}

