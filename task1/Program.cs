using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "akif", "babaxan", "mansirxan", "bedirxan", "rauf" };
            int result = LetterCounter(names);
            Console.WriteLine(result);
        }
        static int LetterCounter(string[] name)
        {
            
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].Length > 5)
                {
                    count++;
                    
                }
            }
            return count;
        }
    }
}
