using System.Collections;
using System.Security.Cryptography.X509Certificates;

WachCar washCar= CarWash.WashingCar;
WachCars washCars = CarWash.WashingCars;

Auto auto1 = new Auto("BMW","M3");
Auto auto2 = new Auto("Mercedes-Benz", "Maybach");
Auto auto3 = new Auto("Toyota", "Corolla");

Garage garage = new Garage();
garage.AddAuto(auto1);
garage.AddAuto(auto2);

Console.WriteLine("Моем машину");
washCar(auto3);
Console.WriteLine();
Console.WriteLine("Моем машины из гаража");
washCars(garage);

class Auto
{
    public string brandName;
    public string model;
    public string status = "not washed";

    public Auto(string brandName, string model)
    {
        this.brandName = brandName;
        this.model = model;
    }
}

class Garage
{
    public List<Auto> Сars { get; set; }

    public Garage()
    {
        Сars = new List<Auto>();
    }
    public void AddAuto(Auto car)
    {
        Сars.Add(car);
    }

    public void DeleteAuto(Auto car)
    {
        Сars.Remove(car);
    }

    public void DeleteAutoInd(int index)
    {
        Сars.RemoveAt(index);
    }
}

class CarWash
{
    public static void WashingCars(Garage garage)
    {
        foreach (Auto car in garage.Сars)
        {
            car.status = "Помыта";
            Console.WriteLine($"Машина {car.brandName} {car.model} {car.status}");
        }
    }
    public static void WashingCar(Auto car)
    {
        car.status = "Помыта";
        Console.WriteLine($"Машина {car.brandName} {car.model} {car.status}");
    }
}

delegate void WachCars(Garage cars);
delegate void WachCar(Auto car);
