
namespace Samsung
{
using System;
class months{
    public static void Main(string[] args)
    {
        string input;
        Console.WriteLine("Enter the month");
        input = Console.ReadLine().ToUpper();
        switch(input){
            case "January":
            case "march":
            case "May" :
            case "July" :
            case "august":
            case "october" :
            case "december" :
            Console.WriteLine("This months has 31 days");
            break;
            case "april" :
            case "June":
            case "September":
            case "Nomvember" :
            Console.WriteLine("this month has 30 days   ");
            break;
            case "February":
            Console.WriteLine("This month has 28 days  in non-leap year and 29 days in  a leap year");
            break;
            default: 
            Console.WriteLine("Incorrect choice");
            break;
        }
    }
}
}