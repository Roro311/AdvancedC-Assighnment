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

            #endregion
        }
        }
}
