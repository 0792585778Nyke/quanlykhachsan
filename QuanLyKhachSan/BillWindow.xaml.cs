﻿using QuanLyKhachSan.Model;
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
    /// Interaction logic for BillWindow.xaml
    /// </summary>
    public partial class BillWindow : Window
    {
        public string Temp;
        public BillWindow()
        {
            InitializeComponent();
        }

        private void billWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var a = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == roomID.Text);
            roomID.Text = Temp;
            DateTime temp = DateTime.Now;
            dateBill.Text = DateTime.Now.ToString();
            cusID.Text = a.First().CUS_ID;
            cusName.Text = a.First().CUS_NAME;
            serName.Text = a.First().SER_ID;
            cusCount.Text = a.First().CUS_CO.ToString();
            typeCustomer.Text = a.First().CUS_TYPE;
            var b = DataProvider.Ins.DB.ROOMs.Where(x => x.RO_ID == roomID.Text);
            var c = DataProvider.Ins.DB.HOTELSERVICEs.Where(x => x.SER_ID == serName.Text);

            //Lấy giá trị
            DateTime dateArrival = a.First().DAY_ARRIVAL.Value.Date;
            DateTime dateLeft = a.First().DAY_LEFT.Value.Date;

            // Tính khoảng thời gian giữa hai ngày
            TimeSpan difference = dateLeft - dateArrival;

            // Lấy số ngày
            decimal totalDays = (decimal)difference.TotalDays;
            var sum = totalDays * b.First().PRICE_DAY;
            if (a.First().CUS_CO == 3) 
            {
                sum = (sum * 125) / 100;
            }
            if (a.First().CUS_TYPE == "Có")
            {
                sum = (sum * 150) / 100;
            }
            decimal? ser = 0;
            if (c.Count() > 0)
                ser += c.First().PRICE;

            cost.Text = (sum + ser).ToString();
            //var bill = new BILL() { RO_ID = roomID.Text, CUS_ID = cusID.Text, CUS_FULLNAME = cusName.Text, SER_ID = serName.Text, BILL_DATE = temp };
            //DataProvider.Ins.DB.BILLs.Add(bill);
            //DataProvider.Ins.DB.SaveChanges();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BILL bill = new BILL();
            if(cusID.Text == "" && serName.Text == "")
            {
                bill.RO_ID = roomID.Text;
                bill.CUS_ID = null;
               
                bill.SER_ID = null;
                bill.BILL_DATE = DateTime.Now;
                bill.PRICE = Convert.ToDecimal(cost.Text);
            }
            else
            if(cusID.Text == "" && serName.Text != "")
            {
                bill.RO_ID = roomID.Text;
                bill.CUS_ID = null;
               
                bill.SER_ID = serName.Text;
                bill.BILL_DATE = DateTime.Now;
                bill.PRICE = Convert.ToDecimal(cost.Text);
            }
            else
                if (cusID.Text != "" && serName.Text == "")
            {
                bill.RO_ID = roomID.Text;
                bill.CUS_ID = cusID.Text;
               
                bill.SER_ID = null;
                bill.BILL_DATE = DateTime.Now;
                bill.PRICE = Convert.ToDecimal(cost.Text);
            }
            else
                if (cusID.Text != "" && serName.Text != "")
            {
                bill.RO_ID = roomID.Text;
                bill.CUS_ID = cusID.Text;
                
                bill.SER_ID = serName.Text;
                bill.BILL_DATE = DateTime.Now;
                bill.PRICE = Convert.ToDecimal(cost.Text);
            }

            DataProvider.Ins.DB.BILLs.Add(bill);
            DataProvider.Ins.DB.SaveChanges();

            BOOKROOM book = DataProvider.Ins.DB.BOOKROOMs.Where(x => x.RO_ID == roomID.Text).First();
            var items = DataProvider.Ins.DB.BOOKROOMs.Remove(book);
            DataProvider.Ins.DB.SaveChanges();

            this.Close();
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            var a = new PrintBillWindow();
            a.ID = Temp;
            a.ShowDialog();
        }
    }
}
