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

namespace WpfApp_02_Advanced
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //pack ui
        private bool isAngry = true;
        private Uri uriAngryimage = new Uri("pack://application:,,,/Assets/myimage1.png",UriKind.Absolute);
        private Uri uriHappyimage = new Uri("pack://application:,,,/Assets/myimage2.png",UriKind.Absolute);

        public MainWindow()
        {
            InitializeComponent();

            // 초기 이미지
            imgTest.Source = new BitmapImage(new Uri("Assets/myimage1.png", UriKind.Relative));

            //content초기 이미지 설정
            imageTest2.Source = new BitmapImage(new Uri("Assets/myimage3.png", UriKind.RelativeOrAbsolute));

            //pack uri 초기 이미지 설정
            imgDisplay.Source=new BitmapImage(uriAngryimage);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            imgTest.Source=new BitmapImage(new Uri("Assets/myimage2.png", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string path = "Assets/myimage4.png";
            imageTest2.Source=new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute));
        }

        private void BtnChangeImage_Click(object sender, RoutedEventArgs e)
        {
            imgDisplay.Source = new BitmapImage(isAngry ? uriAngryimage:uriHappyimage);
            isAngry = !isAngry;
        }
    }
}