using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Game
{
   public  class InputProcessor
    {
        public List<string> ConvertString (string moves)
        {
            string[] listMoves = moves.Split(",");

            for (int i =0; i < listMoves.Length; i++)
            {
                listMoves[i] = listMoves[i].Trim();
            }
            return new List<string>(listMoves);
        }
        public bool CheckMove(string move , int depth)
        {
            string[] listMoves = move.Split(".");
            if (listMoves.Length == depth)
            { 
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
