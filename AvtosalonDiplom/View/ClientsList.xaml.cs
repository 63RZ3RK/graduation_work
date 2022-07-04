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
    /// Логика взаимодействия для ClientsList.xaml
    /// </summary>
    public partial class ClientsList : Page
    {
        public static Avtosalon3Entities3 Context;
        public ClientsList()
        {
            InitializeComponent();
            Context = new Avtosalon3Entities3();
            UpdateDG();
        }

        public void UpdateDG()
        {
            List<Klienti> klienti = Context.Klienti.ToList();
            if (!string.IsNullOrEmpty(Search.Text))
            {
                klienti = klienti.Where(p => p.FIO.ToLower().Contains(Search.Text.ToLower()) || p.PasportNumber.ToLower().Contains(Search.Text.ToLower())).ToList();
            }

            ClientsDG.ItemsSource = klienti;
        }

        private void SearchTextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateDG();
        }
    }
}
