using System;
using System.Collections.Generic;

/*
 *  Name:           Misha Milovidov
 *  Date:           2016.09.21
 *  GitHub Repo:    https://github.com/mmilovidov/data-structures-basics.git
 *  Description:    A console program that makes a random line of 100 people who are waiting to get some burgers, randomly assigns how many burgers                      each person gets, and outputs the total amount of burgers each person ate.
 */

namespace ConsoleApplication
{
    public class Program
    {
        public static Random random = new Random();

        //Generates a random name from an array of 8 names
        public static string randomName() {
            string[] names = new string[8]{"Dan Morain", "Emily Bell", "Carol Roche", "Ann Rose", "John Miller", "Greg Anderson", "Arthur McKinney", "Joann Fisher"};
            int randomIndex = Convert.ToInt32(random.NextDouble() * 7);
            return names[randomIndex];
        }

        //Generates a random number between 1 and 20
        public static int randomNumberInRange() {
            return Convert.ToInt32(random.NextDouble() * 20);
        }

        public static void Main(string[] args)
        {
            Queue<string> line = new Queue<string>();
            Dictionary<string, int> lineDictionary = new Dictionary<string, int>();

            //Adds a random name to a queue 100 times
            for (int i = 0; i < 100; i++){
                line.Enqueue(randomName());
            }

            //Assigns a random amount of burgers to each person in the queue and adds them to a dictionary
            foreach (string Customer in line) {

                if(!lineDictionary.ContainsKey(Customer)){

                    lineDictionary.Add(Customer, 0);
                }

                lineDictionary[Customer] += randomNumberInRange();
            }

            //Outputs the results
            foreach (var Customer in lineDictionary) {

                Console.WriteLine(Customer.Key + "\t\t " + Customer.Value);
            }

            Console.Read();
        }
    }
}
