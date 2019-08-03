using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static ClassLibrary.HelperMethods;

namespace ClassLibrary
{
    public class Challenges
    {
        public void PlanetOneChallenge(Player player, Challenges challenges)
        {
            TypeWriter("Here is your first challenge!\nC# basics are important when learning how to become a great developer!\nEveryone has to start somewhere, lets see where you are.\n");
            TypeWriter("Problem one!\nWe can start small to warm you up!\nVariable declaration, say you have 4 variables a, b, x, and y. \nHow would you declare these in alphabetic order?");
            string userInput = (Console.ReadLine());

            while (userInput != "int a, b, x, y;")
            {
                TypeWriter("try again buddy...");
                userInput = (Console.ReadLine());
            }

            TypeWriter("Awesome, next question!");
            

            TypeWriter("Problem two\nAssign the letter b to either a value of 3 or set it to 7, but not both!");
            userInput = (Console.ReadLine());
            while (userInput != "b=3;" && userInput != "b=7;" && userInput != "int b=3;" && userInput != "int b=7;")
            {
                TypeWriter("try again buddy...You're over thinking this\nLiterally set b to either 3 or 7");
                userInput = (Console.ReadLine());
            }
           
                TypeWriter("Awesome, you survived your first round of planet challenges");

                player.ManageStarDust(125);

            TypeWriter($"Look at you!\nYou have ${player.BankAccount} in your account");
            TypeWriter("Press enter to continue");
            Console.Clear();
        }

        public void PlanetTwoChallenge(Player player, Challenges challenges)
        {
            string PlanetTwoAnswer = "int[] numbers = new int[5];";

            TypeWriter("Welcome to your second challenge!");
            TypeWriter("Declare an array!\n7, 2, 12, 4, 3\nCall the array numbers above and use the data type integer!\nShow me what you got Earthling!");
            string userInput = (Console.ReadLine());

            while (userInput != PlanetTwoAnswer || userInput != PlanetTwoAnswer)
            {
                TypeWriter("Nope, think about it... check spelling... think\nThink about the syntax for DECLARING something!");
                userInput = (Console.ReadLine());
            }
            //if (userInput = "int[] numbers=new int[5]" || userInput = PlanetTwoAnswer)
            //{
            //    TypeWriter("Awesome, you survived your first round of planet challenges");
            //    player.ManageStarDust(125);
            //}
            TypeWriter($"Look at you!\nYou have ${player.BankAccount} in your account");
            TypeWriter("Press enter to continue");
            Console.Clear();

        }

        public void PlanetThreeChallenge(Player player, Challenges challenges)
        {
            string PlanetThreeAnswer = "empid, custid, SUM(qty) AS sumqty";

            TypeWriter("Welcome to your third challenge!");
            TypeWriter("It's time to get down with some SQL");
            TypeWriter("Press ENTER to display the challenge questions\n\n");
            Console.Title = "ASCII Art";
                string title = @"


                    USE TSQLV$;

                    DROP TABLE IF EXISTS dbo.Orders;
                    

                    CREATE TABLE dbo.Orders
                    (
                        orderid       INT         NOT NULL,
                        orderdate     DATE        NOT NULL,
                        empid         INT         NOT NULL,
                        custid        VARCHAR(5)  NOT NULL,
                        qty           INT         NOT NULL,
                        CONSTRAINT PK_Orders PRIMARY KEY(orderid)
                    );

                    INSERT INTO dbo.Orders(orderid, orderdate, empid, custid, qty)
                    VALUES
                        (30001, '20140802', 3, 'A', 10),
                        (10001, '20141224', 2, 'A', 12),
                        (10005, '20141224', 1, 'B', 20),
                        (40001, '20150109', 2, 'A', 40),
                        (10006, '20150118', 1, 'C', 14),
                        (20001, '20160212', 2, 'B', 12),
                        (40005, '20160212', 3, 'A', 10),
                        (20002, '20160216', 1, 'C', 20),
                        (30003, '20160418', 2, 'B', 15),
                        (30004, '20160418', 3, 'C', 22),
                        (30007, '20160907', 3, 'D', 30);

                      SELECT * FROM dbo.Orders;

        Press Enter to display the next screen.
";
            Console.WriteLine(title);
            Console.Read();
            Console.Title = "ASCII Art";
            string titleOne = @"

                    orderid        orderdate    empid         custid      qty
                  --------------- ------------ ------------- ----------- ---------
                  10001            2014-12-24  2             A           12
                  10005            2014-12-24  1             B           20
                  10006            2015-01-18  1             C           14
                  20001            2015-02-12  2             B           12
                  20002            2016-02-16  1             C           20
                  30001            2014-08-02  3             A           10
                  30003            2016-04-18  2             B           15
                  30004            2014-04-18  3             C           22
                  30007            2016-09-07  3             D           30
                  40001            2015-01-09  2             A           40
                  40005            2016-02-12  3             A           10




                With the information provided in the two tables above, fill in the SELECT
                statement to generate the query below:


                    SELECT _______________________
                    FROM dbo.Order
                    GROUP BY empid, custid;


                   empid       custid         sumqty        
                  --------    ---------      ----------
                  2            A              52     
                  3            A              20  
                  1            B              20   
                  2            B              27  
                  1            C              34   
                  3            C              22 
                  3            D              30

";


            Console.WriteLine(titleOne);
            Console.Read();
            
            string userInput = (Console.ReadLine());

            while (userInput != PlanetThreeAnswer)
            {
                TypeWriter("Nope, think about it!");
                userInput = (Console.ReadLine());
            }
         

            TypeWriter($"Look at you!\nYou have ${player.BankAccount} in your account");
            TypeWriter("Press enter to continue");
            Console.Clear();
        }

        public void PlanetFourChallenge(Player player, Challenges challenges)
        {
            string PlanetFourAnswer = "empid, custid, SUM(qty) AS sumqty";

            TypeWriter("Welcome to your third challenge!");
            TypeWriter("It's time to get down with some SQL");
            TypeWriter("Press ENTER to display the challenge questions\n\n");
            Console.Title = "ASCII Art";
            string title = @"


                    USE TSQLV$;

                    DROP TABLE IF EXISTS dbo.Orders;
                    

                    CREATE TABLE dbo.Orders
                    (
                        orderid       INT         NOT NULL,
                        orderdate     DATE        NOT NULL,
                        empid         INT         NOT NULL,
                        custid        VARCHAR(5)  NOT NULL,
                        qty           INT         NOT NULL,
                        CONSTRAINT PK_Orders PRIMARY KEY(orderid)
                    );

                    INSERT INTO dbo.Orders(orderid, orderdate, empid, custid, qty)
                    VALUES
                        (30001, '20140802', 3, 'A', 10),
                        (10001, '20141224', 2, 'A', 12),
                        (10005, '20141224', 1, 'B', 20),
                        (40001, '20150109', 2, 'A', 40),
                        (10006, '20150118', 1, 'C', 14),
                        (20001, '20160212', 2, 'B', 12),
                        (40005, '20160212', 3, 'A', 10),
                        (20002, '20160216', 1, 'C', 20),
                        (30003, '20160418', 2, 'B', 15),
                        (30004, '20160418', 3, 'C', 22),
                        (30007, '20160907', 3, 'D', 30);

                      SELECT * FROM dbo.Orders;
";
            Console.WriteLine(title);
            Console.Read();

            Console.WriteLine("The query you just created produces the following output: (Press enter to display the output) ");
            Console.Title = "ASCII Art";
            string titleOne = @"

                    orderid        orderdate    empid         custid      qty
                  --------------- ------------ ------------- ----------- ---------
                  10001            2014-12-24  2             A           12
                  10005            2014-12-24  1             B           20
                  10006            2015-01-18  1             C           14
                  20001            2015-02-12  2             B           12
                  20002            2016-02-16  1             C           20
                  30001            2014-08-02  3             A           10
                  30003            2016-04-18  2             B           15
                  30004            2014-04-18  3             C           22
                  30007            2016-09-07  3             D           30
                  40001            2015-01-09  2             A           40
                  40005            2016-02-12  3             A           10




                With the information provided in the two tables above, fill in the SELECT
                statement to generate the query below:


                    SELECT _______________________
                    FROM dbo.Order
                    GROUP BY empid, custid;


                   empid       custid         sumqty        
                  --------    ---------      ----------
                  2            A              52     
                  3            A              20  
                  1            B              20   
                  2            B              27  
                  1            C              34   
                  3            C              22 
                  3            D              30

";


            Console.WriteLine(titleOne);
            Console.Read();

            string userInput = (Console.ReadLine());

            while (userInput != PlanetFourAnswer)
            {
                TypeWriter("Nope, think about it!");
                userInput = (Console.ReadLine());
            }


            TypeWriter($"Look at you!\nYou have ${player.BankAccount} in your account");
            TypeWriter("Press enter to continue");
            Console.Clear();
        }


    }
}

