using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Game
{
    class BoardProcessor
    {
        public IBox CreateBoard (int depth)
        {
          if (depth==0)
            { 
              return new SmallBoard();
            }
          else
            {
                return new LargeBoard(depth); 
            }
        }

    }
}
