﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genop.UnitTests
{
    [TestClass]
    public class SolverTests
    {
        [TestMethod]
        public void calculateRotorCurrent_Calculating_GetValue()
        {
            // Arrange
            double x1 = 1, x2 = 1, x3 = 1;
            Solver solver1 = new Solver();

            // Act
            var result = solver1.calculateRotorCurrent(x1, x2, x3);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void calculateAngularVelocity_Calculating_GetValue()
        {
            // Arrange
            double x1 = 1, x2 = 1, x3 = 1;
            Solver solver2 = new Solver();

            // Act
            var result = solver2.calculateAngularVelocity(x1, x2, x3);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CalculateNextStep_Calculating_GetValue()
        {
            // Arrange
            double u = 10;
            Solver solver3 = new Solver();

            // Act
            var result = solver3.CalculateNextStep(u);

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
