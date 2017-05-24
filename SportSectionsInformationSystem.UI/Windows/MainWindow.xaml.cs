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
using SportSectionsInformationSystem.UI.Pages;
using System.Security.Principal;

namespace SportSectionsInformationSystem.UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
            InitializeComponent();
            Switcher.pageSwitcher = this;
           
        }
        public void Navigate(Page nextPage)
        {
            mainFrame.Content = nextPage;
        }
        private void mainFrame_Loaded(object sender, RoutedEventArgs e)
        {
            Navigate( new PageCarousel());
        }

    }
    public static class Switcher
    {
        public static MainWindow pageSwitcher;

        public static void Switch(Page newPage)
        {
            pageSwitcher.Navigate(newPage);
        }


    }
}
