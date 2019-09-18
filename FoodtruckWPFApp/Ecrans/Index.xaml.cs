using FoodtruckApp.Models;
using FoodtruckApp.ViewModels;
using System.Windows;

namespace FoodtruckWPFApp.Ecrans
{
    /// <summary>
    /// Logique d'interaction pour Index.xaml
    /// </summary>
    public partial class Index : Window
    {
        public Index()
        {
            InitializeComponent();
            DataContext = new IndexViewModel();
            //test
        }
    }
}
