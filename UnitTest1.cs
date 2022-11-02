
using Tic_Tac_Game;
using System;
using System.Collections.Generic;
using Xunit;

namespace Tic_Tac_Game
{
    public class UnitTest1
    {
        [Fact]
        public void MyTest()
        {

            InputProcessor inputProcessor = new InputProcessor();
            List<string> listofMoves = inputProcessor.ConvertString("NW.CC , NC.CC ,NW.NW , NE.CC ,NW.SE , CE.CC ,CW.CC , SE.CC ,CW.NW , CC.CC ,CW.SE , CC.NW ,CC.SE , CE.NW ,SW.CC , CE.SE ,SW.NW , SE.SE ,SW.SE");

            Play paly = new Play(listofMoves);

            Assert.Equal("NW, CW, SW", paly.GetLargeBoard());
            Assert.Equal("NW.CC, NW.NW, NW.SE, CW.CC, CW.NW, CW.SE, SW.CC, SW.NW, SW.SE",paly.GetSmallBoard());
            Assert.Equal("1.3, 0.1",paly.GetNumberofWins());
        }
    }
}
