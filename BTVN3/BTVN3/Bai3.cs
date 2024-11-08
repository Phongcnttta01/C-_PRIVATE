namespace BTVN3;

public class Bai3
{
    protected Dictionary<string,Dictionary<String,int>> saleData = new Dictionary<string, Dictionary<String,int>>();

    public Bai3()
    {
    }
    // Phương thức thêm dữ liệu bán hàng
    public void addSaleData(String empoyeeName, String productName, int quantity)
    {
        if (!saleData.ContainsKey(empoyeeName))
        {
            saleData.Add(empoyeeName, new Dictionary<String,int>());
        }

        if (!saleData[empoyeeName].ContainsKey(productName))
        {
            saleData[empoyeeName].Add(productName, quantity);
        }
        else
        {
            saleData[empoyeeName][productName] += quantity;
        }
        
        
    }
    
    // Phương thưc tìm nhân viên bán nhiều hàng nhất 
    public String getTopSaleEmpoyeeName()
    {
        String employeeName = "";
        int maxTotal = 0;
        foreach (var employee in saleData)
        {
            int totalSales = employee.Value.Values.Sum();
            if (totalSales > maxTotal)
            {
                maxTotal = totalSales;
                employeeName = employee.Key;
            }
        }
        return employeeName;
        
    }

    public string getTopSaleProductName()
    {
        String productName = "";
        Dictionary<String,int> productData = new Dictionary<String,int>();
        foreach (var employee in saleData)
        {
            foreach (var product in employee.Value)
            {
                if (productData.ContainsKey(product.Key))
                {
                    productData[product.Key] += product.Value;
                }
                else
                {
                    productData.Add(product.Key, product.Value);
                }
            }
            
        }
        // Sắp xếp giảm dần và lấy vị trí đầu tiên 
        return  productData.OrderByDescending(x => x.Value).FirstOrDefault().Key;
    }


}