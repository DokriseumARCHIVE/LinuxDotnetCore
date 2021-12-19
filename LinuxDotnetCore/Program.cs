using System;
using AppLinux;
using ConsoleApplication.Vehicles;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car();
            Person carl = new CarDriver();
            carl.setFirstname("Carl");
            carl.setLastname("Benz");
            carl.setSex('m');
            carl.setAge(56);
            Console.WriteLine(((Driver) carl).getCars().Count);
            ((Driver) carl).getCars().Add(car1);
            Console.WriteLine(carl.ToString());
            Console.WriteLine(((Driver) carl).getCars().Count);
        }
    }
}