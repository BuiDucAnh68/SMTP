
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(452, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(484, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(426, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(454, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Body:";
            // 
            // txt_from
            // 
            this.txt_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_from.Location = new System.Drawing.Point(535, 145);
            this.txt_from.Margin = new System.Windows.Forms.Padding(2);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(328, 29);
            this.txt_from.TabIndex = 4;
            // 
            // txt_To
            // 
            this.txt_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_To.Location = new System.Drawing.Point(535, 188);
            this.txt_To.Margin = new System.Windows.Forms.Padding(2);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(328, 29);
            this.txt_To.TabIndex = 5;
            // 
            // txt_subject
            // 
            this.txt_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subject.Location = new System.Drawing.Point(535, 235);
            this.txt_subject.Margin = new System.Windows.Forms.Padding(2);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(727, 29);
            this.txt_subject.TabIndex = 6;
            // 
            // richTB_message
            // 
            this.richTB_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTB_message.Location = new System.Drawing.Point(535, 284);
            this.richTB_message.Margin = new System.Windows.Forms.Padding(2);
            this.richTB_message.Name = "richTB_message";
            this.richTB_message.Size = new System.Drawing.Size(727, 480);
            this.richTB_message.TabIndex = 7;
            this.richTB_message.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSend.Font = new System.Drawing.Font("Constantia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(719, 785);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(416, 81);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "SEND ✔";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Lime;
            this.Password.Location = new System.Drawing.Point(883, 145);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(126, 29);
            this.Password.TabIndex = 9;
            this.Password.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(1015, 145);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(247, 29);
            this.txt_password.TabIndex = 10;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // checkBox_Show_Hide
            // 
            this.checkBox_Show_Hide.AutoSize = true;
            this.checkBox_Show_Hide.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Show_Hide.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Show_Hide.ForeColor = System.Drawing.Color.Lime;
            this.checkBox_Show_Hide.Location = new System.Drawing.Point(1066, 179);
            this.checkBox_Show_Hide.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Show_Hide.Name = "checkBox_Show_Hide";
            this.checkBox_Show_Hide.Size = new System.Drawing.Size(144, 23);
            this.checkBox_Show_Hide.TabIndex = 11;
            this.checkBox_Show_Hide.Text = "Show password";
            this.checkBox_Show_Hide.UseVisualStyleBackColor = false;
            this.checkBox_Show_Hide.CheckedChanged += new System.EventHandler(this.checkBox_Show_Hide_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Constantia", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(494, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(658, 68);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sending Gmail mail app";
            // 
            // btn_attachment
            // 
            this.btn_attachment.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_attachment.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attachment.ForeColor = System.Drawing.Color.Yellow;
            this.btn_attachment.Location = new System.Drawing.Point(97, 19);
            this.btn_attachment.Name = "btn_attachment";
            this.btn_attachment.Size = new System.Drawing.Size(191, 46);
            this.btn_attachment.TabIndex = 17;
            this.btn_attachment.Text = "Attachment";
            this.btn_attachment.UseVisualStyleBackColor = false;
            this.btn_attachment.Click += new System.EventHandler(this.btn_attachment_Click);
            // 
            // rTB_File
            // 
            this.rTB_File.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rTB_File.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTB_File.Location = new System.Drawing.Point(24, 71);
            this.rTB_File.Name = "rTB_File";
            this.rTB_File.ReadOnly = true;
            this.rTB_File.Size = new System.Drawing.Size(343, 122);
            this.rTB_File.TabIndex = 19;
            this.rTB_File.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1158, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // rTB_BoxGet
            // 
            this.rTB_BoxGet.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rTB_BoxGet.Location = new System.Drawing.Point(22, 321);
            this.rTB_BoxGet.Name = "rTB_BoxGet";
            this.rTB_BoxGet.ReadOnly = true;
            this.rTB_BoxGet.Size = new System.Drawing.Size(391, 278);
            this.rTB_BoxGet.TabIndex = 21;
            this.rTB_BoxGet.Text = "";
            // 
            // rTB_BoxSend
            // 
            this.rTB_BoxSend.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rTB_BoxSend.Location = new System.Drawing.Point(22, 21);
            this.rTB_BoxSend.Name = "rTB_BoxSend";
            this.rTB_BoxSend.ReadOnly = true;
            this.rTB_BoxSend.Size = new System.Drawing.Size(391, 274);
            this.rTB_BoxSend.TabIndex = 22;
            this.rTB_BoxSend.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rTB_File);
            this.groupBox1.Controls.Add(this.btn_attachment);
            this.groupBox1.Location = new System.Drawing.Point(22, 618);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 211);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // SMTPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1316, 878);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rTB_BoxSend);
            this.Controls.Add(this.rTB_BoxGet);
            this.Controls.Add(this.pictureBox1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SMTPClient";
            this.Text = "Sending gmail mail app [by \"Nhóm 8\" lớp NT106.L21.ATCL]";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

