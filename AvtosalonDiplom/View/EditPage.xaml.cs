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
using System.Windows.Shapes;

namespace AvtosalonDiplom.View
{
    /// <summary>
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Window
    {
        public static Avtosalon3Entities3 Context;
        public int Index { get; set; }
        public EditPage(int index)
        {
            InitializeComponent();
            Context = new Avtosalon3Entities3();
            Index = index;

            var avtomobili = Context.Avtomobili
                .Where(c => c.IDAvto == index);

            foreach (var avtomobil in avtomobili)
            {
                Brand.Text = avtomobil.CarBrand;
                Model.Text = avtomobil.ModelCar;
                Reg.Text = avtomobil.RegNumber;
                Engine.Text = avtomobil.EngineInfo;
                Cost.Text = avtomobil.Cost.ToString();
                Year.Text = avtomobil.YearAuto;
                Color.Text = avtomobil.Color;
                Country.Text = avtomobil.Country;
                Complectation.Text = avtomobil.Complectation;
                CBKPP.Text = avtomobil.KPP;
                PhotoPath.Text = avtomobil.Img;
                CBType.Text = avtomobil.KuzovType;
                Vin.Text = avtomobil.VIN;
                Description.Text = avtomobil.Description;
                if (avtomobil.Img == "Отсутствует" || avtomobil.Img == "")
                {
                    Photo.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\AutoPictures\picture.png"));
                }
                else
                {
                    Photo.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\AutoPictures\\" + avtomobil.Img));
                }
            }
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
            try
            {
                if (String.IsNullOrWhiteSpace(Brand.Text) || String.IsNullOrWhiteSpace(Model.Text) || String.IsNullOrWhiteSpace(Year.Text) ||
                String.IsNullOrWhiteSpace(Color.Text) || String.IsNullOrWhiteSpace(Complectation.Text) || String.IsNullOrWhiteSpace(CBKPP.Text) ||
                String.IsNullOrWhiteSpace(CBType.Text) || String.IsNullOrWhiteSpace(Country.Text) || String.IsNullOrWhiteSpace(Reg.Text) ||
                String.IsNullOrWhiteSpace(Engine.Text) || String.IsNullOrWhiteSpace(Vin.Text) || String.IsNullOrWhiteSpace(Description.Text))
                {
                    MessageBox.Show("Вы должны заплнить все поля!");
                }

                else if (Double.Parse(Cost.Text) < 0)
                {
                    MessageBox.Show("Стоимость не может быть отрицательной!");
                }

                else
                {
                    var avtomobili = Context.Avtomobili
                                    .Where(c => c.IDAvto == Index);

                    foreach (var avtomobil in avtomobili)
                    {
                        avtomobil.CarBrand = Brand.Text;
                        avtomobil.ModelCar = Model.Text;
                        avtomobil.EngineInfo = Engine.Text;
                        avtomobil.RegNumber = Reg.Text;
                        avtomobil.Cost = Convert.ToInt32(Cost.Text);
                        avtomobil.YearAuto = Year.Text;
                        avtomobil.Color = Color.Text;
                        avtomobil.Country = Country.Text;
                        avtomobil.Complectation = Complectation.Text;
                        avtomobil.KPP = CBKPP.Text;
                        avtomobil.Img = PhotoPath.Text;
                        avtomobil.KuzovType = CBType.Text;
                        avtomobil.VIN = Vin.Text;
                        avtomobil.Description = Description.Text;
                    }
                    Context.SaveChanges();
                    MessageBox.Show("Изменения успешно сохранены");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Изменения не удалось сохранить");
                this.Close();
            }
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
