using System;
using CsharpStudyApp.FirstSteps;

namespace CsharpStudyApp
{
    class Program
    {
        private static void UsePerson(Object o)
        {
            var person = (Person) o;
        }
        static void Main(string[] args)
        {
            var user = new User();
            UsePerson(user);

            if (user is Person psn)
            {
                Console.WriteLine("Yea, user is a Person!!! ");
                Console.WriteLine(psn);
            }

            Byte num = 100;
            

            try
            {
                num = checked((Byte) (num + 200));
                Console.WriteLine($"Our num is overflowed - {num}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Ooop, its error - " + e.Message);
            }

            var point = new Point(1, 1);
            Console.WriteLine(point);

            point.Change(10, 20);
            Console.WriteLine(point);

            Object o = point;
            Console.WriteLine(o);
            
            ((Point)o).Change(13,13);
            Console.WriteLine(o);
            
            ((IChangeBoxingPoint)o).Change(13,13);
            Console.WriteLine(o);
            
            ((IChangeBoxingPoint)o).Change(25,17);
            Console.WriteLine(o);
        }
    }
}