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
    /// Логика взаимодействия для CarsList.xaml
    /// </summary>
    public partial class CarsList : Window
    {
        public string FIO;
        public CarsList(string FIO)
        {
            InitializeComponent();
            MainFrame.Navigate(new View.CarsListFrame());
            this.FIO = FIO;
            UserName.Text = FIO;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow exit = new MainWindow();
            exit.Show();
            this.Close();
        }

        private void AddNewCar(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.AddNewCarPage());
        }

        private void HomeClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.CarsListFrame());
        }

        private void SellsClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.SellsList());
        }

        private void OrdersClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.OrdersList());
        }

        private void ClientsClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.ClientsList());
        }
    }
}
