using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CensorLibrary;

namespace CensorLibraryTest
{
    [TestClass]
    public class CensoreTest
    {
        /// <summary>
        /// Набор тестовых данных и выполнение тестов
        /// </summary>
        /// <param name="textstring"></param>
        /// <param name="textcensore"></param>
        [DataTestMethod]
        [DataRow ("В этой строке есть редиска", "В этой строке есть ***")]
        [DataRow("Классная РеДисКА с молоком", "Классная *** с молоком")]
        [DataRow("большой дом, что внём?", "большой дом, что внём?")]
        [DataRow("реДискА купила Редиска", "*** купила ***")]
        [DataRow("реДискА Редиска Редиска", "*** *** ***")]
        [DataRow("", "")]
        public void alltest(string textstring, string textcensore)
        {
           
            string actual = CensoreClass.Censore(textstring);

            Console.WriteLine($"{textstring}-{actual}");
            Assert.AreEqual(textcensore, actual);

        }
    }
}
