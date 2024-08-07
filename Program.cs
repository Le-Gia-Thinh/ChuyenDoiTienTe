using System;

namespace ChuyenDoiTienTe
{
    class Program
    {
        static void Main(string[] args)
        {
            const double rate = 23000; // Tỉ giá 1 USD = 23000 VND
            
           
            Console.WriteLine("Enter the amount in USD: ");
            double usdValue = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"The equivalent amount in VND is: {usdValue * rate}");
            double vndValue = usdValue * rate;
            Console.WriteLine($"The equivalent amount in VND is: {vndValue}");
        }
    }
}
