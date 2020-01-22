using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            int age, height,heartrate;
            age = 23;
            height = 175;

            //max heart rate = 220-age

            heartrate = 220 - age;

            Console.WriteLine("I am " +age+ " years old, my max heart rate is "+heartrate+",I am "+height+" tall.");
            Console.ReadLine();
        }
    }
}
