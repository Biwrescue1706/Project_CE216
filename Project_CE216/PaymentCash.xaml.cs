using System;
using System.Collections.Generic;
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
using System.Xml.Linq;

namespace Project_CE216
{
    public partial class PaymentCash : Window
    {
        private string OrderFilePath = "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Data\\OrderPage.txt";
        public PaymentCash()
        {
            InitializeComponent();
            ReadToFile();
        }

        private void ReadToFile()
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
                            Price.Text = data[1];
                            Quantity.Text = data[2];
                            Total.Text = data[3];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการอ่านไฟล์: " + ex.Message);
            }
        }
        private void cal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int pay1 = string.IsNullOrEmpty(Paymoney1.Text) ? 0 : int.Parse(Paymoney1.Text);
                int pay5 = string.IsNullOrEmpty(Paymoney5.Text) ? 0 : int.Parse(Paymoney5.Text);
                int pay10 = string.IsNullOrEmpty(Paymoney10.Text) ? 0 : int.Parse(Paymoney10.Text);
                int pay20 = string.IsNullOrEmpty(Paymoney20.Text) ? 0 : int.Parse(Paymoney20.Text);
                int pay50 = string.IsNullOrEmpty(Paymoney50.Text) ? 0 : int.Parse(Paymoney50.Text);
                int pay100 = string.IsNullOrEmpty(Paymoney100.Text) ? 0 : int.Parse(Paymoney100.Text);
                int pay500 = string.IsNullOrEmpty(Paymoney500.Text) ? 0 : int.Parse(Paymoney500.Text);
                int pay1000 = string.IsNullOrEmpty(Paymoney1000.Text) ? 0 : int.Parse(Paymoney1000.Text);
                int Paymoney = (pay1 * 1) + (pay5 * 5) + (pay10 * 10) + (pay20 * 20) + (pay50 * 50) + (pay100 * 100) + (pay500 * 500) + (pay1000 * 1000);

                if (decimal.TryParse(Total.Text, out decimal total))
                {
                    if (Paymoney < total)
                    {
                        decimal difference = total - Paymoney;
                        MessageBox.Show($"คุณใส่จำนวนเงินไม่พอ ขาดอีก {difference} บาท", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        decimal change = Paymoney - total;
                        Change.Text = change.ToString();
                        MessageBox.Show($"คุณชำระเงินสำเร็จ เงินทอนคือ {change} บาท", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                        WritePaymentCash(total, Paymoney, change);
                        MainWindow mw = new MainWindow();
                        mw.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void WritePaymentCash(decimal total, decimal paymoney, decimal change)
        {
            string Cash = "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Data\\Cash.txt";
            using (StreamWriter writer = new StreamWriter(Cash, true))
            {
                writer.WriteLine($"\t-----ชำระเงินโดยเงินสด----- ");
                writer.WriteLine($"- วันที่: {DateTime.Now.ToString("dd/MM/yyyy เวลา HH:mm:ss ")}");
                writer.WriteLine($"- ชื่อสินค้า : {NameP.Text} ");
                writer.WriteLine($"- ราคา : {Price.Text} บาท");
                writer.WriteLine($"- จำนวน : {Quantity.Text} ชิ้น");
                writer.WriteLine($"- รวมทั้งสิ้น : {total} บาท ");
                writer.WriteLine($"- จ่ายเงิน : {paymoney} บาท");
                writer.WriteLine($"- เงินทอน : {change} บาท");
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
