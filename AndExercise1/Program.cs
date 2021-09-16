using System;

namespace AndExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eksami punktid");
            Console.WriteLine("Sisesta oma matemaatika, keemia ja bioloogia punktid");
            int math = Convert.ToInt32(Console.ReadLine());
            int chem = Convert.ToInt32(Console.ReadLine());
            int bio = Convert.ToInt32(Console.ReadLine());
            if (math >= 85 && chem >= 90 && bio >= 95)
            {
                Console.WriteLine("Sul on piisavalt punkte");
            }
            else
            {
                Console.WriteLine("Sul pole piisavalt punkte");
            }
           
        }
    }
}
