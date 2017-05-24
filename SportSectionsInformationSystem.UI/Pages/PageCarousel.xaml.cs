using SportIS.Data.Logic;
using SportSectionsInformationSystem.UI.Windows;
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
    /// Логика взаимодействия для PageCarousel.xaml
    /// </summary>
    /// 
     
    //боевые искусства, волейбол, баскетбол, футбол, плавание,  фитнес, спортивная гимнастика, фигурное катание, аэробика, большой теннис
    public partial class PageCarousel : Page
    {
        Repository r;
        public PageCarousel()
        {
            r = Repository.Instance;             
            InitializeComponent();
            DataContext = TabControl;
            CreateTabs();
            TabControl.NumberOfTabs = TabControl.elements.Count ;
            TabControl.AnimationDuration = 2000;
        }
        private void CreateTabs()
        {
            TabControl.AddTab(CreateFixedSizeLabel("../../Images/CarouselCovers/Баскетбол.jpg", new Size(384, 160)));
            TabControl.AddTab(CreateFixedSizeLabel("../../Images/CarouselCovers/Большой теннис.jpg", new Size(384, 160)));
            TabControl.AddTab(CreateFixedSizeLabel("../../Images/CarouselCovers/Борьба.jpg", new Size(384, 160)));
            TabControl.AddTab(CreateFixedSizeLabel("../../Images/CarouselCovers/Волейбол.jpg", new Size(384, 160)));
            TabControl.AddTab(CreateFixedSizeLabel("../../Images/CarouselCovers/Плавание.jpg", new Size(384, 160)));
            TabControl.AddTab(CreateFixedSizeLabel("../../Images/CarouselCovers/Спортивная гимнастика.jpg", new Size(384, 160)));
            TabControl.AddTab(CreateFixedSizeLabel("../../Images/CarouselCovers/Танцы.jpg", new Size(384, 160)));
            TabControl.AddTab(CreateFixedSizeLabel("../../Images/CarouselCovers/Фигурное катание.jpg", new Size(384, 160)));
            TabControl.AddTab(CreateFixedSizeLabel("../../Images/CarouselCovers/Фитнес.jpg", new Size(384, 160)));
            TabControl.AddTab(CreateFixedSizeLabel("../../Images/CarouselCovers/Футбол.jpg", new Size(384,160)));
           }
        private FrameworkElement CreateFixedSizeLabel(string uri_picture, Size size)
        {
            PatternCarousel label = new PatternCarousel(uri_picture);
            label.FontSize = 64;
            label.MinWidth = label.MaxWidth = label.Width = size.Width;
            label.MinHeight = label.MaxHeight = label.Height = size.Height;
            BitmapImage b = new BitmapImage(new Uri(uri_picture, UriKind.Relative));
            ImageBrush content = new ImageBrush();
            content.ImageSource = b;
            label.Background = content;
            string _section = uri_picture.Split('/')[uri_picture.Split('/').Length - 1];
            _section = _section.Remove(_section.Length - 4, 4);
            r.Sections.Add(_section);
            return label;
        }

        private void button_next_Click(object sender, RoutedEventArgs e)
        {
            TabControl.SpinToNext();
        }

        private void button_previous_Click(object sender, RoutedEventArgs e)
        {
            TabControl.SpinToPrevious();
        }

        private void searchClick(object sender, RoutedEventArgs e)
        {
            WindowSearch w = new WindowSearch();
            w.Show();
        }

        private void clickOpenFromFileClick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Document"; // Название файла по умолчанию
            dlg.DefaultExt = ".json"; // Расширение файла по умолчанию
            dlg.Filter = "Json documents (.json)|*.json"; // Фильтр по умолчанию
            dlg.Multiselect = false;
            //необходимо удостовериться, что общее диалоговое окно отобразилось
            bool? result = dlg.ShowDialog();

            //Обработка результатов открытия окна
            try
            {
                if (result == true)
                {
                    Switcher.Switch(new PageFiltered(r.Deserialize(dlg.FileName)));
                }
            }
            catch (ArgumentException e1)
            {
                MessageBox.Show(e1.Message);
            }
            
        }
    }
}
