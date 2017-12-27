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
    public partial class ContractEditForm : Form
    {
        private Contract contract;
        public ContractEditForm(Contract contract)
        {
            InitializeComponent();

            this.contract = contract;

            using (var db = new ApplicationContext())
            {
                db.Orders.Load();
                db.Contracts.Load();

                var currentContract = db.Contracts.FirstOrDefault(u => u.Id == contract.Id);

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
                db.Contracts.Load();

                var currentContract = db.Contracts.FirstOrDefault(u=> u.Id == contract.Id);

                currentContract.Subject = SoftwareTextBox.Text;

                currentContract.Date = dateTimePicker.Value;

                currentContract.ContractTime = Convert.ToInt32(SumTimeTextBox.Text);

                currentContract.TotalCost = Convert.ToInt32(SumPriseTextBox.Text);

                db.SaveChanges();
            }
        }
    }
}
