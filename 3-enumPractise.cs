using System;

namespace Enum
{
    class enumPractice
    {
        enum Workers: byte
        {
            manager,
            teacher,
            officer,
            attendant
        }
        static void Main(string[] args)
        {
            int[] Arr = new int[] { 12000, 8000, 6000, 3700};

            Console.Write("Manager = 0\nTeacher =1\nOfficer = 2\nAttendant = 3\n");
            Console.Write("Please, insert a value = ");
            Workers Value = (Workers)Convert.ToByte(Console.ReadLine());
            switch (Value)
            {
                case Workers.manager :
                    Console.WriteLine("Manager Salary = " + Arr[0]);
                    break;
                case Workers.teacher:
                    Console.WriteLine("Teacher Salary = " + Arr[1]);
                    break;
                case Workers.officer:
                    Console.WriteLine("Officer Salary = " + Arr[2]);
                    break;
                case Workers.attendant:
                    Console.WriteLine("Attendant Salary = " + Arr[3]);
                    break;
            }
        }
    }
}
