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
    /// Логика взаимодействия для carsListItemClientsNGuests.xaml
    /// </summary>
    public partial class carsListItemClientsNGuests : UserControl
    {
        public static Avtosalon3Entities3 Context;
        Avtomobili avtomobili;
        public carsListItemClientsNGuests(Avtomobili avtomobili)
        {
            InitializeComponent();
            Context = new Avtosalon3Entities3();
            this.avtomobili = avtomobili;
            DataContext = avtomobili;
            string rub = " ₽";
            string desc = "Описание: ";
            string cvet = "Цвет: ";
            string country = "Страна производитель: ";
            string complect = "Комплектация: ";
            string kuzov = "Тип кузова: ";
            string vin = "VIN: ";

            BrandLabel.Content = avtomobili.CarBrand.ToUpper();
            ModelLabel.Content = avtomobili.ModelCar.ToUpper();
            ColorLabel.Content = cvet + avtomobili.Color;
            CountryLabel.Content = country + avtomobili.Country;
            ComplectationLabel.Content = complect + avtomobili.Complectation;
            KuzovTypeLabel.Content = kuzov + avtomobili.KuzovType;
            VINLabel.Content = vin + avtomobili.VIN;
            CostLabel.Content = avtomobili.Cost + rub;
            Description.Content = desc + avtomobili.Description;

            if (avtomobili.Img == "Отсутствует" || avtomobili.Img == "")
            {
                Photo.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\AutoPictures\picture.png"));
            }
            else
            {
                Photo.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\AutoPictures\\" + avtomobili.Img));
            }
        }
    }
}
