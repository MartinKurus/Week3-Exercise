using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta täht!");
            char UserCharacter = Convert.ToChar(Console.ReadLine().ToLower());
            
            switch (UserCharacter)

            {
                case 'a':
                    Console.WriteLine("See on täishäälik");
                    break;
                case 'e':
                    Console.WriteLine("See täht on täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("See täht on täishäälik");
                    break;
                case 'o':
                    Console.WriteLine("See täht on täishäälik");
                    break;
                case 'u':
                    Console.WriteLine("See täht on täishäälik");
                    break;
                default:
                    Console.WriteLine("See täht on kaashäälik");
                    break;
            }
            
        }
    }
}
