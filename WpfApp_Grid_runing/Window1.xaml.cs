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

namespace WpfApp_Grid_runing
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

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TextId.Text)||string.IsNullOrWhiteSpace(TextPw.Password))
            {
                // 노랑 경고 창 생성
                MessageBox.Show("아이디,비밀번호를 입력해주세요.", "경고", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show($"로그인 시도 {TextId.Text}/{TextPw.Password}");

            }
        }
    }
}
