using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static ClassLibrary.HelperMethods;

namespace ClassLibrary
{
    public class Stars
    {
        public void StarOne(Player player)
        {
            TypeWriter("Welcome to your first star! \nYou can do a challenge to earn stardust which can be sold on planets or you can go to your first planet\nPress 1 to do the challenge\nPress 2 to leave");
            int userInput = int.Parse(ReadLine());

            while (userInput != 1 && userInput != 2)
            {
                TypeWriter("\nThat was not an option try again\nPress 1 to do the challenge\nPress 2 to leave");
                userInput = Convert.ToInt32(ReadLine());
                Clear();
            }
            
            if (userInput == 1)
            {
                Clear();
                TypeWriter("John has a large box that contains 18 small boxes and each small box contains 25 chocolate bars. \n\nHow many chocolate bars are in the large box? ");
                int answerOne = int.Parse(ReadLine());

                while ( answerOne != 450)
                {
                    TypeWriter("\n\nWrong answer. Try again.");
                    answerOne = int.Parse(ReadLine());  
                }               
                Clear();
                TypeWriter("\nCongrats you got it right! only 2 more.\n\nPRESS ENTER TO GO TO THE NEXT QUESTION");
                ReadLine();
                Clear();

                TypeWriter("Kim can walk 4 kilometers in one hour. \n\nHow many hours does it take Kim to walk 16 kilometers? ");
                int answerTwo = int.Parse(ReadLine());

                while (answerTwo != 4)
                {
                    TypeWriter("\n\nWrong answer. Try again.");
                    answerTwo = int.Parse(ReadLine());   
                }
                Clear();
                player.ManageStarDust(100);
                TypeWriter($"Congrats you got it right! You have been given 100 stardust and now have {player.Stardust} stardust.\n\nPRESS ENTER TO GO TO THE NEXT PLANET");
                ReadLine();
                Clear();
            }
            else { Clear(); }
        }

        public void StarTwo(Player player)
        {
            TypeWriter("Welcome to your second star! \nYou can do a challenge to earn stardust which can be sold on planets or you can go to your second planet\nPress 1 to do the challenge\nPress 2 to leave");
            int userInput = int.Parse(ReadLine());

            while (userInput != 1 && userInput != 2)
            {
                TypeWriter("\nThat was not an option try again\nPress 1 to do the challenge\nPress 2 to leave");
                userInput = Convert.ToInt32(ReadLine());
                Clear();
            }

            if (userInput == 1)
            {
                Clear();
                TypeWriter("Linda bought 3 notebooks at $1.20 each; a box of pencils at $1.50 and a box of pens at $1.70. \n\nHow much did Linda spend?  $ ");
                double answerOne = double.Parse(ReadLine());

                while (answerOne != 6.80)
                {
                    TypeWriter("\n\nWrong answer. Try again.");
                    answerOne = int.Parse(ReadLine());
                }
                Clear();
                TypeWriter("\nCongrats you got it right! only 1 more.\n\nPRESS ENTER TO GO TO THE NEXT QUESTION");
                ReadLine();
                Clear();

                TypeWriter("Tom and Bob have a total of 49 toys. If Bob has 5 more toys than Tom. \n\nhow many toys does Bob have?  ");
                int answerTwo = int.Parse(ReadLine());

                while (answerTwo != 27)
                {
                    TypeWriter("\n\nWrong answer. Try again.");
                    answerTwo = int.Parse(ReadLine());
                }

               
                Clear();
                player.ManageStarDust(200);
                TypeWriter($"Congrats you got it right! You have been given 200 stardust and now have {player.Stardust} stardust.\n\nPRESS ENTER TO GO TO THE NEXT PLANET");
                ReadLine();
                Clear();
            }
            Clear();
        }

        public void StarThree(Player player)
        {
            TypeWriter("Welcome to your third star! \nYou can do a challenge to earn stardust which can be sold on planets or you can go to your second planet\nPress 1 to do the challenge\nPress 2 to leave");
            int userInput = int.Parse(ReadLine());

            while (userInput != 1 && userInput != 2)
            {
                TypeWriter("\nThat was not an option try again\nPress 1 to do the challenge\nPress 2 to leave");
                userInput = Convert.ToInt32(ReadLine());
                Clear();
            }

            if (userInput == 1)
            {
                Clear();
                TypeWriter("John can eat a quarter of a pizza in one minute. \n\nHow many minutes does it take John to eat one pizza and a half?   $ ");
                int answerOne = int.Parse(ReadLine());

                while (answerOne != 6)
                {
                    TypeWriter("\n\nWrong answer. Try again.");
                    answerOne = int.Parse(ReadLine());
                }
                Clear();
                TypeWriter("\nCongrats you got it right! only 1 more.\n\nPRESS ENTER TO GO TO THE NEXT QUESTION");
                ReadLine();
                Clear();

                TypeWriter("ohn read the quarter of the time that Tom read. Tom read only two-fifth of the time that Sasha read. Sasha read twice as long as Mike.\n\nIf Mike read 5 hours, how many hours did John read?  ");
                int answerTwo = int.Parse(ReadLine());

                while (answerTwo != 1)
                {
                    TypeWriter("\n\nWrong answer. Try again.");
                    answerTwo = int.Parse(ReadLine());
                }


                Clear();
                player.ManageStarDust(300);
                TypeWriter($"Congrats you got it right! You have been given 300 stardust and now have {player.Stardust} stardust.\n\nPRESS ENTER TO GO TO THE NEXT PLANET");
                ReadLine();
                Clear();
            }
            Clear();
        }

        public void StarFour(Player player)
        {
            TypeWriter("Welcome to your fourth star! \nYou can do a challenge to earn stardust which can be sold on planets or you can go to your second planet\nPress 1 to do the challenge\nPress 2 to leave");
            int userInput = int.Parse(ReadLine());

            while (userInput != 1 && userInput != 2)
            {
                TypeWriter("\nThat was not an option try again\nPress 1 to do the challenge\nPress 2 to leave");
                userInput = Convert.ToInt32(ReadLine());
                Clear();
            }

            if (userInput == 1)
            {
                Clear();
                TypeWriter("How many minutes are in one week?\nDo not use commas ");
                int answerOne = int.Parse(ReadLine());

                while (answerOne != 10080)
                {
                    TypeWriter("\n\nWrong answer. Try again.");
                    answerOne = int.Parse(ReadLine());
                }
                Clear();
                TypeWriter("\nCongrats you got it right! only 1 more.\n\nPRESS ENTER TO GO TO THE NEXT QUESTION");
                ReadLine();
                Clear();

                TypeWriter("A painter charges $ 225 for materials and $ 35 per hour for labour. The total cost of painting an office is $ 330.\n\nHow many hours did it take the painter to paint the office? ");
                int answerTwo = int.Parse(ReadLine());

                while (answerTwo != 3)
                {
                    TypeWriter("\n\nWrong answer. Try again.");
                    answerTwo = int.Parse(ReadLine());
                }


                Clear();
                player.ManageStarDust(400);
                TypeWriter($"Congrats you got it right! You have been given 400 stardust and now have {player.Stardust} stardust.\n\nPRESS ENTER TO GO TO THE NEXT PLANET");
                ReadLine();
                Clear();
            }
            Clear();
        }
    }
}
