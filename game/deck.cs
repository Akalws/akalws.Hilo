using System;
using System.Collections.Generic;


namespace AKALWS.HILO.game
{
    public class Deck
    {
        int card;
    

        public Deck()
        {
        }

        public int GetNumber()
        {
           
            Random random = new Random();
            
            card = random.Next(1,14);

            return card;


        }
    }
}