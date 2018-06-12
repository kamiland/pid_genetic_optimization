﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Genop;


namespace Genop.UnitTests
{
    /*
     * Klasa wykonująca testy jednostkowe
     * niektórych z metod występujących w
     * klasie PLC.
     */
    [TestClass]
    public class PLCTests
    {
        /*
         * Metoda testująca metodę
         * AutoIdentyfication(), kalkulującą dane
         * i zwracającą wartość liczbową
         */
        [TestMethod]
        public void AutoIdentyfication_Calculating_GetingValue()
        {
            // Arrange
            PLC plc1 = new PLC();

            // Act
            var resoult = plc1.AutoIdentyfication();

            // Assert
            Assert.IsNotNull(resoult);
        }
    }
}
