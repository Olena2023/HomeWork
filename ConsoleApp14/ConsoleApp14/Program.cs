using System;
 

namespace  UnixTime
{   
    internal class Program
    { 
        static void Main(string[] args)
        {
            long enterTime = 0;

            Console.WriteLine("Enter UnixTime (seconds):"); 
            enterTime =Convert.ToInt64( Console.ReadLine());

            // if (enterTime >= -2147483648 && enterTime <= 2147483647)
            if (enterTime >= -9999999999 && enterTime <= 9999999999)
            {
                DateTime date = new DateTime(1970, 1, 1).AddSeconds(enterTime);
                Console.WriteLine(" You enter date: " + date.ToString("MM/dd/yyyy H:mm"));
            }
            else Console.WriteLine("Error!");
        }
    }
}


