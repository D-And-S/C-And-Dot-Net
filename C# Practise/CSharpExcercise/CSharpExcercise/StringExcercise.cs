using System;
using System.Collections.Generic;

namespace CSharpExcercise
{
    public class StringExcercise
    {
        /*
         1. 
          Write a program and ask the user to enter a few numbers separated by a hyphen. 
          Work out if the numbers are consecutive. 
          For example, 
          if the input is "5-6-7-8-9" or "20-19-18-17-16", 
          display a message: "Consecutive"; otherwise, display "Not Consecutive".
        */
        public static void IdentifyConsecutive()
        {
            Console.WriteLine("Enter Number Seperated By Hyphen");
            var input = Console.ReadLine();
            var number = input.Split("-");
            var numberList = new List<int>();
            var message = false;

            for (int i = 0; i < number.Length; i++)
            {
                numberList.Add(int.Parse(number[i]));
            }
            numberList.Sort();
            var lastIndex = numberList.Count - 1;

            for (int i = 0; i < numberList.Count; i++)
            {
                if (i == lastIndex)
                {
                    if (numberList[i] - numberList[i] == 0)
                    {
                        break;
                    }
                }
                else
                {
                    if (numberList[i + 1] - numberList[i] == 1)
                    {
                        message = true;
                    }
                    else
                    {
                        message = false;
                        break;
                    }
                }
            }
            var result = message ? "Number Is Consecutive" : "Not Consecutive";

            Console.WriteLine(result);
        }

        /*
          2.
          Write a program and ask the user to enter a few numbers separated by a hyphen. 
          If the user simply presses Enter, without supplying an input, exit immediately; 
          otherwise, check to see if there are duplicates. 
          If so, display "Duplicate" on the console.
        */
        public static void IdenfityDuplicate()
        {
            Console.WriteLine("enter few numbers separated by hypen");
            var input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                var numbers = input.Split("-");
                var numberList = new List<int>();

                foreach (var number in numbers)
                {
                    numberList.Add(Convert.ToInt32(number));
                }
                numberList.Sort();

                var isDuplicate = false;
                var lastIndex = numberList.Count - 1;
                for (var i = 0; i < numberList.Count; i++)
                {
                    if (i == lastIndex)
                    {
                        break;
                    }
                    if (numberList[i] - numberList[i + 1] == 0)
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                var message = isDuplicate ? "Has Duplicacy" : "NO Duplicacy";
                Console.WriteLine(message);
            }
        }

        /*
         3.
            Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
            A valid time should be between 00:00 and 23:59. 
            If the time is valid, display "Ok"; 
            otherwise, display "Invalid Time". 
            If the user doesn't provide any values, consider it as invalid time.

        */
        public static void ValidTimeFormat()
        {
            Console.WriteLine("Enter Time Value in The 24 Hour Format. e.g 19:00");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var timeFormat = input.Split(":");
            var hour = Convert.ToInt32(timeFormat[0]);
            var minute = Convert.ToInt32(timeFormat[1]);

            if ((hour >= 0 && hour <= 23) && (minute <= 59 && minute >= 0))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }

        /*
          4. 
          Write a program and ask the user to enter a few words separated by a space. 
          Use the words to create a variable name with PascalCase. 
          For example, if the user types: "number of students", 
          display "NumberOfStudents". 
          Make sure that the program is not dependent on the input. 
          So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
        */

        public static void GeneratePascalCase()
        {
            Console.WriteLine("Enter few word seperated by a space");
            var input = Console.ReadLine();
            var word = input.Split(" ");
            var wordList = new List<string>();
            foreach (var item in word)
            {
                var totalCharacter = item.Length - 1;
                var firstCharacter = item[0].ToString().ToUpper();
                var restCharater = item.Substring(1, totalCharacter);
                var completeWord = firstCharacter + restCharater;
                wordList.Add(completeWord);
            }

            var pascalCase = string.Join("", wordList);
            Console.WriteLine(pascalCase);

        }

        /*
          5.
          Write a program and ask the user to enter an English word. 
          Count the number of vowels (a, e, o, u, i) in the word. 
          So, if the user enters "inadequate", 
          the program should display 6 on the console.   
        */
        public static void CountVowels()
        {
            Console.WriteLine("Please Enter The English Word");
            var input = Console.ReadLine().ToLower();
            var count = 0;
            foreach (var item in input)
            {
                var letter = item.ToString();
                if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }

        /*
          5. Write a C# Sharp program to find the longest common ending between two given strings

            Expected Output:

            Original strings: running  ruminating

            Common ending between said two strings:ing
         */
        public static void CommonEnding()
        {
            var stringList = new List<string>();

            for (int i = 0; i < 2; i++)
            {
                if (stringList.Count == 0)
                    Console.WriteLine("Enter String");
                else
                    Console.WriteLine("Enter String 2");

                var input = Console.ReadLine();
                stringList.Add(input);
            }
            Console.WriteLine("\nCommon Ending Between two String are: {0}", FindMatch(stringList[0], stringList[1]));
        }

        private static string FindMatch(string firstString, string secondString)
        {
            for (int i = 0; i < firstString.Length; i++)
            {
                var end = firstString.Substring(i);

                if (secondString.EndsWith(end))
                {
                    return end;
                }
            }
            return "";
        }

        /*
          6. Write a C# Sharp program reverse all the words of a given string which have even length
          Original string: C# Exercises

            Reverse all the words of the said string which have even length.:
            #C Exercises

            Original string: C# is used to develop web apps , desktop apps , mobile apps , games and much more.

            Reverse all the words of the said string which have even length.:
            #C si desu ot develop web sppa , desktop sppa , elibom sppa , games and hcum more.  
         */
        public static void ReverseEvenLengthString()
        {
            Console.WriteLine("Enter A Longest String");
            var input = Console.ReadLine();
            var words = input.Split(" ");
            var wordList = new List<string>();

            foreach (var word in words)
            {
                if (word.Length % 2 == 0)
                {
                    var stringToChar = word.ToCharArray();
                    Array.Reverse(stringToChar);
                    wordList.Add(new string(stringToChar));
                }
                else
                {
                    wordList.Add(word);
                }
            }

            Console.WriteLine(" The Even Lenght Reverse String :\n");
            foreach (var item in wordList)
            {
                Console.Write(" " + item);
            }
        }

        /*
             6. Write a C# Sharp program to alternate the case of each letter in a given string 
                and the first letter of the said string must be uppercase.

             Original string: c# Exercises

             After alternating the case of each letter of the said string:
             C# ExErCiSeS
         */
        public static void AlternateCase()
        {
            Console.WriteLine("Please Enter A String With Space");
            var input = Console.ReadLine();
            var words = input.Split(" ");
            var result = "";

            for (int i = 0; i < words.Length; i++)
            {
                var letter = words[i].ToCharArray();

                for (int j = 0; j < letter.Length; j++)
                {
                    if (j % 2 != 0)
                    {
                        result += char.ToLower(letter[j]);
                    }
                    else
                    {
                        result += char.ToUpper(letter[j]);
                    }
                }
                result += " ";
            }

            Console.WriteLine(result);

        }

        /*
            7. Write a C# Sharp program to find the position of a specified word in a given string

        */

        public static void FindPositionOfTheText()
        {
            Console.WriteLine("Please Enter a String");
            var text = Console.ReadLine().ToLower();

            Console.WriteLine("Please Enter a Word From that String");
            var word = Console.ReadLine().ToLower();

            Console.WriteLine("The String Position Is : {0}", FindWordPosition(text, word));
        }

        private static int FindWordPosition(string text, string word)
        {
            var result = Array.IndexOf(text.Split(' '), word) + 1;
            return result;
        }

        /*
          8.Write a C# Sharp program to convert the first character of each word of a given string to uppercase
            Original string: python exercises
            Output: Python Exercises  
         */

        public static void EachWordUpperCase()
        {
            Console.WriteLine("Enter A String With Space");
            var text = Console.ReadLine();
            var word = text.Split(" ");
            var result = "";

            for (int i = 0; i < word.Length; i++)
            {
                var character = word[i].ToCharArray();

                for (int j = 0; j < character.Length; j++)
                {
                    if (j == 0)
                    {
                        result += char.ToUpper(character[0]);
                    }
                    else
                    {
                        result += character[j];
                    }
                }
                result += " ";
            }
            Console.WriteLine("After Converting : {0}", result);
        }

        /*
          9.  Write a C#  program to check whether a given string is an “isograms” or not. Return True or False

          Original string: Python
          Check the said string is an 'isograms' or not! True

        */
        public static void checkIsogram()
        {
            Console.WriteLine("Enter A String");
            var input = Console.ReadLine().ToLower();
            var result = false;
            var characterList = new List<char>();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please Enter Correct String");
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (characterList.Contains(input[i]))
                    {
                        result = false;
                    }else
                    {
                        characterList.Add(input[i]);
                        result = true;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
