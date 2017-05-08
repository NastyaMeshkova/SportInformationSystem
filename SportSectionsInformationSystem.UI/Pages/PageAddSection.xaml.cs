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
using SportIS.Data;

namespace SportSectionsInformationSystem.UI.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAddSection.xaml
    /// </summary>
    public partial class PageAddSection : Page
    {
        Repository r;
        Dictionary<string, string> week_time;
        public PageAddSection(Repository _r)
        {
            r = Repository.Instance;
            week_time = new Dictionary<string, string>();
            InitializeComponent();

        }

        private void add_click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textbox_time.Text) && !string.IsNullOrEmpty(combobox_weekday.Text))
            {
                if (week_time.ContainsKey(combobox_weekday.Text))
                {
                    week_time[combobox_weekday.Text] = textbox_time.Text;
                    RenewList();
                }
                else
                {
                    week_time.Add(combobox_weekday.Text, textbox_time.Text);
                    RenewList();
                }           
            }
            else
            {
                MessageBox.Show("Вы не ввели время или день недели. Пожалуйста, заполните поля");
            }
        }

        private void delete_click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (list_week_time.SelectedIndex != -1) //если выбрана строка в листбоксе
                {
                    KeyValuePair<string,string> k = week_time.ElementAt(list_week_time.SelectedIndex);
                    week_time.Remove(k.Key);//удаление  указанного элемента из коллекции
                    RenewList();
                }
                
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
            }
        }

        private void add_section_click(object sender, RoutedEventArgs e)
        {
            SportActivity s = new SportActivity(textbox_name.Text,r.SportClubs.First(e1=>e1.ClubName.Equals(combobox_sportclub.Text)),textbox_desc.Text,week_time);
            r.AddSportActivity(s);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            combobox_weekday.Items.Add("Понедельник");
            combobox_weekday.Items.Add("Вторник");
            combobox_weekday.Items.Add("Среда");
            combobox_weekday.Items.Add("Четверг");
            combobox_weekday.Items.Add("Пятница");
            combobox_weekday.Items.Add("Суббота");
            combobox_weekday.Items.Add("Воскресенье");
            for (int i = 0; i < r.SportClubs.Count; i++)
            {
                combobox_sportclub.Items.Add(r.SportClubs[i].ClubName);
            }

        }
        private void RenewList()
        {
            list_week_time.Items.Clear();
            for (int i = 0; i < week_time.Count; i++)
            {
                list_week_time.Items.Add(week_time.ElementAt(i).Key+" "+ week_time.ElementAt(i).Value);
            }
        }
    }
}
