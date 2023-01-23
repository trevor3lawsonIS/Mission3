using System;

namespace Mission3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] boardArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            SupportingClass sc = new SupportingClass(); // CHECK THIS 

            Console.WriteLine(
                "Welcome to Tic-Tac-Toe!" + '\n' +
                "Player 1 will be 'X'" + '\n' +
                "Player 2 will be 'O'" + '\n' + '\n'
                );

            sc.PrintBoard(boardArray); // Here is where we will use the print class CHECK WHERE TO PASS PARAMETERS

            // Collect player choices
            int winner = sc.PrintWinner(boardArray);
            while (winner == 0)
            {
                // Player 1 Choice
                Console.WriteLine("Player 1, enter your choice:");
                int iPlayer1Choice = int.Parse(Console.ReadLine());
                char player1Choice = Convert.ToChar(iPlayer1Choice);

                // check to see if space is taken
                while (boardArray[player1Choice] == 'X' || boardArray[player1Choice] == 'O')
                {
                    Console.WriteLine("Sorry, space " + boardArray[player1Choice] + " is already taken. Please choose another space.");
                    iPlayer1Choice = int.Parse(Console.ReadLine());
                    player1Choice = Convert.ToChar(iPlayer1Choice);
                }
                boardArray[player1Choice] = 'X';

                // Test for winner
                winner = sc.PrintWinner(boardArray);
                if (winner != 0)
                {
                    break;
                }

                // Player two choice
                sc.PrintBoard(boardArray);
                Console.WriteLine("Player 2, enter your choice");
                int iPlayer2Choice = int.Parse(Console.ReadLine());
                char player2Choice = Convert.ToChar(iPlayer2Choice);

                // check to see if space is taken
                while (boardArray[player2Choice] == 'X' || boardArray[player2Choice] == 'O')
                {
                    Console.WriteLine("Sorry, space " + boardArray[player2Choice] + " is already taken. Please choose another space.");
                    iPlayer2Choice = int.Parse(Console.ReadLine());
                    player2Choice = Convert.ToChar(iPlayer2Choice);
                }
                boardArray[player2Choice] = 'O';

                // Test for winner
                winner = sc.PrintWinner(boardArray);
            }

            // Final print of results
            sc.PrintBoard(boardArray);
            if (winner == 1)
            {
                Console.WriteLine("Player 1 wins!!!");
            } else if (winner == 2)
            {
                Console.WriteLine("Player 2 wins!!!");
            } else
            {
                Console.WriteLine("Tie Game :(");
            }

        }
    }
}
