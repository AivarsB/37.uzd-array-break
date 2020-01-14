using System;

namespace _37.uzd_array_break
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 22)
                {
                    Console.WriteLine(numbers[i]);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
// Definēt int masīvu ar 10 elementiem { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8 }. 
// Drukājam vērtības console logā, tik ilgi kamēr sastopam vērtību 22. 
// Pēc vērtības 22 sasniegšanas cikls ir jāpārtrauc.