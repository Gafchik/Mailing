
namespace Mailing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_mail = new System.Windows.Forms.Panel();
            this.IsHTML = new System.Windows.Forms.CheckBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.count_mail_numeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.text_mail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.thema_mail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recipients_LB = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.del_recipient = new System.Windows.Forms.Button();
            this.add_recipient = new System.Windows.Forms.Button();
            this.panel_mail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.count_mail_numeric)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_mail
            // 
            this.panel_mail.BackColor = System.Drawing.SystemColors.Control;
            this.panel_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_mail.Controls.Add(this.IsHTML);
            this.panel_mail.Controls.Add(this.send_btn);
            this.panel_mail.Controls.Add(this.count_mail_numeric);
            this.panel_mail.Controls.Add(this.label6);
            this.panel_mail.Controls.Add(this.text_mail);
            this.panel_mail.Controls.Add(this.label2);
            this.panel_mail.Controls.Add(this.label1);
            this.panel_mail.Controls.Add(this.thema_mail);
            this.panel_mail.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_mail.Location = new System.Drawing.Point(0, 0);
            this.panel_mail.Name = "panel_mail";
            this.panel_mail.Size = new System.Drawing.Size(458, 450);
            this.panel_mail.TabIndex = 0;
            // 
            // IsHTML
            // 
            this.IsHTML.AutoSize = true;
            this.IsHTML.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IsHTML.Location = new System.Drawing.Point(25, 340);
            this.IsHTML.Name = "IsHTML";
            this.IsHTML.Size = new System.Drawing.Size(104, 25);
            this.IsHTML.TabIndex = 13;
            this.IsHTML.Text = "Это HTML";
            this.IsHTML.UseVisualStyleBackColor = true;
            // 
            // send_btn
            // 
            this.send_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.send_btn.Location = new System.Drawing.Point(266, 340);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(124, 42);
            this.send_btn.TabIndex = 11;
            this.send_btn.Text = "Отправить";
            this.send_btn.UseVisualStyleBackColor = true;
            // 
            // count_mail_numeric
            // 
            this.count_mail_numeric.Location = new System.Drawing.Point(270, 271);
            this.count_mail_numeric.Name = "count_mail_numeric";
            this.count_mail_numeric.Size = new System.Drawing.Size(120, 23);
            this.count_mail_numeric.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Количество сообщений :";
            // 
            // text_mail
            // 
            this.text_mail.Location = new System.Drawing.Point(11, 95);
            this.text_mail.Multiline = true;
            this.text_mail.Name = "text_mail";
            this.text_mail.Size = new System.Drawing.Size(410, 144);
            this.text_mail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(91, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Содержимое письма письма :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тема письма :";
            // 
            // thema_mail
            // 
            this.thema_mail.Location = new System.Drawing.Point(149, 11);
            this.thema_mail.Name = "thema_mail";
            this.thema_mail.Size = new System.Drawing.Size(272, 23);
            this.thema_mail.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.add_recipient);
            this.panel1.Controls.Add(this.del_recipient);
            this.panel1.Controls.Add(this.recipients_LB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(512, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 450);
            this.panel1.TabIndex = 1;
            // 
            // recipients_LB
            // 
            this.recipients_LB.FormattingEnabled = true;
            this.recipients_LB.ItemHeight = 15;
            this.recipients_LB.Location = new System.Drawing.Point(27, 179);
            this.recipients_LB.Name = "recipients_LB";
            this.recipients_LB.Size = new System.Drawing.Size(231, 214);
            this.recipients_LB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(118, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Отправитель :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль  :";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(118, 91);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(150, 23);
            this.password.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Логин :";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(118, 46);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(150, 23);
            this.login.TabIndex = 4;
            // 
            // del_recipient
            // 
            this.del_recipient.BackColor = System.Drawing.Color.Red;
            this.del_recipient.Location = new System.Drawing.Point(27, 146);
            this.del_recipient.Name = "del_recipient";
            this.del_recipient.Size = new System.Drawing.Size(32, 23);
            this.del_recipient.TabIndex = 10;
            this.del_recipient.Text = "-";
            this.del_recipient.UseVisualStyleBackColor = false;
            // 
            // add_recipient
            // 
            this.add_recipient.BackColor = System.Drawing.Color.Lime;
            this.add_recipient.Location = new System.Drawing.Point(226, 146);
            this.add_recipient.Name = "add_recipient";
            this.add_recipient.Size = new System.Drawing.Size(32, 23);
            this.add_recipient.TabIndex = 11;
            this.add_recipient.Text = "+";
            this.add_recipient.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_mail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_mail.ResumeLayout(false);
            this.panel_mail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.count_mail_numeric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_mail;
        private System.Windows.Forms.CheckBox IsHTML;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.NumericUpDown count_mail_numeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_mail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox thema_mail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox recipients_LB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button add_recipient;
        private System.Windows.Forms.Button del_recipient;
    }
}

