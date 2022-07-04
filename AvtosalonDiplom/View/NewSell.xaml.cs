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
using System.Windows.Shapes;
using Word = Microsoft.Office.Interop.Word;

namespace AvtosalonDiplom.View
{
    /// <summary>
    /// Логика взаимодействия для NewSell.xaml
    /// </summary>
    public partial class NewSell : Window
    {
        public static Avtosalon3Entities3 Context;
        public int Index { get; set; }

        private readonly string TemplateFileName = @"C:\Users\Айдар\Desktop\Хисамов отчет преддипломной практики\AvtosalonDiplom\AvtosalonDiplom\DKP\DKP.docx";

        public NewSell(int index)
        {
            InitializeComponent();
            Context = new Avtosalon3Entities3();
            Index = index;

            foreach (Klienti klienti in Context.Klienti)
            {
                CBClientPassporNumber.Items.Add(klienti.IDKlient + ", " + klienti.PasportNumber + ", " + klienti.FIO);
            }
        }

        private void AddNewSellClick(object sender, RoutedEventArgs e)
        {
            if (CBClientPassporNumber.Text == "")
            {
                MessageBox.Show("Выберите клиента!");
                return;
            }    

            int id = Convert.ToInt32(CBClientPassporNumber.Text.Substring(0, CBClientPassporNumber.Text.IndexOf(", ")));

            var klienti = Context.Klienti
                .Where(c => c.IDKlient == id);

            var avtomobili = Context.Avtomobili
                .Where(c => c.IDAvto == Index);

            string date = DateTime.Today.ToShortDateString().ToString();

            try
            {
                if (ContractYOrN.IsChecked == true)
                {
                    foreach (var klient in klienti)
                    {
                        foreach (var avto in avtomobili)
                        {
                            var fio = klient.FIO;
                            var birthday = klient.Birthday;
                            var adress = klient.Adress;
                            var passport = klient.PasportNumber.Substring(0, 4);
                            var passports = klient.PasportNumber.Substring(4);
                            var phone = klient.Phone;
                            var gotFrom = klient.GotFrom;

                            var title = avto.CarBrand.ToUpper() + " " + avto.ModelCar.ToUpper();
                            var year = avto.YearAuto;
                            var vin = avto.VIN;
                            var color = avto.Color;
                            var cost = avto.Cost.ToString() + " ₽";
                            var engine = avto.EngineInfo;
                            var reg = avto.RegNumber;

                            var wordApp = new Word.Application();
                            wordApp.Visible = false;

                            var wordDocument = wordApp.Documents.Open(TemplateFileName);
                            ReplaceWordStub("{FIO}", fio, wordDocument);
                            ReplaceWordStub("{Birthday}", birthday, wordDocument);
                            ReplaceWordStub("{Passport}", passport, wordDocument);
                            ReplaceWordStub("{Passports}", passports, wordDocument);
                            ReplaceWordStub("{Address}", adress, wordDocument);
                            ReplaceWordStub("{Phone}", phone, wordDocument);
                            ReplaceWordStub("{Car Title}", title, wordDocument);
                            ReplaceWordStub("{VIN}", vin, wordDocument);
                            ReplaceWordStub("{Color}", color, wordDocument);
                            ReplaceWordStub("{Cost}", cost, wordDocument);
                            ReplaceWordStub("{Date}", date, wordDocument);
                            ReplaceWordStub("{Year}", year, wordDocument);
                            ReplaceWordStub("{FIO Again}", fio, wordDocument);
                            ReplaceWordStub("{VIN Again}", vin, wordDocument);
                            ReplaceWordStub("{Engine Info}", engine, wordDocument);
                            ReplaceWordStub("{Got From}", gotFrom, wordDocument);
                            ReplaceWordStub("{Reg Number}", reg, wordDocument);
                            wordDocument.SaveAs2("ДКП " + fio);
                            wordApp.Visible = true;
                        }
                    }
                }

                Prodazhi prodazhi = new Prodazhi()
                {
                    IDAvto = Index,
                    IDKlient = id,
                    DateProdazhi = date
                };
                Context.Prodazhi.Add(prodazhi);
                Context.SaveChanges();

                var prodazha = Context.Prodazhi
                    .Where(c => c.IDKlient == id && c.IDAvto == Index);

                foreach (var prod in prodazha)
                {
                    foreach (var klient in klienti)
                    {
                        foreach (var avto in avtomobili)
                        {
                            prod.CarBrand = avto.CarBrand;
                            prod.ModelCar = avto.ModelCar;
                            prod.Color = avto.Color;
                            prod.Cost = avto.Cost;
                            prod.VIN = avto.VIN;
                            prod.YearAuto = avto.YearAuto;

                            prod.FIO = klient.FIO;
                            prod.Adress = klient.Adress;
                            prod.Birthday = klient.Birthday;
                            prod.PasportNumber = klient.PasportNumber;
                            prod.Phone = klient.Phone;
                        }
                    }
                }
                var Avtomobili = Context.Avtomobili
                .Where(c => c.IDAvto == Index);

                foreach (var avtomobil in Avtomobili)
                {
                    Context.Avtomobili.Remove(avtomobil);
                }

                Context.SaveChanges();
                MessageBox.Show("Продажа успешно сохранена!");
            }

            catch
            {
                MessageBox.Show("Ошибка! Продажу не удалось добавить.");
            }

            this.Close();
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
