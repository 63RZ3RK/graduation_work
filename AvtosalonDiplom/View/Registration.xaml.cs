using AvtosalonDiplom.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AvtosalonDiplom.View
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public static Avtosalon3Entities3 Context;
        public Registration()
        {
            InitializeComponent();
            Context = new Avtosalon3Entities3();
        }

        private void AuthorizationMove_Click(object sender, RoutedEventArgs e)
        {
            MainWindow authorization = new MainWindow();
            authorization.Show();
            this.Close();
        }

        private void SaveNewUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string fio = FIO.Text.Trim();
                string phone = Phone.Text.Trim().ToLower();
                string birthday = BirthDay.Text.Trim().ToLower();
                string addres = Addres.Text.Trim().ToLower();
                string email = Email.Text.Trim().ToLower();
                string pasportNumber = PassportNumber.Text.Trim().ToLower();
                string password = PasswordTB.Text.Trim().ToLower();
                DateTime date = new DateTime(2006, 1, 1);

                var klient = Context.Klienti;
                foreach (var k in klient)
                {
                    if (k.PasportNumber == pasportNumber)
                    {
                        MessageBox.Show("Серия и номер паспорта уже используются");
                        break;
                    }

                    else if (k.Phone == phone)
                    {
                        MessageBox.Show("Номер телефона уже занят");
                        break;
                    }

                    else if (k.Email == email)
                    {
                        MessageBox.Show("Email уже занят");
                        Email.Text = "";
                        email = "";
                        break;
                    }
                }

                if (fio.Length < 5)
                {
                    MarkInvalid(FIO);
                }

                else if (phone.Length < 11)
                {
                    MarkInvalid(Phone);
                }

                else if (BirthDay.SelectedDate >= date)
                {
                    BirthDay.ToolTip = "Минимальный возраст 16 лет";
                    MarkInvalid(BirthDay);
                }

                else if (addres.Length < 7)
                {
                    Addres.ToolTip = "Адрес должен содержать минимум 7 символов";
                    MarkInvalid(Addres);
                }

                else if (email.Length < 10 && !email.Contains("@") && !email.Contains("."))
                {
                    Email.ToolTip = "example@gmail.com";
                    MarkInvalid(Email);
                }

                else if (pasportNumber.Length < 10)
                {
                    PassportNumber.ToolTip = "Серия и номер должны быть в точности с паспортом";
                    MarkInvalid(PassportNumber);
                }

                else if (password.Length < 7)
                {
                    PasswordTB.ToolTip = "Пароль должен содержать минимум 7 символов";
                    MarkInvalid(PasswordTB);
                }

                else
                {
                    Klienti klienti = new Klienti()
                    {
                        FIO = fio,
                        Phone = phone,
                        Birthday = birthday,
                        Adress = addres,
                        Email = email,
                        PasportNumber = pasportNumber,
                        Password = password,
                        UserType = "User"
                    };

                    Context.Klienti.Add(klienti);
                    Context.SaveChanges();

                    MessageBox.Show("Пользователь успешно добавлен");
                    MainWindow authorization = new MainWindow();
                    authorization.Show();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Не удалось добавить пользователя");
            }
        }

        public void MarkInvalid(Control control)
        {
            control.BorderBrush = Brushes.Red;
        }

        public void MarkValid(Control control)
        {
            control.ToolTip = "";
            control.BorderBrush = Brushes.Transparent;
        }
    }
}
