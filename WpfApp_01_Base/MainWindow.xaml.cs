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

namespace WpfApp_01_Base
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

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (radioMale.IsChecked == true)
            {
                MessageBox.Show("남성");
            }
            else if (radioFemale.IsChecked == true)
            {
                MessageBox.Show("여성");
            }
        }

        private void radioFemale_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("여성 채크");
        }

        private void radioMaleChecked(object sender, RoutedEventArgs e)
        {

        }

        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //슬라이더 이벤트 실시간 값 변환
            if (volumeSlider != null)
            {
                //volumeText.Text = $"현제 값: {volumeSlider.Value}";
            }
        }

        private void check(object sender, RoutedEventArgs e)
        {
            List<string> selectFruits=new List<string>();

            if (checkBoxApp.IsChecked == true)
            {
                selectFruits.Add("사과");
            }
            if (checkBoxbanana.IsChecked == true)
            {
                selectFruits.Add("바나나");
            }
            if (checkBoxoOring.IsChecked == true)
            {
                selectFruits.Add("오렌지");
            }
            testRe.Text=$"선택한 과일: {string.Join(", ", selectFruits)}";
        }

        private void checkboxState_Click(object sender, RoutedEventArgs e)
        {
            bool? state=checkboxState.IsChecked;
            if (state==true)
            {
                textStatus.Text = $"현재 상태 true";
            }
            else if (state==false)
            {
                textStatus.Text = $"현재 상태 false";
            }
            else
            {
                textStatus.Text = $"현재 상태 null";
            }
        }
    }
}