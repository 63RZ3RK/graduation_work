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

namespace AvtosalonDiplom.View
{
    /// <summary>
    /// Логика взаимодействия для AddNewOrder.xaml
    /// </summary>
    public partial class AddNewOrder : Page
    {
        public static Avtosalon3Entities3 Context;
        public string FIO, IDKlient, Phone, Email;
        public AddNewOrder(string FIO, string IDKlient, string Phone, string Email)
        {
            InitializeComponent();
            Context = new Avtosalon3Entities3();
            this.FIO = FIO;
            this.IDKlient = IDKlient;
            this.Phone = Phone;
            this.Email = Email;
        }

        private void CreateOrderClick(object sender, RoutedEventArgs e)
        {
            if(Brand.Text.Length < 1)
            {
                Brand.ToolTip = "Минимальный размер поля 4 символа";
                MarkInvalid(Brand);
            }

            else if (Model.Text.Length < 1)
            {
                Model.ToolTip = "Минимальный размер поля 4 символа";
                MarkInvalid(Model);
            }

            else if (Year.Text.Length < 4 || Convert.ToInt32(Year.Text) > 2022)
            {
                Year.ToolTip = "Год выпуска не может быть ранее 2022";
                MarkInvalid(Year);
            }

            else if (Cost.Text.Length < 4)
            {
                Cost.ToolTip = "Минимальный размер поля 4 символа";
                MarkInvalid(Cost);
            }

            else if (Color.Text.Length < 4)
            {
                Color.ToolTip = "Минимальный размер поля 4 символа";
                MarkInvalid(Color);
            }

            else if (Complectation.Text.Length < 4)
            {
                Complectation.ToolTip = "Минимальный размер поля 4 символа";
                MarkInvalid(Complectation);
            }
            else
            {
                string brand = Brand.Text.Trim().ToLower();
                string model = Model.Text.Trim().ToLower();
                string cost = Cost.Text.Trim().ToLower();
                string color = Color.Text.Trim().ToLower();
                string complectation = Complectation.Text.Trim().ToLower();
                string Date = DateTime.Today.ToShortDateString();

                Zayavki zayavki = new Zayavki()
                {
                    IDKlient = Convert.ToInt32(IDKlient),
                    Phone = Phone,
                    Email = Email,
                    FIO = FIO,
                    CarBrand = brand,
                    ModelCar = model,
                    YearAuto = Year.Text,
                    DateZayavki = Date,
                    Cost = Convert.ToInt32(cost),
                    Color = color,
                    Complectation = complectation,
                    Status = 1
                };

                Context.Zayavki.Add(zayavki);
                Context.SaveChanges();
                MessageBox.Show("Ваша заявка успешно принята, мы с вами свяжемся при поступлении требуемого авто!");
                Brand.Text = null;
                Model.Text = null;
                Cost.Text = null;
                Color.Text = null;
                Complectation.Text = null;
                Year.Text = null;
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
