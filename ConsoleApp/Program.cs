using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        public static string GetFibonacciApi(int n)
        {

            string url = "https://localhost:44391/Fibonacci/?n=" + n;
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";

            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }


        static  void Main(string[] args)
        {
            Console.WriteLine("Fibonacci :");
            Console.WriteLine("Please enter the number to calculate the Fibonacci :");
            int n = int.Parse(Console.ReadLine());
            string FibonacciResult =  GetFibonacciApi(n);
            Console.WriteLine(@$"Fibonacci result ={FibonacciResult} ");
            Console.ReadKey();
          

        }




    }
    }
