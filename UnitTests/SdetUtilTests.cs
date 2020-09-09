using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDETExercise;
using System;

namespace UnitTests
{
    /// <summary>
    /// This test are testing the class SdetUtil
    /// </summary>
    [TestClass]
    public class SdetUtilTests
    {

        /// <summary>
        /// Test the method LongestWord() of a sentence and return it's lenght and the word
        /// </summary>
        [TestMethod]
        public void TestSentence1()
        {
            SdetUtil util = new SdetUtil();

            string result = util.LongestWord("The cow jumped over the moon");

            Assert.AreEqual("6 jumped", result);
        }

        /// <summary>
        /// Test that LongestWord method with empty string should return an ArgumentException
        /// </summary>
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void TestEmptySentence()
        {
            SdetUtil util = new SdetUtil();

            util.LongestWord("");            
        }

        /// <summary>
        /// Test LongestWord method with sentence of one word
        /// </summary>
        [TestMethod]
        public void TestOneWord()
        {
            SdetUtil util = new SdetUtil();

            string result = util.LongestWord("The");

            Assert.AreEqual("3 The", result);
        }

        /// <summary>
        /// This test that the LongestWord method returns the first longest word if there is a tie
        /// </summary>
        [TestMethod]
        public void TestIfThereIsATie()
        {
            SdetUtil util = new SdetUtil();

            string result = util.LongestWord("The car is red");

            Assert.AreEqual("3 The", result);
        }

        /// <summary>
        /// Test LongestWord method with Symbol and it's lenght
        /// </summary>
        [TestMethod]
        public void TestSymbol()
        {
            SdetUtil util = new SdetUtil();

            string result = util.LongestWord("%%%");

            Assert.AreEqual("3 %%%", result);
        }
    }
}
