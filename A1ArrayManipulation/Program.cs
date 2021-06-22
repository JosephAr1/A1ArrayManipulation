using System;

namespace A1ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] Array = new int [10];
            int j; 

            

            for (j = 0; j < Array.Length; j++) // for loop to get the number entered by the user and store it to j
            {

                Console.Write("Please Enter a Number: "); // prompt the user to enter the user
                Array[j] = Convert.ToInt32(Console.ReadLine()); 
            }
            Console.Write("New Value of Array is: ");

            for (int i = 0; i < 10; i++) // this is the inner loop to continue to modify the values of the
                                         // array for the new value
            {
                Console.Write(" " + Convert.ToString(Array[i] / (i + 1))); // this is to print the new new value of the numbers
                                                                           // prompted by the user where it was divided by  the array 
                                                                           // plus (1) one
            }
            



        }

        
    }
}
