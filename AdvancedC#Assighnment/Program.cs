namespace AdvancedC_Assighnment
{
    internal class Program
    {
        // Starter Code: Product Catalog
        static List<Product> catalog = new List<Product>()
    {
        new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
        new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
        new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
        new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
        new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
        new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
        new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
        new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
        new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
        new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
        };

        // Task 01: Smart Product Search
        // Func<Product, bool> checks whether a product satisfies a condition.
        static List<Product> SearchProducts(
            List<Product> products,
            Func<Product, bool> filter)
        {
            List<Product> result = new List<Product>();

            foreach (Product product in products)
            {
                if (filter(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }

        // Task 03.1: Print Reports
        // Action<Product> performs an action on each product without returning a value.
        static void PrintReport(
            List<Product> products,
            Action<Product> action)
        {
            foreach (Product product in products)
            {
                action(product);
            }
        }


        static void Main(string[] args)
        {

            #region Task 01: Smart Product Search
            // ==============================
            // Task 01: Smart Product Search
            // ==============================

            Console.WriteLine("========== Task 01: Smart Product Search ==========");

            // Search 1: All Electronics products
            Console.WriteLine("\n1. Electronics Products:");

            List<Product> electronics = SearchProducts(
                catalog,
                p => p.Category == "Electronics"
            );

            foreach (Product p in electronics)
            {
                Console.WriteLine(p.Name);
            }

            // Search 2: Products cheaper than $50
            Console.WriteLine("\n2. Products Cheaper Than $50:");

            List<Product> cheapProducts = SearchProducts(
                catalog,
                p => p.Price < 50
            );

            foreach (Product p in cheapProducts)
            {
                Console.WriteLine($"{p.Name} - ${p.Price}");
            }

            // Search 3: Products that are in stock
            Console.WriteLine("\n3. Products In Stock:");

            List<Product> inStock = SearchProducts(
                catalog,
                p => p.Stock > 0
            );

            foreach (Product p in inStock)
            {
                Console.WriteLine(p.Name);
            }

            // Search 4: Clothing products under $100
            Console.WriteLine("\n4. Clothing Products Under $100:");

            List<Product> clothing = SearchProducts(
                catalog,
                p => p.Category == "Clothing" && p.Price < 100
            );

            foreach (Product p in clothing)
            {
                Console.WriteLine($"{p.Name} - ${p.Price}");
            }

            #endregion

            #region Task 03.1: Print Reports
            // ==============================
            // Task 03.1: Print Reports
            // ==============================

            Console.WriteLine("\n========== Task 03.1: Print Reports ==========");

            // Scenario 1: Short Report
            Console.WriteLine("\n1. Short Report:");

            PrintReport(catalog, p =>
            {
                Console.WriteLine($"{p.Name} - ${p.Price}");
            });

            // Scenario 2: Detailed Report
            Console.WriteLine("\n2. Detailed Report:");

            PrintReport(catalog, p =>
            {
                Console.WriteLine(
                    $"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}"
                );
            });
            #endregion

        }
    }
}
