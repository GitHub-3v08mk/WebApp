using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp;

namespace WebAppTest
{
    [TestClass]
    public class FunctionsTest
    {

        public void test_NumberEven_1_false()
        {

            //Arrange
            Functions functions = new Functions();

            //Act
            bool returnValue = functions.numberEven(1);

            //Assert
            Assert.IsFalse(returnValue);

        }

        [TestMethod]
        public void test_NumberEven_2_true()
        {

            //Arrange
            Functions functions = new Functions();

            //Act
            bool returnValue = functions.numberEven(2);

            //Assert
            Assert.IsTrue(returnValue);

        }

        [TestMethod]
        public void test_numberDouble_1_2()
        {

            //Arrange
            Functions functions = new Functions();

            //Act
            int returnValue = functions.numberDouble(1);

            //Assert
            Assert.AreEqual(2, returnValue);

        }

        [TestMethod]
        public void test_numberDouble_2_4()
        {

            //Arrange
            Functions functions = new Functions();

            //Act
            int returnValue = functions.numberDouble(2);

            //Assert
            Assert.AreEqual(4, returnValue);

        }

        [TestMethod]
        public void test_stringReturn_testStringValue_testStringValue()
        {

            //Arrange
            Functions functions = new Functions();

            //Act
            String returnValue = functions.stringReturn("testStringValue");

            //Assert
            Assert.AreEqual("testStringValue", returnValue);

        }

    }
}