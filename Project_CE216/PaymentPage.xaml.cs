using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;

namespace Project_CE216
{
    /// <summary>
    /// Interaction logic for PaymentPage.xaml
    /// </summary>
    public partial class PaymentPage : Window
    {
        public PaymentPage()
        {
            InitializeComponent();
            LoadDataFromFile();
        }

        private void LoadDataFromFile()
        {
            string filePath = "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Data\\OrderPage.txt";
            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    if (lines.Length > 0)
                    {
                        // อ่านข้อมูลจากบรรทัดแรกในไฟล์
                        string[] data = lines[0].Split(',');

                        // ตรวจสอบว่าข้อมูลที่ได้มีความยาวเพียงพอ
                        if (data.Length >= 4)
                        {
                            // กำหนดค่าให้กับคอนโทรลในหน้า PaymentPage
                            NameP.Text = data[0]; // ชื่อสินค้า
                            Price.Text = data[1]; // ราคา
                            Quantity.Text = data[2]; // จำนวน
                            Total.Text = data[3]; // รวมทั้งสิ้น
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการอ่านไฟล์: " + ex.Message);
            }
        }
        private void WriteToFile()
        {
            string name = NameP.Text;
            int price = int.Parse(Price.Text);
            int quantity = int.Parse(Quantity.Text);
            int total = price * quantity;
            string filePath = "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Data\\SummaryDaily.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{name},{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")},{price},{quantity},{total}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message);
            }
        }

        private void Cash_Click(object sender, RoutedEventArgs e)
        {
            WriteToFile();
            PaymentCash cash = new PaymentCash();
            cash.Show();
            this.Close();
        }

        private void Transfer_Click(object sender, RoutedEventArgs e)
        {
            WriteToFile();
            PaymentTransfer TP = new PaymentTransfer();
            TP.Show();
            this.Close();
        }
    }
}