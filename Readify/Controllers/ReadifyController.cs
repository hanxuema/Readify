using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;
using Readify.Models;

namespace Readify.Controllers
{
    [RoutePrefix("api")]
    public class ReadifyController : ApiController
    {

        [Route("fibonacci")]
        [HttpGet]
        public long Fibonacci(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;

            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   

            return Fibonacci(n - 1) + Fibonacci(n - 2);

        }

        [HttpGet]
        [Route("ReverseWords")]
        public string ReverseWords(string sentence)
        {
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
            return "6f563692-74cc-4e71-9744-b6d0c386c26b";
        }

        [HttpGet]
        [Route("TriangleType")]
        public async Task<string> TriangleType(int a, int b, int c)
        {
            int shortest;
            int middle;
            int longest;
            int[] input = new int[3] { a, b, c };

            //find the shortest
            Array.Sort(input);
            shortest = input[0];
            //find the middle
            middle = input[1];
            //find the longest
            longest = input[2];

            //if the shortest plus the middel is less or equal to the largest
            if (shortest + middle <= longest)
            {
                return "Error";
            }

            if (shortest == middle && shortest == longest)
            {
                return "Equilateral";
            }

            if (shortest == middle || middle == longest)
            {
                return "Isosceles";
            }

            return "Scalene";
        }

        [HttpGet]
        [Route("TestHeaderAndBody/{firstName}/{lastName}")]
        public async Task<string> TestApi([FromBody] Student student)
        {
            
            return string.Format("fname header {0}, lname header {1}, fname body {2},lname body {3}");
        }
    }
}