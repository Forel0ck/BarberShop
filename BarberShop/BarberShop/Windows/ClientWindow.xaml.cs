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
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        List<Client> client = new List<Client>();
        List<string> ForSort = new List<string>()
        {
            "По умолчанию","По фамилия","По имени","По телефону"
        };

        public ClientWindow()
        {
            InitializeComponent();
            AllClient.ItemsSource = context.Client.ToList();
            Sort.ItemsSource = ForSort;
            Sort.SelectedIndex = 0;
            Filter();
        }
        private void Filter()
        {
            client = ClassEntities.context.Client.ToList();
            client = client.Where(i => i.FIO.Contains(Search.Text)).ToList();

            switch (Sort.SelectedIndex)
            {
                case 0:
                    client = client.OrderBy(i => i.IdClient).ToList();
                    break;
                case 1:
                    client = client.OrderBy(i => i.FirstName).ToList();
                    break;
                case 2:
                    client = client.OrderBy(i => i.LastName).ToList();
                    break;
                case 3:
                    client = client.OrderBy(i => i.Phone).ToList();
                    break;
                default:
                    client = client.OrderBy(i => i.IdClient).ToList();
                    break;
            }

            if (AllClient == null)
            {
                MessageBox.Show("Такой записи нет");
            }

            AllClient.ItemsSource = client;

            

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

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddClientWindow addClientWindow = new AddClientWindow();
            addClientWindow.ShowDialog();
            this.Close();
        }

        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }
    }
}
