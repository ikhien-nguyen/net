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

namespace baikiemtratx2
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
        List<NhanVien> ds = new List<NhanVien>();
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            if (isChecked())
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.maNhanVien = txtMaNhanVien.Text.Trim();
                nhanVien.hoTen = txtHoTen.Text.Trim();
                if (rdNam.IsChecked == true)
                {
                    nhanVien.gioiTinh = "Nam";
                }
                else
                {
                    nhanVien.gioiTinh = "Nữ";
                }
                nhanVien.tienBanHang = float.Parse(txtSoTien.Text.Trim());
                ds.Add(nhanVien);
                dgvHienThi.ItemsSource = null;
                dgvHienThi.ItemsSource = ds;
            }
        }

        private void btnWindow2_Click(object sender, RoutedEventArgs e)
        {
            /*List<NhanVien> dsMax = new List<NhanVien>();*/
            var max= ds.Max(nv => nv.tienBanHang);
            var query= ds.FindAll(nv => nv.tienBanHang==max);
            Window2 window2 = new Window2();
            window2.dgvHienThi.ItemsSource= query;
            window2.Show();
        }
        private bool isChecked()
        {
            if(txtMaNhanVien.Text.Trim()=="" || txtHoTen.Text.Trim() == "" || txtSoTien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ các thông tin", "Thông báo",MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if(ds.Any(nv => nv.maNhanVien == txtMaNhanVien.Text.Trim())){
                MessageBox.Show("Mã nhân viên bị trùng vui lòng nhập lại", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if(!float.TryParse(txtSoTien.Text.Trim(), out float tienBanHang) || tienBanHang <=0)
            {
                MessageBox.Show("Tiền bán hàng không hợp lệ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return true;
        }
    }
}