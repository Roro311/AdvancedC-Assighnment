namespace AdvancedC_Assighnment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            //List<int> grades = new List<int>()
            //{
            //    85, 92, 78, 95, 88, 70, 100, 65
            //};

            //// 1. Print collection, Count, First and Last
            //Console.WriteLine("Grades:");

            //foreach (int grade in grades)
            //{
            //    Console.Write(grade + " ");
            //}

            //Console.WriteLine("\nCount: " + grades.Count);
            //Console.WriteLine("First Grade: " + grades.First());
            //Console.WriteLine("Last Grade: " + grades.Last());

            //// 2. Sort ascending
            //grades.Sort();

            //Console.WriteLine("\nSorted Grades:");

            //foreach (int grade in grades)
            //{
            //    Console.Write(grade + " ");
            //}

            //// 3. First grade above 90
            //int firstAbove90 = grades.First(g => g > 90);

            //Console.WriteLine("\nFirst Grade Above 90: " + firstAbove90);

            //// 4. All grades below 75
            //var failingGrades = grades.Where(g => g < 75).ToList();

            //Console.WriteLine("Failing Grades:");

            //foreach (int grade in failingGrades)
            //{
            //    Console.Write(grade + " ");
            //}

            //// 5. Remove all failing grades
            //grades.RemoveAll(g => g < 75);

            //Console.WriteLine("\nAfter Removing Failing Grades:");

            //foreach (int grade in grades)
            //{
            //    Console.Write(grade + " ");
            //}

            //// 6. Check if any grade equals 100
            //bool has100 = grades.Any(g => g == 100);

            //Console.WriteLine("\nHas Grade 100? " + has100);

            //// 7. Convert grades to List<string>
            //List<string> gradeStrings = grades
            //    .Select(g => "Grade: " + g)
            //    .ToList();

            //Console.WriteLine("\nGrade Strings:");

            //foreach (string grade in gradeStrings)
            //{
            //    Console.WriteLine(grade);
            //}
            #endregion

            #region Exercise 2:  Leaderboard
            //SortedList<int, string> leaderboard = new SortedList<int, string>();

            //// 1. Add players
            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800, "Ali");
            //leaderboard.Add(350, "Mona");

            //// 2. Print all entries
            //Console.WriteLine("Leaderboard:");

            //foreach (var player in leaderboard)
            //{
            //    Console.WriteLine(player.Key + " = " + player.Value);
            //}

            //// 3. First Key and First Value
            //Console.WriteLine("\nFirst Key: " + leaderboard.Keys[0]);
            //Console.WriteLine("First Value: " + leaderboard.Values[0]);

            //// 4. Check if score 500 exists
            //Console.WriteLine("\nScore 500 Exists? " +
            //    leaderboard.ContainsKey(500));

            //// 5. Safely get player with score 999
            //if (leaderboard.TryGetValue(999, out string playerName))
            //{
            //    Console.WriteLine("Player: " + playerName);
            //}
            //else
            //{
            //    Console.WriteLine("Player Not Found");
            //}

            //// 6. Remove score 200
            //leaderboard.Remove(200);

            //Console.WriteLine("\nUpdated Leaderboard:");

            //foreach (var player in leaderboard)
            //{
            //    Console.WriteLine(player.Key + " = " + player.Value);
            //}
            #endregion

            #region Exercise 3: Phone Book
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            //// 1. Add 4 contacts
            //phoneBook.Add("Ahmed", "01011111111");
            //phoneBook.Add("Sara", "01022222222");
            //phoneBook.Add("Mona", "01033333333");
            //phoneBook.Add("Ali", "01044444444");

            //// 2. Add new contact using [] syntax
            //phoneBook["Omar"] = "01055555555";

            //// 3. Try adding duplicate using Add()
            //try
            //{
            //    phoneBook.Add("Ahmed", "01099999999");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            //// 4. Try adding duplicate using TryAdd()
            //bool added = phoneBook.TryAdd("Ahmed", "01088888888");

            //Console.WriteLine("Added Successfully? " + added);

            //// 5. Search for contact that doesn't exist
            //bool exists = phoneBook.ContainsKey("Youssef");

            //Console.WriteLine("Youssef Exists? " + exists);

            //// 6. Get contact with fallback
            //string phone = phoneBook.GetValueOrDefault("Youssef", "Not Found");

            //Console.WriteLine("Phone: " + phone);

            //// 7. Print all Keys
            //Console.WriteLine("\nContact Names:");

            //foreach (string name in phoneBook.Keys)
            //{
            //    Console.Write(name + " ");
            //}

            //// Print all Values
            //Console.WriteLine("\nPhone Numbers:");

            //foreach (string number in phoneBook.Values)
            //{
            //    Console.Write(number + " ");
            //}
            #endregion
        }
    }
}
