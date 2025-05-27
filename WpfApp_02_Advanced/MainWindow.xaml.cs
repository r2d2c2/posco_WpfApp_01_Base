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
        private Uri uriAngryimage = new Uri("pack://application:,,,/Assets/myimage1.png", UriKind.Absolute);
        private Uri uriHappyimage = new Uri("pack://application:,,,/Assets/myimage2.png", UriKind.Absolute);

        private List<Person> peopleInfo;

        public MainWindow()
        {
            InitializeComponent();

            // 초기 이미지
            imgTest.Source = new BitmapImage(new Uri("Assets/myimage1.png", UriKind.Relative));

            //content초기 이미지 설정
            imageTest2.Source = new BitmapImage(new Uri("Assets/myimage3.png", UriKind.RelativeOrAbsolute));

            //pack uri 초기 이미지 설정
            imgDisplay.Source = new BitmapImage(uriAngryimage);


            // 데이터 로드
            LoadData();

            LoadData2();

            LoadData3();
            singleSelectDataGrid.ItemsSource = peopleInfo;
            multiSelectied.ItemsSource = peopleInfo;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            imgTest.Source = new BitmapImage(new Uri("Assets/myimage2.png", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string path = "Assets/myimage4.png";
            imageTest2.Source = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute));
        }

        private void BtnChangeImage_Click(object sender, RoutedEventArgs e)
        {
            imgDisplay.Source = new BitmapImage(isAngry ? uriAngryimage : uriHappyimage);
            isAngry = !isAngry;
        }

        private void LoadData()
        {
            List<Person> people = new List<Person>()
            {
                new Person { Id = 1, Name = "홍길동", Age = 30, IsActive = true },
                new Person { Id = 1, Name = "데이먼", Age = 30, IsActive =false},
                new Person { Id = 1, Name = "김철수", Age = 30, IsActive = true }
            };
            myDataGrid.ItemsSource = people; // 데이터 바인딩
        }
        private void LoadData2()
        {
            List<Person> people2 = new List<Person>()
            {
                new Person { Id = 1, Name = "홍길동", Age = 30, IsActive = true },
                new Person { Id = 2, Name = "데이먼", Age = 30, IsActive =false},
                new Person { Id = 3, Name = "김철수", Age = 30, IsActive = true }
            };
            myDataGrid2.ItemsSource = people2; // 데이터 바인딩
        }

        private void LoadData3()
        {
            peopleInfo = new List<Person>()
            {
                new Person { Id = 1, Name = "홍길동1", Age = 30, IsActive = true },
                new Person { Id = 2, Name = "데이먼2", Age = 30, IsActive =false},
                new Person { Id = 3, Name = "김철수3", Age = 30, IsActive = true },
                new Person { Id = 1, Name = "홍길동4", Age = 30, IsActive = true },
                new Person { Id = 2, Name = "데이먼5", Age = 30, IsActive =false},
                new Person { Id = 3, Name = "김철수6", Age = 30, IsActive = true }
            };
        }

        private void singleSelectDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // selectedItem 속성을 통해 현재 선택된 항목에 접근
            if(singleSelectDataGrid.SelectedItem is Person selectedPerson)
            {// is가 객체가 특정 타입인지 확인 null 채크 
                Console.WriteLine($"다일 선택 : id={selectedPerson.Id} name={selectedPerson.Name}");
            }
            else
            {
                Console.WriteLine("선택된 항목은 없다");
            }
        }

        private void ShowSingeItem_Click(object sender, RoutedEventArgs e)
        {
            if (singleSelectDataGrid.SelectedItem is Person selectedPerson)
            {
                MessageBox.Show(
                    $"단일 선택 : id={selectedPerson.Id} name={selectedPerson.Name}" +
                    $" age={selectedPerson.Age} Acivate{selectedPerson.IsActive}",
                    "정보", // Title of the MessageBox
                    MessageBoxButton.OK, // Correct parameter for MessageBoxButton
                    MessageBoxImage.Information // Correct parameter for MessageBoxImage
                );
            }
        }

        private void multiSelectied_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (multiSelectied.SelectedItems.Count > 0)
            {
                string selecteNames=string.Join(", ", multiSelectied.SelectedItems.Cast<Person>().Select(p=>p.Name));
                //multiSelectied.SelectedItems 오브젝트형 리스트를 Cast를 통해 Person형으로 변환(여러개)
                Console.WriteLine($"다중 선택 {multiSelectied.SelectedItems.Count} 명 {selecteNames}");
            }
            else
            {
                return;
            }
        }

        private void ShowMultiItems_Click(object sender, RoutedEventArgs e)
        {
            if (multiSelectied.SelectedItems.Count > 0)
            {
                string selectedInfo = "선택된 사람";
                foreach (Person person in multiSelectied.SelectedItems.Cast<Person>())
                {
                   selectedInfo+=$"-{person.Name} {person.Age}세 {person.IsActive}\n";
                }
                MessageBox.Show(selectedInfo, "다중 정보", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("다중선택된 사람 없음");
            }
        }
    }
    // GridData를 위한 클레스
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
    }
}