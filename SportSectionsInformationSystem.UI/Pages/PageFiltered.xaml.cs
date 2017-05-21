using SportIS.Data;
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
    /// Логика взаимодействия для PageFiltered.xaml
    /// </summary>
    public partial class PageFiltered : Page
    {

        public PageFiltered(List<SportActivity> sports)
        {
            InitializeComponent();
            foreach (var item in sports)
            {
                ActivityControl a = new ActivityControl(item);
                a.Height = 300;
                stackPanelShow.Children.Add(a);
            }
        }
    }
}
