namespace Speed;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter distance in meters: ");
        double distance = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter hours: ");
        int hours = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter minutes: ");
        int minutes = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter seconds: ");
        int seconds = Convert.ToInt32(Console.ReadLine());
        
        //Calculations
        int totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
        
        Console.WriteLine("Meters per second: " + CalculateMetersPerSecond(distance, totalSeconds));
        Console.WriteLine("Kilometers per hour: " + CalculateKilometersPerHour(distance, totalSeconds));
        Console.WriteLine("Miles per hour: " + CalculateMilesPerHour(distance, totalSeconds));
    }

    static double CalculateMetersPerSecond(double distance, double totalSeconds)
    {
        return distance / totalSeconds;
    }

    static double CalculateKilometersPerHour(double distance, double totalSeconds)
    {
        double distanceInKilometers = distance / 1000.0;
        double timeInHours = totalSeconds / 3600.0;
        return distanceInKilometers / timeInHours;
    }

    static double CalculateMilesPerHour(double distance, double totalSeconds)
    {
        double distanceInMiles = distance / 1609.0;
        double timeInHours = totalSeconds / 3600.0;
        return distanceInMiles / timeInHours;
    }
}