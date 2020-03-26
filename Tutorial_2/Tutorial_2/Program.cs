using System;

namespace Tutorial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Paweł,Nowak,Informatyka dzienne,Dzienne,459,2000-02-12 00:00:00.000,nowak @pjwstk.edu.pl,Alina,Adam";

            Student s = Student.GetInstanceOf(line);

            Console.WriteLine(s.FatherName);
              
        }
    }
}
