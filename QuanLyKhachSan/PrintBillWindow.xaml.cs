using NetTopologySuite.Index.HPRtree;
using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for PrintBillWindow.xaml
    /// </summary>
    public partial class PrintBillWindow : Window
    {
        public string ID;
        List<String> data;

        public PrintBillWindow()
        {
            InitializeComponent();
        }
        public class Bill
        {
            public int STT { get; set; }
            public string FULLNAME { get; set; }
            public int AMOUNT { get; set; }
            public string SUBTOTAL { get; set; }
        }

        private void printBillWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == ID);
            cusName.Text = a.First().CUS_NAME;
            cusID.Text = a.First().CUS_ID;
            dateBill.Text = DateTime.Now.ToString();
            invoiceNo.Text = (DataProvider.Ins.DB.BILLs.Count() + 1).ToString();
            data = new List<string>();
            var temp = a.First().SER_ID;
            var b = DataProvider.Ins.DB.ROOMs.Where(x => x.RO_ID == ID);
            var c = DataProvider.Ins.DB.HOTELSERVICEs.Where(x => x.SER_ID == temp.ToString());
            
            List<Bill> items = new List<Bill>();

            //Lấy giá trị
            DateTime dateArrival = a.First().DAY_ARRIVAL.Value.Date;
            DateTime dateLeft = a.First().DAY_LEFT.Value.Date;

            // Tính khoảng thời gian giữa hai ngày
            TimeSpan difference = dateLeft - dateArrival;

            // Lấy số ngày
            decimal totalDays = (decimal)difference.TotalDays;
            var sum = totalDays * b.First().PRICE_DAY;
            decimal? ser = 0;
            if (c.Count() > 0)
                ser += c.First().PRICE;
            if (a.First().CUS_CO == 3)
            {
                sum = (sum * 125) / 100;
            }
            if (a.First().CUS_TYPE == "Có")
            {
                sum = (sum * 150) / 100;
            }

            items.Add(new Bill() { STT = 1, FULLNAME = "Tiền dịch vụ", AMOUNT = 1, SUBTOTAL = ser.ToString() });
            items.Add(new Bill() { STT = 2, FULLNAME = "Tiền thuê phòng", AMOUNT = 1, SUBTOTAL = sum.ToString() });
            listLV.ItemsSource = items;

            price.Text = (sum + ser).ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(print, "invoice");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
