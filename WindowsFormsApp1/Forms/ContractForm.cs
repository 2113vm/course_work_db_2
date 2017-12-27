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
    public partial class ContractForm : Form
    {
        private Order order;

        public ContractForm(Order order)
        {
            InitializeComponent();

            this.order = order;

            using(var db = new ApplicationContext())
            {
                db.Orders.Load();
                db.Users.Load();

                var currentOrder = db.Orders.FirstOrDefault(u => u.Id == order.Id);

                NumberOrderTextBox.Text = currentOrder.Number + "";

                ClientTextBox.Text = currentOrder.Organization;

                PerformerTextBox.Text = currentOrder.Performer.Login;

                SoftwareTextBox.Text = currentOrder.SoftwareName;

                SumTimeTextBox.Text = db.Stages.Where(u => u.OrderId.Id == currentOrder.Id).Sum(u => u.Duration) + "";

                SumPriseTextBox.Text = db.Stages.Where(u => u.OrderId.Id == currentOrder.Id).Sum(u => u.Priсe) + "";
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                db.Orders.Load();
                db.Users.Load();
                db.Contracts.Load();

                var contract = new Contract();

                contract.Customer = ClientTextBox.Text;

                contract.Performer = PerformerTextBox.Text;

                contract.Subject = SoftwareTextBox.Text;

                contract.Date = dateTimePicker.Value;

                contract.ContractTime = Convert.ToInt32(SumTimeTextBox.Text);

                contract.TotalCost = Convert.ToInt32(SumPriseTextBox.Text);

                var currentOrder = db.Orders.FirstOrDefault(u => u.Id == order.Id);
                contract.Order = currentOrder;

                db.Contracts.Add(contract);

                db.SaveChanges();
            }
        }
    }
}
