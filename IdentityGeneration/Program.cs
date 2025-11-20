using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.VisualBasic;

while (true)
{
    Console.WriteLine("enter the date of your berthday");
    String date = Console.ReadLine();

    if (int.TryParse(date, out int year))
    {
        if (year >= 2013 && year <= 2024)
        {
            Console.WriteLine("Gen Alpha");
        }
        else if (year >= 1997 && year <= 2012)
        {
            Console.WriteLine("Z");
        }

        else if (year >= 1981 && year <= 1996)
        {
            Console.WriteLine("Y");

        }
        else if (year >= 1965 && year <= 1980)
        {
            Console.WriteLine("X");

        }
        else if (year >= 1946 && year <= 1964)
        {
            Console.WriteLine("Baby Boomers");
        }
        else if (year >= 1928 && year <= 1945)
        {
            Console.WriteLine("Silent Generation");
        }
    }
    else
        {
            Console.WriteLine("enter a number");

        }
    }

