using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace Project_CE216
{
    /// <summary>
    /// Interaction logic for SummaryDaily.xaml
    /// </summary>
    public partial class SummaryDaily : Window
    {
        private string summaryDailyFilePath = "C:\\Users\\AdminPC\\Desktop\\CE216\\Project_CE216\\Data\\SummaryDaily.txt";

        public SummaryDaily()
        {
            InitializeComponent();
            LoadSummaryDailys();
        }
        private void LoadSummaryDailys()
        {
            try
            {
                if (File.Exists(summaryDailyFilePath))
                {
                    var lines = File.ReadAllLines(summaryDailyFilePath);
                    var productBuy = new Dictionary<string, (int Quantity, decimal TotalBuy, string Date)>();

                    foreach (var line in lines)
                    {
                        var data = line.Split(',');
                        var productName = data[0];
                        var date = data[1];
                        if (int.TryParse(data[3], out int quantity) && decimal.TryParse(data[4], out decimal buy))
                        {
                            if (productBuy.ContainsKey(productName))
                            {
                                productBuy[productName] = (productBuy[productName].Quantity + quantity, productBuy[productName].TotalBuy + buy, date);
                            }
                            else
                            {
                                productBuy[productName] = (quantity, buy, date);
                            }
                        }
                    }

                    var summarizedBuy = productBuy.Select((kvp, index) => new
                    {
                        No = index + 1,
                        ProductName = kvp.Key,
                        Date = kvp.Value.Date,
                        Quantity = kvp.Value.Quantity + " ชิ้น",
                        TotalBuy = kvp.Value.TotalBuy + " บาท"
                    }).ToList();

                    SummaryDailyDataGrid.ItemsSource = summarizedBuy;
                }
                else
                {
                    MessageBox.Show("File not found: " + summaryDailyFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading daily sales: " + ex.Message);
            }
        }
    }
}