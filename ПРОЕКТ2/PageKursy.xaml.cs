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
using ПРОЕКТ2;

namespace ПРОЕКТ2
{
    /// <summary>
    /// Логика взаимодействия для PageKursy.xaml
    /// </summary>
    public partial class PageKursy : Page
    {
        public PageKursy()
        {
            InitializeComponent();
        }

        private void ButtonKursyGoOproecte_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OproectePage());
        }

        private void ButtonKursyGoKab_Click(object sender, RoutedEventArgs e)
        {
            PageLichKab pageLichKab = new PageLichKab();
            NavigationService.Navigate(pageLichKab);
        }
    }
}
