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
            return JsonToObject(filename);

        }

        public static Product GetProductByCode(string productCode)
        {
            return JsonToObject(filename).FirstOrDefault(x => x.ProductCode == productCode);
        }

        private static List<Product> JsonToObject(string filename)
        {
            return JsonUtility.JsonToObject<List<Product>>(filename);
        }
    }
}
