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
using ПРОЕКТ2.Models;
using static System.Net.Mime.MediaTypeNames;

namespace ПРОЕКТ2
{
    /// <summary>
    /// Логика взаимодействия для PageLichKab.xaml
    /// </summary>
    public partial class PageLichKab : Page
    {
        
        public PageLichKab()
        {
            InitializeComponent();
            NameTextBox.Text = AuthData.Instance.FirstName;
            LastNameTextBox.Text = AuthData.Instance.LastName;
            FirstNameTextBox.Text = AuthData.Instance.Name;
            EmailTextBox.Text = AuthData.Instance.Email;

        }
        public PageLichKab(string firstName, string lastName, string Name, string email)
        {
            InitializeComponent();
            FirstNameTextBox.Text = firstName;
            LastNameTextBox.Text = lastName;
            NameTextBox.Text = Name;
            EmailTextBox.Text = email;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonGoMain1_Click(object sender, RoutedEventArgs e)
        {
            AuthData.Instance.FirstName = string.Empty;
            AuthData.Instance.LastName = string.Empty;
            AuthData.Instance.Name = string.Empty;
            AuthData.Instance.Email = string.Empty;

            // Переход на страницу авторизации
            AvtorizPage avtorizPage = new AvtorizPage();
            NavigationService.Navigate(avtorizPage);
        }

        private void ButtonGoKursy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageKursy());
        }
    }
}