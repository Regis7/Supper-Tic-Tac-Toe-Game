
using System;
using System.Collections.Generic;

namespace Tic_Tac_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                Console.WriteLine("Please enter a correct input, 1 list of moves is needed");
                Console.ReadKey();
                return;
            }
            else if (args.Length == 0)
            {
                Console.WriteLine("Please put input");
                Console.ReadKey();
                return;
            }
            //"NW.CC,NC.CC,NW.NW,NE.CC,NW.SE,CE.CC,CW.CC,SE.CC,CW.NW,CC.CC,CW.SE,CC.NW,CC.SE,CE.NW,SW.CC,CE.SE,SW.NW,SE.SE,SW.SE"

            InputProcessor inputProcessor = new InputProcessor();
            List<string> listofMoves = inputProcessor.ConvertString(args[0]);
            try
            {
                Play play = new Play(listofMoves);
                Console.WriteLine(play.GetLargeBoard());
                Console.WriteLine(play.GetSmallBoard());
                Console.WriteLine(play.GetNumberofWins());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.ReadKey();
                return;
            }

            Console.ReadKey();


        }
    }
}
