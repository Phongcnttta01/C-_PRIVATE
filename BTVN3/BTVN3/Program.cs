namespace BTVN3;

class Program
{
    static void Main(string[] args)
    {
        Bai3 b3 = new Bai3();
        b3.addSaleData("Alice", "ProductA", 10);
        b3.addSaleData("Alice", "ProductB", 5);
        b3.addSaleData("Bob", "ProductA", 7);
        b3.addSaleData("Bob", "ProductC", 8);
        b3.addSaleData("Charlie", "ProductA", 15);
        b3.addSaleData("Charlie", "ProductB", 3);
        // Tìm nhân viên 
        string topEmployee = b3.getTopSaleEmpoyeeName();
        Console.WriteLine("Nhân viên bán được nhiều sản phẩm nhất: " + topEmployee);
        // Tìm sản phẩm 
        string bestSellingProduct = b3.getTopSaleProductName();
        Console.WriteLine("Sản phẩm bán chạy nhất: " + bestSellingProduct);
    }
}