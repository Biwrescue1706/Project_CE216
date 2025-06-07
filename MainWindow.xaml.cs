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

namespace Project_CE216
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            Product p = new Product();
            p.Show();
            this.Close();
        }
        //ออกจากหน้าจอหลัก
        private void Sign_out_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ShowSummaryDaily_Click(object sender, RoutedEventArgs e)
        {
            SummaryDaily summaryDaily = new SummaryDaily();
            summaryDaily.Show();
            this.Close();
        }
    }
}