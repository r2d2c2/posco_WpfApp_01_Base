using Microsoft.Win32;
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

namespace WpfApp_Imgae_Runing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 탐색기 열기
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*";
            openFileDialog.Title = "버튼에 추가할 이미지 선택";
            if(openFileDialog.ShowDialog()==true)
            {
                // 선택한 이미지 파일 경로 가져오기
                string imagePath = openFileDialog.FileName;
                // 이미지 파일을 BitmapImage로 변환
                BitmapImage bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.Absolute));
                // Image 컨트롤에 이미지 설정
                //myButton.Width=bitmapImage.Width;
                //myButton.Height=bitmapImage.Height;
                //버튼에 이미지 설정
                myButton.Content=new Image { Source = bitmapImage, Width = bitmapImage.Width, Height = bitmapImage.Height };
            }
        }
    }
}