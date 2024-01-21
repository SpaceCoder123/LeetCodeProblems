using System.Linq.Expressions;

namespace LeetCode
{
    public class RemoveDuplicatesLeetCode
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int count = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            return count;
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            int og = x;
            int rev = 0;

            while (x != 0)
            {
                int digit = x % 10;
                rev = rev * 10 + digit;
                x /= 10;
            }

            return og == rev;
        }

        public static int SearchInsertPosition(int[] nums, int target)
        {
            return SearchPosition(nums, 0, nums.Length, target);
        }

        public static int SearchPosition(int[] nums, int lowerLimit, int upperLimit, int target)
        {
            if (target > nums[nums.Length - 1])
            {
                return nums.Length;
            }
            if (target < nums[0])
            {
                return 0;
            }
            if (lowerLimit == upperLimit)
            {
                return upperLimit;
            }
            int mid = (lowerLimit + upperLimit) / 2;
            if (target == nums[mid])
            {
                return mid;
            }
            else if (target < nums[mid])
            {
                return SearchPosition(nums, lowerLimit, mid, target);
            }
            else
            {
                return SearchPosition(nums, mid + 1, upperLimit, target);
            }
        }

        // You must write an algorithm with O(log n) runtime complexity.

        public static int SearchRotatedSortedArray(int[] nums, int target)
        {
            //edge and initial cases
            if (nums[0] == target) return 0;
            if (nums[nums.Length - 1] == target) return nums.Length - 1;

            int mid = ((0 + nums.Length) / 2);
            if (target > nums[0] && target < nums[mid]) return FindElement(nums, 0, mid, target);
            else return FindElement(nums, mid, nums.Length - 1, target);
        }

        public static int FindElement(int[] nums, int startIndex, int endIndex, int target)
        {
            if (nums[startIndex] == target) return startIndex;
            if (nums[endIndex] == target) return endIndex;
            int mid = ((startIndex + endIndex) / 2);
            if (startIndex == endIndex - 1 || startIndex == endIndex)
            {
                if (nums[startIndex] == target) return startIndex;
                else if (nums[endIndex] == target) return endIndex;
                return -1;
            }
            if (target < nums[mid])
            {
                return FindElement(nums, startIndex, mid - 1, target);

            }
            else
            {
                return FindElement(nums, mid, endIndex, target);
            }
        }

        // assuming both the target would be next to each other
        public static int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0) return new int[] { -1, -1 };
            return SearchItems(nums, 0, nums.Length - 1, target);
        }

        public static int[] SearchItems(int[] nums, int startIndex, int endIndex, int target)
        {
            if(nums[startIndex] == target && startIndex != 0)
            {
                if (nums[startIndex - 1] == target)
                    return new int[] { startIndex - 1, startIndex };
            }
            if (startIndex == endIndex - 1|| startIndex == endIndex || nums[startIndex] == nums[endIndex])
            {
                if (nums[startIndex] == target || nums[endIndex]== target)
                {
                    if (nums[startIndex] == nums[endIndex])
                        return new int[] { startIndex, endIndex };
                    if (nums[endIndex] == target)
                        return new int[] { endIndex, endIndex };
                    if (nums[startIndex] == target)
                        return new int[] { startIndex, startIndex };
                }
                else
                {
                    return new int[] { -1, -1 };
                }
            }
            int mid = (startIndex + endIndex) / 2;
            if (nums[mid] > target)
            {
                return SearchItems(nums, startIndex, mid, target);
            }
            else
            {
                return SearchItems(nums, mid, endIndex, target);

            }

        }

        public static int[] SearchRange2(int[] nums, int target)
        {
            int[] result = new int[] { -1, -1};
            result[0] = FindFirstOccurance(nums, target);
            if (result[0]!= -1)
                result[1] = FindSecondOccurance(nums, target);
            return result;
        }

        private static int FindFirstOccurance(int[] nums, int target)
        {
            int firstIndex = 0;
            int lastIndex = nums.Length - 1;
            int result = -1;
            
            while(firstIndex <= lastIndex)
            {
                int mid = (firstIndex + lastIndex) / 2;
                if (nums[mid] == target)
                {
                    result = mid;
                    lastIndex = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    firstIndex = mid + 1;
                }
                else
                {
                    lastIndex = mid - 1;
                }
            }
            return result;
        }

        private static int FindSecondOccurance(int[] nums, int target)
        {
            int firstIndex = 0;
            int lastIndex = nums.Length - 1;
            int result = -1;
            
            while (firstIndex <= lastIndex)
            {
                int mid = (firstIndex + lastIndex) / 2;
                if (nums[mid] == target)
                {
                    result = mid;
                    firstIndex = mid + 1;
                }
                else if (nums[mid] < target)
                {
                    firstIndex = mid + 1;
                }
                else
                {
                    lastIndex = mid - 1;
                }
            }
            return result;
        }
    }
}
