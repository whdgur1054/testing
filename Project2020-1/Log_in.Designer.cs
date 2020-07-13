namespace Project2020_1
{
    partial class Log_in
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
            this.label_ID = new System.Windows.Forms.Label();
            this.label_PW = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_PW = new System.Windows.Forms.TextBox();
            this.button_SIGN_IN = new System.Windows.Forms.Button();
            this.button_LOG_IN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(15, 22);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(41, 12);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "아이디";
            // 
            // label_PW
            // 
            this.label_PW.AutoSize = true;
            this.label_PW.Location = new System.Drawing.Point(15, 120);
            this.label_PW.Name = "label_PW";
            this.label_PW.Size = new System.Drawing.Size(53, 12);
            this.label_PW.TabIndex = 1;
            this.label_PW.Text = "패스워드";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(84, 19);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(127, 21);
            this.textBox_ID.TabIndex = 2;
            // 
            // textBox_PW
            // 
            this.textBox_PW.Location = new System.Drawing.Point(84, 117);
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.PasswordChar = '*';
            this.textBox_PW.Size = new System.Drawing.Size(127, 21);
            this.textBox_PW.TabIndex = 3;
            // 
            // button_SIGN_IN
            // 
            this.button_SIGN_IN.Location = new System.Drawing.Point(17, 171);
            this.button_SIGN_IN.Name = "button_SIGN_IN";
            this.button_SIGN_IN.Size = new System.Drawing.Size(75, 23);
            this.button_SIGN_IN.TabIndex = 4;
            this.button_SIGN_IN.Text = "회원가입";
            this.button_SIGN_IN.UseVisualStyleBackColor = true;
            this.button_SIGN_IN.Click += new System.EventHandler(this.button_SIGN_IN_Click);
            // 
            // button_LOG_IN
            // 
            this.button_LOG_IN.Location = new System.Drawing.Point(136, 171);
            this.button_LOG_IN.Name = "button_LOG_IN";
            this.button_LOG_IN.Size = new System.Drawing.Size(75, 23);
            this.button_LOG_IN.TabIndex = 5;
            this.button_LOG_IN.Text = "로그인";
            this.button_LOG_IN.UseVisualStyleBackColor = true;
            this.button_LOG_IN.Click += new System.EventHandler(this.button_LOG_IN_Click);
            // 
            // Log_in
            // 
            this.AcceptButton = this.button_LOG_IN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 233);
            this.Controls.Add(this.button_LOG_IN);
            this.Controls.Add(this.button_SIGN_IN);
            this.Controls.Add(this.textBox_PW);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_PW);
            this.Controls.Add(this.label_ID);
            this.Name = "Log_in";
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_PW;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_PW;
        private System.Windows.Forms.Button button_SIGN_IN;
        private System.Windows.Forms.Button button_LOG_IN;
    }
}