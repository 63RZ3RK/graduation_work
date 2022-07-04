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
    /// Логика взаимодействия для CarsListFrame.xaml
    /// </summary>
    public partial class CarsListFrame : Page
    {
        public static Avtosalon3Entities3 Context;
        public CarsListFrame()
        {
            InitializeComponent();
            Context = new Avtosalon3Entities3();
            UpdateCarsListView();
            foreach (Avtomobili avtomobil in Context.Avtomobili.ToList())
            {

                IQueryable<String> brandQuery =
                (from brand in Context.Avtomobili
                 select brand.CarBrand).Distinct();
                CBBrands.Items.Clear();
                CBBrands.Items.Add("Все");
                foreach (String brand in brandQuery)
                {
                    CBBrands.Items.Add(brand);
                }
            }
        }

        private void UpdateCarsListView()
        {
            List<Avtomobili> avtomobili = Context.Avtomobili.ToList();

            if(CBBrands.SelectedIndex > 0)
            {
                avtomobili = avtomobili.Where(p => p.CarBrand.ToString() == CBBrands.SelectedItem.ToString()).ToList();
            }

            if (Search.Text.Length > 0)
            {
                avtomobili = avtomobili.Where(p => p.CarBrand.ToLower().Contains(Search.Text.ToLower()) || p.ModelCar.ToLower().Contains(Search.Text.ToLower())).ToList();
            }

            if(CBOrderCost.SelectedIndex > 0)
            {
                switch (CBOrderCost.SelectedIndex)
                {
                    case 1:
                        avtomobili = avtomobili.OrderBy(p => p.Cost).ToList();
                        break;
                    case 2:
                        avtomobili = avtomobili.OrderByDescending(p => p.Cost).ToList();
                        break;
                }
            }

            CarsListView.Items.Clear();
            foreach (Avtomobili avto in avtomobili)
            {
                CarsListView.Items.Add(new userControlsItems.carsListItem(avto));
            }
        }

        private void PoiskAvto(object sender, TextChangedEventArgs e)
        {
            UpdateCarsListView();
        }

        private void SortSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCarsListView();
        }

        private void FiltSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCarsListView();
        }
    }
}
