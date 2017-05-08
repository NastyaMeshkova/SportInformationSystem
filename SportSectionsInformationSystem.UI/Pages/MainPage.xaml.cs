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
using SportIS.Data.Logic;
using SportIS.Data;

namespace SportSectionsInformationSystem.UI.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        Repository r;
        MainWindow m;
        public MainPage(MainWindow _m)
        {
            r = new Repository();
             m = _m;
            InitializeComponent();
        }

        private void button_add_new_section_click(object sender, RoutedEventArgs e)
        {
            m.mainFrame.Content = new PageAddSection(r);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
