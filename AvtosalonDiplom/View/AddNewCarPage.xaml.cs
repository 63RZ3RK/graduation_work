using AvtosalonDiplom.Entity;
using Microsoft.Win32;
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

namespace AvtosalonDiplom.View
{
    /// <summary>
    /// Логика взаимодействия для AddNewCarPage.xaml
    /// </summary>
    public partial class AddNewCarPage : Page
    {
        public static Avtosalon3Entities3 Context;
        public AddNewCarPage()
        {
            InitializeComponent();
            Context = new Avtosalon3Entities3();
        }

        private void btnChoiceImg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fdg = new OpenFileDialog();
            if (fdg.ShowDialog() == true)
            {
                Photo.Source = new BitmapImage(new Uri(fdg.FileName, UriKind.RelativeOrAbsolute));
                string st = System.IO.Path.GetFileName(fdg.FileName);
                if (st == "")
                {
                    st = "Отсутствует";
                }
                PhotoPath.Text = st;
            }
        }

        private void SaveNewCar(object sender, RoutedEventArgs e)
        {
            string Date = DateTime.Today.ToShortDateString().ToString();

            if (String.IsNullOrWhiteSpace(Brand.Text) || String.IsNullOrWhiteSpace(Model.Text) || String.IsNullOrWhiteSpace(Year.Text) ||
                String.IsNullOrWhiteSpace(Color.Text) || String.IsNullOrWhiteSpace(Complectation.Text) || String.IsNullOrWhiteSpace(CBKPP.Text) ||
                String.IsNullOrWhiteSpace(CBType.Text) || String.IsNullOrWhiteSpace(Country.Text) || String.IsNullOrWhiteSpace(Reg.Text) || 
                String.IsNullOrWhiteSpace(Engine.Text) || String.IsNullOrWhiteSpace(Vin.Text) || String.IsNullOrWhiteSpace(Description.Text))
            {
                MessageBox.Show("Вы должны заплнить все поля!");
            }
            else
            if (Double.Parse(Cost.Text) < 0)
            {
                MessageBox.Show("Стоимость не может быть отрицательной!");
            }
            else
            {
                Avtomobili auto = new Avtomobili()
                {
                    CarBrand = Brand.Text,
                    ModelCar = Model.Text,
                    RegNumber = Reg.Text,
                    Cost = Convert.ToInt32(Cost.Text),
                    EngineInfo = Engine.Text,
                    YearAuto = Year.Text,
                    Color = Color.Text,
                    Country = Country.Text,
                    Complectation = Complectation.Text,
                    KPP = CBKPP.Text,
                    Img = PhotoPath.Text,
                    KuzovType = CBType.Text,
                    VIN = Vin.Text,
                    Description = Description.Text,
                    DatePublic = Date
                };

                Context.Avtomobili.Add(auto);
                Context.SaveChanges();
                MessageBox.Show("Авто успешно добавлено");
                Brand.Text = "";
                Model.Text = "";
                Reg.Text = "";
                Engine.Text = "";
                Cost.Text = "";
                Year.Text = "";
                Color.Text = "";
                Country.Text = "";
                Complectation.Text = "";
                CBKPP.Text = "";
                PhotoPath.Text = "";
                CBType.Text = "";
                Vin.Text = "";
                Description.Text = "";
                Photo.Source = null;
            } 
        }
    }
}
