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
using static System.Net.Mime.MediaTypeNames;

namespace Project_CE216
{

    public partial class OderPage : Window
    {
        private string path;
        private object imagePath;

        public string ProductName { get; set; }
        public string ProductImagePath { get; set; }
        public int ProductPrice { get; set; }

        public OderPage(string name, string imagePath, int price)
        {
            InitializeComponent();

            ProductName = name;
            ProductImagePath = imagePath;
            ProductPrice = price;
            Name.Text = ProductName;
            ProductImage.Source = new BitmapImage(new Uri(ProductImagePath));
            Price.Text = ProductPrice.ToString();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            string filePath = "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Data\\ProductOrder.txt"; // กำหนดที่อยู่ไฟล์ของคุณ
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                // ลบ 3 บรรทัด ล่าสุด
                lines = lines.Take(lines.Length - 3).ToArray();

                // เขียนข้อมูลที่เหลือกลับลงในไฟล์
                File.WriteAllLines(filePath, lines);

                Console.WriteLine("Last line removed successfully.");
            }

            Product pd = new Product();
            pd.Show();
            this.Close();
        }

        private void Payments_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Quantity.Text, out int quantity))
            {
                if (quantity > 24)
                {
                    // Show error message if quantity exceeds 24
                    MessageBox.Show("คุณสั่งของเกินจำนวนที่จำกัด", "ข้อผิดพลาด", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (quantity < 1)
                {
                    MessageBox.Show("กรุณาใส่จำนวนที่ถูกต้อง", "ข้อผิดพลาด", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    // Calculate total price
                    int totalPrice = quantity * ProductPrice;

                    // Write data to the OrderPage.txt file
                    string filePath = "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Data\\OrderPage.txt"; // specify your file path
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.WriteLine($"{ProductName},{ProductPrice},{Quantity.Text},{totalPrice}");
                    }

                    // Open the PaymentPage window
                    PaymentPage pmp = new PaymentPage();
                    pmp.Show();

                    // Close the OrderPage window
                    this.Close();
                }
            }
            else
            {
                // Show error message if the Quantity input is not a valid integer
                MessageBox.Show("กรุณาใส่จำนวนที่ถูกต้อง", "ข้อผิดพลาด", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}