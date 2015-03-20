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
    class Program
    {
        static void Main(string[] args)
        {
            RollDice dice = new RollDice();
            dice.rollTwoDice();
            dice.printTally();
            dice.printFrequency();

            Console.WriteLine("Enter the key to exit...");
            Console.ReadKey();
        }
    }
}
