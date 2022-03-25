using BarberShop.Classes;
using BarberShop.EF;
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
using static BarberShop.ClassEntities;

namespace BarberShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        List<Personnel> personnels = new List<Personnel>();

       
        public ReportWindow()
        {
            InitializeComponent();
            AllPersonal.ItemsSource = context.Personnel.ToList();

            Filter();

        }
        private void Filter()
        {
            personnels = ClassEntities.context.Personnel.ToList();

            personnels = personnels.Where(i => i.INFO.Contains(Search.Text)).ToList();


            if (AllPersonal == null)
            {
                MessageBox.Show("Такой записи нет");
            }
            AllPersonal.ItemsSource = personnels;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            this.Close();
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        public void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var FDate = FirstDate.SelectedDate.Value;

                var SDate = SecondDate.SelectedDate.Value;

                var user = (AllPersonal.SelectedItem as EF.Personnel);

                var listServices = context.Record.ToList().Where(i => i.IdPersonnel == user.IdPersonnel).Select(i => i.IdServices).ToList();

                double summ = 0;

                foreach (var item in listServices)
                {
                    summ = summ + Convert.ToDouble(context.Services.ToList().Where(i => i.IdServices == item).FirstOrDefault().Cost);
                }

                //Salary salary = new Salary(List<string> listServices);

                var res = (summ * 0.3) * 0.87;

                Result.Text = res.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так");
                return;
            }
           
        }
    }
    
}
