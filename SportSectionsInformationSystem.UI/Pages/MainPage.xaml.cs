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
            r = Repository.Instance;
             m = _m;
            InitializeComponent();
        }

        private void button_add_new_section_click(object sender, RoutedEventArgs e)
        {
            m.mainFrame.Content = new PageAddSection(r);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<SportActivity> activities = r.SportActivities.Where(e1=>e1.Type.Equals(CurrentActivity.Activity)).ToList();
            for (int i = 0; i < activities.Count; i++)
            {
                ActivityControl a = new ActivityControl(activities[i]);
                stack.Children.Add(a);
            }
        }

        private void deleteSectionClick(object sender, RoutedEventArgs e)
        {
            r.Serialize(r.SportActivities);
            MessageBox.Show("jr");
        }
    }
}
