using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuyi_iipb22_2_Altunin_ME_Bowling;
using System;

namespace Tyuyi_iipb22_2_Altunin_ME_Bowling_TESTs
{
    [TestClass]
    public class TrowTest
    {
        [TestMethod]
        public void Throw_t()
        {
            
            Throw attempt = new Throw(5);
            Assert.IsNotNull(attempt);
            int score = attempt.Score;
            Assert.AreEqual(5, score);

        }
    }
}
