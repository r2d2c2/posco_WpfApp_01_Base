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

namespace WpfApp_Slider_Runing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 별도의 스레드에서 Loop 메서드를 실행
            Task.Run(() => Loop());
        }
        async Task Loop()
        {
            while (true)
            {
                
                    // UI 스레드에서 배경색 변경
                    await Dispatcher.InvokeAsync(() =>
                    {
                        if (Nomul.IsChecked == true)
                        {
                            // 배경색을 변경
                            Color color = Color.FromRgb((byte)RSlider.Value, (byte)GSlider.Value, (byte)BSlider.Value);
                            Background = new SolidColorBrush(color);
                        }
                        else if (NotNomul.IsChecked == true)
                        {
                            //색 반전
                            Color color = Color.FromRgb((byte)(255-RSlider.Value), (byte)(255-GSlider.Value), (byte)(255-BSlider.Value));
                            Background = new SolidColorBrush(color);
                        }
                        else if (BlackAndWite.IsChecked == true)
                        {
                            // rgb 변균값을 이용한 흑백
                            Color color = Color.FromRgb((byte)((byte)(RSlider.Value + GSlider.Value + BSlider.Value) / 3f), (byte)((byte)(RSlider.Value + GSlider.Value + BSlider.Value) / 3), (byte)((byte)(RSlider.Value + GSlider.Value + BSlider.Value) / 3));
                            Background = new SolidColorBrush(color);
                        }
                    });
               
                
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RText.Text =RSlider.Value.ToString();
        }

        private void GSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            GText.Text = GSlider.Value.ToString();
        }

        private void BSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BText.Text = BSlider.Value.ToString();
        }

    }
}