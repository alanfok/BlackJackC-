using System;
using System.Security.Cryptography.X509Certificates;

namespace Blackjack
{
    internal class Desk
    {
        Random rm = new Random();
        private static Desk instance;
        string[] deskcard = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};


        public static Desk Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Desk();
                }

                return instance;
            }
        }


        public string CardDealt()
        {

            int index = rm.Next(0, 12);
            return deskcard[index];
        }
    }
}