using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Bornander.UI.TabCarousel.Test.ExamplePanels;

namespace Bornander.UI.TabCarousel.Test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = TabControl;
            

            // Default Test
            //TabControl.AddTab(new LoginPanel());
            TabControl.AddTab(CreateFixedSizeLabel("mainscreen.png", new Size(320, 240)));
            TabControl.AddTab(CreateFixedSizeLabel("screen1.png", new Size(320, 240)));
            TabControl.AddTab(CreateFixedSizeLabel("screen2.png", new Size(320, 240)));
            TabControl.AddTab(CreateFixedSizeLabel("screen1.png", new Size(320, 240)));
            TabControl.AddTab(CreateFixedSizeLabel("screen1.png", new Size(320, 240)));
            TabControl.AddTab(CreateFixedSizeLabel("screen1.png", new Size(320, 240)));
            TabControl.AddTab(CreateFixedSizeLabel("screen1.png", new Size(320, 240)));
            TabControl.AddTab(CreateFixedSizeLabel("screen1.png", new Size(320, 240)));

            
            TabControl.NumberOfTabs = 4;
            TabControl.AnimationDuration = 2000;
        
        }
       
        private static FrameworkElement CreateFixedSizeLabel(string uri_picture, Size size)
        {
            Page1 label = new Page1 ();
            label.FontSize = 64;
            label.MouseEnter += Label_MouseEnter;
            label.MinWidth = label.MaxWidth = label.Width = size.Width;
            label.MinHeight = label.MaxHeight = label.Height = size.Height;
            BitmapImage b = new BitmapImage(new Uri(uri_picture, UriKind.Relative));
            ImageBrush content = new ImageBrush();
            content.ImageSource = b;
            
            label.Background = content;
            
            return label;
        }

        private static void Label_MouseEnter(object sender, MouseEventArgs e)
        {
           
            BitmapImage b = new BitmapImage(new Uri("mainscreen.png", UriKind.Relative));
            ImageBrush content = new ImageBrush();
            content.ImageSource = b;
            
            
        }

        private void HandlePrevious(object sender, RoutedEventArgs e)
        {
            TabControl.SpinToPrevious();
        }

        private void HandleNext(object sender, RoutedEventArgs e)
        {
            TabControl.SpinToNext();
        }

        private void GotoIndex(object sender, RoutedEventArgs e)
        {
           TabControl.SpinToIndex((int)TargetIndex.Value);
        }
    }
}
