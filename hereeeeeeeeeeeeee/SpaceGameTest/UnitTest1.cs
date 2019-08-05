using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace SpaceGameTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Player player = new Player();
            //Player player = new Player();
            //player.ManageBankAccount(-1300);
            //Assert.AreEqual(200, player.BankAccount);

            Stars stars = new Stars();
            stars.StarOne(player);

        }
    }
}
