using System;
using System.IO;
namespace LinkedListProblem1.DsAndAlgorithm
{
    public class BinarySearch
    {
        public void Search(string filePath)
        {
            string data = File.ReadAllText(filePath);
            string[] words = data.Split(",");
            Console.WriteLine("Enter word to search");
            string search = Console.ReadLine();
            foreach (var item in words)
            {
                if (search.ToLower().Equals(item.ToLower()))
                {
                    Console.WriteLine("word found");
                    return;
                }
            }
            Console.WriteLine("word not found");
        }
    }
}