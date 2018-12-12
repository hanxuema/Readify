using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Readify.Controllers
{
    [RoutePrefix("api")]
    public class ReadifyController : ApiController
    {

        [Route("fibonacci")]
        [HttpGet]
        public long Fibonacci(int n)
        {
            int[] fibArray = new int[n + 2];
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
            return "6f563692-74cc-4e71-9744-b6d0c386c26b-99999";
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
 
    }
}