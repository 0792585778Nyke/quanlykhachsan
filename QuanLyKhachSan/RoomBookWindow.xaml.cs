using QuanLyKhachSan.Model;
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

namespace QuanLyKhachSan
{
    /// <summary>
    /// Interaction logic for RoomBookWindow.xaml
    /// </summary>
    public partial class RoomBookWindow : Window
    {
        public RoomBookWindow()
        {
            InitializeComponent();

        }

        public delegate void GETDATA(List<string> data);
        public GETDATA mydata;
        public string temp;
        private void BookingWindow_Loaded(object sender, RoutedEventArgs e)
        {
                roomID.Text = temp;
                cusID.Text=null;
                cusCount.Text=null;
                typeCustomer.Text=null;
                cusName.Text = null;
                timearrival.SelectedDate = null;
                timeleft.SelectedDate = null;
                timeBook.SelectedDate = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (timeleft.SelectedDate < timearrival.SelectedDate)
                MessageBox.Show("Ngày rời phải sớm hơn ngày vào.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            else if(timearrival.SelectedDate < timeBook.SelectedDate)
                MessageBox.Show("Ngày đặt phòng phải sớm hơn ngày vào.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            else if (cusID.Text == "" || serID.Text == "" || cusName.Text == "" || cusCount.SelectedItem == null || typeCustomer.SelectedItem == null || timearrival.SelectedDate == null || timeleft.SelectedDate == null || timeBook.SelectedDate == null) 
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }    
            else
            {
                BOOKROOM booking = new BOOKROOM();
                if (cusID.Text == "" && serID.Text != "")
                {
                    booking.RO_ID = roomID.Text;
                    booking.CUS_ID = null;
                    booking.CUS_NAME = cusName.Text;
                    booking.CUS_CO = int.Parse(cusCount.Text);
                    booking.CUS_TYPE = typeCustomer.Text;
                    booking.SER_ID = serID.Text;
                    booking.DAY_ARRIVAL = timearrival.SelectedDate;
                    booking.DAY_LEFT = timeleft.SelectedDate;
                    booking.DAY_LEFT = timeleft.SelectedDate;
                    booking.DAY_BOOK = timeBook.SelectedDate;
                    booking.DAY_BOOK = timeBook.SelectedDate;
                }
                else if (serID.Text == "" && cusID.Text != "")
                {
                    booking.RO_ID = roomID.Text;
                    booking.CUS_ID = cusID.Text;
                    booking.CUS_NAME = cusName.Text;
                    booking.CUS_CO = int.Parse(cusCount.Text);
                    booking.CUS_TYPE = typeCustomer.Text;
                    booking.SER_ID = null;
                    booking.DAY_ARRIVAL = timearrival.SelectedDate;
                    booking.DAY_LEFT = timeleft.SelectedDate;
                    booking.DAY_LEFT = timeleft.SelectedDate;
                    booking.DAY_BOOK = timeBook.SelectedDate;
                    booking.DAY_BOOK = timeBook.SelectedDate;
                }
                else if (serID.Text == "" && cusID.Text == "")
                {
                    booking.RO_ID = roomID.Text;
                    booking.CUS_ID = null;
                    booking.CUS_NAME = cusName.Text;
                    booking.CUS_CO = int.Parse(cusCount.Text);
                    booking.CUS_TYPE = typeCustomer.Text;
                    booking.SER_ID = null;
                    booking.DAY_ARRIVAL = timearrival.SelectedDate;
                    booking.DAY_LEFT = timeleft.SelectedDate;
                    booking.DAY_LEFT = timeleft.SelectedDate;
                    booking.DAY_BOOK = timeBook.SelectedDate;
                    booking.DAY_BOOK = timeBook.SelectedDate;
                }
                else if (serID.Text != "" && cusID.Text != "")
                {
                    booking.RO_ID = roomID.Text;
                    booking.CUS_ID = cusID.Text;
                    booking.CUS_NAME = cusName.Text;
                    booking.CUS_CO = int.Parse(cusCount.Text);
                    booking.CUS_TYPE = typeCustomer.Text;
                    booking.SER_ID = serID.Text;
                    booking.DAY_ARRIVAL = timearrival.SelectedDate;
                    booking.DAY_LEFT = timeleft.SelectedDate;
                    booking.DAY_LEFT = timeleft.SelectedDate;
                    booking.DAY_BOOK = timeBook.SelectedDate;
                    booking.DAY_BOOK = timeBook.SelectedDate;
                }
                if (cusID.Text != "")
                {
                    var customer = DataProvider.Ins.DB.CUSTOMERs.Where(c => c.CUS_ID == cusID.Text).FirstOrDefault();
                    if (customer == null)
                    {
                        MessageBox.Show("Mã khách hàng không tồn tại. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                }
                if (serID.Text != "")
                {
                    var services = DataProvider.Ins.DB.HOTELSERVICEs.Where(c => c.SER_ID == serID.Text).FirstOrDefault();
                    if (services == null)
                    {
                        MessageBox.Show("Mã dịch vụ không tồn tại. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                }

                DataProvider.Ins.DB.BOOKROOMs.Add(booking);
                DataProvider.Ins.DB.SaveChanges();

                this.Close();
            }
        }
    }
}
