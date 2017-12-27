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
    public partial class OrderAcceptForm : Form
    {
        public OrderAcceptForm()
        {
            InitializeComponent();

            using (var db = new ApplicationContext())
            {
                db.Orders.Load();
                db.Users.Load();

                var myOrders = db.Orders.Where(u => u.Performer.Id == ApplicationContext.CurrentUser.Id);

                OrderListBox.Items.AddRange(myOrders.ToArray());

                db.Statuses.Load();
                StatusBox.Items.AddRange(db.Statuses.ToArray());
            }
        }

        private void CreateContractButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                db.Orders.Load();
                db.Contracts.Load();
                db.Statuses.Load();

                var order = db.Orders.FirstOrDefault(u => u.Id == ((Order)OrderListBox.SelectedItem).Id);
                var contract = db.Contracts.FirstOrDefault(u => u.Order.Id == ((Order)OrderListBox.SelectedItem).Id);
                if (order != null && order.OrderStatus.Name == "Заказ отклонён")
                    MessageBox.Show("Заказ отменен. Договор составить нельзя!");
                else if (contract == null)
                {
                    if (StagesListBox.Items.Count > 0)
                    {
                        var form = new Forms.ContractForm((Order)OrderListBox.SelectedItem);
                        form.ShowDialog();
                    }
                    else MessageBox.Show("Заполните этапы!");
                }
                else MessageBox.Show("У вас уже есть контракт по этому заказу!");
            }

        }

        private void OrderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentOrder = (Order)OrderListBox.SelectedItem;
            if (currentOrder != null)
            {
                BankInfoTextBox.Text = currentOrder.ClientBankInfo;
                OrganizationTextBox.Text = currentOrder.Organization;
                SoftwareTextBox.Text = currentOrder.SoftwareName;
                CommentTextBox.Text = currentOrder.Comment;
                StatusBox.Text = currentOrder.OrderStatus.ToString();
                updateStages();
            }
            else MessageBox.Show("Выберите заказ!");
        }

        private void AcceptStatusButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                var selectOrder = (Order)OrderListBox.SelectedItem;

                var currentContract = db.Contracts.FirstOrDefault(u => u.Order.Id == ((Order)OrderListBox.SelectedItem).Id);

                if (currentContract == null && 
                    (StatusBox.SelectedItem.ToString() != "Составление договора" && 
                    StatusBox.SelectedItem.ToString() != "Заказ отклонён") )
                {
                    MessageBox.Show("Прежде чем менять статус, составьте договор!");
                    return;
                }

                if (selectOrder != null)
                {
                    var currentOrder = db.Orders.FirstOrDefault(u => u.Id == selectOrder.Id);
                    var newOrderStatus = db.Statuses.
                        FirstOrDefault(u => u.Id == ((Status)StatusBox.SelectedItem).Id);
                    currentOrder.OrderStatus = newOrderStatus;
                    db.SaveChanges();
                    selectOrder.OrderStatus = newOrderStatus;
                }
                else
                {
                    MessageBox.Show("Выбирите заказ!");
                }
            }
        }

        private void EditContractButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                db.Orders.Load();
                db.Statuses.Load();

                var selectOrder = (Order)OrderListBox.SelectedItem;

                if (selectOrder != null)
                {
                    var currentOrder = db.Orders.FirstOrDefault(u => u.Id == selectOrder.Id);
                    if(currentOrder != null && currentOrder.OrderStatus.Id > 2)
                    {
                        MessageBox.Show("Договор подтвержден. Редактировать нельзя!");
                        return;
                    }
                    var contract = db.Contracts.FirstOrDefault(u => u.Order.Id == ((Order)OrderListBox.SelectedItem).Id);

                    if (contract != null)
                    {
                        var editContract = new ContractEditForm(contract);
                        editContract.ShowDialog();
                    }
                    else MessageBox.Show("Договор по этому заказу ещё не создан!");
                }
                else MessageBox.Show("Выберите Заказ!");
            }

        }

        private void AddStageButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                db.Orders.Load();
                db.Statuses.Load();

                var selectOrder = (Order)OrderListBox.SelectedItem;
                var dbOrder = db.Orders.FirstOrDefault(u => u.Id == selectOrder.Id);
                if (dbOrder != null && dbOrder.OrderStatus.Id > 2)
                {
                    MessageBox.Show("Договор подтвержден. Добавлять этапы нельзя!");
                }
                else if (selectOrder != null)
                {
                    StagesForm form = new StagesForm(selectOrder);
                    form.ShowDialog();
                    updateStages();
                }
                else MessageBox.Show("Выберите этап!");
            }

        }

        private void updateStages()
        {
            StagesListBox.Items.Clear();
            using (var db = new ApplicationContext())
            {

                db.Stages.Load();

                db.Orders.Load();
                db.Users.Load();
                var order = (Order)OrderListBox.SelectedItem;
                if (order != null)
                {
                    var currentStages = db.Stages.Where(u => u.OrderId.Id == order.Id);

                    StagesListBox.Items.AddRange(currentStages.ToArray());
                }
            }
        }

        private void OrderAcceptForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.loginForm.Show();
        }

        private void StagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectStage = (Stage)StagesListBox.SelectedItem;
            if (selectStage != null)
            {
                var editOrderForm = new StagesForm(selectStage);
                editOrderForm.ShowDialog();
                updateStages();
            }
            else MessageBox.Show("Выберите этап!");
        }

        private void StatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                db.Orders.Load();
                db.Statuses.Load();
                db.Contracts.Load();

                var currentOrder = db.Orders.FirstOrDefault(u => u.Id == ((Order)OrderListBox.SelectedItem).Id);
                var currentContract = db.Contracts.FirstOrDefault(u => u.Order.Id == ((Order)OrderListBox.SelectedItem).Id);
                if(currentContract == null && (StatusBox.SelectedItem.ToString() == "Договор подтверждён" ||
                                                StatusBox.SelectedItem.ToString() == "Договор составлен"))
                {
                    MessageBox.Show("Договор еще не составлен!");
                    return;
                }
                var currentStatus = currentOrder.OrderStatus.Id - 1;
                if (currentOrder.OrderStatus.Name == "Заказ отклонён")
                {
                    StatusBox.SelectedIndex = currentStatus;
                    MessageBox.Show("Заказ отклонен!");
                }
                else if (StatusBox.SelectedIndex < currentStatus)
                {
                    StatusBox.SelectedIndex = currentStatus;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderForm form = new OrderForm();
            form.ShowDialog();
        }
    }
}
