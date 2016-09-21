using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static Random random = new Random();

        public static string randomName() {
            string[] names = new string[8]{"Dan Morain", "Emily Bell", "Carol Roche", "Ann Rose", "John Miller", "Greg Anderson", "Arthur McKinney", "Joann Fisher"};
            int randomIndex = Convert.ToInt32(random.NextDouble() * 7);
            return names[randomIndex];
        }

        public static int randomNumberInRange() {
            return Convert.ToInt32(random.NextDouble() * 20);
        }

        public static void Main(string[] args)
        {
            Queue<string> line = new Queue<string>();
            Dictionary<string, int> lineDictionary = new Dictionary<string, int>();

            for (int i = 0; i < 100; i++){
                line.Enqueue(randomName());
            }

            // IEnumerator<string> LineEnumerator = line.GetEnumerator();

            // while (LineEnumerator.MoveNext())
            // {
            //     string myValue = LineEnumerator.Current;
            // }

            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
