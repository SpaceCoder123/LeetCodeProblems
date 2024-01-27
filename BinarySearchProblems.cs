namespace LeetCode
{
    public class BinarySearchProblems
    {
        // solution for 
        //https://leetcode.com/problems/find-peak-element/description/
        //https://leetcode.com/problems/peak-index-in-a-mountain-array/
        public static int FindPeakElement(int[] nums)
        {
            // base cases 
            if (nums.Length == 0) return 0;
            int startIndex = 0;
            int endIndex = nums.Length - 1;

            // required for final execution 
            int mid = (startIndex + endIndex) / 2;

            int finalElement = GetPeakElement(nums, startIndex, endIndex);
            if (nums[finalElement] > nums[mid])
            {
                return finalElement;
            }
            else
            {
                return mid;
            }
        }
        public static int GetPeakElement(int[] nums, int startIndex, int endIndex)
        {
            if (startIndex == endIndex)
            {
                return startIndex;
            }
            if (startIndex == endIndex - 1 || endIndex == startIndex -1)
            {
                return FindMaximum(nums, startIndex, endIndex);
            }
            int mid = (startIndex + endIndex) / 2;
            return FindMaximum(nums, GetPeakElement( nums, startIndex, mid), GetPeakElement(nums, mid+1, endIndex));
        }

        public static int FindMaximum(int[] nums, int startIndex, int endIndex)
        {
            if (nums[startIndex] > nums[endIndex])
                return startIndex;
            else
                return endIndex;
        }
    }
}
