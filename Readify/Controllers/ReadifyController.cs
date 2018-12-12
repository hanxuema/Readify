using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;

namespace Readify.Controllers
{
    [RoutePrefix("api")]
    public class ReadifyController : ApiController
    {
        private readonly string myToken = "6f563692-74cc-4e71-9744-b6d0c386c26b";

        [Route("fibonacci")]
        [HttpGet]
        public BigInteger Fibonacci(long n)
        {
            if (n < 0)
            {
                n = 0 - n;
            }
            BigInteger[] fibArray = new BigInteger[n + 2];
            int index;

            fibArray[0] = 0;
            fibArray[1] = 1;

            for (index = 2; index <= n; index++)
            {

                fibArray[index] = fibArray[index - 1] + fibArray[index - 2];
            }

            return fibArray[n];

        }

        [HttpGet]
        [Route("ReverseWords")]
        public string ReverseWords(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return "";
            }
            var charArray = new Char[sentence.Length];
            for (int i = 0; i < sentence.Length; i++)
            {
                charArray[sentence.Length - i - 1] = sentence[i];
            }
            return new string(charArray);
        }


        [HttpGet]
        [Route("Token")]
        public string Token()
        {
            return myToken;
        }

        [HttpGet]
        [Route("TriangleType")]
        public string TriangleType(int a, int b, int c)
        {
            //Equilateral: All the side are equal in size.

            //Isosceles: Any two sized are equal.
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "Error";
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return "Error";
            }

            if (a == b && b == c)
            {
                return "Equilateral";
            }

            if ((a == b && b != c) || (b == c && a != c) || (a == c && b != c))
            {
                return "Isosceles";
            }

            return "Scalene";
        }

    }
}