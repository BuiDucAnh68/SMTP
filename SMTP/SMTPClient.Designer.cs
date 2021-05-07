
namespace SMTP
{
    partial class SMTPClient
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
            this.txt_from = new System.Windows.Forms.TextBox();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.richTB_message = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.checkBox_Show_Hide = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Message";
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(2, 17);
            this.txt_from.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(206, 20);
            this.txt_from.TabIndex = 4;
            this.txt_from.TextChanged += new System.EventHandler(this.txt_from_TextChanged);
            // 
            // txt_To
            // 
            this.txt_To.Location = new System.Drawing.Point(2, 63);
            this.txt_To.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(561, 20);
            this.txt_To.TabIndex = 5;
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(2, 106);
            this.txt_subject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(561, 20);
            this.txt_subject.TabIndex = 6;
            // 
            // richTB_message
            // 
            this.richTB_message.Location = new System.Drawing.Point(2, 159);
            this.richTB_message.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTB_message.Name = "richTB_message";
            this.richTB_message.Size = new System.Drawing.Size(766, 310);
            this.richTB_message.TabIndex = 7;
            this.richTB_message.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(568, 1);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(200, 146);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send(SMTPClient)";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(255, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 9;
            this.Password.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(257, 17);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(231, 20);
            this.txt_password.TabIndex = 10;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // checkBox_Show_Hide
            // 
            this.checkBox_Show_Hide.AutoSize = true;
            this.checkBox_Show_Hide.Location = new System.Drawing.Point(500, 17);
            this.checkBox_Show_Hide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_Show_Hide.Name = "checkBox_Show_Hide";
            this.checkBox_Show_Hide.Size = new System.Drawing.Size(53, 17);
            this.checkBox_Show_Hide.TabIndex = 11;
            this.checkBox_Show_Hide.Text = "Show";
            this.checkBox_Show_Hide.UseVisualStyleBackColor = true;
            this.checkBox_Show_Hide.CheckedChanged += new System.EventHandler(this.checkBox_Show_Hide_CheckedChanged);
            // 
            // SMTPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 470);
            this.Controls.Add(this.checkBox_Show_Hide);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.richTB_message);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SMTPClient";
            this.Text = "SMTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.RichTextBox richTB_message;
        private System.Windows.Forms.Button btnSend;
        public System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.CheckBox checkBox_Show_Hide;
    }
}

