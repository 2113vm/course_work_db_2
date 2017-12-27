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

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public static LoginForm loginForm;

        public LoginForm()
        {
            InitializeComponent();
            loginForm = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Roles.Load();
                db.Users.Load();
                var user = db.Users.FirstOrDefault(u => u.Login == textBoxLogin.Text && u.Password == textBoxPass.Text);

                if(user != null)
                {
                    ApplicationContext.CurrentUser = user;

                    switch (user.Role.NameRole)
                    {
                        case "Исполнитель":
                            {
                                var form = new Forms.OrderAcceptForm();
                                form.Show();
                                this.Hide();
                                break;
                            }
                        case "Заказчик":
                            {
                                var form = new Forms.OrderForm();
                                form.Show();
                                this.Hide();
                                break;
                            }
                        default:
                            MessageBox.Show("В базе данных нет вашей роли! Обратитесь за помощью к администратору.");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                var role = new Role
                {
                    Login = "Performer",
                    NameRole = "Исполнитель",
                    Password = "IamPerformer"
                };

                var role1 = new Role
                {
                    Login = "Client",
                    NameRole = "Заказчик",
                    Password = "IamClient"
                };

                var role2 = new Role
                {
                    Login = "Admin",
                    NameRole = "Администратор",
                    Password = "IamAdmin"
                };

                var user = new User
                {
                    Login = "3DiVi",
                    Password = "123",
                    Role = role
                };

                var user1 = new User
                {
                    Login = "MyCompany",
                    Password = "123",
                    Role = role
                };

                var user2 = new User
                {
                    Login = "Завод",
                    Password = "123",
                    Role = role1
                };

                var user3 = new User
                {
                    Login = "Фирма",
                    Password = "123",
                    Role = role1
                };

                var user4 = new User
                {
                    Login = "admin",
                    Password = "123",
                    Role = role2
                };

                var status = new Status
                {
                    Name = "Составление договора"
                };

                var status1 = new Status
                {
                    Name = "Договор составлен"
                };

                var status2 = new Status
                {
                    Name = "Договор подтверждён"
                };

                var status3 = new Status
                {
                    Name = "Заказ отклонён"
                };

                var status4 = new Status
                {
                    Name = "Договор просрочен"
                };

                var status5 = new Status
                {
                    Name = "На этапе \"Анализ требований\""
                };

                var status6 = new Status
                {
                    Name = "На этапе \"Проектирование\""
                };

                var status7 = new Status
                {
                    Name = "На этапе \"Реализация\""
                };

                var status8 = new Status
                {
                    Name = "На этапе \"Внедрение\""
                };

                db.Database.Migrate();

                db.Roles.Add(role);
                db.Roles.Add(role1);
                db.Roles.Add(role2);

                db.Users.Add(user);
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.Users.Add(user3);
                db.Users.Add(user4);

                db.Statuses.Add(status);
                db.Statuses.Add(status1);
                db.Statuses.Add(status2);
                db.Statuses.Add(status3);
                db.Statuses.Add(status4);
                db.Statuses.Add(status5);
                db.Statuses.Add(status6);
                db.Statuses.Add(status7);
                db.Statuses.Add(status8);

                db.SaveChanges();
            }
        }
    }
}
