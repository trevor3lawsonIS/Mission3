using System;
using System.Collections.Generic;
using System.Text;

namespace Mission3
{
    class SupportingClass
    {
        public void PrintBoard(char[] board)
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
            Console.WriteLine("   |   |   ");
        }

        public int PrintWinner(char[] board)
        {
            int outcome = 0;
            //horizontal wins
            if (board[0] == board[1] && board[1] == board[2])
            {
                if (board[0] == 'X')
                {
                    outcome = 1;
                    return outcome;
                }
                if (board[0] == 'O')
                {
                    outcome = 2;
                    return outcome;
                }
            }

            if (board[3] == board[4] && board[4] == board[5])
            {
                if (board[0] == 'X')
                {
                    outcome = 1;
                    return outcome;
                }
                if (board[0] == 'O')
                {
                    outcome = 2;
                    return outcome;
                }
            }

            if (board[6] == board[7] && board[7] == board[8])
            {
                if (board[0] == 'X')
                {
                    outcome = 1;
                    return outcome;
                }
                if (board[0] == 'O')
                {
                    outcome = 2;
                    return outcome;
                }
            }

            //vertical wins
            if (board[0] == board[3] && board[3] == board[6])
            {
                if (board[0] == 'X')
                {
                    outcome = 1;
                    return outcome;
                }
                if (board[0] == 'O')
                {
                    outcome = 2;
                    return outcome;
                }
            }

            if (board[1] == board[4] && board[4] == board[7])
            {
                if (board[0] == 'X')
                {
                    outcome = 1;
                    return outcome;
                }
                if (board[0] == 'O')
                {
                    outcome = 2;
                    return outcome;
                }
            }

            if (board[2] == board[5] && board[5] == board[8])
            {
                if (board[0] == 'X')
                {
                    outcome = 1;
                    return outcome;
                }
                if (board[0] == 'O')
                {
                    outcome = 2;
                    return outcome;
                }
            }

            //diagonal wins
            if (board[0] == board[4] && board[4] == board[8])
            {
                if (board[0] == 'X')
                {
                    outcome = 1;
                    return outcome;
                }
                if (board[0] == 'O')
                {
                    outcome = 2;
                    return outcome;
                }
            }

            if (board[2] == board[4] && board[4] == board[6])
            {
                if (board[0] == 'X')
                {
                    outcome = 1;
                    return outcome;
                }
                if (board[0] == 'O')
                {
                    outcome = 2;
                    return outcome;
                }
            }

            if (outcome != 1 || outcome != 2)
            {
                int count = 0;
                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == 'X' || board[i] == 'O')
                    {
                        count++;

                    }
                }
                if (count == 9)
                {
                    outcome = 3;
                    return outcome;
                }
            }

            return outcome;
            
        }

        // return 0 1 2 
    }
}
