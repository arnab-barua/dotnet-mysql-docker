namespace DotNetTest.Models
{
    public class Product : BaseDomain
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
