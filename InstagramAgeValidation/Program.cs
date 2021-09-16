using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siseta om sünniaasta");
            int UserYear = Convert.ToInt32(Console.ReadLine());
            int UserAge = 2021 - UserYear;
            if (UserAge < 13)
            {
                Console.WriteLine("Sa ei või instagrami kasutada");
            }
            else
            {
                Console.WriteLine("Sa võid instagrami kasutada");
            }
        }
    }
}
