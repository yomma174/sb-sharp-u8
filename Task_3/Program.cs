﻿namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                HashSet<int> set = new HashSet<int>();
    
                string userInput = Console.ReadLine();
    
                if (!set.Contains(int.Parse(userInput)))
                {
                    set.Add(int.Parse(userInput));
                    Console.WriteLine("Число успешно сохранено.");
                }
                else
                    Console.WriteLine("Число уже вводилось ранее.");
            }
            while (true)
        }
    }
}
