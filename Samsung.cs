using System;
namespace Samsung
{
    class math
    {
        public static void Main1(String[] args)
        {
            int numOne;
            int numTwo;
            int result = 0;
            Console.WriteLine("(1) Addition");
            Console.WriteLine("(2) Subtracion");
            Console.WriteLine("(3) Multiplication");
            Console.WriteLine("(4) Division");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value one");
            numOne = Convert.ToInt32(Console.ReadLine());
            numTwo = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    result = numOne + numTwo;
                    break;
                case 2:
                    result = numOne - numTwo;
                    break;
                case 3:
                    result = numOne * numTwo;
                    break;
                case 4:
                    Console.WriteLine("Do you want to calculate the quotient or remainder");
                    Console.WriteLine("(1) Quoctient");
                    Console.WriteLine("(2) Remainder");
                    break;
                        int choice = Convert.ToInt32(Console.ReadLine());
         switch (choice)
         {
            case 1:
            result = numOne / numTwo;
                break;
            case 2:
            result = numOne % numTwo;
            break;
            default:
            Console.WriteLine("Incorrect Choice");
            break;
         }
         break;
         default:
         Console.WriteLine("Incorrect choice");
         break;
            }
            Console.WriteLine("Result : "+result);
        
         
        }
    }
}