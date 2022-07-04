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
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Window
    {
        public string FIO, IDKlient, Phone, Email;
        public UserPage(string FIO, string IDKlient, string Phone, string Email)
        {
            InitializeComponent();
            MainFrame.Navigate(new View.userGuestCarsList());
            this.FIO = FIO;
            this.IDKlient = IDKlient;
            this.Phone = Phone;
            this.Email = Email;
            UserName.Text = FIO;
        }

        private void ClientOrdersList(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.ClientsOrdersPage(IDKlient));
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow exit = new MainWindow();
            exit.Show();
            this.Close();
        }

        private void HomeClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.userGuestCarsList());
        }

        private void NewOrderForm(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.AddNewOrder(FIO, IDKlient,Phone, Email));
        }
    }
}
