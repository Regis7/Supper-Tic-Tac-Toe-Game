
using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Game
{
    interface IBoardEvaluateVisitor
    {
        string EvaluateWinner(LargeBoard largeBoard);
        string EvaluateWinner(SmallBoard smallBoard);
    }
}
