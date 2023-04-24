using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var HassansCar = new Car();
            HassansCar.Make = "Subaru";
            HassansCar.Model = "Impreza";
            HassansCar.Year = 2018;
            HassansCar.EngineNoise = "Zoom";
            HassansCar.HonkNoise = "BOP";
            HassansCar.IsDrivable = true;

            lot.Cars.Add(HassansCar);

            var MomsCar = new Car()
            {
                Year = 2017,
                Make = "Lexus",
                Model = "NX",
                EngineNoise = "eowwwww",
                HonkNoise = "Beep",
                IsDrivable = true
            };
            lot.Cars.Add(MomsCar);

            var SarasCar = new Car(2014,"chevy","Cruze","Brr","HONKKK",true);
            lot.Cars.Add(SarasCar);

            HassansCar.MakeEngineNoise();
            MomsCar.MakeEngineNoise();
            SarasCar.MakeEngineNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
