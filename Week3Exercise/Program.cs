using System;

namespace Week3Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada pin koodi
            //programm võrdleb sisestatud pin koodi arvuga 1234
            //kui sisestatud pin kood on 1234
            //programm kuvab konsoolis "tere tulemast!"
            //kui sisestatud pin on vale programm kuvab konsoolis
            //"vale pin. proovi uuesti.
            Console.WriteLine("Sisesta PIN-kood");
            int UserPin = Convert.ToInt32(Console.ReadLine());
            /*if (UserPin == 1234)
            {
                Console.WriteLine("Tere tulemast");
            }
            else
            {
                Console.WriteLine("Vale PIN-kood.Proovi uuesti");
            }*/
            if(UserPin != 1234) {
                Console.WriteLine("Vale PIN.Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }


        }
    }
}
