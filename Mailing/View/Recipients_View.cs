using Mailing.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mailing.View
{
    public partial class Recipients_View : Form
    {
        Email_rep _Rep = new Email_rep();
        public Recipients_View()
        {
            InitializeComponent();
            _Rep.GetColl().ToList().ForEach(i => recipients_LB.Items.Add(i.email));
            add_to_list.Click += Add_to_list_Click;
            del_recipient.Click += Del_recipient_Click;
            add_recipient.Click += Add_recipient_Click;
            init_listbox();
        }
        public void init_listbox()
        {
            recipients_LB.Items.Clear();
            _Rep.GetColl().ToList().ForEach(i => recipients_LB.Items.Add(i.email)); 
        }

        private void Add_recipient_Click(object sender, EventArgs e)
        {
            if (new_item.Text != null && new_item.Text != string.Empty)
            { _Rep.Create(new MyEmail() {email= new_item.Text }); }
            init_listbox();
        }

        private void Del_recipient_Click(object sender, EventArgs e)
        {
            if (recipients_LB.SelectedItem == null)
                return;
            _Rep.Delete(new MyEmail() {email= recipients_LB.SelectedItem.ToString() });
            MessageBox.Show("Успех", "Удалено");
            init_listbox();
        }

        private void Add_to_list_Click(object sender, EventArgs e)
        {
            if(recipients_LB.SelectedItem==null)
            {
                MessageBox.Show("Ошибка", "Вы ничего не выбрали");
                return;
            }
            Model_mailin._recipients.Add(new MailAddress(recipients_LB.SelectedItem.ToString()));
            MessageBox.Show("Успех", "Добавлено");
        }
    }
}
