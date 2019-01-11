using System;
using ClassLibrary.Classes;
using ClassLibrary;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DriveTrain drivetrain = new DriveTrain();
            drivetrain.Uses = "Disele";
            drivetrain.Liters = 53;

            Car car = new Car("Bmw", "M3", 5);
            ATV atv = new ATV("Bazoka", "Z300", 1);
            Motorcycle motorcycle = new Motorcycle("Kawasaki", "KB300", 3);
            Bike bike = new Bike("Biltema", "Standard", 1);
            
            Console.WriteLine("I have a " + car.name + ", " + car.model + " with " + car.GetGears() + " Gears " + drivetrain);
            Console.WriteLine("I have a " + atv.name + ", " + atv.model + " with " + atv.GetGears() + " Gears");
            Console.WriteLine("I have a " + motorcycle.name + ", " + motorcycle.model + " with " + motorcycle.GetGears() + " Gears");
            Console.WriteLine("I have a " + bike.name + ", " + bike.model + " with " + bike.GetGears() + " Gears");
            Console.ReadLine();
        }

        
    }
}
