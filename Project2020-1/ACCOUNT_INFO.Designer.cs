namespace Project2020_1
{
    partial class ACCOUNT_INFO
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
            this.button_pw_change = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // button_pw_change
            // 
            this.button_pw_change.Location = new System.Drawing.Point(27, 59);
            this.button_pw_change.Name = "button_pw_change";
            this.button_pw_change.Size = new System.Drawing.Size(104, 23);
            this.button_pw_change.TabIndex = 1;
            this.button_pw_change.Text = "비밀번호 변경";
            this.button_pw_change.UseVisualStyleBackColor = true;
            this.button_pw_change.Click += new System.EventHandler(this.button_pw_change_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(249, 326);
            this.dataGridView1.TabIndex = 2;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(90, 27);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(29, 12);
            this.label_ID.TabIndex = 3;
            this.label_ID.Text = "----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "선호하는 장르";
            // 
            // ACCOUNT_INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_pw_change);
            this.Controls.Add(this.label1);
            this.Name = "ACCOUNT_INFO";
            this.Text = "ACCOUNT_INFO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_pw_change;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label2;
    }
}