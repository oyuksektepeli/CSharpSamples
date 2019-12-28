using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {

            static string timeConversion(string s)
            {
                DateTime timeValue = Convert.ToDateTime(s);
                string result = timeValue.ToString("HH:mm:ss");
                return result;

            }

            string s = Console.ReadLine();

            string result = timeConversion(s);

            Console.WriteLine(result);

            
        }
    }
}
