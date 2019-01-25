using System;
using static System.Math;
using System.Diagnostics;

namespace HelloWorld
{
    class Program
    {   
        //// Exercise 1
        // Calculate the area of a triangle using Heron's formula
        private static double herons(double i,double j,double k)
        {
            double area = 0;
            double s = (i + j + k) / 2;
            area = Math.Sqrt(s * (s - i) * (s - j) * (s - k));
            return area;
        }

        // Exercise 2
        // Input a number (n) from the user and check if it is even or odd.
        static int num_max(int i)
        {
            int a = i;
            if (a % 2 == 0)
                Console.WriteLine("Number "+ a + " is Even \n");
            else
                Console.WriteLine("Number " + a + " is Odd");
            return 0;
        }

        /// Exercise 3 
        /// Input 3 Numbers from the user and check if the Maximum and the Minimum : 
        public static double normalmax(double a,double b, double c)
        {
            if(a>b)
            {
                if(a>c)
                {
                    Console.Write(a + "\n is maximum of the three numbers entered.");
                }
                else
                {
                    Console.Write(c + "\n is maximum of the three numbers entered.");
                }
              
            }
            else
            {
                if(b>c)
                {
                    Console.Write(b + "\n is maximum of the three numbers entered.");
                }
                else
                {
                    Console.Write(c + "\n is maximum of the three numbers entered.");
                }
            }
            return 0;
        }

        /// Exercise 4
        /// Calculate the sum for first n natural numbers 
        static int calcsum(int i)
        {
            int sum = 0;
            for (int j = i; j > 0; j--)
            {
                sum = sum + j;
            }
            return sum;
        }

        /// Exercise 5 
        // Input a value (n) from the user and display the following * 
        //pattern:
        // Input n=5
        // Output
        // *
        // **
        // ***
        // ****
        // *****
        static int pattern_asc(int userInput5)
        {
            for (int i = 1; i <= userInput5; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            return 0;
        }

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

        static int pattern_desc(int userInput6)
        {
            for (int i = 0; i <= userInput6; ++i)
            {
                for (int j = userInput6; j > 0; --j)
                {
                    if (j > i)
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
            return 0;
        }

        static int sum_array(int userInput7)
        {

            int[] arr = new int[userInput7];

            Console.Write("\n Input elements in the array :\n");
            for (int i = 0; i < userInput7; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sumarr = 0;
            for (int i = 0; i < userInput7; i++)
            {
                sumarr = sumarr + arr[i];
            }
            Console.Write("Sum of the " + userInput7 + " array elements as entered is  : " + sumarr);
            return 0;
        }

        // Function to Print the Even numbers in an array
        static int even_array(int userInput9)
        {
            int[] arr = new int[userInput9];
            Console.Write("\n Input elements in the array :\n");
            for (int i = 0; i < userInput9; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < userInput9; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.WriteLine("Number " + arr[i] + " is Even \n");
                else
                    continue;
            }
            return 0;
        }

        // Exercise 9
        // Enter n numbers in an array and find the highest and the smallest number.
        
        static int minmax( int userInput8)
        {
            int[] arr1 = new int[userInput8];

            Console.Write("Input elements in the array :\n");
            for (int i = 0; i < userInput8; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int large = arr1[0];
            for (int i = 0; i < userInput8; i++)
            {
                if (arr1[i] > large)
                {
                    large = arr1[i];
                }
            }
            Console.Write("Largest in the lot is : " + large + "\n");


            int small = arr1[0];
            for (int i = 0; i < userInput8; i++)
            {
                if (arr1[i] < small)
                {
                    small = arr1[i];
                }
            }

            Console.Write("Smallest in the lot is : " + small);
            return 0;
        }


        // Main Function
        static void Main(string[] args)
        {
            Console.WriteLine("Hello good people of DIS !! Lets Make this activity a bit less boring : P ");

            //Exercise 1 
            //Check if the number is Even or Odd
            Console.Write("You know what seems ODD to me ? Numbers that arent even :/ \n");
            Console.Write("Enter the Number you want to check for Even or Odd : ");
            string num = Console.ReadLine();
            int userInput = Convert.ToInt32(num);
            int max = num_max(userInput);



            //// Main definition to the Herons function.
            Console.Write("\nCalculating Triangle area is tedious ? Let us get our calculator for this : ");
            Console.WriteLine("\nLets calculate the Area of a Triangle (Enter three sides ) :");
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

            //Exercise 3
            // Take 3 numbers input and find the max out of them 
            Console.WriteLine("\n Lets see which amongst the three numbers you have is the largest. (You can enter decimals) ");
            Console.Write("\nNum 1 : ");
            string param10 = Console.ReadLine();
            double d = Convert.ToDouble(param10);

            Console.Write("\nNum 2 : ");
            string param11 = Console.ReadLine();
            double e = Convert.ToDouble(param11);

            Console.Write("\nNum 3 : ");
            string param12 = Console.ReadLine();
            double f = Convert.ToDouble(param12);
            
            double get_max_n = normalmax(d, e, f);

            // Exercise 4
            // Input a value (n) from the user and calculate the sum of first n 
            Console.Write("\nSince we are talking aboit numbers... Let us get the sum of first N natural numbers ?\n ");
            Console.Write("\nWant to know what is the sum of first n natural numbers (Enter N here ) : ");
            
            string param = Console.ReadLine();
            int userInput2 = Convert.ToInt32(param);
            int get_sum = calcsum(userInput2);

            Console.WriteLine("\n Sum of first " + param + " is :" + get_sum);


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
            
            Console.Write("Enough with these numbers.. I see you're getting bored \n\n Want to see some pattern instead ? Enter the number 'n' :  ");
            string param4 = Console.ReadLine();
            int userInput5 = Convert.ToInt32(param4);
            int get_pat_asc = pattern_asc(userInput5);

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
            Console.Write("\nWant to see some pattern :P ? Again !!! This time lets reverse it? Enter the number 'n'  :  \n ");
            string param5 = Console.ReadLine();
            int userInput6 = Convert.ToInt32(param5);
            int get_pat_desc = pattern_desc(userInput6);

            // Exercise 7
            // Enter n numbers in an array and print sum of all the numbers numbers.
            // Write your code here
            Console.WriteLine("Do you know arrays ? \n Lets Play with some !!! First lets find the sum of some numbers within an array :\n");
            Console.Write(" \n How Many Numbers do you wanna pick ? ");
            string param6 = Console.ReadLine();
            int userInput7 = Convert.ToInt32(param6);
            int get_sum_arr = sum_array(userInput7);

            //Exercise 8 
            // Enter n Numbers in an Array and Print all the even numbers in the array. 
            // Write Code here 
            Console.Write("\n   Not bad Huh ... Also, like I said earlier about my love for even numbers(XO XO) Lets find them in the array   \n ");
            Console.WriteLine("\n Lets get some Even Numbers from the numbers you enter (Let us see if I get this right) : \n");

            Console.Write("\n  How many Numbers do you want to Pick ? ");
            string param8 = Console.ReadLine();
            int userInput9 = Convert.ToInt32(param8);
            int get_even_arr = even_array(userInput9);



            // Exercise 9
            // Enter n numbers in an array and find the highest and the smallest 
            //number.
            // Write your code here
            Console.WriteLine("  Having fun ? .... No ?  :( , Let me get you the the Maximum and Minimum from the lot ? ");
            Console.Write("\n How Many Numbers do you wanna pick ? ");
            string param7 = Console.ReadLine();
            int userInput8 = Convert.ToInt32(param7);
            int get_min_max = minmax(userInput8);


            Console.Write("\nWere you impressed ? (Y/N)");
            string param9 = Console.ReadLine();
            
            if(param9=="Y" || param9 == "y")
            {
                Console.Write("\n Thanks for the feedback :) ");
            }
            else
            {
                Console.Write("\n Will try and Improve if I get less marks for not handling exceptions :P");
            }
            Console.WriteLine("Press any key to exit "); 
            Console.ReadKey(true);
        }
    }
}
