namespace FizzBuzzConsole
{
    public class Logic
    {
        /* FizzBuzz Function - input num (1 - 100), receive answer:
         * If number is divisible by 3, print Fizz
         * If number is divisible by 5, print Buzz
         * If number is divisible by 3 and 5, print FizzBuzz
         * Else print the number 
         */
        public static string FizzBuzz(int num)
        {
            string answer;

            if (num % 3 == 0 && num % 5 == 0)
            {
                answer = "FizzBuzz";
            }
            else if (num % 3 == 0)
            {
                answer = "Fizz";
            }
            else if (num % 5 == 0)
            {
                answer = "Buzz";
            }
            else
            {
                answer = num.ToString();
            }

            return answer;
        }
    }
}
