using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BT_02_10
{
    // Lớp con Laptop kế thừa Product và triển khai ISellable
    public class Laptop : Product, ISellable
    {
        public Laptop(string name, decimal price, int stock) : base(name, price, stock) { }
        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Laptop: {Name}, Giá: {Price:C}, Tồn kho: {Stock}");
        }

        public override void ApplyDiscount(decimal percentage)
        {
            Price -= Price * (percentage / 100);
            Console.WriteLine($"Giá mới sau khi giảm {percentage}%: {Price:C}");
        }

        public void Sell(int quantity)
        {
            if (quantity <= Stock)
            {
                Stock -= quantity;
                Console.WriteLine($"{quantity} {Name} đã bán. Số lượng tồn kho: {Stock}");
            }
            else
            {
                Console.WriteLine("Đã hết hàng tồn kho, không thể bán.");
            }
        }

        public bool IsInStock()
        {
            return Stock > 0;
        }
    }
}
