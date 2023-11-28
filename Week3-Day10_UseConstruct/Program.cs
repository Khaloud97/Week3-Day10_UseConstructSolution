namespace Week3_Day10_UseConstruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, to Proudect system!");

            Product p1 =new Product("Mobile","mobile with red color",210.3);
            Product p2 = new Product("Lab", "Lab with blue color", 300.2);
            Product p3 = new Product("Phone", "Phone with blue color", 100.5);

            Console.WriteLine("Py = "+ Product.py);//call const  (<className> . <variableName>);
            
            Console.WriteLine($" {p1.Id}, {p1.Name} , {p1.Description} ,price of it= {p1.Price}");
            Console.WriteLine($" {p2.Id}, {p2.Name} , {p2.Description} ,price of it= {p2.Price}");
            Console.WriteLine($" {p3.Id}, {p3.Name} , {p3.Description} ,price of it= {p3.Price}");
        }
    }
}