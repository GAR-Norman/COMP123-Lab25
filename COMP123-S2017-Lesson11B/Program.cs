using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Gabriel Norman
 * Date: July 27, 2017
 * Description: This is the driver class
    * Version: 0.2 - Commented out the unneccessay test harness code so the console output is easier to read; 
 */

namespace COMP123_S2017_Lesson11B
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand hand = new Hand();

           // Console.WriteLine(deck.ToString());
            //Console.WriteLine();
            deck.Shuffle();
           // Console.WriteLine("Shuffled");
           // Console.WriteLine(deck.ToString());

            //hand.Add(deck.Deal1());
           // Console.WriteLine(hand.ToString());
           // Console.WriteLine();
           // hand.Add(deck.Deal1());
            //Console.WriteLine(hand.ToString());

           // Console.WriteLine();
            //Console.WriteLine(deck.ToString());                 //The Test Harness relevent to this lab begins below!

           
            
            // Testing the deal 5 method using the hand object!
            Hand hand2 = new Hand();

            hand2 = deck.Deal5();
            Console.WriteLine(hand2);


            //Testing the highest card method!
           Hand.HighestCard(hand2);
          
            



        }
    }
}
