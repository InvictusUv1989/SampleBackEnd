using Newtonsoft.Json;
using SampleBackEnd.Model;

namespace SampleBackEnd.Services
{
    public class ProductService
    {

        public static List<Product> GetProductData()
        {
            using (StreamReader r = new StreamReader("Data/product.json"))
            {
                string json = r.ReadToEnd();
                List<Product> items = JsonConvert.DeserializeObject<List<Product>>(json);

                return items;
            }

        }

        public static Product GetProductByCode(string productCode)
        {
            using (StreamReader r = new StreamReader("Data/product.json"))
            {
                string json = r.ReadToEnd();
                List<Product> items = JsonConvert.DeserializeObject<List<Product>>(json);

                return items.FirstOrDefault(x => x.ProductCode == productCode);
            }

        }
    }
}
