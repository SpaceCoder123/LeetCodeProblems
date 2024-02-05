using System.ComponentModel.DataAnnotations;

namespace LeetCode
{
    public class SortingProblems
    {
        //1365. How Many Numbers Are Smaller Than the Current Number
        // testcase 1. Ip = [8,1,2,2,3], Op = [4,0,1,1,3]
        public static int[] SmallerNumbersThanCurrent([Required]int[] nums)
        {
            int[] result = new int[nums.Length];
            for(int i = 0; i < nums.Length;i++)
            {
                int count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                        count++;
                }
                result[i] = count;   
            }
            return result;
        }

        //2418. Sort the People
        public static string[] SortPeople(string[] names, int[] heights)
        {
            return SortHeights(heights,names);
        }
        private static string[] SortHeights(int[] heights, string[] names) 
        {
            for (int i = 0;i < heights.Length;i++)
            {
                for( int j = 0; j < heights.Length; j++)
                {
                    if (heights[i] > heights[j])
                    {
                        int temp = heights[i];
                        heights[i] = heights[j];
                        heights[j] = temp;
                        string temp1 = names[i];
                        names[i] = names[j];
                        names[j] = temp1;
                    }
                }
            }
            return names;
        }

        //2733. Neither Minimum nor Maximum, IN PROGRESS

        public static int FindNonMinOrMax(int[] nums)
        {
            // base case 
            if (nums.Length >= 2) return -1;
            return 0;
        }

        //1913. Maximum Product Difference Between Two Pairs
    }
}
