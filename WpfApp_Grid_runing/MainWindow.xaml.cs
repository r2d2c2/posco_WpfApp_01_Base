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

namespace WpfApp_Grid_runing
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
            if (IdInput.Text == "" || string.IsNullOrWhiteSpace(IdInput.Text)||string.IsNullOrWhiteSpace(PwInput.Text))
            {
                //MessageBox.Show("아이다,비밀번호를 입력해주세요.");
                // 노랑 경고 창 생성
                MessageBox.Show("아이디,비밀번호를 입력해주세요.", "경고", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show($"로그인 시도 {IdInput.Text}/{PwInput.Text}");
            }

        }
    }
}