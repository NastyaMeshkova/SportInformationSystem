using SportIS.Data;
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
    /// Логика взаимодействия для ActivityControl.xaml
    /// </summary>
    public partial class ActivityControl :  UserControl
    {
        SportActivity s;
        Repository r;
        public ActivityControl(SportActivity s)
        {
            this.s = s;
            r = Repository.Instance;
           
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            text_actTitle.Text = s.Title;
            text_actdesc.Text = s.Description;
            text_address.Text = s.Club.Address;
            text_clubname.Text = s.Club.ClubName;
            text_metro.Text = "";
            for (int i = 0; i < s.Club.Stations.Count; i++)
            {
                text_metro.Text += s.Club.Stations[i]+" ";
            }
            text_price.Text = s.Price.ToString();

            
        }

        private void button_edit_click(object sender, RoutedEventArgs e)
        {
            CurrentActivity.Activity = s.Type;
            CurrentActivity.BackGroundURL = "../../Images/CarouselCovers/"+CurrentActivity.Activity+".jpg";
            Switcher.Switch(new PageAddSection(s));
        }

        private void buttonDeleteClick(object sender, RoutedEventArgs e)
        {
            CurrentActivity.Activity = s.Type;
            CurrentActivity.BackGroundURL = "../../Images/CarouselCovers/" + CurrentActivity.Activity + ".jpg";        
            r.SportActivities.Remove(s);
            Switcher.Switch(new MainPage());
        }
    }
}
