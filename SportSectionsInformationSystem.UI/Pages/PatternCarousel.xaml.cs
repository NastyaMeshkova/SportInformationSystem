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
        MainWindow m;
        string section = "";
        public PatternCarousel( MainWindow _m,string url)
        {
            string _section = url.Split('/')[url.Split('/').Length-1];
            _section = section.Remove(section.Length-4,4);
            section = _section;
            m = _m;
            InitializeComponent();
        }
        private void button_pattern_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
