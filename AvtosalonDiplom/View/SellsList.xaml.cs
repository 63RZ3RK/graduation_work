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
using AvtosalonDiplom.Entity;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace AvtosalonDiplom.View
{
    /// <summary>
    /// Логика взаимодействия для SellsList.xaml
    /// </summary>
    public partial class SellsList : System.Windows.Controls.Page
    {
        public static Avtosalon3Entities3 Context;
        public SellsList()
        {
            InitializeComponent();
            Context = new Avtosalon3Entities3();
            UpdateDG();
        }

        public void UpdateDG()
        {
            List<Prodazhi> prodazhi = Context.Prodazhi.ToList();

            DateTime? date = CBSortDateAfter.SelectedDate;
            DateTime? date1 = CBSortDateBefore.SelectedDate;

            if (CBSortDateAfter.SelectedDate != null && CBSortDateBefore.SelectedDate != null)
            {
                prodazhi = prodazhi.Where(p => DateTime.Parse(p.DateProdazhi) >= date && DateTime.Parse(p.DateProdazhi) <= date1).ToList();
            }

            if (!string.IsNullOrEmpty(Search.Text))
            {
                prodazhi = prodazhi.Where(p => p.FIO.ToLower().Contains(Search.Text.ToLower()) 
                || p.VIN.ToLower().Contains(Search.Text.ToLower()) 
                || p.PasportNumber.ToLower().Contains(Search.Text.ToLower())).ToList();
            }
            
            SellsDG.ItemsSource = prodazhi;
        }

        private void SearchTextCHanged(object sender, TextChangedEventArgs e)
        {
            UpdateDG();
        }

        private void NewDateBefore(object sender, SelectionChangedEventArgs e)
        {
            UpdateDG();
        }

        private void NewDateAfter(object sender, SelectionChangedEventArgs e)
        {
            UpdateDG();
        }

        private void ExcelClick(object sender, RoutedEventArgs e)
        {
            if(CBSortDateAfter.Text == "" || CBSortDateBefore.Text == "")
            {
                MessageBox.Show("Выберете даты продаж!");
            }
            else { 
                DateTime date = (DateTime)CBSortDateAfter.SelectedDate;
                DateTime date1 = (DateTime)CBSortDateBefore.SelectedDate;

                string d = date.ToShortDateString();
                string d1 = date1.ToShortDateString();
                string Podpis = "Подпись администратора: ";

                Excel.Application excel = new Excel.Application();
                Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                workbook.SaveAs("Отчет о продажах"+ " " + d + "-" + d1);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                int iLastRow = sheet1.Cells[sheet1.Rows.Count, "A"].End[Excel.XlDirection.xlUp].Row;
                for (int j = 0; j < SellsDG.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[1, j + 1];
                    sheet1.Cells[1, j + 1].Font.Bold = true;
                    sheet1.Columns[j + 1].ColumnWidth = 20;
                    myRange.Value2 = SellsDG.Columns[j].Header;
                }

                for (int i = 0; i < SellsDG.Columns.Count; i++)
                {
                    for (int j = 0; j < SellsDG.Items.Count; j++)
                    {
                        TextBlock b = SellsDG.Columns[i].GetCellContent(SellsDG.Items[j]) as TextBlock;
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                        if (b != null)
                        {
                            myRange.Value2 = b.Text;
                        }
                    }
                }
                excel.Visible = true;
            }
        }
    }
}
