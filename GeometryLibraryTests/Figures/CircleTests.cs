using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary.Figures;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Figures.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CalculateAreaTest()
        {
            IFigure circle = new Circle(10);
            Assert.AreEqual(circle.CalculateArea(), 314.1592653589793);
        }
    }
}