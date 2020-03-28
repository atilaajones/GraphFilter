﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphFilter.Invariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphFilter.Invariants;
using GraphFilterTest.GraphHelper;

namespace GraphFilter.Invariants.Tests
{
    [TestClass()]
    public class ColoringTests
    {
        [TestMethod()]
        public void ChromaticNumberTest()
        {
            //Coloring color = new Coloring();     
            Assert.AreEqual(4, Coloring.ChromaticNumber(GraphHelper.wheel_5()));
            Assert.AreEqual(3, Coloring.ChromaticNumber(GraphHelper.NotConnected()));
            Assert.AreEqual(3, Coloring.ChromaticNumber(GraphHelper.ExBronKerb_Wiki()));
            Assert.AreEqual(5, Coloring.ChromaticNumber(GraphHelper.Complete(5)));
        }
    }
}