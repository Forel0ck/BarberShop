using BarberShop.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        public AddClientWindow()
        {
            InitializeComponent();
        }

        private Regex regex = new Regex(@"\d{3}-\d{3}-\d{4}"); 

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client();
            var userPhone = ClassEntities.context.Client.Where(i => i.Phone == Phone.Text).FirstOrDefault();

            if (userPhone!=null)
            {
                MessageBox.Show("Такой номер уже существует", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            if (!string.IsNullOrWhiteSpace(Fname.Text))
            {
                client.FirstName = Fname.Text;
            }
            else
            {
                MessageBox.Show("Вы не ввели имя", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!string.IsNullOrWhiteSpace(Lname.Text))
            {
                client.LastName = Lname.Text;
            }
            else
            {
                MessageBox.Show("Вы не ввели фамилию","Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            
            if (!string.IsNullOrWhiteSpace(Phone.Text))
            {
               
                 client.Phone = Phone.Text;
            }
            else
            {
                MessageBox.Show("Вы не ввели номер.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var chekPhone = Phone.Text;

            if (!regex.IsMatch(chekPhone))
            {
                MessageBox.Show("Номер не корректен.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            MessageBox.Show("Пользователь добавлен");
            ClassEntities.context.Client.Add(client);
            ClassEntities.context.SaveChanges();

            this.Hide();
            ClientWindow clientWindow = new ClientWindow();
            clientWindow.ShowDialog();
            this.Close();

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ClientWindow clientWindow = new ClientWindow();
            clientWindow.ShowDialog();
            this.Close();
        }
        private void Fname_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void Lname_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void Phone_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Phone_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.Text = new string
                    (
                         textBox.Text.Where(ch => ch == '+' || ch == '-' || (ch >= '0' && ch <= '9')).ToArray()
                    );
            }
        }

        private void Fname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.Text = new string
                    (
                         textBox.Text.Where(ch => (ch >= 'а' && ch <= 'я') || (ch >= 'А' && ch <= 'Я') || ch == 'ё' || ch == 'Ё' || (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z')).ToArray()
                    );
            }
        }

        private void Lname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.Text = new string
                    (
                         textBox.Text.Where(ch => (ch >= 'а' && ch <= 'я') || (ch >= 'А' && ch <= 'Я') || ch == 'ё' || ch == 'Ё' || (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z')).ToArray()
                    );
            }
        }
    }
}
