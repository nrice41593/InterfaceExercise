using System;
namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany
    { 
        public Suv()
        {
        }
        public double EngineSize { get; set; } = 4.0;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Mustang";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }



        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward ...");
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving forward ...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }

        public void Park()
        {

        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
