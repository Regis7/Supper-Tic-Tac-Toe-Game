using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Game
{
    interface IBox
    {
        int GetDepth();
        bool PlayMove(string player, string move );

        string EvaluateWinner(IBoardEvaluateVisitor visitor);
        string GetWinner();

    List<string> WinWithBoards();
    List<string> AllWinningBoards();
    List<int> NumberofWins(List<int> listofwins,string player,int  maxDepth);
    }
}
