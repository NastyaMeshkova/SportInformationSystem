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
       
        public MainPage()
        {
            r = Repository.Instance;
           
            InitializeComponent();
        }

        private void button_add_new_section_click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PageAddSection(null));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            label_section.Content = CurrentActivity.Activity;
            List<SportActivity> activities = r.SportActivities.Where(e1=>e1.Type.Equals(CurrentActivity.Activity)).ToList();
            for (int i = 0; i < activities.Count; i++)
            {
                ActivityControl a = new ActivityControl(activities[i]);
                a.Height = 300;
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
