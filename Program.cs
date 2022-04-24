using System;

namespace Lesson_1_Homework
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Console.WriteLine("TEst 1");


    //    }
    //}

    public class Homework
    {
        public void CheckIfNumberIsEvenOrOdd(int number)
        {
            /* Exercise 1
          * using "if" write a programm that checks whether an integer is greater then zero and even or odd
          * Example:
          * -------------------------------------------------
          * |input   | result                               |
          * |--------|--------------------------------------|
          * |  1     | even                                 |
          * |--------|--------------------------------------|
          * |  2     | odd                                  |
          * |--------|--------------------------------------|
          * | -1     | the value should be greater then zero|
          * -------------------------------------------------
          * 
          */
            int mod = number % 2;
            if (number < 0)
            {
                Console.WriteLine($"Entered value, {number} - should be greater then zero");
            }
            else if (mod > 0)
            {
                Console.WriteLine($"Entered value {number} - is odd");
            }
            else { Console.WriteLine($"Entered value {number} - is even"); }
        }
        public void NumberDivideToFour(int number)
        {
            /* Exercise 2
        * using a ternary operator write a program that print if number divide to 4
        * Example: 
        * --------------------------------------------
        * |input   | result                          |
        * |--------|---------------------------------|
        * |  -4    | The number divide to 4          |
        * |--------|---------------------------------|
        * |   2    | The number doesn't divide to 4  |
        * --------------------------------------------
        */
            int mod = number % 4;
            var result = mod == 0 ? "The number divide to 4" : "The number doesn't divide to 4";

            Console.WriteLine($"Entered value {number} {result}");
        }
        public void DayOfWeek(string day)
        {
            /* Exercise 3
             * using "switch" statement write a program that print the number of day of week
             * Example: monday - 1, tuesday - 2 etc. 
             * ---------------------------------------------------------
             * |day           |number                                  |
             * |--------------|----------------------------------------|
             * |monday        |   1                                    |
             * |tuesday       |   2                                    |
             * |wednesday     |   3                                    |
             * |thursday      |   4                                    |
             * |friday        |   5                                    |
             * |saturday      |   6                                    |
             * |sunday        |   7                                    |
             * |default value |Wrong value! Please give a day of a week|
             * ---------------------------------------------------------
             */

            switch (day)
            {
                case "Monday":
                    Console.WriteLine($"{day} - 1");
                    break;
                case "Tuesday":
                    Console.WriteLine($"{day} - 2");
                    break;
                case "Wednesday":
                    Console.WriteLine($"{day} - 3");
                    break;
                case "Thursday":
                    Console.WriteLine($"{day} - 4");
                    break;
                case "Friday":
                    Console.WriteLine($"{day} - 5");
                    break;
                case "Saturday":
                    Console.WriteLine($"{day} - 6");
                    break;
                case "Sunday":
                    Console.WriteLine($"{day} - 7");
                    break;
                default:
                    Console.WriteLine($"{day} - Wrong value! Please give a day of a week");
                    break;
            }
        }
        public void CheckLetterIfVowel(char character)
        {
            /* Exercise 4
             * write a program that will print input character is a vowel, consonant or not a letter
             * Method 1: using a switch case
             * Method 2: using if
             * ---------------------------
             * |input| result            |
             * |-----|-------------------|
             * |  a  | a is a vowel      |
             * |  b  | b is a consonant  |
             * ---------------------------
             */
            //Method 1: using a switch case
              switch (character)
             {
                  case 'a':
                  case 'e':
                  case 'i':
                  case 'o':
                  case 'u':
                  case 'A':
                  case 'E':
                  case 'I':
                  case 'O':
                  case 'U':
                      Console.WriteLine($"{character} - is a vowel");
                      break;
                  case 'b':
                  case 'c':
                  case 'd':
                  case 'f':
                  case 'g':
                  case 'h':
                  case 'j':
                  case 'k':
                  case 'l':
                  case 'm':
                  case 'n':
                  case 'p':
                  case 'q':
                  case 'r':
                  case 's':
                  case 't':
                  case 'v':
                  case 'w':
                  case 'x':
                  case 'y':
                  case 'z':
                  case 'B':
                  case 'C':
                  case 'D':
                  case 'F':
                  case 'G':
                  case 'H':
                  case 'J':
                  case 'K':
                  case 'L':
                  case 'M':
                  case 'N':
                  case 'P':
                  case 'Q':
                  case 'R':
                  case 'S':
                  case 'T':
                  case 'V':
                  case 'W':
                  case 'X':
                  case 'Y':
                  case 'Z':

                      Console.WriteLine($"{character} - is a consonant");
                      break;
                 default:
                      Console.WriteLine($"{character} - is not a letter");
                      break;
              } 

            // Method 2: using if
            
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u' || character == 'A'
                || character == 'E' || character == 'I' || character == 'O' || character == 'U')
            {
                Console.WriteLine($"{character} - is a vowel");
            }
            else if (character == 'b' || character == 'c' || character == 'd' || character == 'f' || character == 'g' || character == 'h' || character == 'j' ||
                character == 'k' || character == 'l' || character == 'm' || character == 'n' || character == 'p' || character == 'q' || character == 'r' ||
                character == 's' || character == 't' || character == 'v' || character == 'w' || character == 'x' || character == 'y' || character == 'z' ||
                character == 'B' || character == 'C' || character == 'D' || character == 'F' || character == 'G' || character == 'H' || character == 'J' ||
                character == 'K' || character == 'L' || character == 'M' || character == 'N' || character == 'P' || character == 'Q' || character == 'R' ||
                character == 'S' || character == 'T' || character == 'V' || character == 'W' || character == 'X' || character == 'Y' || character == 'Z')
            {
                Console.WriteLine($"{character} - is a consonant");
            }
            else { Console.WriteLine($"{character} - is not a letter"); }
        }
        public static void Main(String[] args)
        {
            Homework homework = new Homework();

            Console.WriteLine("1. Checking if entered numbers are odd or even. Only positive numbers allowed");
            homework.CheckIfNumberIsEvenOrOdd(-11);
            homework.CheckIfNumberIsEvenOrOdd(11);
            homework.CheckIfNumberIsEvenOrOdd(8);

            //---------------------------------------
            Console.WriteLine("2. Checking if entered numbers divide to 4");
            homework.NumberDivideToFour(10);
            homework.NumberDivideToFour(16);
            //---------------------------------------
            Console.WriteLine("3. Print the number of day of week"); 
            homework.DayOfWeek("Monday");
            homework.DayOfWeek("Sunday");
            homework.DayOfWeek("some day");
            //---------------------------------------
            Console.WriteLine("4. Print input character is a vowel, consonant or not a letter");
            homework.CheckLetterIfVowel('p');
            homework.CheckLetterIfVowel('i');
           
        }
    }
}
