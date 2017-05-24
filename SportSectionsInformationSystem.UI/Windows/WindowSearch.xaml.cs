using SportIS.Data.Logic;
using SportSectionsInformationSystem.UI.Pages;
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
using System.Windows.Shapes;

namespace SportSectionsInformationSystem.UI.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowSearch.xaml
    /// </summary>
    public partial class WindowSearch : Window
    {
        Repository r;
        public WindowSearch()
        {
            r = Repository.Instance;
            InitializeComponent();
            foreach (var item in r.SubwayStations)
            {
                item.Stations.ForEach(e => comboboxSubway.Items.Add(e));
            }
            r.Sections.ForEach(e=>comboboxTypes.Items.Add(e));
        }

        private void searchClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double priceMax = 0;
                double priceMin = 0;
                if (textboxPriceMax.Text == "")
                {
                    priceMax = 100000;
                }
                else
                {
                    priceMax = double.Parse(textboxPriceMax.Text);
                }
                if (textboxPriceMin.Text == "")
                {
                    priceMin = -1;
                }
                else
                {
                    priceMin = double.Parse(textboxPriceMin.Text);
                }
                if (priceMax<0||(priceMin<0&&priceMin!=-1))
                {
                    throw new ArgumentException("Цена отрицательная");
                }
                Switcher.Switch(new PageFiltered(r.Search(priceMin, priceMax, comboboxTypes.Text, comboboxSubway.Text)));
                this.Close();

            }
            catch (FormatException)
            {

                MessageBox.Show("Цена введена неверно");
            }
            
        }
    }
}
