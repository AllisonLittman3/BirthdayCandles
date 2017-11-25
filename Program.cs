using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCandles
{
    class Program
    {
        static int birthdayCakeCandles(int n, int[] ar)
        {
            
            int numOfCandlesBlownOut = 0;//this is our blown out candle counter! It starts at zero
            int highestNumber = ar[0];//first we need to find the tallest candles, which are the highest numbers in the array
            for (int i = 0; i < n; i++)//this loop cycles through the array to find the highest number, i.e. the "tallest candles"
            {
                if (ar[i] > highestNumber)
                {
                    highestNumber = ar[i];
                }
            }
            for (int j = 0; j < n; j++)//this loop cycles through the array to count how many candles are the "tallest"
            {
                if (ar[j] == highestNumber)//if this candle in the array is the tallest...
                {
                    numOfCandlesBlownOut = numOfCandlesBlownOut + 1;//it will get blown out!
                }
            }
            return numOfCandlesBlownOut;//this returns the total number of blown out candles
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //n is the number of birthday candles on a cake
            string[] ar_temp = Console.ReadLine().Split(' '); //the array contains the height of each of the candles, the birthday girl will only blow out the tallest candles
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandles(n, ar); //this method will calculate how many candles (the tallest) were blown out
            Console.WriteLine(result); //this prints the number of candles blown out
        }
    }
}
