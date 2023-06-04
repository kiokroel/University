var car1 = new Car("qwe123", "qwe");
var car2 = new Car("asd123", "asd");
var car3 = new Car("zxc123", "zxc");
var car4 = new Car("qaz123", "qaz");

var cars = new List<Car>
{
    car1,
    car2,
    car3,
    car4
};

var driver1 = new Driver("asdas", car2.id);
var driver2 = new Driver("rthrbhers", car2.id);
var driver3 = new Driver("aoi;sergdgergas", car1.id);
var driver4 = new Driver("a;iosrgerdas", car4.id);
var driver5 = new Driver("rserg;o;edas", car2.id);
var driver6 = new Driver("agererggsdas", car3.id);
var driver7 = new Driver("asdergergas", car3.id);

var drivers = new List<Driver> 
{
   driver1,
   driver2,
   driver3,
   driver4,
   driver5,
   driver6,
   driver7
};

var groupDrivers = from driver in drivers
                group driver by driver.car_id;

foreach (var car in groupDrivers)
{
    Console.WriteLine($"Бренд: {cars[car.Key].brand} номер: {cars[car.Key].number}");

    foreach (var driver in car)
    {
        Console.WriteLine(driver.name);
    }
    Console.WriteLine();
}

var groupDriversName = from driver in drivers
          where driver.name[0] == 'r'
          select driver;

foreach (var driver in groupDriversName)
{
    Console.WriteLine($"{driver.name}");
}

class Car
{
    static int count = 0;
    public int id { get; set; }
    public string number { get; set; }
    public string brand { get; set; }

    public Car(string number, string brand)
    {
        id += count;
        count++;
        this.number = number;
        this.brand = brand;
    }
}

class Driver
{
    static int count = 0;
    public int id { get; set; }
    public string name { get; set; }
    public int car_id { get; set; }

    public Driver(string name, int car_id)
    {
        id += count;
        count++;
        this.name = name;
        this.car_id = car_id;
    }
}
