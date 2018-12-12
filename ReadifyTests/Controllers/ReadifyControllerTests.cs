using Microsoft.VisualStudio.TestTools.UnitTesting;
using Readify.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readify.Controllers.Tests
{
    [TestClass()]
    public class ReadifyControllerTests
    {
        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377,
        [TestMethod()]
        public void Fibonacci_Should_Return_Zero_If_Input_Is_Zero()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.Fibonacci(0);

            Assert.AreEqual(result, 0);

        }
        [TestMethod()]
        public void Fibonacci_Should_Return_One_If_Input_Is_One()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.Fibonacci(1);

            Assert.AreEqual(result, 1);

        }
        [TestMethod()]
        public void Fibonacci_Should_Return_One_If_Input_Is_Two()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.Fibonacci(2);

            Assert.AreEqual(result, 1);

        }
        [TestMethod()]
        public void Fibonacci_Should_Return_4_If_Input_Is_3()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.Fibonacci(3);

            Assert.AreEqual(result, 2);

        }
        [TestMethod()]
        public void Fibonacci_Should_Return_34_If_Input_Is_9()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.Fibonacci(9);

            Assert.AreEqual(result, 34);

        }
        [TestMethod()]
        public void Fibonacci_Should_Return_832040_If_Input_Is_30()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.Fibonacci(30);

            Assert.AreEqual(result, 832040);

        }
        [TestMethod()]
        public void Fibonacci_Should_Return_832040_If_Input_Is_minus30()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.Fibonacci(-30);

            Assert.AreEqual(result, 832040);

        }

        [TestMethod()]
        public void ReverseWords_Should_Return_abc_If_Input_Is_cba()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.ReverseWords("cba");

            Assert.AreEqual(result, "abc");
        }
        [TestMethod()]
        public void ReverseWords_Should_Return_ABC_If_Input_Is_CBA()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.ReverseWords("CBA");

            Assert.AreEqual(result, "ABC");
        }
        [TestMethod()]
        public void ReverseWords_Should_Return_AbC_If_Input_Is_CbA()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.ReverseWords("CbA");

            Assert.AreEqual(result, "AbC");
        }
        [TestMethod()]
        public void ReverseWords_Should_Return_123_If_Input_Is_321()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.ReverseWords("321");

            Assert.AreEqual(result, "123");
        }
        [TestMethod()]
        public void ReverseWords_Should_Return_A_BC_If_Input_Is_CB_A()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.ReverseWords("CB_A");

            Assert.AreEqual(result, "A_BC");
        }
        [TestMethod()]
        public void ReverseWords_Should_Return_EmptyString_If_Input_Has_Only_Space()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.ReverseWords("    ");

            Assert.AreEqual(result, "");
        }
    }
}