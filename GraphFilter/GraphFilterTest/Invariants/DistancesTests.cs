﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphFilter.Invariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphFilterTest.GraphHelper;

namespace GraphFilter.Invariants.Tests
{
    [TestClass()]
    public class DistancesTests
    {
        Graph g = GraphHelper.wheel_5();
        Graph h = GraphHelper.NotConnected();

        [TestMethod()]
        public void DistanceMatrixTest()
        {
            int[,] RealDistMatrix = new int[6, 6] { { 0, 1, 1, 1, 1, 1 }, { 1, 0, 1, 2, 2, 1 }, { 1, 1, 0, 1, 2, 2 }, { 1, 2, 1, 0, 1, 2 }, { 1, 2, 2, 1, 0, 1 }, { 1, 1, 2, 2, 1, 0 } };
            int[,] distMatrixWheel5 = Utils.Distance.Matrix(g);
            for (int i = 0; i < g.order; i++)
                for (int j = 0; j < g.order; j++) Assert.AreEqual(RealDistMatrix[i, j], distMatrixWheel5[i, j]);
        }

        [TestMethod()]
        public void DiameterTest()
        {
            Assert.AreEqual(2, InvariantNum.Diameter.Calculate(g));
        }

        [TestMethod()]
        public void IsConnectedTest()
        {
            Assert.IsTrue(InvariantBool.IsConnected.Calculate(g));
            Assert.IsFalse(InvariantBool.IsConnected.Calculate(h));
        }
    }
}