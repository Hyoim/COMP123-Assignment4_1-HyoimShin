/********************************************************
 * Hyoim Shin (300802252)
 * March 16, 2015
 * Assignment4-1 : Array Practice
 * Revision History : 
 * 
 * ******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyoimShin_Assignment4_1
{
    class RollDice
    {
        Random rnd = new Random();

        // PRIVATE PROPERTIES +++++++++++++++++++++++++++++++++++++++++
        private int number1;  // the number of the first dice
        private int number2;  // the number of the second dice
        private int sum;      // the sum of number1 and number2
        private int[] tallyArr = new int[11];
        private int[,] frequencyArr = new int[6,6];

        // CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++
        public RollDice()
        {
            initialTallyArray();
            initialFreqencyArr();
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++
        // Initializes the value of tallArr
        private void initialTallyArray()
        {
            for(int index = 0; index <11; index++)
            {
                tallyArr[index] = 0;
            }
        }
        // Initializes the value of fequencyArr
        private void initialFreqencyArr()
        {
            for(int row = 0; row < 6; row++)
            {
                for (int col=0; col < 6; col++)
                {   
                    frequencyArr[row,col] = 0;
                }
            }
        }

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++
        // To roll the two dice and sum of the two values
        public void rollTwoDice()
        {
            for(int index = 0; index < 36000; index++)
            {
                this.number1 = rnd.Next(6);
                this.number2 = rnd.Next(6);
                this.sum = number1 + number2;
              //  Console.WriteLine(this.sum);
                tallyOfNumber(this.sum);
                frequencyOfValue(this.number1, this.number2);
            }
        }
        
        // To tally the number of times each possible sum appears
        public int[] tallyOfNumber(int sum)
        {
            this.tallyArr[sum]++;
            return tallyArr;
        }

        // Calculate how many times each number was rolled
        public int[,] frequencyOfValue(int row, int col)
        {
            this.frequencyArr[row,col]++;

            return frequencyArr;
        }
        // Display the results in tabular format how many times each number was rolled
        public void printTally()
        {
            Console.WriteLine("The number of times each possible sum appears: ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("    2    3     4     5     6     7     8     9     10    11    12");
            Console.WriteLine("-------------------------------------------------------------------");

            for (int index = 0; index < 11; index++)
            {
                Console.Write("{0,6}", tallyArr[index]);       
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------");
            
        }
        // Display the results in tabular format how many times each number was rolled
        public void printFrequency()
        {
            int count = 0;

            Console.WriteLine();
            Console.WriteLine("The number of times each number was rolled: ");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("        1          2         3         4         5         6");
            Console.WriteLine("---------------------------------------------------------------");

            for (int row = 0; row < 6; row++)
            {
                Console.Write(" {0} |", row + 1);
                for (int col = 0; col < 6; col++)
                {
                    count++;
                    Console.Write("  {0,5}   ", frequencyArr[row, col]);
                    if (count % 6 == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("---------------------------------------------------------------");
                    }
                }
            }
        }
    }
}
