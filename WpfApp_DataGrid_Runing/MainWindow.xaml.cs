using Microsoft.Win32;
using System.IO;
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

namespace WpfApp_DataGrid_Runing
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


        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //csv 파일 열기
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All files (*.*)|*.*";
            if(openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                pathLabel.Content = filePath;
                // CSV 파일 읽기
                try
                {
                    List<MyData> people=new List<MyData>();
                    using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');

                            if (parts.Length >= 3)
                            {
                                people.Add(new MyData
                                {
                                    Name = parts[0],
                                    Age = int.Parse(parts[1]),
                                    Info = parts[2]
                                });
                            }
                        }
                    }
                    dataGrid.ItemsSource=people; // 데이터 바인딩
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"파일을 읽는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnGetdata_Click(object sender, RoutedEventArgs e)
        {
            if(dataGrid.SelectedItem is MyData data)
            {
                MessageBox.Show($"선택된 이름 {data.Name}");
            }
            else
            {
                MessageBox.Show("선택된 항목이 없습니다.");
            }
        }
    }
    public class MyData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Info { get; set; }
    }
}