namespace AdvancedC_Assighnment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            List<int> grades = new List<int>()
            {
                85, 92, 78, 95, 88, 70, 100, 65
            };

            // 1. Print collection, Count, First and Last
            Console.WriteLine("Grades:");

            foreach (int grade in grades)
            {
                Console.Write(grade + " ");
            }

            Console.WriteLine("\nCount: " + grades.Count);
            Console.WriteLine("First Grade: " + grades.First());
            Console.WriteLine("Last Grade: " + grades.Last());

            // 2. Sort ascending
            grades.Sort();

            Console.WriteLine("\nSorted Grades:");

            foreach (int grade in grades)
            {
                Console.Write(grade + " ");
            }

            // 3. First grade above 90
            int firstAbove90 = grades.First(g => g > 90);

            Console.WriteLine("\nFirst Grade Above 90: " + firstAbove90);

            // 4. All grades below 75
            var failingGrades = grades.Where(g => g < 75).ToList();

            Console.WriteLine("Failing Grades:");

            foreach (int grade in failingGrades)
            {
                Console.Write(grade + " ");
            }

            // 5. Remove all failing grades
            grades.RemoveAll(g => g < 75);

            Console.WriteLine("\nAfter Removing Failing Grades:");

            foreach (int grade in grades)
            {
                Console.Write(grade + " ");
            }

            // 6. Check if any grade equals 100
            bool has100 = grades.Any(g => g == 100);

            Console.WriteLine("\nHas Grade 100? " + has100);

            // 7. Convert grades to List<string>
            List<string> gradeStrings = grades
                .Select(g => "Grade: " + g)
                .ToList();

            Console.WriteLine("\nGrade Strings:");

            foreach (string grade in gradeStrings)
            {
                Console.WriteLine(grade);
            }
            #endregion
        }
    }
}
