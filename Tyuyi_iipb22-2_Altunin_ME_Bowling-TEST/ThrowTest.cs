using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuyi_iipb22_2_Altunin_ME_Bowling;
using System;
using System.Net.Sockets;

namespace Tyuyi_iipb22_2_Altunin_ME_Bowling_TEST
{
    [TestClass]
    public class ThrowTest
    {
        [TestMethod]
        public void Throw_t()
        { 
            Throw att1 = new Throw(5);
            Assert.IsNotNull(att1);
            int score = att1.Score;
            Assert.AreEqual(5, score);


            Throw att2 = new Throw(4);
            Assert.IsNotNull(att2);
            int score2 = att2.Score;
            Assert.AreEqual(4, score2);
            
        }
    }
}

