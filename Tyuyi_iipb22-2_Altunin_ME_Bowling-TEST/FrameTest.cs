using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Tyuyi_iipb22_2_Altunin_ME_Bowling;

namespace Tyuyi_iipb22_2_Altunin_ME_Bowling_TEST
{

    [TestClass]
    public class FrameTest
    {      
        [TestMethod]
        public void FrameTest1()
        {
            Throw att1 = new Throw(5);
            Throw att2 = new Throw(3);
            Frame fr = new Frame(att1, att2);
            //Assert.AreEqual(4, score2);
        }
    }
}
