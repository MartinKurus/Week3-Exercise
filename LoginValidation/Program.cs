using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja parool
            //programm kontrollib sisestatud andmed
            //kui sisestatud kasutaja tunnus on "admin" ja
            //sisestatud parool on "admin1234" 
            //siis programm kuvab "tere tulemast!"
            //muul juhul programm kuvab "vale kasutaja tunnus või parool.proovi uuesti"
            Console.WriteLine("Sisesta kasutajatunnus ja parool");
            string userName = Console.ReadLine();
            string userPass = Console.ReadLine();
            if (userName != "admin" || userPass != "admin1234" )
            {
                Console.WriteLine("Vale kasutajatunnus või parool.Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }


        }
    }
}
