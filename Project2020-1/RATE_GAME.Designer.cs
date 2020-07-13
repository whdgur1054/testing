namespace Project2020_1
{
    partial class RATE_GAME
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_bad = new System.Windows.Forms.RadioButton();
            this.radioButton_good = new System.Windows.Forms.RadioButton();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_accept = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "게임 이름";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(85, 12);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(447, 21);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_bad);
            this.groupBox1.Controls.Add(this.radioButton_good);
            this.groupBox1.Location = new System.Drawing.Point(7, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(72, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "평가";
            // 
            // radioButton_bad
            // 
            this.radioButton_bad.AutoSize = true;
            this.radioButton_bad.Location = new System.Drawing.Point(6, 42);
            this.radioButton_bad.Name = "radioButton_bad";
            this.radioButton_bad.Size = new System.Drawing.Size(59, 16);
            this.radioButton_bad.TabIndex = 1;
            this.radioButton_bad.Text = "싫어요";
            this.radioButton_bad.UseVisualStyleBackColor = true;
            // 
            // radioButton_good
            // 
            this.radioButton_good.AutoSize = true;
            this.radioButton_good.Checked = true;
            this.radioButton_good.Location = new System.Drawing.Point(6, 20);
            this.radioButton_good.Name = "radioButton_good";
            this.radioButton_good.Size = new System.Drawing.Size(59, 16);
            this.radioButton_good.TabIndex = 0;
            this.radioButton_good.TabStop = true;
            this.radioButton_good.Text = "좋아요";
            this.radioButton_good.UseVisualStyleBackColor = true;
            // 
            // textBox_desc
            // 
            this.textBox_desc.Location = new System.Drawing.Point(85, 39);
            this.textBox_desc.Multiline = true;
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(447, 143);
            this.textBox_desc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "평가 내용";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(781, 233);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_accept
            // 
            this.button_accept.Location = new System.Drawing.Point(563, 10);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(75, 23);
            this.button_accept.TabIndex = 7;
            this.button_accept.Text = "평가하기";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "게임이름을 통해 검색한 후 ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "밑의 항목을 클릭하여주십시오.";
            // 
            // RATE_GAME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.Name = "RATE_GAME";
            this.Text = "RATE_GAME";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_bad;
        private System.Windows.Forms.RadioButton radioButton_good;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}