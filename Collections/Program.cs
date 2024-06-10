namespace Collections;

public class Program
{
    static void Main(String[] args)
    {
        Car ferrari = new Car("Ferrari", "812 SuperFast", -812, 340.2f, 2024);

        ferrari.ShowTechnicalPasport();
        Console.WriteLine();
        ferrari.AfterStage(288, 39.8f);
        ferrari.ShowTechnicalPasport();
    }


    class Car
    {
        public string Brand;
        public string Model;
        public int HorsePower;
        public float MaxSpeed;
        public int Year;

        public Car(string brand, string model, int horsePower, float maxSpeed, int year)
        {
            if (horsePower < 0)
            {
                HorsePower = 100;
            }
            else
            {
                HorsePower = horsePower;
            }

            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            Year = year;
        }

        public Car()
        {
            Brand = "BMW";
            Model = "M3";
            HorsePower = 480;
            MaxSpeed = 330.3f;
            Year = 2018;
        }

        public void ShowTechnicalPasport()
        {
            Console.WriteLine(
                $"Brand of car: {Brand} \nModel of car:  {Model}  \nH.p: {HorsePower}  \nMaxSpeed: {MaxSpeed} km/h \nYear: {Year}");
        }

        public void AfterStage(int horsepower, float maxSpeed)
        {
            HorsePower += horsepower;
            MaxSpeed += maxSpeed;
        }
    }
}