
namespace Mailing.View
{
    partial class Recipients_View
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
            this.recipients_LB = new System.Windows.Forms.ListBox();
            this.add_recipient = new System.Windows.Forms.Button();
            this.del_recipient = new System.Windows.Forms.Button();
            this.add_to_list = new System.Windows.Forms.Button();
            this.new_item = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recipients_LB
            // 
            this.recipients_LB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recipients_LB.FormattingEnabled = true;
            this.recipients_LB.ItemHeight = 15;
            this.recipients_LB.Location = new System.Drawing.Point(0, 116);
            this.recipients_LB.Name = "recipients_LB";
            this.recipients_LB.Size = new System.Drawing.Size(428, 334);
            this.recipients_LB.TabIndex = 0;
            // 
            // add_recipient
            // 
            this.add_recipient.BackColor = System.Drawing.Color.Lime;
            this.add_recipient.Location = new System.Drawing.Point(372, 68);
            this.add_recipient.Name = "add_recipient";
            this.add_recipient.Size = new System.Drawing.Size(32, 23);
            this.add_recipient.TabIndex = 13;
            this.add_recipient.Text = "+";
            this.add_recipient.UseVisualStyleBackColor = false;
            // 
            // del_recipient
            // 
            this.del_recipient.BackColor = System.Drawing.Color.Red;
            this.del_recipient.Location = new System.Drawing.Point(242, 68);
            this.del_recipient.Name = "del_recipient";
            this.del_recipient.Size = new System.Drawing.Size(32, 23);
            this.del_recipient.TabIndex = 12;
            this.del_recipient.Text = "-";
            this.del_recipient.UseVisualStyleBackColor = false;
            // 
            // add_to_list
            // 
            this.add_to_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.add_to_list.Location = new System.Drawing.Point(12, 68);
            this.add_to_list.Name = "add_to_list";
            this.add_to_list.Size = new System.Drawing.Size(174, 23);
            this.add_to_list.TabIndex = 14;
            this.add_to_list.Text = "Добавить в рассылку";
            this.add_to_list.UseVisualStyleBackColor = false;
            // 
            // new_item
            // 
            this.new_item.Location = new System.Drawing.Point(242, 12);
            this.new_item.Name = "new_item";
            this.new_item.Size = new System.Drawing.Size(174, 23);
            this.new_item.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(108, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "новый Tmail";
            // 
            // Recipients_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.new_item);
            this.Controls.Add(this.add_to_list);
            this.Controls.Add(this.add_recipient);
            this.Controls.Add(this.del_recipient);
            this.Controls.Add(this.recipients_LB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Recipients_View";
            this.Text = "Recipients_View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox recipients_LB;
        private System.Windows.Forms.Button add_recipient;
        private System.Windows.Forms.Button del_recipient;
        private System.Windows.Forms.Button add_to_list;
        private System.Windows.Forms.TextBox new_item;
        private System.Windows.Forms.Label label1;
    }
}