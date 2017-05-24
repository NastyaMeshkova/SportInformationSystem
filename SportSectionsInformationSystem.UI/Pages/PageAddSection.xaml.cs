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
using System.Text.RegularExpressions;

namespace SportSectionsInformationSystem.UI.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAddSection.xaml
    /// </summary>
    public partial class PageAddSection : Page
    {
        Repository r;
        SportActivity s;
        Dictionary<string, string> week_time;
        public PageAddSection(SportActivity _s)
        {
            InitializeComponent();
            r = Repository.Instance;
            week_time = new Dictionary<string, string>();
            s = _s;
            if (s != null)
            {
                buttonAddEdit.Content = "Редактировать";
                textbox_name.Text = s.Title;
                textbox_desc.Text = s.Description;
                textbox_price.Text = s.Price.ToString();
                combobox_sportclub.Text = s.Club.ClubName;
                week_time = s.WeekDayTime;
                foreach (var item in s.WeekDayTime)
                {
                    list_week_time.Items.Add(item.Key + " " + item.Value);
                }

            }


        }
        private SportActivity Add()
        {
            SportActivity sport = null;
            if (string.IsNullOrEmpty(textbox_name.Text) || string.IsNullOrEmpty(combobox_sportclub.Text) || string.IsNullOrEmpty(textbox_price.Text))
            {
                throw new ArgumentException("Пожалуйста, заполните все поля (описание по желанию)");
            }
            else
            {
                if (double.Parse(textbox_price.Text) < 0)
                {
                    throw new ArgumentException("Цена отрицательная");
                }
                SportActivity s = new SportActivity(textbox_name.Text, r.SportClubs.First(e1 => e1.ClubName.Equals(combobox_sportclub.Text)), textbox_desc.Text, week_time, double.Parse(textbox_price.Text), CurrentActivity.Activity);
                sport = s;
            }
            return sport;
        }
        private void add_click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textbox_time.Text) && !string.IsNullOrEmpty(combobox_weekday.Text))
                {
                    Regex _timeRegex = new Regex(@"^(\d{0,2}):(\d{0,2})$");
                    Match match = _timeRegex.Match(textbox_time.Text);
                    string[] str = textbox_time.Text.Split(':');
                    if (!match.Success || uint.Parse(str[0])>23 || uint.Parse(str[1]) > 59 )
                        throw new ArgumentException("Время введено неверно. Формат - (час):(мин)");
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
            catch (ArgumentException e1)
            {

                MessageBox.Show(e1.Message);
            }
            catch(FormatException)
            {
                MessageBox.Show("Время введено неверно.Формат - (час):(мин)");
            }

        }

        private void delete_click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (list_week_time.SelectedIndex != -1) //если выбрана строка в листбоксе
                {
                    KeyValuePair<string, string> k = week_time.ElementAt(list_week_time.SelectedIndex);
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
            try
            {
                if (s == null)
                {
                    r.AddSportActivity(Add());
                }
                else
                {
                    int i = r.SportActivities.IndexOf(s);
                    r.SportActivities[i] = Add();
                }
                Switcher.Switch(new MainPage());
            }
            catch (FormatException)
            {
                MessageBox.Show("Цена введена неверно");
            }
            catch (ArgumentException e1)
            {
                MessageBox.Show(e1.Message);
            }

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

                list_week_time.Items.Add(week_time.ElementAt(i).Key + " " + week_time.ElementAt(i).Value);
            }
        }

        private void clickBack(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainPage());
        }
    }
}
