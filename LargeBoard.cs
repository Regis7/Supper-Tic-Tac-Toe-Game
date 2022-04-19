using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Game
{
    class LargeBoard : Box
    {
        private IBox NW; private IBox NC; private IBox NE; private IBox CW; private IBox CC; private IBox CE;
        private IBox SW; private IBox SC; private IBox SE;

        public IBox GetNW { get => NW; }
        public IBox GetNC { get => NC; }
        public IBox GetNE { get => NE; }
        public IBox GetCW { get => CW; }
        public IBox GetCC { get => CC; }
        public IBox GetCE { get => CE; }
        public IBox GetSW { get => SW; }
        public IBox GetSC { get => SC; }
        public IBox GetSE { get => SE; }

        public LargeBoard(int depth)
        {
            this.Depth = depth;
            BoardProcessor boardProcessor = new BoardProcessor();


            NW = boardProcessor.CreateBoard(depth - 1);
            NC = boardProcessor.CreateBoard(depth - 1);
            NE = boardProcessor.CreateBoard(depth - 1);
            CW = boardProcessor.CreateBoard(depth - 1);
            CC = boardProcessor.CreateBoard(depth - 1);
            CE = boardProcessor.CreateBoard(depth - 1);
            SW = boardProcessor.CreateBoard(depth - 1);
            SC = boardProcessor.CreateBoard(depth - 1);
            SE = boardProcessor.CreateBoard(depth - 1);

        }
        public override bool PlayMove(string player, string move)
        {
            string[] moveBoxes = move.Split(".");

            int index =  listOfBoxes.IndexOf (moveBoxes[0].Trim());

        if (index > -1)
            {
                string innerMove = "";
                for (int i = 1; i < moveBoxes.Length; i++)
                {
                    if (i == 1)
                    {
                        innerMove = moveBoxes[i];
                    }   
                    else
                    { 
                    innerMove = innerMove + "." + moveBoxes[i];
                    }
                }
                bool result = SetBox(player , innerMove, moveBoxes[0].Trim());
                return result ;
            }
        else
            {
                throw new Exception ("invalid Box value, please do a valid move");
            }
        }
        private bool SetBox(string player,string innerMove, string moveBox)
        {
            bool result = false;
            if (moveBox == "NW")
            {
                result = NW.PlayMove(player, innerMove);
            }
            if (moveBox == "NC")
            {
                result = NC.PlayMove(player, innerMove);
            }
            if (moveBox == "NE")
            {
                result = NE.PlayMove(player, innerMove);
            }
            if (moveBox == "CW")
            {
                result = CW.PlayMove(player, innerMove);
            }
            if (moveBox == "CC")
            {
                result = CC.PlayMove(player, innerMove);
            }
            if (moveBox == "CE")
            {
                result = CE.PlayMove(player, innerMove);
            }
            if (moveBox == "SW")
            {
                result = SW.PlayMove(player, innerMove);
            }
            if (moveBox == "SC")
            {
                result = SC.PlayMove(player, innerMove);
            }
            if (moveBox == "SE")
            {
                result = SE.PlayMove(player, innerMove);
            }
            return result;
        }
        
        public override string EvaluateWinner(IBoardEvaluateVisitor visitor)
        {
            return visitor.EvaluateWinner(this);
        }
        public override List<string> AllWinningBoards()
        {
            List<string> allWinBoards= new List<string>();

            List<string> winningBoards= WinWithBoards();

            for (int i=0 ; i<winningBoards.Count; i++)
            {
                if(winningBoards[i]=="NW")
                {
                    List<string> nwBoxes = NW.AllWinningBoards();
                    if ( nwBoxes.Count == 0)
                    {
                        allWinBoards.Add("NW");
                    }
                    else
                    {
                        for(int n=0; n<nwBoxes.Count;n++)
                        {
                            allWinBoards.Add("NW."+nwBoxes[n]);
                        }
                    }
                }

                else if (winningBoards[i] == "NC")
                {

                    List<string> ncBoxes = NC.AllWinningBoards();
                    if ( ncBoxes.Count == 0)
                    {
                        allWinBoards.Add("NC");
                    }
                    else
                    {
                        for(int n=0; n<ncBoxes.Count;n++)
                        {
                            allWinBoards.Add("NC."+ncBoxes[n]);
                        }
                    }
                }

                else if (winningBoards[i] == "NE")
                {

                    List<string> neBoxes = NE.AllWinningBoards();
                    if (neBoxes.Count == 0)
                    {
                        allWinBoards.Add("NE");
                    }
                    else
                    {
                        for (int n = 0; n < neBoxes.Count; n++)
                        {
                            allWinBoards.Add("NE." + neBoxes[n]);
                        }
                    }
                }

                else if (winningBoards[i] == "CW")
                {

                    List<string> cwBoxes = CW.AllWinningBoards();
                    if (cwBoxes.Count == 0)
                    {
                        allWinBoards.Add("CW");
                    }
                    else
                    {
                        for (int n = 0; n < cwBoxes.Count; n++)
                        {
                            allWinBoards.Add("CW." + cwBoxes[n]);
                        }
                    }
                }

                else if (winningBoards[i] == "CC")
                {

                    List<string> ccBoxes = CC.AllWinningBoards();
                    if (ccBoxes.Count == 0)
                    {
                        allWinBoards.Add("CC");
                    }
                    else
                    {
                        for (int n = 0; n < ccBoxes.Count; n++)
                        {
                            allWinBoards.Add("CC." + ccBoxes[n]);
                        }
                    }
                }

                else if (winningBoards[i] == "CE")
                {

                    List<string> ceBoxes = CE.AllWinningBoards();
                    if (ceBoxes.Count == 0)
                    {
                        allWinBoards.Add("CE");
                    }
                    else
                    {
                        for (int n = 0; n < ceBoxes.Count; n++)
                        {
                            allWinBoards.Add("CE." + ceBoxes[n]);
                        }
                    }
                }

                else if (winningBoards[i] == "SW")
                {

                    List<string> swBoxes = SW.AllWinningBoards();
                    if (swBoxes.Count == 0)
                    {
                        allWinBoards.Add("SW");
                    }
                    else
                    {
                        for (int n = 0; n < swBoxes.Count; n++)
                        {
                            allWinBoards.Add("SW." + swBoxes[n]);
                        }
                    }
                }

                else if (winningBoards[i] == "SC")
                {

                    List<string> scBoxes = SC.AllWinningBoards();
                    if (scBoxes.Count == 0)
                    {
                        allWinBoards.Add("SC");
                    }
                    else
                    {
                        for (int n = 0; n < scBoxes.Count; n++)
                        {
                            allWinBoards.Add("SC." + scBoxes[n]);
                        }
                    }
                }

                else if (winningBoards[i] == "SE")
                {

                    List<string> seBoxes = SE.AllWinningBoards();
                    if (seBoxes.Count == 0)
                    {
                        allWinBoards.Add("SE");
                    }
                    else
                    {
                        for (int n = 0; n < seBoxes.Count; n++)
                        {
                            allWinBoards.Add("SE." + seBoxes[n]);
                        }
                    }
                }
            }
            return allWinBoards;
        }
        public override List<int> NumberofWins(List<int> listofwins,string player,int  maxDepth)
        {
            if (player == GetWinner())
            {
                listofwins[maxDepth-Depth]++;
            }

            listofwins=  NW.NumberofWins(listofwins, player,maxDepth);
            listofwins = NC.NumberofWins(listofwins, player,maxDepth);
            listofwins = NE.NumberofWins(listofwins, player,maxDepth);
            listofwins = CW.NumberofWins(listofwins, player,maxDepth);
            listofwins = CC.NumberofWins(listofwins, player,maxDepth);
            listofwins = CE.NumberofWins(listofwins, player,maxDepth);
            listofwins = SW.NumberofWins(listofwins, player,maxDepth);
            listofwins = SC.NumberofWins(listofwins, player,maxDepth);
            listofwins = SE.NumberofWins(listofwins, player,maxDepth);

            return listofwins;
        }
    }
}
