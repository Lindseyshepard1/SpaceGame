using System;
using static System.Console;
using static ClassLibrary.HelperMethods;


namespace ClassLibrary
{
    public class Player
    {

        public Player()
        {
            this.Stardust = 0;
            this.BankAccount = 2000;
            this.UserFood = 0;
        }
        
        public int BankAccount { get; set; }
        public int Stardust { get; set; }
        public int UserFood { get; set; }


        public void Market(int foodAndWater)
        {
            TypeWriter($"\nWelcome to the Market. What can I help you with today?\n\nYou have ${BankAccount} and {Stardust} stardust");
            TypeWriter($"\n\nEnter 1 to pick up some food and water, \nEnter 2 to sell some stardust, \nEnter 3 to exit!");
            int userInput = Convert.ToInt32(ReadLine());

            while (userInput != 1 && userInput != 2 && userInput != 3)
            {
                Clear();
                TypeWriter("Try again");
                userInput = Convert.ToInt32(ReadLine());
            }
            if (userInput == 1)
            {
                if (BankAccount <= 0) { TypeWriter("\nYou dont have enough money!\n\nPRESS ENTER"); }
                else
                {
                    ManageBankAccount(foodAndWater);
                    ManageUserFood(foodAndWater);
                    Write($"You have {UserFood} food and water\nPRESS ENTER TO RETURN TO THE HOME PAGE");
                    ReadLine();
                    Clear();
                    Market(foodAndWater);
                }
            }
            else if (userInput == 2)
            {
                if (Stardust <= 0) { TypeWriter("You dont have any Stardust!\n\nPRESS ENTER"); ReadLine(); }
                ManageBankAccount(Stardust * 2);
                Stardust = 0;
                TypeWriter($"You currently have {Stardust} stardust and ${BankAccount}\nPRESS ENTER TO RETURN TO THE HOME PAGE"); ReadLine();
                Clear();
                Market(foodAndWater);
            }
            Clear();
        }

        public void BuyFuel(int fuel)
        {

            TypeWriter($"Welcome to the fuel station! \n \n Choose one of the following options with your ${BankAccount} \n 1.Pay $100 to fill up. \n 2. I don't need gas. ");
            int userInput = int.Parse(ReadLine());

            while (userInput != 1 && userInput != 2)
            {
                Clear();
                TypeWriter("\nYou havent chosen either option! Try again.");
                userInput = int.Parse(ReadLine());
            }

            if (userInput == 1)
            {
                if (BankAccount < fuel) TypeWriter("\nYou dont have enough money. Try to go sell some stardust.");
                ManageBankAccount(fuel);
                TypeWriter($"\nYou have filled up your tank and you have ${BankAccount} left!");
                ReadLine();
            }
            else{ }
            Clear();
        }

        public void ManageBankAccount( int value)
        {
            BankAccount += value; 
        }

        public void ManageStarDust(int value)
        {
            Stardust += value;
        }

        public void ManageUserFood(int value)
        {
            UserFood += value;
        }

        public void BuyShipAndSuit()
        {
            TypeWriter($"\nYou have found a spaceship and a space suit!!! You have ${BankAccount}. Would you like to spend $1300? \n Press 1 for yes.\n Press 2 for no. ");
            int userInput = int.Parse(ReadLine());

            while (userInput != 1 && userInput != 2)
            {
                Clear();
                TypeWriter("\nYou havent chosen either option! Try again.");
                userInput = int.Parse(ReadLine());
            }
            if (userInput == 1)
            {
                ManageBankAccount(-1300);
                TypeWriter($"\nCongrats! you are now ready to travel and you have ${BankAccount} left!");
                
            }
            if (userInput == 2)
            {
                TypeWriter($"\nOH NO!!!!! You didn't leave earth in time and died!");
                ReadLine();
                Environment.Exit(0);
            }

            TypeWriter("\nNow that you have a ship, lets get some fuel!\n\nPRESS ENTER");
            ReadLine();
            Clear();

        }

        public void BuyHouse()
        {
            WriteLine($"Choose a house to move into!\nYou have ${BankAccount}");
            ReadLine();
            WriteLine("\nPress 1 to buy this one for $300");
            WriteLine(@"

         _
      _-'_'-_
   _-' _____ '-_
_-' ___________ '-_
 |___|||||||||___|
 |___|||||||||___|
 |___|||||||o|___|
 |___|||||||||___|
 |___|||||||||___|
 |___|||||||||___|

");
            ReadLine();
            WriteLine("Press 2 to buy this one for $500");
            WriteLine(@"

     _|=|__________
    /              \
   /                \
  /__________________\
   ||  || /--\ ||  ||
   ||[]|| | .| ||[]||
 ()||__||_|__|_||__||()
( )|-|-|-|====|-|-|-|( ) 
^^^^^^^^^^====^^^^^^^^^^^");
            ReadLine();
            WriteLine("Press 3 to buy this one for $700");
            WriteLine(@"
                      
                                      /\
                                      /\
                                      /\
                                    _`=='_
                                 _-~......~-_
                             _--~............~--_
                       __--~~....................~~--__
           .___..---~~~................................~~~---..___,
            `=.________________________________________________,='
               @^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^@
                        |  |  I   I   II   I   I  |  |
                        |  |__I___I___II___I___I__|  |
                        | /___I_  I   II   I  _I___\ |
                        |'_     ~~~~~~~~~~~~~~     _`|
                    __-~...~~~~~--------------~~~~~...~-__
            ___---~~......................................~~---___
.___..---~~~......................................................~~~---..___,
 `=.______________________________________________________________________,='
    @^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^@
              |   |    | |    |  |    ||    |  |    | |    |   |
              |   |____| |____|  |    ||    |  |____| |____|   |
              |__________________|____||____|__________________|
            _-|_____|_____|_____|__|------|__|_____|_____|_____|-_ 
");
            WriteLine("\n\nPress 4 if you dont have enough money");
            int userInput = int.Parse(ReadLine());

            switch(userInput)
            {
                case 1:
                    Clear();
                    TypeWriter("Congrats on your new house and goodluck!");
                    WriteLine(@"

         _
      _-'_'-_
   _-' _____ '-_
_-' ___________ '-_
 |___|||||||||___|
 |___|||||||||___|
 |___|||||||o|___|
 |___|||||||||___|
 |___|||||||||___|
 |___|||||||||___|

");
                    ReadLine();
                    break;
                case 2:
                    Clear();
                    TypeWriter("Congrats on your new house and goodluck!");
                    WriteLine(@"

     _|=|__________
    /              \
   /                \
  /__________________\
   ||  || /--\ ||  ||
   ||[]|| | .| ||[]||
 ()||__||_|__|_||__||()
( )|-|-|-|====|-|-|-|( ) 
^^^^^^^^^^====^^^^^^^^^^^");
                    ReadLine();
                    break;
                case 3:
                    Clear();
                    TypeWriter("Congrats on your new house and goodluck!");
                    WriteLine(@"
                      
                                      /\
                                      /\
                                      /\
                                    _`=='_
                                 _-~......~-_
                             _--~............~--_
                       __--~~....................~~--__
           .___..---~~~................................~~~---..___,
            `=.________________________________________________,='
               @^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^@
                        |  |  I   I   II   I   I  |  |
                        |  |__I___I___II___I___I__|  |
                        | /___I_  I   II   I  _I___\ |
                        |'_     ~~~~~~~~~~~~~~     _`|
                    __-~...~~~~~--------------~~~~~...~-__
            ___---~~......................................~~---___
.___..---~~~......................................................~~~---..___,
 `=.______________________________________________________________________,='
    @^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^@
              |   |    | |    |  |    ||    |  |    | |    |   |
              |   |____| |____|  |    ||    |  |____| |____|   |
              |__________________|____||____|__________________|
            _-|_____|_____|_____|__|------|__|_____|_____|_____|-_ 
");
                    ReadLine();
                    break;
                case 4:
                    Clear();
                    TypeWriter("You didn't have enough money for a home and froze to death");
                    ReadLine();
                    Environment.Exit(0);
                    break;
            }
            TypeWriter("Thank you for playing");
            ReadLine();
        }
    }
}