using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Game
{
    abstract class Box : IBox
    {
        private int depth;
        private string winner;

        public List<string> listOfBoxes = new List<string>() { "NW", "NC", "NE", "CW", "CC", "CE", "SW", "SC", "SE" };

        protected int Depth { get => depth; set => depth = value; }
        public string Winner { get => winner; set => winner = value; }

        public int GetDepth()
        {
            return Depth;
        }
        public abstract bool PlayMove(string player, string move);
        private List<string> winedWithBoards;
        public void WinWithBoards(List<string> winedWithBoards)
        {
            this.winedWithBoards=winedWithBoards;
        }
        public abstract List<string> AllWinningBoards();
        public abstract string EvaluateWinner(IBoardEvaluateVisitor visitor);

        public List<string> WinWithBoards()
        {
            return winedWithBoards;
        }

        public string GetWinner()
        {
            return Winner;
        }
        public abstract List<int> NumberofWins(List<int> listofwins,string player,int  maxDepth);
    }
}

