using System;
using System.Collections.Generic;

namespace CSharpExcercise
{
    class ArrayExcercise
    {

    
        /*
         1.
            When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
            If no one likes your post, it doesn't display anything.
            If only one person likes your post, it displays: [Friend's Name] likes your post.
            If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.           
            Write a program and continuously ask the user to enter different names, 
            until the user presses Enter (without supplying a name). Depending on the number of names provided, 
            display a message based on the above pattern.
         */
        public static void FacebookLikePattern()
        {
            var nameList = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter Diffrent Names");
                var input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    nameList.Add(input);
                }
            }

            switch (nameList.Count)
            {
                case 0:
                    Console.WriteLine("Nobody Likes your post");
                    break;
                case 1:
                    Console.WriteLine("{0} Liked Your Post", nameList[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} Liked Your Post", nameList[0], nameList[1]);
                    break;
                default:
                    Console.WriteLine("{0}, {1} and {2} others Liked Your Post", nameList[0], nameList[1], nameList.Count-2);
                    break;
            }

        }

        /*
         2.
           Write a program and ask the user to enter their name. 
           Use an array to reverse the name and then store the result in a new string. 
           Display the reversed name on the console.
         */
        public static void DisplayReverseName()
        {
            Console.WriteLine("Enter Your Name");
            var input = Console.ReadLine();
            var characterList = new List<char>();
            var stringToCharacter = input.ToCharArray();

            foreach (var item in stringToCharacter)
            {
                characterList.Add(item);
            }
            characterList.Reverse();
            var newString = string.Join("",characterList);
            Console.WriteLine(newString);
            
            
            //Solution One
            //Console.WriteLine("Enter Your Name");
            //var input = Console.ReadLine();
            //var characterList = new List<int>();

            //var characters = new char[input.Length];

            //for (var i= input.Length; i > 0;i--)
            //{
            //    characters[input.Length - i] = input[i - 1];
            //}

            //Console.WriteLine("Reversed Name:");
            //var reversed = new string(characters);
            //Console.WriteLine(reversed);

        }

        /*
         3.
          Write a program and ask the user to enter 5 numbers. 
          If a number has been previously entered, 
          display an error message and ask the user to re-try. 
          Once the user successfully enters 5 unique numbers, 
          sort them and display the result on the console.
        */
        public static void UniqueNumberSorting()
        {
            var numberList = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter 5 Numbers");
                var input = int.Parse(Console.ReadLine());

                if (numberList.Contains(input))
                {
                    Console.WriteLine("Please re-try");
                }
                else
                {
                    numberList.Add(input);
                }
            }
            numberList.Sort();

            foreach (var item in numberList)
            {
                Console.WriteLine(item+" ");
            }
        }

        /*
         4.
           Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
           The list of numbers may include duplicates. 
           Display the unique numbers that the user has entered.
         */
        public static void UniqueNumberWithoutDuplicate()
        {
            var numberList = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a Number");
                var input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }
                else
                {
                    var number = int.Parse(input);
                    if (numberList.Contains(number))
                    {
                        continue;
                    }
                    else
                    {
                        numberList.Add(number);
                    }

                }
            }

            foreach (var num in numberList)
            {
                Console.Write(num);
            }
        }

        /*
            5.
            Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
            If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
            otherwise, display the 3 smallest numbers in the list.
         */
        public static void ThreeSmallestNumebr()
        {
            var numberList = new List<int>();
            var isInvalid = false;

            while (true)
            {              
                if (isInvalid)
                {
                    Console.WriteLine("Invalid List re try");
                    isInvalid = false;
                }else
                {
                    Console.WriteLine("Enter 5 Number seperated number");
                    var input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        isInvalid = true;
                        continue;
                    }

                    var number = input.Split(",");

                    if (number.Length < 5)
                    {
                        isInvalid = true;
                        continue;
                    }
                        
                    foreach (var item in number)
                    {
                        numberList.Add(int.Parse(item));
                    }
                    numberList.Sort();

                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(numberList[i]+" ");
                    }
                    break;
                }
            }
        }

        /*
          6. Write a C# Sharp program to re-arrange the elements in a given array of numbers 
          and check the numbers are consecutive or not.  

         Original array elements:
        -10 -11 -12 -13 -14 15 16 17 18 19 20
        Check the numbers of the said array are consecutive or not! False

        Original array elements:
        -1 -2 -3 0 1 4 3 2
        Check the numbers of the said array are consecutive or not! True
        */
        public static void ConsecutiveInput()
        {
            Console.WriteLine("-1 -2 -3 0 1 4 3 2 Check the numbers of the said array are consecutive or not! True");
            int[] nums = {-1,-2,-3,0,1,4,3,2};

            Console.WriteLine("The array said it is consecutive : {0}", CheckConsecutive(nums));
        }
        private static bool CheckConsecutive(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - nums[i-1] !=1)
                    return false;
            }
            return true;
        }

        /*
           7. find the missing number in the array 
        */
        public static void MissingNumber()
        {
            int[] numbers = { 10, 11, 12, 13, 14, 16, 17, 18, 19, 20 };

            var missingNumber = 0;
            for (int i = 0; i <= numbers.Length; i++)
            {
                if (numbers[i + 1] - numbers[i] == 1)
                    missingNumber = 0;
                else
                {
                    missingNumber = numbers[0] + i + 1;
                    break;
                }
            }
            Console.WriteLine(missingNumber);

        }

        /*
         8. Write a C# Sharp program to 
         calculate the sum of two 
         lowest negative numbers of a given array of integers.
         */
        public static void FindLowestNegative()
        {
            int[] numbers = { -1, -2, -4, 0, 3, 4, 5, 9, };
            var numberList = new List<int>();
            var sum = 0;

            foreach (var item in numbers)
            {
                numberList.Add(item); ;
            }
            numberList.Sort();

            for (int i = 0; i < 2; i++)
            {
                sum += numberList[i];
            }
            Console.WriteLine("Sum of Two Lowest Number is : "+ sum);
        }

        /*
          9.Write a program in C# Sharp to print or display the upper triangular of a given matri

            Test Data :
            Input the size of the square matrix : 3
            Input elements in the first matrix :
            element - [0],[0] : 1
            element - [0],[1] : 2
            element - [0],[2] : 3
            element - [1],[0] : 4
            element - [1],[1] : 5
            element - [1],[2] : 6
            element - [2],[0] : 7
            element - [2],[1] : 8
            element - [2],[2] : 9
            Expected Output :
            The matrix is :
            1 2 3
            4 5 6
            7 8 9

            Setting zero in lower triangular matrix
            1 2 3
            0 5 6
            0 0 9
         */
        public static void DisplayUpperTriangleMatrix()
        {
            int[,] arr1= new int[50, 50];
            Console.Write("intput the size of the square matrix : ");
            var number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input elements in the first matrix :");
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write("Element - [{0}][{1}] :",i,j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Then matrix is: \n");

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write("{0}  ", arr1[i, j]);                    
                }
                Console.Write("\n");
            }

            Console.Write("\n Setting zero in upper triangular matrix\n");

            for (int i = 0; i <number; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < number; j++)
                {
                    if (i>=j)
                    {
                        Console.Write("{0} ",arr1[i,j]);
                    }else
                    {
                        Console.Write("{0} ",0);
                    }
                }
                Console.Write("\n\n");
            }
        }

        /*
          9. Write a C# Sharp program to get only the odd values from a given array of integers
        */
        public static void getOddValue()
        {
            try
            {
                Console.WriteLine("Enter number seperated by comma");
                var input = Console.ReadLine();
                var number = input.Split(",");
                var numberList = new List<int>();

                for (int i = 0; i < number.Length; i++)
                {
                    numberList.Add(Convert.ToInt32(number[i]));
                }

                foreach (var item in numberList)
                {
                    if (item % 2 != 0)
                    {
                        Console.Write(item + " ");
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Please Provide Correct Input");
            }

        }

        /*
          Write a C# Sharp program to remove all 
           duplicate elements from a given array 
           and returns a new array.

          Original array elements:
            25
            Anna
            False
            25
            4/15/2021 12:10:51 PM
            112.22
            Anna
            False

          After removing duplicate elements from the said array:
            25
            Anna
            False
            4/15/2021 12:10:51 PM
            112.22
         */
        public static void RemoveDuplicate()
        {
            string[] arr = {"25","Anna","25", "False", "4/15/2021 12:10:51 PM", "112.22", "Anna", "False"};
            var arrayList = new List<string>();

            foreach (var item in arr)
            {
                if (arrayList.Contains(item))
                {
                    continue;
                }else
                {
                    arrayList.Add(item);
                }
            }

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
