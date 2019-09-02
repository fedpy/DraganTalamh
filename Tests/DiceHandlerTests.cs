using Microsoft.VisualStudio.TestTools.UnitTesting;
using DraganTalamh.Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraganTalamh.Extras.Tests
{
    [TestClass()]
    public class DiceHandlerTests
    {
        [TestMethod()]
        public void DiceFourTest()
        {
            for (int i = 0; i < 100000; i++)
            {
                int testNumber = DiceHandler.DiceFour();
                if (testNumber <= 0 || testNumber > 4)
                {
                    Assert.Fail();
                }
            }
        }
    }
}
