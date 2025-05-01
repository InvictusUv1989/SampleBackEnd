using SampleBackEnd.Model;
using SampleBackEnd.Utitlites;

namespace SampleBackEnd.Services
{
    public class CustomerService
    {
        const string filename = "Data/Customer.json";
        public static List<Customer> GetCustomer()
        {
            return JsonUtility.JsonToObject<List<Customer>>(filename);
        }

        public static Customer GetCustomerById(string customerId)
        {
            return JsonUtility.JsonToObject<List<Customer>>(filename).FirstOrDefault(x => x.CustomerId == customerId);
        }
    }
}
