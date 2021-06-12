using System;

namespace SharpWasher
{
    class Program
    {
        delegate void W(Car car);
        static void Main(string[] args)
        {
            Console.WriteLine("List of dirty cars. If the car is clean you will see the mark 'True'");
            Garage garage = new Garage();
            Car car1 = new Car("Tesla");
            Car car2 = new Car("BMW");
            Car car3 = new Car("Toyota");
            Car car4 = new Car("Ferrari");
            garage.Add(car1);
            garage.Add(car2);
            garage.Add(car3);
            garage.Add(car4);
            foreach (var car in garage)
            {
                Console.WriteLine(car);

            }
            Console.WriteLine("If the car is clean after washing you will see the mark 'True'");

            Washer washer = new Washer();
            W del = washer.Wash;
            foreach (var car in garage)
            {
                del(car);
                Console.WriteLine(car);

            }
            Console.ReadKey();
        }
    }
}
