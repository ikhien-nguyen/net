using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2_tx2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation= WindowStartupLocation.CenterScreen;
        }
        private void XoaThongBaoLoi()
        {
            errDiachi.Content = "";
            errDiem.Content = "";
            errHoten.Content = "";
            errLop.Content = "";
            errMasv.Content = "";
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            XoaThongBaoLoi();
        }
        private bool CheckData()
        {
            bool ch = true;
            string masv = txtMasv.Text;
            string hoten = txtHoten.Text;
            string diem = txtDiem.Text;

            if (!Regex.IsMatch(masv, "^\\d{1,}$"))
            {
                ch = false;
                errMasv.Content = "Bạn phải nhập mã sinh viên là số";
            }
            else
            {
                errMasv.Content = "";
            }

            return ch;
        }


    }
}