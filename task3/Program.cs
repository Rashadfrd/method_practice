using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adlarin sayini daxil edin:");
            int nameCounter = int.Parse(Console.ReadLine());
            bool result = NameFinder(nameCounter);
            Console.WriteLine(result);

        }
        static bool NameFinder(int num)
        {
            bool check = false;
            int count = 0;
            int count2 = 0;
            int j = 0;
            Console.WriteLine("Adlari daxil edin:");
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    count++;
                }
            }

            if (num == ++count)
            {
                Console.WriteLine("Istediyiniz adi daxil edin:");
                string input1 = Console.ReadLine();
                for (int i = 0; i < input.Length; i++)
                {
                    while (j < input1.Length)
                    {
                        if (input[i] == input1[j])
                        {
                            count2++;
                            j++;
                            break;
                        }
                        
                        else
                        {
                            count2 = 0;
                            j = 0;
                        }
                        break;
                    }
                }
                if (count2 == input1.Length)
                {
                    check = true;
                    return check;
                }
                else
                {
                    check = false;
                    return check;
                }
            }
            return check;

        }
        
    }
}
