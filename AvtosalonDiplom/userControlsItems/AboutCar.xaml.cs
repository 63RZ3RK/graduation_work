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
    /// Логика взаимодействия для AboutCar.xaml
    /// </summary>
    public partial class AboutCar : UserControl
    {
        Zayavki zayavki;
        public static Avtosalon3Entities3 Context;
        public AboutCar(Zayavki zayavki)
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

            foreach (Status status in Context.Status.ToList())
            {
                StatusCB.Items.Add(status.StatusName);
            }

            StatusCB.SelectedIndex = (int)zayavki.Status - 1;
        }

        private void NewOrderStatus(object sender, SelectionChangedEventArgs e)
        {
            int index = zayavki.IDZayavki;
            var Zayavki = Context.Zayavki
                .Where(c => c.IDZayavki == index);

            foreach (var zayavka in Zayavki)
            {
                if (StatusCB.SelectedIndex == 0)
                {
                    BorderOrder.BorderBrush = Brushes.Yellow;
                    zayavka.Status = 1;
                }

                else if (StatusCB.SelectedIndex == 1)
                {
                    BorderOrder.BorderBrush = Brushes.Red;
                    zayavka.Status = 2;
                }

                else if (StatusCB.SelectedIndex == 2)
                {
                    BorderOrder.BorderBrush = Brushes.Green;
                    zayavka.Status = 3;                   
                }

                else if (StatusCB.SelectedIndex == 4)
                {
                    BorderOrder.BorderBrush = Brushes.Red;
                    zayavka.Status = 4;
                }
            }
            Context.SaveChanges();
        }
    }
}
