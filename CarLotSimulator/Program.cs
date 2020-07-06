using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        public static IEnumerable<object> CarList { get; private set; }

        static void Main(string[] args)
        {
            //DONE - Set the properties for each of the cars

            //Now that the Car class is created we can instanciate 3 new cars
            Console.WriteLine(CarLot._numberOfCars);
            
            CarLot carLot = new CarLot();

            //Adding a new Car to the carlist
           //carLot.CarList.Add(car1);
            Car car1 = new Car
            {
                Year = 2002,
                Make = "Toyota",
                Model = "Celica",
                EngineNoise = "Vroom",
                HonkNoise = "Honk",
                IsDriveable = false
            };

            car1.MakeEngineNoise();
            car1.MakeHonkNoise();

            Console.WriteLine(CarLot._numberOfCars);
            carLot.CarList.Add(car1);

            //Parameterized Constructor
            var car2 = new Car()
            {
                Year = 2003,
                Make = "BMW",
                Model = "328i",
                EngineNoise = "Clunky",
                HonkNoise = "Beep",
                IsDriveable = false
            };

            car2.MakeEngineNoise();
            car2.MakeHonkNoise();

            Console.WriteLine(CarLot._numberOfCars);
            carLot.CarList.Add(car2);


            //Long Method
            Car tesla = new Car();
            tesla.Year = 2018;
            tesla.Make = "Tesla";
            tesla.Model = "ModelS";
            tesla.EngineNoise = "Smooth";
            tesla.HonkNoise = "Beep beep";
            tesla.IsDriveable = true;
            carLot.CarList.Add(tesla);

            tesla.MakeEngineNoise();
            tesla.MakeHonkNoise();

            Console.WriteLine(CarLot._numberOfCars);
            carLot.CarList.Add(tesla);

            //Object Initializer Method
            Car celica = new Car() 
            { 
                Year = 2000, 
                Make = "Toyota", 
                Model = "Celica", 
                EngineNoise = "Nothing", 
                HonkNoise = "Help" 
            };
            celica.MakeEngineNoise();
            celica.MakeHonkNoise();

            Console.WriteLine(CarLot._numberOfCars);
            carLot.CarList.Add(celica);

            foreach (var car in carLot.CarList)
            {
                Console.WriteLine(); 
                Console.WriteLine($"{car.Year}, {car.Make} {car.Model}");
            }
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
//TODO

//DONE - Create a seperate class file called Car DONE
//DONE - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
//DONE - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
//DONE - The methods should take one string parameter: the respective noise property  

//DONE - Now that the Car class is created we can instanciate 3 new cars

//DONE - Call each of the methods for each car

//*************BONUS*************//

//DONE - Set the properties utilizing the 3 different ways we learned about, one way for each car

//*************BONUS X 2*************//

//DONE - Create a CarLot class
//DONE - It should have at least one property: a List of cars
