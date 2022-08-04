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
    public class TriangleTests
    {
        [TestMethod()]
        public void CalculateAreaTest()
        {
            IFigure triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(triangle.CalculateArea(), 6);
        }

        [TestMethod()]
        public void IsIsoscelesTest()
        {
            Assert.IsTrue(new Triangle(2, 2, 3).IsIsosceles());
        }
    }
}