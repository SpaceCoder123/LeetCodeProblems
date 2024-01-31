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
            if (startIndex == endIndex - 1 || endIndex == startIndex - 1)
            {
                return FindMaximum(nums, startIndex, endIndex);
            }
            int mid = (startIndex + endIndex) / 2;
            return FindMaximum(nums, GetPeakElement(nums, startIndex, mid), GetPeakElement(nums, mid + 1, endIndex));
        }

        public static int FindMaximum(int[] nums, int startIndex, int endIndex)
        {
            if (nums[startIndex] > nums[endIndex])
                return startIndex;
            else
                return endIndex;
        }
        //https://leetcode.com/problems/single-element-in-a-sorted-array/description/

        public static int SingleNonDuplicate(int[] nums)
        {
            int totalLength = nums.Length - 1;
            int startIndex = 0;

            // edge cases
            if (nums.Length == 1)
                return nums[0];

            if (nums[0] != nums[1])
                return nums[0];

            if (nums[totalLength] != nums[totalLength - 1])
                return nums[totalLength];

            // actual case 
            while (startIndex <= totalLength)
            {
                int mid = (startIndex + totalLength) / 2;

                // Check if mid is the non-duplicate element
                if (nums[mid] != nums[mid - 1] && nums[mid] != nums[mid + 1])
                {
                    return nums[mid];
                }

                // Adjust the search range based on the comparison
                if ((mid % 2 == 0 && nums[mid] == nums[mid + 1]) || (mid % 2 == 1 && nums[mid] == nums[mid - 1]))
                {
                    startIndex = mid + 1;
                }
                else
                {
                    totalLength = mid - 1;
                }
            }

            return 0;
        }

        //solution brute force O(n^2)
        public static int CountPairs(IList<int> nums, int target)
        {
            int count = 0;
            int totalCount = nums.Count;
            for (int i = 0; i < totalCount; i++)
            {
                for (int j = i+1; j < totalCount; j++)
                {
                    count += CheckValue(nums[i], nums[j], target);
                }
            }
            return count;
        }
        public static int CheckValue(int outer, int inner, int target)
        {
            int value = outer + inner;
            if (value < target)
                return 1;
            else return 0;
        }
    }
}
