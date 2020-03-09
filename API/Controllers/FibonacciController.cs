using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FibonacciController : Controller
    {
       

        [HttpGet]
        public int Get(int n)
        {
            return Fibonacci(n);
        }





        private int Fibonacci(int n)
        {
            if(n<1 || n>100)
            {
                return -1; 
            }
            if(n==1 || n==2)
            {
                return 1; 
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}