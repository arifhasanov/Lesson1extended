using System;

namespace ConsoleApp1
{
    class Program
    {
        //initiating variables in order to make is to change them later if needed
        static int loopingNumber = 100;
        static string[] result = new string[loopingNumber];
        static int divider1 = 3;
        static int divider2 = 5;

        static void Main(string[] args)
        {
            //for the loop it is important to run it less than the loopingNumber
            for (int i = 1; i <= (loopingNumber / 2); i++)
            {
                //running encapsulated function two times, because the for loop will run only half time of loopingNumber
                //one time for number itself, another time for the number + half of the loopingNumber
                result[i-1] = calculate(i);
                result[i+(loopingNumber / 2)-1] = calculate(i + (loopingNumber / 2));
            }
            //in case if the looping number is odd, I have to check the very last number
            if (loopingNumber % 2 != 0)
            {
                result[loopingNumber - 1] = calculate(loopingNumber);
            }

            //after array is fully built up, I convert it into one string so I can show it in console without a second loop
            Console.WriteLine(string.Join(",\n",result));
        }

        static string calculate(int i)
        {
            //building an element of the array
            string check = "";
            //if the number is divided by divider1, then it gets its text
            if (i % divider1 == 0) check += "Fizz";
            //if the number is divided by divider2, then it gets its text
            //if it is dividable by both, then it will get both texts
            if (i % divider2 == 0) check += "Buzz";
            //if the check is still empty, it means the number wasnt dividable by any of the dividers. In this case I add the number itself to the array. Otherwise I add the text.
            return check == "" ? i.ToString() : check;
        }
    }
}
