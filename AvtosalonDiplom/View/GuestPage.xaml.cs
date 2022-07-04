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
    /// Логика взаимодействия для GuestPage.xaml
    /// </summary>
    public partial class GuestPage : Window
    {
        public string FIO;
        public GuestPage(string FIO)
        {
            InitializeComponent();
            MainFrame.Navigate(new View.userGuestCarsList());
            this.FIO = FIO;
            UserName.Text = FIO;
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
    }
}
