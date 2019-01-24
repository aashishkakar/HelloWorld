using System;
using static System.Math;

namespace HelloWorld
{
    class Program
    {   

        static int calcsum(int i)
        {
            int sum = 0;
            for(int j=i;j>0;j--)
            {
                sum = sum + j;
            }
            return sum;
        }

        //// Exercise 1
        // Calculate the area of a triangle using Heron's formula
        private static double herons(double i,double j,double k)
        {
            double area = 0;
            double s = (i + j + k) / 2;
            area = Math.Sqrt(s * (s - i) * (s - j) * (s - k));
            return area;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to continue : ");
            Console.WriteLine("Hello World!");
            

            int x = 2;
            int y = 3;

            int z = x + y;

            Console.WriteLine("Sum of x and y is " + z + "\n");


            // M disambiguates between double and decimal. 

            decimal income = 10000.45M;
            decimal taxRate = 0.1M;
            decimal taxLiability = income * taxRate;
            Console.WriteLine("Tax liability is " + taxLiability+"\n");



            //Parsing to Specific Data Types
            //int inputNumber = Convert.ToInt32(userInput);

            //Check if the number is Even or Odd

            string num = Console.ReadLine();
            int userInput = Convert.ToInt32(num);
            if (userInput % 2 == 0)
                Console.WriteLine("Number " + num + " is Even \n");
            else
                Console.WriteLine("Number " + num + " is Odd");

            //Write your code here
            //Write a method that accepts a parameter (n) and returns the sum 
            //of first n natural numbers.
            Console.Write("Enter the parameter (n) such that I can provide you the sum of first n natural numbers :");
            string param = Console.ReadLine();
            int userInput2 = Convert.ToInt32(param);
            int get_sum = calcsum(userInput2);
                   

            Console.WriteLine("\n Sum of first " + param + " is :" + get_sum);

            //// Main definition to the Herons function.

            Console.Write("Side 1 : ");
            string param1 = Console.ReadLine();
            double a = Convert.ToDouble(param1);

            Console.Write("Side 2 : ");
            string param2 = Console.ReadLine();
            double b = Convert.ToDouble(param2);

            Console.Write("Side 3 : ");
            string param3 = Console.ReadLine();
            double c = Convert.ToDouble(param3);


            double get_area = herons(a, b, c);

            Console.WriteLine(" Area is :" + get_area);
            // Exercise 4
            // Input a value (n) from the user and calculate the sum of first n 

            // Exercise 5
            // Input a value (n) from the user and display the following * 
            //pattern:
            // Input n=5
            // Output
            // *
            // **
            // ***
            // ****
            // *****
            // Write your code here

            string param4 = Console.ReadLine();
            int userInput5 = Convert.ToInt32(param4);
            //int get_sum = calcsum(userInput5);

            for(int i=1;i<=userInput5;++i)
            {
                for(int j=0;j<i;++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");                  
            }
            //////////////////////////

            // Exercise 6
            // Input a value (n) from the user and display the following * 
            //pattern:
            // Input n=5
            // Output
            //     *
            //    **
            //   ***
            //  ****
            // *****
            // Write your code here
            string param5 = Console.ReadLine();
            int userInput6 = Convert.ToInt32(param5);
            //int get_sum = calcsum(userInput5);

            for (int i = 0; i <= userInput6; ++i)
            {
                for (int j = userInput6; j >= 0; --j)
                {
                    if(j>i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    
                }
                Console.WriteLine("\n");
            }
            ///////
            ///// Exercise 8
            // Enter n numbers in an array and print all the even numbers.
            // Write your code here

            Console.Write(" How Many Numbers do you wanna pick ? ");
            string param6 = Console.ReadLine();
            int userInput7 = Convert.ToInt32(param6);

            int[] arr = new int[userInput7];

            Console.Write("Input elements in the array :\n");
            for (int i = 0; i < userInput7; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sumarr = 0;
            for (int i=0;i<userInput7;i++)
            {
                sumarr = sumarr + arr[i];
            }
            Console.Write("Sum of the "+userInput7+" array elements as entered is  : "+ sumarr);

            // Exercise 9
            // Enter n numbers in an array and find the highest and the smallest 
            //number.
            // Write your code here

            Console.Write(" How Many Numbers do you wanna pick ? ");
            string param7 = Console.ReadLine();
            int userInput8 = Convert.ToInt32(param7);

            int[] arr1 = new int[userInput8];

            Console.Write("Input elements in the array :\n");
            for (int i = 0; i < userInput8; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int large = arr1[0];
            for (int i = 0; i < userInput8 ; i++)
            {
                if(arr1[i]>large)
                {
                    large = arr1[i];
                }
            }
            Console.Write("Largest in the lot is : " + large+"\n");


            int small = arr1[0];
            for (int i = 0; i<userInput8;i++)
            {
                if(arr1[i]<small)
                {
                    small = arr1[i];
                }
            }

            Console.Write("Smallest in the lot is : " + small);
            //////
            Console.ReadKey(true);
        }
    }
}
