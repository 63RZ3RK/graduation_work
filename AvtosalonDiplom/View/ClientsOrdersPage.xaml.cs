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
    /// Логика взаимодействия для ClientsOrdersPage.xaml
    /// </summary>
    public partial class ClientsOrdersPage : Page
    {
        public static Avtosalon3Entities3 Context;
        public int Index;
        public ClientsOrdersPage(string IDKlient)
        {
            InitializeComponent();
            Context = new Avtosalon3Entities3();
            this.Index = Convert.ToInt32(IDKlient);
            UpdateCarsListView();
        }

        private void UpdateCarsListView()
        {
            List<Zayavki> zayavki = Context.Zayavki.ToList();

            if (Search.Text.Length > 0)
            {
                zayavki = zayavki.Where(p => p.FIO.ToLower().Contains(Search.Text.ToLower()) ||
                p.CarBrand.ToLower().Contains(Search.Text.ToLower()) ||
                p.ModelCar.ToLower().Contains(Search.Text.ToLower())).ToList();
            }

            var Zayavki = Context.Zayavki
                .Where(c => c.IDKlient == Index);

            OrdersListView.Items.Clear();
            foreach (Zayavki zayavka in Zayavki)
            {
                OrdersListView.Items.Add(new userControlsItems.ClientsOrdersListItem(zayavka));
            }
        }

        private void SearchTextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateCarsListView();
        }
    }
}
