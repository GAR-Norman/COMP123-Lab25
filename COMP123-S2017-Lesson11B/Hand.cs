using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Gabriel Norman
 * Date: July 27, 2017
 * Description: This is the Hand class
 * It inherits from the CardList Abstract class
 * Version: 0.1 - Created the Hand class
 */

namespace COMP123_S2017_Lesson11B
{
    public class Hand : CardList
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        // PRIVATE METHODS
        protected override void _initialize()
        {
            // STUB
           // this method is empty
        }

    
        // PUBLIC METHODS 

            /// <summary>
            /// This method returns the highest hand.
            /// </summary>
            /// <returns></returns>
            public static void HighestCard(Hand hand)
        {

            Card theHighest = new Card((Face)0, (Suit)1);

            for (int i = 0; i < 5; i++)
            {
                if(hand[i].Face > theHighest.Face)
                {
                    theHighest = hand[i];
                }
            }



            var theHighestCard = from HighCrd in hand where HighCrd.Face == theHighest.Face select HighCrd;

            foreach (var item in theHighestCard)
            {
                Console.WriteLine("The highest card in the hand is the {0} of {1}", item.Face, item.Suit);
            }

            
        }

        /// <summary>
        /// This method overrides the built-in ToString method.
        /// </summary>
        /// <returns>
        /// This method returns the current cards in the deck
        /// </returns>
        public override string ToString()
        {
            string outputString = "";

            outputString += "Hand Contains  Number of Cards: " + this.Count + "\n";
            outputString += "==================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }
    }
}