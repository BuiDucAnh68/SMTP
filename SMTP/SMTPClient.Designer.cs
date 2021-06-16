
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMTPClient));
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
            this.label5 = new System.Windows.Forms.Label();
            this.btn_attachment = new System.Windows.Forms.Button();
            this.rTB_File = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rTB_BoxGet = new System.Windows.Forms.RichTextBox();
            this.rTB_BoxSend = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Body:";
            // 
            // txt_from
            // 
            this.txt_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_from.Location = new System.Drawing.Point(122, 116);
            this.txt_from.Margin = new System.Windows.Forms.Padding(2);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(353, 29);
            this.txt_from.TabIndex = 4;
            // 
            // txt_To
            // 
            this.txt_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_To.Location = new System.Drawing.Point(122, 159);
            this.txt_To.Margin = new System.Windows.Forms.Padding(2);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(353, 29);
            this.txt_To.TabIndex = 5;
            // 
            // txt_subject
            // 
            this.txt_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subject.Location = new System.Drawing.Point(122, 206);
            this.txt_subject.Margin = new System.Windows.Forms.Padding(2);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(759, 29);
            this.txt_subject.TabIndex = 6;
            // 
            // richTB_message
            // 
            this.richTB_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTB_message.Location = new System.Drawing.Point(122, 255);
            this.richTB_message.Margin = new System.Windows.Forms.Padding(2);
            this.richTB_message.Name = "richTB_message";
            this.richTB_message.Size = new System.Drawing.Size(759, 480);
            this.richTB_message.TabIndex = 7;
            this.richTB_message.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(222, 779);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(527, 81);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(505, 117);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(112, 26);
            this.Password.TabIndex = 9;
            this.Password.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(623, 115);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(231, 29);
            this.txt_password.TabIndex = 10;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // checkBox_Show_Hide
            // 
            this.checkBox_Show_Hide.AutoSize = true;
            this.checkBox_Show_Hide.Location = new System.Drawing.Point(750, 149);
            this.checkBox_Show_Hide.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Show_Hide.Name = "checkBox_Show_Hide";
            this.checkBox_Show_Hide.Size = new System.Drawing.Size(101, 17);
            this.checkBox_Show_Hide.TabIndex = 11;
            this.checkBox_Show_Hide.Text = "Show password";
            this.checkBox_Show_Hide.UseVisualStyleBackColor = true;
            this.checkBox_Show_Hide.CheckedChanged += new System.EventHandler(this.checkBox_Show_Hide_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(574, 59);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sending Gmail Mail App";
            // 
            // btn_attachment
            // 
            this.btn_attachment.Location = new System.Drawing.Point(913, 799);
            this.btn_attachment.Name = "btn_attachment";
            this.btn_attachment.Size = new System.Drawing.Size(391, 56);
            this.btn_attachment.TabIndex = 17;
            this.btn_attachment.Text = "Attachment";
            this.btn_attachment.UseVisualStyleBackColor = true;
            this.btn_attachment.Click += new System.EventHandler(this.btn_attachment_Click);
            // 
            // rTB_File
            // 
            this.rTB_File.BackColor = System.Drawing.SystemColors.GrayText;
            this.rTB_File.Location = new System.Drawing.Point(913, 638);
            this.rTB_File.Name = "rTB_File";
            this.rTB_File.ReadOnly = true;
            this.rTB_File.Size = new System.Drawing.Size(391, 146);
            this.rTB_File.TabIndex = 19;
            this.rTB_File.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(778, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // rTB_BoxGet
            // 
            this.rTB_BoxGet.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rTB_BoxGet.Location = new System.Drawing.Point(913, 12);
            this.rTB_BoxGet.Name = "rTB_BoxGet";
            this.rTB_BoxGet.ReadOnly = true;
            this.rTB_BoxGet.Size = new System.Drawing.Size(391, 305);
            this.rTB_BoxGet.TabIndex = 21;
            this.rTB_BoxGet.Text = "";
            // 
            // rTB_BoxSend
            // 
            this.rTB_BoxSend.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rTB_BoxSend.Location = new System.Drawing.Point(913, 323);
            this.rTB_BoxSend.Name = "rTB_BoxSend";
            this.rTB_BoxSend.ReadOnly = true;
            this.rTB_BoxSend.Size = new System.Drawing.Size(391, 301);
            this.rTB_BoxSend.TabIndex = 22;
            this.rTB_BoxSend.Text = "";
            // 
            // SMTPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 877);
            this.Controls.Add(this.rTB_BoxSend);
            this.Controls.Add(this.rTB_BoxGet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rTB_File);
            this.Controls.Add(this.btn_attachment);
            this.Controls.Add(this.label5);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SMTPClient";
            this.Text = "SMTP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_attachment;
        private System.Windows.Forms.RichTextBox rTB_File;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rTB_BoxGet;
        private System.Windows.Forms.RichTextBox rTB_BoxSend;
    }
}

