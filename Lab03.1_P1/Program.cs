using Lab03._1_P1;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();
        car.make = "Hà Nội";
        car.year = 2023;
        car.model = "MR2";
        car.color = "Black";

        car.Input();
        car.Start();
        car.Stop();
    }
}