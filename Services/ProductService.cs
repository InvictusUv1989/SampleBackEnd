using Newtonsoft.Json;
using SampleBackEnd.Model;
using SampleBackEnd.Utitlites;

namespace SampleBackEnd.Services
{
    public class ProductService
    {
        const string filename = "Data/product.json";
        public static List<Product> GetProductData()
        {
            return JsonUtility.JsonToObject<List<Product>>(filename);

        }

        public static Product GetProductByCode(string productCode)
        {
            return JsonUtility.JsonToObject<List<Product>>(filename).FirstOrDefault(x => x.ProductCode == productCode);
        }

    }
}
