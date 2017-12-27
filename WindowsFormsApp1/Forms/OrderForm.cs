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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();

            using (var db = new ApplicationContext())
            {
                db.Users.Load();

                var performers = db.Users.Where(u => u.Role.NameRole == "Исполнитель");

                PerformerBox.Items.AddRange(performers.ToArray());

                updateOrders();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                var order = new Order();

                db.Users.Load();
                order.Client = db.Users.FirstOrDefault(u => u.Id == ApplicationContext.CurrentUser.Id);

                if (OranizationTextBox.Text.Length != 0 && OranizationTextBox.Text.Length < 50)
                    order.Organization = OranizationTextBox.Text;
                else
                {
                    MessageBox.Show("Введите организацию!");
                    return;
                }

                if (NameSoftwareTextBox.Text.Length != 0 && NameSoftwareTextBox.Text.Length < 50)
                    order.SoftwareName = NameSoftwareTextBox.Text;
                else
                {
                    MessageBox.Show("Введите название ПО!");
                    return;
                }

                if (BankTextBox.Text.Length >= 16 && BankTextBox.Text.Length < 19)
                    order.ClientBankInfo = BankTextBox.Text;
                else
                {
                    MessageBox.Show("Вы ввели некорректную бнковскую карту!");
                    return;
                }

                if (PerformerBox.Text.Length != 0)
                    order.Performer = db.Users.FirstOrDefault(u => u.Id == ((User)PerformerBox.SelectedItem).Id);
                else
                {
                    MessageBox.Show("Выбирите исполнителя!");
                    return;
                }

                order.Comment = CommentTextBox.Text;

                db.Statuses.Load();
                order.OrderStatus = db.Statuses.First();

                db.Orders.Add(order);

                db.SaveChanges();

                OrderListBox.Items.Add(order);
            }
        }

        private void OrderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                
                db.Orders.Load();
                db.Statuses.Load();
                var currentOrder = (Order)OrderListBox.SelectedItem;
                if (currentOrder != null)
                {
                    var dbOrder = db.Orders.FirstOrDefault(u => u.Id == currentOrder.Id);
                    var contractOrder = dbOrder.OrderStatus.Name;
                    if (contractOrder == "Заказ отклонён")
                    {
                        MessageBox.Show("Заказ отклонен!");
                    }
                    else if (currentOrder != null)
                    {
                        var editOrderForm = new EditOrderForm(currentOrder.Id);
                        editOrderForm.ShowDialog();
                        updateOrders();
                    }
                    else MessageBox.Show("Выберите заказ!");
                }
            }
        }

        private void updateOrders()
        {
            OrderListBox.Items.Clear();
            using (var db = new ApplicationContext())
            {
                db.Orders.Load();

                var myOrders = db.Orders.Where(u => u.Client.Id == ApplicationContext.CurrentUser.Id);

                OrderListBox.Items.AddRange(myOrders.ToArray());
            }
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.loginForm.Show();
        }
    }
}
