using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
using System.Windows;
using System.Xml.Linq;

namespace Project_CE216
{
    public interface IProduct
    {
        void OpenOderPage(string name, string productImage, int Price);
    }
}