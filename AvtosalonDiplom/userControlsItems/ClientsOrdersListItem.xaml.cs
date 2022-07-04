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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AvtosalonDiplom.userControlsItems
{
    /// <summary>
    /// Логика взаимодействия для ClientsOrdersListItem.xaml
    /// </summary>
    public partial class ClientsOrdersListItem : UserControl
    {
        Zayavki zayavki;
        public static Avtosalon3Entities3 Context;
        public ClientsOrdersListItem(Zayavki zayavki)
        {
            InitializeComponent();
            Context = new Avtosalon3Entities3();
            this.zayavki = zayavki;
            DataContext = zayavki;

            string fio = "Ф.И.О: ";
            string email = "Эл. Почта: ";
            string phone = "Телефон: ";
            string brand = "Марка: ";
            string model = "Модель: ";
            string cost = "Цена: ";
            string rub = " ₽";
            string year = "Год выпуска: ";
            string cvet = "Цвет: ";
            string complect = "Комплектация: ";
            string stat= "Статус: ";

            FIOLabel.Content = fio + zayavki.FIO;
            EmailLabel.Content = email + zayavki.Email;
            PhoneLabel.Content = phone + zayavki.Phone;
            CarBrandLabel.Content = brand + zayavki.CarBrand;
            ModelCarLabel.Content = model + zayavki.ModelCar;
            CostLabel.Content = cost + zayavki.Cost + rub;
            YearLabel.Content = year + zayavki.YearAuto;
            ColorLabel.Content = cvet + zayavki.Color;
            ComplectationLabel.Content = complect + zayavki.Complectation;

            if (zayavki.Status == 1)
            {
                BorderOrder.BorderBrush = Brushes.Yellow;
            }

            else if (zayavki.Status == 2)
            {
                BorderOrder.BorderBrush = Brushes.Red;
            }

            else if (zayavki.Status == 3)
            {
                BorderOrder.BorderBrush = Brushes.Green;
            }

            else if (zayavki.Status == 4)
            {
                BorderOrder.BorderBrush = Brushes.Red;
            }

            var Zayavki = Context.Status
                .Where(c => c.IDStatus == zayavki.Status);
            foreach (Status status in Zayavki)
            {
                StatusLabel.Content = stat + status.StatusName;
            }

            if(zayavki.Status != 1)
            {
                CancelOrder.Visibility = Visibility.Hidden;
            }
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            BorderOrder.BorderBrush = Brushes.Red;

            int index = zayavki.IDZayavki;
            var Zayavka = Context.Zayavki
                .Where(c => c.IDZayavki == index);

            foreach (Zayavki zayavka in Zayavka)
            {
                zayavka.Status = 4;
            }
            Context.SaveChanges();
        }
    }
}
