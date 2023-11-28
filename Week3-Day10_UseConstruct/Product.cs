
namespace Week3_Day10_UseConstruct
{
    class Product
    {
        public const double py = 3.14;
        public static int ProductId; //this is static (fixed vale) is class 
        public int Id;
        public string Name;
        public string Description;
        public double Price;


        public Product(string Name, string Description, double Price)
        {
            ProductId += 1;
            this.Id = ProductId;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;

        }
        

    }
}
