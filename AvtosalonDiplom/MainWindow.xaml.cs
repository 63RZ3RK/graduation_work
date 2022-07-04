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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AvtosalonDiplom.Entity;
using AvtosalonDiplom.View;
using MaterialDesignThemes;

namespace AvtosalonDiplom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Avtosalon3Entities3 Context;
        public MainWindow()
        {
            InitializeComponent();
            Context = new Avtosalon3Entities3();
        }

        private void RegistrationMove_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            bool proverka = false;
            foreach (Klienti klient in Context.Klienti)
            {               
                if (klient.Email == EmailTB.Text.Trim() && klient.Password.Trim() == PasswordBox.Password)
                {
                    if(klient.UserType == "Admin")
                    {
                        CarsList carsList = new CarsList(klient.FIO);
                        carsList.Show();
                        this.Close();
                        proverka = true;
                        
                    }
                    if(klient.UserType == "User")
                    {
                        UserPage userPage = new UserPage(klient.FIO,klient.IDKlient.ToString(), klient.Phone, klient.Email);
                        userPage.Show();
                        this.Close();
                        proverka = true;
                        break;
                    }                   
                }              
            }
            if(!proverka)
            {
                MessageBox.Show("Проверьте правильность введенных данных");
                EmailTB.Text = null;
                PasswordBox.Password = null;
            }
        }

        private void Guest_Click(object sender, RoutedEventArgs e)
        {
            GuestPage guestPage = new GuestPage("Гость");
            guestPage.Show();
            this.Close();
        }
    }
}
