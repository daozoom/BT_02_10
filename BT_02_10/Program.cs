using BT_02_10;
using System;
using System.Text;

namespace BT_02_10
{
    // Chương trình chính
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Khởi tạo sản phẩm
            MobilePhone phone = new MobilePhone("iPhone 14", 999.99m, 10);
            Laptop laptop = new Laptop("MacBook Pro", 1999.99m, 5);
            Accessory accessory = new Accessory("AirPods", 199.99m, 20);

            // Hiển thị thông tin sản phẩm
            phone.DisplayProductInfo();
            laptop.DisplayProductInfo();
            accessory.DisplayProductInfo();

            // Thực hiện bán hàng
            phone.Sell(2);
            laptop.Sell(1);
            accessory.Sell(5);

            // Kiểm tra tồn kho
            Console.WriteLine($"Sản phẩm {phone.Name} còn tồn kho không? {phone.IsInStock()}");
            Console.WriteLine($"Sản phẩm {laptop.Name} còn tồn kho không? {laptop.IsInStock()}");
            Console.WriteLine($"Sản phẩm {accessory.Name} còn tồn kho không? {accessory.IsInStock()}");

            // Áp dụng giảm giá
            phone.ApplyDiscount(10);
            laptop.ApplyDiscount(15);
            accessory.ApplyDiscount(5);

            // Hiển thị lại thông tin sản phẩm sau khi giảm giá
            phone.DisplayProductInfo();
            laptop.DisplayProductInfo();
            accessory.DisplayProductInfo();
        }
    }
}
