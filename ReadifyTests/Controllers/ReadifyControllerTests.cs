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
        public void Fibonacci_Should_Return_2880067194370816000_If_Input_Is_90()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.Fibonacci(92);

            Assert.AreEqual(result, 7540113804746346000);

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
        public void ReverseWords_Should_Return_fldjas_If_Input_Is_sajdlf()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.ReverseWords("   sajdlf");

            Assert.AreEqual(result, "   fldjas");
        }
        [TestMethod()]
        public void ReverseWords_Should_Return_fldjas_If_Input_Is_abbccd()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.ReverseWords("ab bc cd");

            Assert.AreEqual(result, "ba cb dc");
        }
    
        [TestMethod()]
        public void ReverseWords_Should_Return_EmptyString_If_Input_Has_Only_Space()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.ReverseWords("    ");

            Assert.AreEqual(result, "");
        }

        [TestMethod()]
        public void Token_Should_Return_Correct_Token()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.Token();

            Assert.AreEqual(result, "6f563692-74cc-4e71-9744-b6d0c386c26b");
        }

        [TestMethod()]
        public void TriangleType_Should_Return_Error_If_Para_Are_1_2_3()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.TriangleType(1,2,3);
            Assert.AreEqual(result, "Error");
        }
        [TestMethod()]
        public void TriangleType_Should_Return_Error_If_Para_Are_1_3_1()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.TriangleType(1, 3, 1);
            Assert.AreEqual(result, "Error");
        }
        [TestMethod()]
        public void TriangleType_Should_Return_Error_If_Para_Are_Minus()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.TriangleType(-3, 4, 2);
            Assert.AreEqual(result, "Error");
        }
        [TestMethod()]
        public void TriangleType_Should_Return_Error_If_Para_Are_Zero()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.TriangleType(0, 4, 2);
            Assert.AreEqual(result, "Error");
        }
        [TestMethod()]
        public void TriangleType_Should_Return_Equilateral_If_Para_Are_Equal_And_Greater_Than_Zero()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.TriangleType(3,3,3);
            Assert.AreEqual(result, "Equilateral");
        }
           [TestMethod()]
        public void TriangleType_Should_Return_Isosceles_If_Only_A_And_B_Are_Equal()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.TriangleType(3,3,2);
            Assert.AreEqual(result, "Isosceles");
        }
        [TestMethod()]
        public void TriangleType_Should_Return_Isosceles_If_Only_C_And_B_Are_Equal()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.TriangleType(1, 2, 2);
            Assert.AreEqual(result, "Isosceles");
        }
        [TestMethod()]
        public void TriangleType_Should_Return_Isosceles_If_Only_A_And_C_Are_Equal()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.TriangleType(3, 2, 3);
            Assert.AreEqual(result, "Isosceles");
        }
        [TestMethod()]
        public void TriangleType_Should_Return_Scalene_If_Para_Are_NOT_Equal()
        {
            var readifyCotr = new ReadifyController();
            var result = readifyCotr.TriangleType(3, 2, 4);
            Assert.AreEqual(result, "Scalene");
        }
    }
}