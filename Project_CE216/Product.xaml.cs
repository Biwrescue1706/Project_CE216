using System.IO;
using System.Windows;

namespace Project_CE216
{
    public partial class Product : Window, IProduct
    {
        public Product()
        {
            InitializeComponent();
        }
        private void Oder00_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊ก 180 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\coke180ml.jpg", 12);
        }
        private void Oder001_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊ก 1 ลิตร", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\coke1L.jpg", 27);
        }
        private void Oder002_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊กไม่มีน้ำตาล 180 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\cokezero180ml.jpg", 12);
        }
        private void Oder003_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊กไม่มีน้ำตาล 1 ลิตร", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\cokezero1L.jpg", 27);
        }
        private void Oder004_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊กไม่มีน้ำตาลไลม์  325 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\cokelime325ml.jpg", 16);
        }
        private void Oder01_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊ก 300 มล." , "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\coke300ml.jpg",14);
        }
        private void Oder011_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊ก 1.25 ลิตร ","C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\coke1.25L.jpg",31);
        }
        private void Oder012_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊กไม่มีน้ำตาล 330 มล.","C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\cokezero330ml.jpg",14);
        }
        private void Oder013_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊กไม่มีน้ำตาล 1.25 ลิตร ","C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\cokezero1.25L.jpg",31);
        }
        private void Oder014_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊กไม่มีน้ำตาลไลmN  325 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\cokelight325ml.jpg", 16);
        }
        private void Oder02_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊ก 325 มล." ,"C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\coke325ml.jpg",16);
        }
        private void Oder021_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊ก 1.6 ลิตร ","C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\coke1.6L.jpg",36);
        }
        private void Oder022_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊กไม่มีน้ำตาล 325 มล.","C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\cokezero325ml.jpg",16);
        }
        private void Oder023_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊กไม่มีน้ำตาล 1.6 ลิตร","C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\cokezero1.6L.jpg",36);
        }
        private void Oder03_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊ก 510 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\coke510ml.jpg", 19);
        }

        private void Oder031_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊ก 2 ลิตร", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\coke2L.jpg", 42);
        }

        private void Oder032_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊กไม่มีน้ำตาล 510 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\cokezero510ml.jpg", 19);
        }

        private void Oder033_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("โค๊กไม่มีน้ำตาล 2 ลิตร", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\cokezero2L.jpg", 42);
        }

        private void Oder10_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ 245 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsi245ml.jpg", 13);
        }
        private void Oder101_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ 550 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsi550ml.jpg", 20);
        }
        private void Oder102_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ไม่มีน้ำตาล 245 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsizero245ml.jpg", 13);
        }
        private void Oder103_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ไม่มีน้ำตาล 1 ลิตร", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsizero1L.jpg", 27);
        }
        private void Oder104_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ไลม์ไม่มีน้ำตาล 550 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsizerolime550ml.jpg", 20);
        }
        private void Oder11_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ 330 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsi330ml.jpg", 14);
        }
        private void Oder111_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ 1 ลิตร", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsi1L.jpg", 27);
        }
        private void Oder112_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ไม่มีน้ำตาล 330 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsizero330ml.jpg", 14);
        }
        private void Oder113_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ไม่มีน้ำตาล 1.45 ลิตร", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsizero1.45L.jpg", 34);
        }
        private void Oder12_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ 325 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsi325ml.jpg", 16);
        }
        private void Oder121_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ 1.45 ลิตร", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsi1.45L.jpg", 34);
        }
        private void Oder122_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ไม่มีน้ำตาล 325 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsizero325ml.jpg", 16);
        }
        private void Oder123_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ไม่มีน้ำตาล 1.95 ลิตร", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsizero1.95L.jpg", 42);
        }
        private void Oder13_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ 550 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsi550ml.jpg", 20);
        }
        private void Oder131_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ 1.95 ลิตร", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsi1.95L.jpg", 42);
        }
        private void Oder132_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ไม่มีน้ำตาล 550 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsizero550ml.jpg", 20);
        }
        private void Oder133_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("เป๊ปซี่ไลม์ 410 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Pepsilime410ml.jpg", 42);
        }
        private void Oder20_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("แฟนต้า น้ำส้มไม่มีน้ำตาล 550 มล.","C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Orangezero550ml.jpg",19);
        }
        private void Oder201_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("แฟนต้า องุ่นป๊อป 550 มล.","C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\fantaGrape550ml.jpg",19);
        }
        private void Oder202_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("แฟนต้า น้ำแดง 1.25 ลิตร","C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\fantared1.25L.jpg",31);
        }
        private void Oder21_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("แฟนต้า น้ำส้ม 1.25 ลิตร","C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Orange1.25L.jpg",31);
        }
        private void Oder211_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("แฟนต้า น้ำแดงมะนาว 550 มล.","C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\fantaredlime550ml.jpg",19);
        }
        private void Oder22_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("แฟนต้า น้ำเขียว 550 มล.","C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\fantaGreen550ml.jpg",19);
        }
        private void Oder221_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("แฟนต้า น้ำแดง 330 มล.","C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\fantared330ml.jpg",16);
        }
        private void Oder23_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("แฟนต้า น้ำเขียว 1.25 ลิตร","C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\fantaGreen1.25L.jpg",31);
        }
        private void Oder231_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("แฟนต้า น้ำแดง 550 มล.","C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\fantared550ml.jpg",19);
        }
        private void Oder30_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("น้ำดื่มคริสตัล 600 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\crystal600ml.jpg", 7);
        }
        private void Oder301_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("น้ำดื่มทิพย์ 550 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\thip550ml.jpg", 7);
        }
        private void Oder31_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("น้ำดื่มคริสตัล 1500 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\crystal1500ml.jpg", 14);
        }
        private void Oder311_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("น้ำดื่มทิพย์ 1500 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\thip1500ml.jpg", 14);
        }
        private void Oder32_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("น้ำดื่มเนส์เล่เพียวไลฟ์ 600 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Nestle600ml.jpg", 7);
        }
        private void Oder321_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("น้ำดื่มสิงห์ 600 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\singha600ml.jpg", 7);
        }
        private void Oder33_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("น้ำดื่มเนส์เล่เพียวไลฟ์ 1500 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\Nestle1500ml.jpg", 14);
        }
        private void Oder331_Click(object sender, RoutedEventArgs e)
        {
            OpenOderPage("น้ำดื่มสิงห์ 1500 มล.", "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Image\\singha1500ml.jpg", 14);
        }
        public void OpenOderPage(string name, string ProductImage, int Price)
        {
            WriteToFile(name, Price);
            OderPage oderPage = new OderPage(name, ProductImage, Price);
            oderPage.Show();
            this.Close();
        }
        private void WriteToFile(string name, int price)
        {
            string filePath = "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Data\\ProductOrder.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("Order Date: " + DateTime.Now.ToString("dd/MM/yyyy เวลา HH:mm:ss "));
                writer.WriteLine($"{name},{price}");
                writer.WriteLine(new string('-', 20));
            }
        }
    }
}