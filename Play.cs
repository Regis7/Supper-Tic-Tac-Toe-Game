
using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Game
{
    public class Play
    {
        private IBox board;
        private string[] players = new string[2] { "x", "o" };
        private List<string> X_playerMoves = new List<string>();
        private List<string> O_playerMoves = new List<string>();

        public Play(List<string> listofMoves)
        {
            int depth = GetDepth(listofMoves);
            board = new LargeBoard(depth);

            PlayMoves(listofMoves);

            board.EvaluateWinner(new BoardEvaluateVisitor());
        }
        private int GetDepth(List<string> listofMoves)
        {
            string[] firstmove = listofMoves[0].Split(".");
            int depth = firstmove.Length;
            return depth;
        }
        private void PlayMoves(List<string> listofMoves)
        {
            InputProcessor inputProcessor = new InputProcessor();

            string player = players[0];
            for   (int i = 0; i < listofMoves.Count; i++)
                {
                if (!inputProcessor.CheckMove(listofMoves[i], GetDepth(listofMoves)))
                {
                throw new Exception ("Wrong depth on a move");
                }

                bool result = board.PlayMove(player, listofMoves[i]);
                if (result)
                {
                    if (player == players[0])
                    {
                        player = players[1];
                        X_playerMoves.Add(listofMoves[i]);
                    }
                    else
                    {
                        player = players[0];

                        O_playerMoves.Add(listofMoves[i]);
                    }
                }
                }
        }
        public string GetLargeBoard()
        {
            string winner = board.GetWinner();
            List<string> moves;

            if (winner == players[0])
            {
                moves = X_playerMoves;
            }
            else
            {
                moves = O_playerMoves;
            }

            List<string> winningBoards = board.WinWithBoards();
            string winning = "";

            for (int i = 0; i < moves.Count; i++)
            {
                string largeMove = moves[i].Substring(0, 2);
                if (winningBoards.Contains(largeMove))
                {
                    if (!winning.Contains(largeMove))

                    {
                        if (winning == "")
                        {
                            winning = largeMove;
                        }
                        else
                        {
                            winning = winning + ", " + largeMove;
                        }
                    }
                }
            }
            return winning;
        }

        public string GetSmallBoard()
        {
            List<string> allBoards = board.AllWinningBoards();
            string winner = board.GetWinner();

            List<string> moves;

            if (winner == players[0])
            {
                moves = X_playerMoves;
            }
            else
            {
                moves = O_playerMoves;
            }

            string winning = "";

            for (int i = 0; i < moves.Count; i++)
            {
                string smallMove = moves[i];
                if (allBoards.Contains(smallMove))
                {
                    if (!winning.Contains(smallMove))

                    {
                        if (winning == "")
                        {
                            winning = smallMove;
                        }
                        else
                        {
                            winning = winning + ", " + smallMove;
                        }
                    }
                }
            }
            return winning;
        }
        public string GetNumberofWins()
        {
            List<int> listofWinsX = new List<int>();
            List<int> listofWinsO = new List<int>();
            for (int i=0;i<board.GetDepth(); i++)
            {
                listofWinsX.Add(0);
                listofWinsO.Add(0);
            }

            listofWinsX = board.NumberofWins(listofWinsX, players[0], board.GetDepth());
            listofWinsO = board.NumberofWins(listofWinsO, players[1], board.GetDepth());

            string  allwins = "";
            for (int i = 0; i < board.GetDepth(); i++)
            {
                if (i < board.GetDepth() - 1)
                {
                    allwins = allwins+listofWinsX[i] + ".";
                }
                else
                {
                    allwins = allwins+listofWinsX[i]+"";
                }
            }

            allwins = allwins + ", ";
            for (int i = 0; i < board.GetDepth(); i++)
            {
                if (i < board.GetDepth() - 1)
                {
                    allwins = allwins+listofWinsO[i] + ".";
                }
                else
                {
                    allwins = allwins+listofWinsO[i]+"";
                }
            }
            return allwins;
        }

    }
}
