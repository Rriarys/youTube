using System;

internal class Program
{
    static void Main()
    {
        int minutes = 123;
        const int SEC_IN_MIN = 60;

        System.Console.WriteLine($"{minutes} minutes = {minutes*SEC_IN_MIN} seconds\n");

        double celsium = 21;
        double farenheite = celsium * 1.8 + 32;

        System.Console.WriteLine($"{celsium} in Celsium = {farenheite} in Farenheite. ");
    }
}

