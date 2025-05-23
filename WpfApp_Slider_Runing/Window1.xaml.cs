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

namespace WpfApp_Slider_Runing
{
    /// <summary>
    /// Window1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void sliderValue(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (testR == null || testG == null || testB == null)
            {
                return;// 초기화가 안된 경우
            }
            int r = (int)sliderR.Value;
            int g = (int)sliderG.Value;
            int b = (int)sliderB.Value;

            testR.Text = r.ToString();
            testG.Text = g.ToString();
            testB.Text = b.ToString();

            Color color = Color.FromRgb((byte)r, (byte)g, (byte)b);
            if (radioOriginal.IsChecked == true)
            {
                color = Color.FromRgb((byte)r, (byte)g, (byte)b);
                //Background = new SolidColorBrush(color);
            }
            else if (radioGray.IsChecked==true)
            {
                byte avg = (byte)((r + g + b) / 3);
                color = Color.FromRgb(avg, avg, avg);
                //Background = new SolidColorBrush(color);
            }
            else if (radioInvert.IsChecked == true)
            {
                color = Color.FromRgb((byte)(255 - r), (byte)(255 - g), (byte)(255 - b));
                //Background = new SolidColorBrush(color);
            }

            mainGrid.Background = new SolidColorBrush(color);
        }

        private void radioChecked(object sender, RoutedEventArgs e)
        {
            sliderValue(sender, null);
        }
    }
}
