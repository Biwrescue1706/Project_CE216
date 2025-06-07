using QRCoder;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Xml.Linq;

namespace Project_CE216
{
    public partial class PaymentTransfer : Window
    {
        public PaymentTransfer()
        {
            InitializeComponent();
            ReadFromFile();
        }

        private string OrderFilePath = "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Data\\OrderPage.txt";

        public object BarcodeFormat { get; private set; }

        private void ReadFromFile()
        {
            try
            {
                if (File.Exists(OrderFilePath))
                {
                    string[] lines = File.ReadAllLines(OrderFilePath);
                    if (lines.Length > 0)
                    {
                        string[] data = lines[0].Split(',');
                        if (data.Length >= 4)
                        {
                            NameP.Text = data[0];
                            Total.Text = data[3];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }
        private void GenerateQR_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // รับราคาจากกล่องข้อความ Total
                decimal prices = decimal.Parse(Total.Text);

                using (WebClient client = new WebClient())
                {
                    string url = $"https://promptpay.io/0645248365/{prices}.png";
                    string fileName = "image"; // ระบุชื่อไฟล์ที่จะบันทึกภาพรหัส QR
                    // ดาวน์โหลดภาพโค้ด QR จาก URL
                    client.DownloadFile(url, fileName);

                    // Display the QR code image on the Image control
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = new Uri(Path.GetFullPath(fileName)); // Use Path.GetFullPath to correctly reference the file
                    bitmapImage.EndInit();
                    ImageQR.Source = bitmapImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Pay_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Extract payment details from the UI
                string name = NameP.Text;
                string total = Total.Text;
                // Write payment details to file
                WritePaymentDetails(name, total);

                // Open the main window
                MainWindow MW = new MainWindow();
                MW.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payment details: " + ex.Message);
            }
        }
        private void WritePaymentDetails(string name, string total)
        {
            string PTransfer = "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Data\\PTransfer.txt";
            using (StreamWriter writer = new StreamWriter(PTransfer, true))
            {
                writer.WriteLine($"\t-----ชำระเงินโดยการโอน----- ");
                writer.WriteLine($"- วันที่: {DateTime.Now.ToString("dd/MM/yyyy เวลา HH:mm:ss ")}");
                writer.WriteLine($"- ชื่อสินค้า : {NameP.Text} ");
                writer.WriteLine($"- รวมทั้งสิ้น : {total} บาท ");
                writer.WriteLine($"- ชำระเงินโดยการโอน : {total} บาท");
                writer.WriteLine(new string('-', 20));
            }
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            string filePath = "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Data\\ProductOrder.txt"; // กำหนดที่อยู่ไฟล์ของคุณ
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                // ลบ 3 บรรทัดล่าสุด
                lines = lines.Take(lines.Length - 3).ToArray();

                // เขียนข้อมูลที่เหลือกลับลงในไฟล์
                File.WriteAllLines(filePath, lines);

                Console.WriteLine("Last line removed successfully.");
            }
            Product pd = new Product();
            pd.Show();
            this.Close();
        }
    }
}
