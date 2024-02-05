namespace LeetCode
{
    public class ListArraysProblems
    {
        public static int MaxArea(int[] height)
        {
            int result = 0;
            return result;
        }
        public static bool IsValidSudoku(char[][] board)
        {
            foreach (var item in board)
                foreach (var item2 in item)
                {

                }
            return true;
        }

        public static bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            {
                return false;
            }

            int rowCount = matrix.Length;
            int colCount = matrix[0].Length;

            int low = 0;
            int high = rowCount * colCount - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int midElement = matrix[mid / colCount][mid % colCount];
                Console.WriteLine("low " + low);
                Console.WriteLine("high " + high);
                Console.WriteLine("midElement " + midElement);
                Console.WriteLine("mid " + mid);
                Console.WriteLine("Iteration Complete");
                if (midElement == target)
                {
                    return true;
                }
                else if (midElement < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return false;
        }


        //public static bool SearchMatrix(int[][] matrix, int target)
        //{
        //    int colfirstIndex = 0;
        //    int rowfirstIndex = 0;
        //    int colMid= (colfirstIndex + matrix.Length)/2;
        //    int colMidFirst = matrix[colMid][0];
        //    int colMidLast = matrix[colMid][matrix.Length-1];
        //    return false;
        //}

        // very risky solution if the array does not contain duplicate elements
        public static int findDuplicate(int[] nums)
        {
            int slow = nums[0];
            int fast = nums[0];
            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            } while (slow != fast);

            fast = nums[0];
            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }
            return slow;
        }

    }
}
