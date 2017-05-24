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
    /// Логика взаимодействия для PageFiltered.xaml
    /// </summary>
    public partial class PageFiltered : Page
    {
        List<SportActivity> sports;
        public PageFiltered(List<SportActivity> sports)
        {
            this.sports = sports;
            InitializeComponent();
            foreach (var item in sports)
            {
                ActivityControl a = new ActivityControl(item);
                a.Height = 300;
                stackPanelShow.Children.Add(a);
            }
        }

        private void buttonbackClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PageCarousel());
        }

        private void buttonSaveInFileClick(object sender, RoutedEventArgs e)
        {
            Repository r = Repository.Instance;
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Document"; // Название файла по умолчанию
            dlg.DefaultExt = ".json"; // Расширение файла по умолчанию
            dlg.Filter = "Json documents (.json)|*.json"; // Фильтр по умолчанию
            //необходимо удостовериться, что общее диалоговое окно отобразилось
            bool? result = dlg.ShowDialog();

            //Обработка результатов открытия окна
            if (result == true)
            {
                r.Serialize(sports,dlg.FileName);
                MessageBox.Show("Информация сохранена");
            }
        }
    }
}
