namespace SampleBackEnd.Model
{
    public class Product
    {
        public required string ProductCode { get; set; }
        public required string ProductName { get; set; }
        public required string ProductDescription { get; set; }
        public required double ProductPrice { get; set; }
    }
}
