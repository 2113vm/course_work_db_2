using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class EditOrderForm : Form
    {
        private static int orderId;
        public EditOrderForm(int Id)
        {
            orderId = Id;
            InitializeComponent();

            using (var db = new ApplicationContext())
            {
                db.Orders.Load();
                db.Users.Load();
                db.Statuses.Load();

                var currentOrder = db.Orders.Find(Id);
                BankTextBox.Text = currentOrder.ClientBankInfo;
                OranizationTextBox.Text = currentOrder.Organization;
                NameSoftwareTextBox.Text = currentOrder.SoftwareName;
                CommentTextBox.Text = currentOrder.Comment;
                StatusBox.Text = currentOrder.OrderStatus.ToString();

                var performers = db.Users.Where(u => u.Role.NameRole == "Исполнитель");
                PerformerBox.Items.AddRange(performers.ToArray());

                PerformerBox.Text = currentOrder.Performer.Login;
            }
        }

        private void EditOrderButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                db.Orders.Load();
                db.Users.Load();

                var currentOrder = db.Orders.Find(orderId);

                currentOrder.Comment = CommentTextBox.Text;
                var contract = db.Contracts.FirstOrDefault(u => u.Order.Id == currentOrder.Id);
                if (contract != null)
                {
                    MessageBox.Show("Договор составлен. Редактировать нельзя!");
                    return;
                }
                //====================================
                if (OranizationTextBox.Text.Length != 0 && OranizationTextBox.Text.Length < 50)
                    currentOrder.Organization = OranizationTextBox.Text;
                else
                {
                    MessageBox.Show("Укажите организацию!");
                    return;
                }

                if (NameSoftwareTextBox.Text.Length != 0 && NameSoftwareTextBox.Text.Length < 50)
                    currentOrder.SoftwareName = NameSoftwareTextBox.Text;
                else
                {
                    MessageBox.Show("Введите название ПО!");
                    return;
                }

                if (BankTextBox.Text.Length >= 16 && BankTextBox.Text.Length < 19)
                    currentOrder.ClientBankInfo = BankTextBox.Text;
                else
                {
                    MessageBox.Show("Вы ввели некорректный номер банковской карты!");
                    return;
                }

                if (PerformerBox.Text.Length != 0)
                    currentOrder.Performer = db.Users.FirstOrDefault(u => u.Id == ((User)PerformerBox.SelectedItem).Id);
                else
                {
                    MessageBox.Show("Укажите заказчика!");
                    return;
                }
                db.SaveChanges();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenContractButton_Click(object sender, EventArgs e)
        {
            using(var db = new ApplicationContext())
            {
                db.Contracts.Load();
                var contract = db.Contracts.FirstOrDefault(u => u.Order.Id == orderId);
                if (contract == null)
                {
                    MessageBox.Show("Договор ещё не составлен. Ждите обновление статуса!");
                    return;
                }
                else
                {
                    var acceptContractForm = new AcceptContractForm(orderId);
                    acceptContractForm.ShowDialog();
                }
            }
        }
    }
}
