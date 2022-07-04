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
    /// Логика взаимодействия для OrdersList.xaml
    /// </summary>
    public partial class OrdersList : Page
    {
        public static Avtosalon3Entities3 Context;
        public OrdersList()
        {
            InitializeComponent();
            Context = new Avtosalon3Entities3();
            UpdateCarsListView();
            foreach (Status status in Context.Status.ToList())
            {
                FiltrationCB.Items.Add(status.StatusName);
            }
        }

        private void UpdateCarsListView()
        {
            List<Zayavki> zayavki = Context.Zayavki.ToList();

            if(FiltrationCB.SelectedIndex > 0)
            {
                zayavki = zayavki.Where(p => p.Status == FiltrationCB.SelectedIndex).ToList();
            }

            if (Search.Text.Length > 0)
            {
                zayavki = zayavki.Where(p => p.FIO.ToLower().Contains(Search.Text.ToLower()) || 
                p.CarBrand.ToLower().Contains(Search.Text.ToLower()) || 
                p.ModelCar.ToLower().Contains(Search.Text.ToLower())).ToList();
            }

            OrdersListView.Items.Clear();
            foreach (Zayavki zayavka in zayavki)
            {
                OrdersListView.Items.Add(new userControlsItems.AboutCar(zayavka));
            }
        }

        private void SearchTextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateCarsListView();
        }

        private void filtrationChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCarsListView();
        }
    }
}
