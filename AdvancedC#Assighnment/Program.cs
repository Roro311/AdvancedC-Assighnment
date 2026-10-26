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

        // Task 03.2: Transform Products
        // Func<Product, T> transforms each product into a value of type T.
        static List<T> TransformProducts<T>(
            List<Product> products,
            Func<Product, T> transform)
        {
            List<T> result = new List<T>();

            foreach (Product product in products)
            {
                result.Add(transform(product));
            }

            return result;
        }

        // Task 03.3: Filter Products
        // Predicate<Product> returns true or false for each product.
        static List<Product> FilterProducts(
            List<Product> products,
            Predicate<Product> condition)
        {
            return products.FindAll(condition);
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

            #region Task 03.2: Transform Products
            // ==============================
            // Task 03.2: Transform Products
            // ==============================

            Console.WriteLine("\n========== Task 03.2: Transform Products ==========");

            // Scenario 3: Summary List
            Console.WriteLine("\n3. Summary List:");

            List<string> summary = TransformProducts(
                catalog,
                p => $"{p.Name} (${p.Price})"
            );

            foreach (string item in summary)
            {
                Console.WriteLine(item);
            }

            // Scenario 4: Price Label
            Console.WriteLine("\n4. Price Labels:");

            List<string> labels = TransformProducts(
                catalog,
                p => p.Price > 100 ? "Expensive!" : "Affordable"
            );

            for (int i = 0; i < catalog.Count; i++)
            {
                Console.WriteLine($"{catalog[i].Name}: {labels[i]}");
            }
            #endregion

            #region Task 03.3: Filter Products
            // ==============================
            // Task 03.3: Filter Products
            // ==============================

            Console.WriteLine("\n========== Task 03.3: Filter Products ==========");

            // Scenario 5: Low-Stock Alert
            Console.WriteLine("\n5. Low-Stock Alerts:");

            List<Product> lowStock = FilterProducts(
                catalog,
                p => p.Stock < 20
            );

            foreach (Product p in lowStock)
            {
                Console.WriteLine(
                    $"[LOW STOCK] {p.Name}: only {p.Stock} left!"
                );
            #endregion
            }
    }
           


    }
    
}
