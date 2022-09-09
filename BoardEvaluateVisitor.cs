using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Game
{
    class BoardEvaluateVisitor : IBoardEvaluateVisitor
    {
        public string EvaluateWinner(LargeBoard largeBoard)
        {
            IBoardEvaluateVisitor visitor = new BoardEvaluateVisitor();
            string winner = "";

            largeBoard.GetNW.EvaluateWinner(visitor);
            largeBoard.GetNC.EvaluateWinner(visitor);
            largeBoard.GetNE.EvaluateWinner(visitor);
            largeBoard.GetCW.EvaluateWinner(visitor);
            largeBoard.GetCC.EvaluateWinner(visitor);
            largeBoard.GetCE.EvaluateWinner(visitor);
            largeBoard.GetSW.EvaluateWinner(visitor);
            largeBoard.GetSC.EvaluateWinner(visitor);
            largeBoard.GetSE.EvaluateWinner(visitor);

            if (largeBoard.GetNW.EvaluateWinner(visitor) != "" && largeBoard.GetNW.EvaluateWinner(visitor) == largeBoard.GetNC.EvaluateWinner(visitor) && largeBoard.GetNW.EvaluateWinner(visitor) == largeBoard.GetNE.EvaluateWinner(visitor))
            {
                winner = largeBoard.GetNW.EvaluateWinner(visitor);
                List<string> WinWithBoards = new List<string>();
                WinWithBoards.Add("NW");
                WinWithBoards.Add("NC");
                WinWithBoards.Add("NE");

            largeBoard.WinWithBoards(WinWithBoards);
            }

            else if (largeBoard.GetCW.EvaluateWinner(visitor) != "" && largeBoard.GetCW.EvaluateWinner(visitor) == largeBoard.GetCC.EvaluateWinner(visitor) && largeBoard.GetCW.EvaluateWinner(visitor) == largeBoard.GetCE.EvaluateWinner(visitor))
            {
                winner = largeBoard.GetCW.EvaluateWinner(visitor);
                List<string> WinWithBoards = new List<string>();
                WinWithBoards.Add("CW");
                WinWithBoards.Add("CC");
                WinWithBoards.Add("CE");

                largeBoard.WinWithBoards(WinWithBoards);
            }

            else if (largeBoard.GetSW.EvaluateWinner(visitor) != "" && largeBoard.GetSW.EvaluateWinner(visitor) == largeBoard.GetSC.EvaluateWinner(visitor) && largeBoard.GetSW.EvaluateWinner(visitor) == largeBoard.GetSE.EvaluateWinner(visitor))
            {
                winner = largeBoard.GetSW.EvaluateWinner(visitor);
                List<string> WinWithBoards = new List<string>();
                WinWithBoards.Add("SW");
                WinWithBoards.Add("SC");
                WinWithBoards.Add("SE");

                largeBoard.WinWithBoards(WinWithBoards);
            }
            else if (largeBoard.GetNW.EvaluateWinner(visitor) != "" && largeBoard.GetNW.EvaluateWinner(visitor) == largeBoard.GetCW.EvaluateWinner(visitor) && largeBoard.GetNW.EvaluateWinner(visitor) == largeBoard.GetSW.EvaluateWinner(visitor))
            {
                winner = largeBoard.GetNW.EvaluateWinner(visitor);
                List<string> WinWithBoards = new List<string>();
                WinWithBoards.Add("NW");
                WinWithBoards.Add("CW");
                WinWithBoards.Add("SW");

                largeBoard.WinWithBoards(WinWithBoards);
            }

            else if (largeBoard.GetNC.EvaluateWinner(visitor) != "" && largeBoard.GetNC.EvaluateWinner(visitor) == largeBoard.GetCC.EvaluateWinner(visitor) && largeBoard.GetNC.EvaluateWinner(visitor) == largeBoard.GetSC.EvaluateWinner(visitor))
            {
                winner = largeBoard.GetNC.EvaluateWinner(visitor);
                List<string> WinWithBoards = new List<string>();
                WinWithBoards.Add("NC");
                WinWithBoards.Add("CC");
                WinWithBoards.Add("SC");

                largeBoard.WinWithBoards(WinWithBoards);
            }

            else if (largeBoard.GetNE.EvaluateWinner(visitor) != "" && largeBoard.GetNE.EvaluateWinner(visitor) == largeBoard.GetCE.EvaluateWinner(visitor) && largeBoard.GetNE.EvaluateWinner(visitor) == largeBoard.GetSE.EvaluateWinner(visitor))
            {
                winner = largeBoard.GetNE.EvaluateWinner(visitor);
                List<string> WinWithBoards = new List<string>();
                WinWithBoards.Add("NE");
                WinWithBoards.Add("CE");
                WinWithBoards.Add("SE");

                largeBoard.WinWithBoards(WinWithBoards);
            }

            else if (largeBoard.GetNW.EvaluateWinner(visitor) != "" && largeBoard.GetNW.EvaluateWinner(visitor) == largeBoard.GetCC.EvaluateWinner(visitor) && largeBoard.GetNW.EvaluateWinner(visitor) == largeBoard.GetSE.EvaluateWinner(visitor))
            {
                winner = largeBoard.GetNW.EvaluateWinner(visitor);
                List<string> WinWithBoards = new List<string>();
                WinWithBoards.Add("NW");
                WinWithBoards.Add("CC");
                WinWithBoards.Add("SE");

                largeBoard.WinWithBoards(WinWithBoards);
            }

            else if (largeBoard.GetNE.EvaluateWinner(visitor) != "" && largeBoard.GetNE.EvaluateWinner(visitor) == largeBoard.GetCC.EvaluateWinner(visitor) && largeBoard.GetNE.EvaluateWinner(visitor) == largeBoard.GetSW.EvaluateWinner(visitor))
            {
                winner = largeBoard.GetNE.EvaluateWinner(visitor);
                List<string> WinWithBoards = new List<string>();
                WinWithBoards.Add("NE");
                WinWithBoards.Add("CC");
                WinWithBoards.Add("SW");

                largeBoard.WinWithBoards(WinWithBoards);
            }

            if (winner != "")
            {
                largeBoard.Winner = winner;
            }
            return winner;
        }
        public string EvaluateWinner(SmallBoard smallBoard)
        {
            return smallBoard.Winner;
        }
    }
}

