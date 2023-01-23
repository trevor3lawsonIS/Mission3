using System;

namespace Mission3
{
    public class Program
    {
        static void Main(string[] args)
        {

            char[] board = { 'O', 'O', 'X', 'X', 'O', 'O', 'O', 'X', 'X' };
            SupportingClass pb = new SupportingClass();
            pb.PrintBoard(board);
            int thing = pb.PrintWinner(board);
            Console.WriteLine(thing);
        }
    }
}
