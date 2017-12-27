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
    public partial class StagesForm : Form
    {
        private Order currentOrder;
        private Stage selectStage = null;
        public StagesForm(Order order)
        {
            InitializeComponent();

            currentOrder = order;

            using (var db = new ApplicationContext())
            {
                db.Users.Load();
                var performers = db.Users.Where(u => u.Role.NameRole == "Исполнитель");

                PerformerBox.Items.AddRange(performers.ToArray());
            }
        }

        public StagesForm(Stage stage)
        {
            InitializeComponent();
            selectStage = stage;

            using (var db = new ApplicationContext())
            {
                NameStageComboBox.Text = stage.Name;
                db.Users.Load();

                var performers = db.Users.Where(u => u.Role.NameRole == "Исполнитель");
                PerformerBox.Items.AddRange(performers.ToArray());

                PerformerBox.Text = stage.Performer.Login;

                TimeTextBox.Text = stage.Duration + "";

                PriceTextBox.Text = stage.Priсe + "";

            }
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                db.Orders.Load();
                db.Stages.Load();
                db.Users.Load();

                Stage stage = new Stage();

                if (selectStage != null)
                    stage = db.Stages.FirstOrDefault(u => u.Id == selectStage.Id);

                if (currentOrder == null)
                    currentOrder = db.Orders.FirstOrDefault(u => u.Id == stage.OrderId.Id);

                stage.OrderId = db.Orders.FirstOrDefault(u => u.Id == currentOrder.Id);

                if (NameStageComboBox.Text.Length != 0 && NameStageComboBox.Text.Length < 50)
                    stage.Name = NameStageComboBox.Text;
                else
                {
                    MessageBox.Show("Введите название этапа!");
                    return;
                }
                
                if (PerformerBox.Text.Length != 0)
                    stage.Performer = db.Users.FirstOrDefault(u => u.Id == ((User)PerformerBox.SelectedItem).Id);
                else
                {
                    MessageBox.Show("Укажите исполнителя!");
                    return;
                }

                bool converted = Int32.TryParse(TimeTextBox.Text, out int days);
                if (converted && days > 0 && days < 100)
                    stage.Duration = days;
                else
                {
                    MessageBox.Show("Максимальная длительность этапа 100 дней!");
                    return;
                }

                converted = Int32.TryParse(PriceTextBox.Text, out int price);
                if (converted && price > 0)
                    stage.Priсe = price;
                else
                {
                    MessageBox.Show("Введите цену!");
                    return;
                }

                if(selectStage == null)
                    db.Stages.Add(stage);

                db.SaveChanges();
            }
            this.Close();
        }

        private void SubContractButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                var orderForm = new OrderForm();

                orderForm.OranizationTextBox.Text = ApplicationContext.CurrentUser.Login;

                orderForm.NameSoftwareTextBox.Text = NameStageComboBox.Text;

                orderForm.PerformerBox.Text = PerformerBox.Text;



                orderForm.ShowDialog();

            }

        }

        private void PerformerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectPerformer = (User)PerformerBox.SelectedItem;
            if (selectPerformer.Id != ApplicationContext.CurrentUser.Id && NameStageComboBox.Text.Length > 0)
                SubContractButton.Visible = true;
            else SubContractButton.Visible = false;
        }
    }
}
