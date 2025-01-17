using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Assignment3
{
  
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            SetupImages();
            InitializeComponent();
        }

        private List<BitmapImage> hair = new List<BitmapImage>();
        private List<BitmapImage> eyes = new List<BitmapImage>();
        private List<BitmapImage> nose = new List<BitmapImage>();
        private List<BitmapImage> mouth = new List<BitmapImage>();
        
        private Random random = new Random();

        private int horizontalOffset = 150;
        private int hairOffset = 0;
        private int eyesOffset = 200;
        private int noseOffset = 400;
        private int mouthOffset = 600;

        private void SetupImages()
        {
            hair.Add(new BitmapImage(new Uri("../../images/Guy1P1.png", UriKind.Relative)));
            hair.Add(new BitmapImage(new Uri("../../images/Guy2P1.png", UriKind.Relative)));
            hair.Add(new BitmapImage(new Uri("../../images/Guy3P1.png", UriKind.Relative)));
            hair.Add(new BitmapImage(new Uri("../../images/Guy4P1.png", UriKind.Relative)));

            eyes.Add(new BitmapImage(new Uri("../../images/Guy1P2.png", UriKind.Relative)));
            eyes.Add(new BitmapImage(new Uri("../../images/Guy2P2.png", UriKind.Relative)));
            eyes.Add(new BitmapImage(new Uri("../../images/Guy3P2.png", UriKind.Relative)));
            eyes.Add(new BitmapImage(new Uri("../../images/Guy4P2.png", UriKind.Relative)));

            nose.Add(new BitmapImage(new Uri("../../images/Guy1P3.png", UriKind.Relative)));
            nose.Add(new BitmapImage(new Uri("../../images/Guy2P3.png", UriKind.Relative)));
            nose.Add(new BitmapImage(new Uri("../../images/Guy3P3.png", UriKind.Relative)));
            nose.Add(new BitmapImage(new Uri("../../images/Guy4P3.png", UriKind.Relative)));

            mouth.Add(new BitmapImage(new Uri("../../images/Guy1P4.png", UriKind.Relative)));
            mouth.Add(new BitmapImage(new Uri("../../images/Guy2P4.png", UriKind.Relative)));
            mouth.Add(new BitmapImage(new Uri("../../images/Guy3P4.png", UriKind.Relative)));
            mouth.Add(new BitmapImage(new Uri("../../images/Guy4P4.png", UriKind.Relative)));
        }
        
        private void GetImage(int xLoc1, int yLoc1, BitmapImage BMimg)
        {
            Image img = new Image();
            img.Source = BMimg;
            img.Width = BMimg.Width;
            img.Height = BMimg.Height;
            Canvas.SetLeft(img, xLoc1);
            Canvas.SetTop(img, yLoc1);
            myCanvas.Children.Add(img);
        }

        private void Combo_Changed(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedItem = Combo.SelectedItem as ComboBoxItem;
            if (selectedItem.Content.Equals("Hair 1"))
            {
                GetImage(horizontalOffset, hairOffset, hair[0]);
            }
            else if (selectedItem.Content.Equals("Hair 2"))
            {
                GetImage(horizontalOffset, hairOffset, hair[1]);
            }
            else if (selectedItem.Content.Equals("Hair 3"))
            {
                GetImage(horizontalOffset, hairOffset, hair[2]);
            }
            else if (selectedItem.Content.Equals("Hair 4"))
            {
                GetImage(horizontalOffset, hairOffset, hair[3]);
            }
        }

        private void Eyes_1_Click(object sender, RoutedEventArgs e)
        {
            GetImage(horizontalOffset, eyesOffset, eyes[0]);

        }

        private void Eyes_2_Click(object sender, RoutedEventArgs e)
        {
            GetImage(horizontalOffset, eyesOffset, eyes[1]);

        }

        private void Eyes_3_Click(object sender, RoutedEventArgs e)
        {
            GetImage(horizontalOffset, eyesOffset, eyes[2]);

        }

        private void Eyes_4_Click(object sender, RoutedEventArgs e)
        {
            GetImage(horizontalOffset, eyesOffset, eyes[3]);

        }

        private void Nose_1_Click(object sender, RoutedEventArgs e)
        {
            GetImage(horizontalOffset, noseOffset, nose[0]);

        }

        private void Nose_2_Click(object sender, RoutedEventArgs e)
        {
            GetImage(horizontalOffset, noseOffset, nose[1]);

        }

        private void Nose_3_Click(object sender, RoutedEventArgs e)
        {
            GetImage(horizontalOffset, noseOffset, nose[2]);

        }

        private void Nose_4_Click(object sender, RoutedEventArgs e)
        {
            GetImage(horizontalOffset, noseOffset, nose[3]);

        }

        private void Value_Changed(object sender, RoutedEventArgs e)
        {
            if (Slider.Value == 1)
            {
                GetImage(horizontalOffset, mouthOffset, mouth[0]);
            }
            else if (Slider.Value == 2)
            {
                GetImage(horizontalOffset, mouthOffset, mouth[1]);
            }
            else if (Slider.Value == 3)
            {
                GetImage(horizontalOffset, mouthOffset, mouth[2]);
            }
            else if (Slider.Value == 4)
            {
                GetImage(horizontalOffset, mouthOffset, mouth[3]);
            }
        }

        private void Random_Click(object sender, RoutedEventArgs e)
        {
            GetImage(horizontalOffset, hairOffset, hair[random.Next(0, 4)]);
            GetImage(horizontalOffset, eyesOffset, eyes[random.Next(0, 4)]);
            GetImage(horizontalOffset, noseOffset, nose[random.Next(0, 4)]);
            GetImage(horizontalOffset, mouthOffset, mouth[random.Next(0, 4)]);
        }
    }
}
