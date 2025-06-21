using System;

public class FinancialForecast
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Present Value (PV): ");
        double pv = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Annual Growth Rate (r in %): ");
        double rate = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Enter Number of Years (n): ");
        int years = Convert.ToInt32(Console.ReadLine());

        double futureValue = CalculateFutureValue(pv, rate, years);

        Console.WriteLine($"\nFuture Value after {years} years: {futureValue:F2}");
    }

    // Recursive method to calculate future value
    public static double CalculateFutureValue(double pv, double rate, int years)
    {
        if (years == 0)
            return pv;  
        return (1 + rate) * CalculateFutureValue(pv, rate, years - 1); 
    }
}
