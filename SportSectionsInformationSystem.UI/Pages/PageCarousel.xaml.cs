﻿using System;
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
        MainWindow m;
        public PageCarousel(MainWindow _m)
        {
            m = _m;      
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
            PatternCarousel label = new PatternCarousel(m,uri_picture);
            label.FontSize = 64;
            label.MinWidth = label.MaxWidth = label.Width = size.Width;
            label.MinHeight = label.MaxHeight = label.Height = size.Height;
            BitmapImage b = new BitmapImage(new Uri(uri_picture, UriKind.Relative));
            ImageBrush content = new ImageBrush();
            content.ImageSource = b;
            label.Background = content;
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
    }
}
