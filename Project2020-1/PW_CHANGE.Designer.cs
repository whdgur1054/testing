namespace Project2020_1
{
    partial class PW_CHANGE
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
            this.textBox_past_pw = new System.Windows.Forms.TextBox();
            this.textBox_new_pw = new System.Windows.Forms.TextBox();
            this.textBox_new_pw_2 = new System.Windows.Forms.TextBox();
            this.button_accept = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_past_pw
            // 
            this.textBox_past_pw.Location = new System.Drawing.Point(167, 47);
            this.textBox_past_pw.Name = "textBox_past_pw";
            this.textBox_past_pw.Size = new System.Drawing.Size(171, 21);
            this.textBox_past_pw.TabIndex = 0;
            this.textBox_past_pw.UseSystemPasswordChar = true;
            // 
            // textBox_new_pw
            // 
            this.textBox_new_pw.Location = new System.Drawing.Point(167, 106);
            this.textBox_new_pw.Name = "textBox_new_pw";
            this.textBox_new_pw.Size = new System.Drawing.Size(171, 21);
            this.textBox_new_pw.TabIndex = 1;
            this.textBox_new_pw.UseSystemPasswordChar = true;
            // 
            // textBox_new_pw_2
            // 
            this.textBox_new_pw_2.Location = new System.Drawing.Point(167, 152);
            this.textBox_new_pw_2.Name = "textBox_new_pw_2";
            this.textBox_new_pw_2.Size = new System.Drawing.Size(171, 21);
            this.textBox_new_pw_2.TabIndex = 2;
            this.textBox_new_pw_2.UseSystemPasswordChar = true;
            // 
            // button_accept
            // 
            this.button_accept.Location = new System.Drawing.Point(199, 243);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(75, 23);
            this.button_accept.TabIndex = 3;
            this.button_accept.Text = "확인";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(358, 47);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "확인";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "현재 비밀번호 확인";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "변경 비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "변경 비밀번호 확인";
            // 
            // PW_CHANGE
            // 
            this.AcceptButton = this.button_accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 329);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.textBox_new_pw_2);
            this.Controls.Add(this.textBox_new_pw);
            this.Controls.Add(this.textBox_past_pw);
            this.Name = "PW_CHANGE";
            this.Text = "PW_CHANGE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_past_pw;
        private System.Windows.Forms.TextBox textBox_new_pw;
        private System.Windows.Forms.TextBox textBox_new_pw_2;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}