
using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Game
{
    class SmallBoard : Box
    {
        public SmallBoard()
        {
            Depth = 0;
            Winner = "";
        }
        public override bool PlayMove(string player, string move)
        {
            if (Winner.Equals(""))
            {
                Winner = player;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string EvaluateWinner(IBoardEvaluateVisitor visitor)
        {
            return visitor.EvaluateWinner(this);
        }
        public override List<string> AllWinningBoards()
        {
            return new List<string>();
        }
        public override List<int> NumberofWins(List<int> listofwins, string player, int maxDepth)
        {
            return listofwins;
        }
    }
}
