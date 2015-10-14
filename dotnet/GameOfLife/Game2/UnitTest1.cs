using System;
using GameOfLife;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Game2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CellisAlive()
        {
            Cell cell = new Cell(true);
            Assert.AreEqual(true, cell.IsAlive);
        }

        [TestMethod]
        public void CellisDead()
        {
            Cell cell = new Cell(false);
            Assert.AreEqual(true, cell.isDead);
        }

        [TestMethod]
        public void WorldInstanceExists()
        {
            DaWorld aliveWorld = new DaWorld(4);
            Assert.AreEqual(false, aliveWorld.Barren);
        }

        [TestMethod]
        public void WorldIsBarren()
        {
            DaWorld deadWorld = new DaWorld(1);
            Assert.AreEqual(true, deadWorld.Barren);
        }

        //[TestMethod]
        //public void hasOneNeighorDead()
        //{

        //}

        //[TestMethod]
        //public void livesWith2()
        //{

        //}

        //[TestMethod]
        //public void livesWith3()
        //{

        //}

        //[TestMethod]
        //public void diesWith4()
        //{

        //}

        //[TestMethod]
        //public void regeneratesWithExact3()
        //{

        //}
    }
}
