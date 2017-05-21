using SportIS.Data.Logic;
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

namespace SportSectionsInformationSystem.UI.Pages
{
    /// <summary>
    /// Логика взаимодействия для PatternCarousel.xaml
    /// </summary>
    public partial class PatternCarousel : Page
    {
        string section = "";
        string url = "";
        public PatternCarousel(string url)
        {
            this.url = url;
            string _section = url.Split('/')[url.Split('/').Length-1];
            _section = _section.Remove(_section.Length-4,4);
            section = _section;
            InitializeComponent();
        }
        private void button_pattern_Click(object sender, RoutedEventArgs e)
        {
            CurrentActivity.Activity = section;
            CurrentActivity.BackGroundURL = url;
            MainPage m = new MainPage();
            Switcher.Switch(m);
            
        }
    }
}
