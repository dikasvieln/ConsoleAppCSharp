using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace ConsoleAppCSharp.LeetCode
{
    internal class DSA
    {
        public void BinarySearch(int[] nums, int sample)
        {
            int left = 0;
            int right = nums.Length - 1;
            while(left <= right)
            {
                int mid = left + (right - left) / 2; 
                if (nums[mid] == sample)
                {
                    Console.WriteLine("Found at index: " + mid);
                    left = mid + 1;
                }
                else if (nums[mid] < sample)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;

                }
            }

        }

        public void BinarySearchRecursive(int[] nums, int sample, int left, int right)
        {
            if (left > right)
            {
                Console.WriteLine("Element not found");
                return;
            }

            int mid = left + (right - left) / 2;
            if (nums[mid] == sample)
            {
                Console.WriteLine("Found at index: " + mid);
            }
            else if (nums[mid] < sample)
            {
                BinarySearchRecursive(nums, sample, mid + 1, right);
            }
            else
            {
                BinarySearchRecursive(nums, sample, left, mid - 1);
            }
        }
    } 
}