using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapdonhang
{
    internal class Program
    {
        static void Main(String[] args)
        {
            try
            {
                //Nhập số lượng sản phẩm
                Console.WriteLine("Nhap so luong san pham: ");
                int soluong = int.Parse(Console.ReadLine());
                //Nhập giá của một sản phẩm
                Console.WriteLine("Nhap gia tri cua mot san pham: ");
                double gia = Convert.ToDouble(Console.ReadLine());
                //tính tổng giá trị đơn hàng
                double tonggiatri = soluong * gia;
                Console.WriteLine("Tong don hang la: " + tonggiatri);
            }
            catch (FormatException)
            {
                Console.WriteLine("Du lieu sai.Xin hay nhap lai. ");
            }
        }
    }
}
