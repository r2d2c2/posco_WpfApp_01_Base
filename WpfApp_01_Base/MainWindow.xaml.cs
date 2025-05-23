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

            //데이터 바인딩
            //데이터 리스트 생성
            List<Animale> animals = new List<Animale>()
            {
                new Animale() { Name="하마",Percent= 10 },
                new Animale() { Name="타조",Percent= 90 },
                new Animale() { Name="토끼",Percent= 50 }
            };
            listBox.ItemsSource=animals;
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

        private void comboFruits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //사용자가 선택한 항목을 가지고 오기
            ComboBoxItem selectedItem = (ComboBoxItem)comboFruits.SelectedItem;//형변환 실패시 null 반환
            
            if(selectedItem != null)
            {
                string selectedText=selectedItem.Content.ToString();
                textResult2.Text = $"선택한 과일: {selectedText}";
            }
        }

        private void listColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selected = (ListBoxItem)listColors.SelectedItem;
            if(selected != null)
            {
                string selectedText = selected.Content.ToString();
                textSelected.Text= $"선택한 색상: {selectedText}";
            }
        }

        private void listFruits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<string> selectedFruits = new List<string>();
            foreach(ListBoxItem i in listFruits.SelectedItems)
            {
                selectedFruits.Add(i.Content.ToString());
            }
            textSelected.Text = $"선택한 과일: {string.Join(", ", selectedFruits)}";
        }

        // 바인딩용
        public class Animale
        {
            public string Name { get; set; }
            public int Percent { get; set; }
        }

        private void btnNamver_Click(object sender, RoutedEventArgs e)
        {
            WebBrowser1.Navigate("https://naver.com");
        }

        private void btnBakc_Click(object sender, RoutedEventArgs e)
        {
            if(WebBrowser1.CanGoBack)
            {
                WebBrowser1.GoBack();
            }
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            if(WebBrowser1.CanGoForward)
            {
                WebBrowser1.GoForward();
            }
        }
    }
}