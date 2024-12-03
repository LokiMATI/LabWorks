namespace LabWork_28
{
    public class ProductClass
    {
        public ProductClass(string type, string name, string price)
        {
            this.Type = type;
            this.Name = name;
            this.Price = price;
        }
        public string? Type { get; set; }
        public string? Name { get; set; }
        public string? Price { get; set; }
    }
}
