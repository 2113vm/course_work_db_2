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
    public partial class AcceptContractForm : Form
    {
        private int orderId;
        public AcceptContractForm(int orderId)
        {
            InitializeComponent();

            this.orderId = orderId;

            using (var db = new ApplicationContext())
            {
                db.Orders.Load();
                db.Contracts.Load();

                var currentContract = db.Contracts.FirstOrDefault(u => u.Order.Id == orderId);
                
                NumberOrderTextBox.Text = currentContract.Id + "";

                ClientTextBox.Text = currentContract.Customer;

                PerformerTextBox.Text = currentContract.Performer;

                SoftwareTextBox.Text = currentContract.Subject;

                SumTimeTextBox.Text = currentContract.ContractTime + "";

                SumPriseTextBox.Text = currentContract.TotalCost + "";

                dateTimePicker.Value = currentContract.Date;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                db.Orders.Load();
                db.Statuses.Load();

                var order = db.Orders.FirstOrDefault(u => u.Id == orderId);
                if(order != null && order.OrderStatus.Id > 2){
                    return;
                }
                order.OrderStatus = db.Statuses.FirstOrDefault(u => u.Name == "Договор подтверждён");

                db.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                db.Orders.Load();
                db.Statuses.Load();

                var order = db.Orders.FirstOrDefault(u => u.Id == orderId);
                if (order != null && order.OrderStatus.Id > 2)
                {
                    MessageBox.Show("Нельзя отклонить договор!");
                    return;
                }
                order.OrderStatus = db.Statuses.FirstOrDefault(u => u.Name == "Заказ отклонён");

                db.SaveChanges();
            }
        }
    }
}
