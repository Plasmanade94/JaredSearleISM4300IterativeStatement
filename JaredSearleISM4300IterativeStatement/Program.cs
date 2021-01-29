using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaredSearleISM4300IterativeStatement
{
    class Program
    {


        static void Main(string[] args)
        {

            {


                {
                    int output;
                    Console.WriteLine("Please enter an integer between 1 and 100.");
                    Console.ReadKey(true);
                    string input = Console.ReadLine();
                    //Records input from user as a string.
                    output= int.Parse(input);
                    //Converts the input into a decimal format for conditional statement use.
                                      
                    int count = 0;

                    do
                    {
                        count++;
                        //adds one to count and displays the following message with the output
                        Console.WriteLine("Hello! You have entered " +output +". This is the current integer value in the loop: " +count);
                        
                    } while (count < output);
                     //Even if count is 5 , it still goes through 5 times, ensuring the correct number of loops.   
                        
                     
                     Console.ReadKey(true);
                    }

                    







                }
            }
        }
    }


