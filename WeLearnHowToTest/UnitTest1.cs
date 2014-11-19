using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeLearnHowToTest
{
    [TestClass]
    public class UnitTest1
    {
        private SomethingLikeComparer _comparer;

        [TestInitialize]
        public void Initialize()
        {
            _comparer = new SomethingLikeComparer();
        }


        [TestMethod]
        public void TestMethod1()
        {
            // When
            ClassWeTest testObject = new ClassWeTest();
            double numberOne = 0.00f;
            int numberTwo = 1;

            // Do
            double result = testObject.ItIsSomethingLikeDividing(numberOne, numberTwo);


            // Then
            Assert.AreEqual(1.0f,_comparer.Compare(result,0.0f));
            Assert.AreEqual(1, _comparer.Counts);
        }

        [TestMethod]
        public void TestMethod2()
        {
            ClassWeTest testObject = new ClassWeTest();
            double numberOne = 1.00f;
            int numberTwo = 1;

            // Do
            double result = testObject.ItIsSomethingLikeDividing(numberOne, numberTwo);


            // Then
            Assert.AreEqual(0, _comparer.Compare(result, 2.0f));
            Assert.AreEqual(1, _comparer.Counts);
        }

        [TestMethod]
        [ExpectedException(typeof (DivideByZeroException))]
        public void TestDivideByZero()
        {
            ClassWeTest testObject = new ClassWeTest();
            double numberOne = 1.00f;
            int numberTwo = 0;

            // Do
            double result = testObject.ItIsSomethingLikeDividing(numberOne, numberTwo);


            // Then
            
        }
    }
}
