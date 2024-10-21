using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Write your code here
                // List to hold missing numbers
                List<int> missing = new List<int>();
                // Boolean array to track present numbers
                bool[] present = new bool[nums.Length + 1];

                // Iterate through the input numbers and mark them as present
                foreach (var num in nums)
                    present[num] = true;

                // Check which numbers from 1 to n are missing
                for (int i = 1; i <= nums.Length; i++)
                    if (!present[i])  // if the number is not present
                        missing.Add(i);

                // Return the list of missing numbers
                return missing;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Write your code here
                // Result array to hold sorted values
                int[] result = new int[nums.Length];
                // Pointers for even and odd placement
                int evenIndex = 0, oddIndex = nums.Length - 1;

                // Sort numbers into even and odd positions
                foreach (var num in nums)
                {
                    if (num % 2 == 0)            // Check if the number is even
                        result[evenIndex++] = num;       // Place it at the even index and increment the index
                    else
                        result[oddIndex--] = num;        // Place odd numbers at the end and decrement the index
                }

                // Return the sorted array
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Write your code here
                // Map to store numbers and their indices
                Dictionary<int, int> map = new Dictionary<int, int>();

                // Iterate through the array to find two numbers that add up to the target
                for (int i = 0; i < nums.Length; i++)
                {
                    // Calculate the required complement
                    int complement = target - nums[i];
                    if (map.ContainsKey(complement))           // Check if the complement exists in the map
                        return new int[] { map[complement], i };       // Return the indices if found

                    map[nums[i]] = i;         // Add the current number and its index to the map
                }

                return new int[] { };         // Return an empty array if no solution is found
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Write your code here
                // Sort the array to easily access the largest numbers
                Array.Sort(nums);
                // Get the length of the array
                int n = nums.Length;
                // Calculate the maximum product of three numbers (either all three largest or two smallest and one largest)
                return Math.Max(nums[0] * nums[1] * nums[n - 1], nums[n - 1] * nums[n - 2] * nums[n - 3]);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here
                // Convert the decimal number to a binary string and return
                return Convert.ToString(decimalNumber, 2);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                // Write your code here
                // Initialize left and right pointers for binary search
                int left = 0, right = nums.Length - 1;

                // Use binary search to find the minimum in the rotated sorted array
                while (left < right)
                {
                    // Calculate the middle index
                    int mid = (left + right) / 2;      
                    if (nums[mid] > nums[right])
                        left = mid + 1;     // The minimum is in the right half
                    else
                        right = mid;        // The minimum is in the left half or mid
                }

                // Return the minimum element found at the left pointer
                return nums[left];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Write your code here
                // Negative numbers are not palindromes
                if (x < 0) return false;

                // Convert the number to a string
                string str = x.ToString();
                
                // Check if the string is equal to its reverse
                return str == new string(str.Reverse().ToArray());
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Write your code here
                // Base case for Fibonacci numbers
                if (n <= 1)
                    return n;      // Return n if it is 0 or 1

                // Initialize the first two Fibonacci numbers
                int a = 0, b = 1;

                // Calculate Fibonacci number using iteration
                for (int i = 2; i <= n; i++)
                {
                    int temp = a + b;      // Calculate the next Fibonacci number
                    a = b;                 // Move to the next position
                    b = temp;              // Update the previous number to the current
                }

                // Return the nth Fibonacci number
                return b;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
