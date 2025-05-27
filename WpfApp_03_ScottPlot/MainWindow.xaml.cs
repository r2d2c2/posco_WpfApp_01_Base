using ScottPlot;
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

namespace WpfApp_03_ScottPlot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            //ShowScatter();
            ShowSignal();
        }
        #region #Scatter
        private void ShowScatter()
        {
            // create sample data
            double[] dataX = { 1, 2, 3, 4, 5 };
            double[] dataY = { 1, 4, 9, 16, 25 };

            // add a scatter plot to the plot
            WpfPlot1.Plot.Add.Scatter(dataX, dataY);


            WpfPlot1.Refresh();
            //위 추가한 내용을 그래프로 보여줌
        }
        #endregion

        #region # Signal 
        private void ShowSignal()
        {
            // create sample data
            //double[] sin = Generate.Sin(51);
            //사인파를 이루는 y값을 배열

            double[] cosin = Generate.Cos(30);

            // add a signal plot to the plot
            WpfPlot1.Plot.Add.Signal(cosin);


            WpfPlot1.Refresh();
        }
        #endregion
    }
}