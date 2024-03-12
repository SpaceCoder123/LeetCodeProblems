namespace LeetCode
{
    public class SlidingWindow
    {
        //1652. Defuse the Bomb
        public static int[] Decrypt(int[] code, int k)
        {
            int n = code.Length;
            // base case
            int[] result = new int[n];

            if (k == 0)
                return result; // If k is 0, return an array of zeros.

            // sliding window setup
            int firstPointer = 0;
            if (k < 0)
            {
                for (int i = 0; i < n; i++)
                {
                    result[i] = WindowSumBackward(i, code, Math.Abs(k));
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    firstPointer += i;
                    int secondPointer = (k + i) % n;
                    result[i] = WindowSumForward(i, secondPointer, code, n);
                }
            }
            return result;
        }
        private static int WindowSumForward(int firstPointer, int secondPointer, int[] arr, int totalLength)
        {
            int count = 0;
            for (int i = 0; i < totalLength; i++)
            {
                if (firstPointer > secondPointer)
                {
                    if (i > firstPointer)
                        count += arr[i];
                    else if (i <= secondPointer)
                        count += arr[i];
                }
                else if (i > firstPointer && i <= secondPointer)
                    count += arr[i];
            }
            return count;
        }

        private static int WindowSumBackward(int firstPointer, int[] arr, int k)
        {
            int sum = 0;
            for (int i = firstPointer; i > firstPointer - k; i--)
            {
                int index = ((i % arr.Length + arr.Length) - 1) % arr.Length;
                sum += arr[index];
            }
            return sum;
        }

        //2490. Circular Sentence
        public static bool IsCircularSentence(string sentence)
        {
            string[] wordList = sentence.Split(" ");
            int n = wordList.Length;
            char firstCharacter = wordList.FirstOrDefault().FirstOrDefault();
            bool flag = true;
            if (n == 1)
            {
                flag = WordChecker(firstCharacter, wordList.FirstOrDefault().LastOrDefault()) ? true : false;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (flag == false)
                    {
                        break;
                    }
                    if (i == n - 1)
                    {
                        flag = WordChecker(firstCharacter, wordList.LastOrDefault().LastOrDefault()) ? true : false;
                    }
                    else
                    {
                        flag = WordChecker(wordList[i].LastOrDefault(), wordList[i + 1].FirstOrDefault()) ? true : false;
                    }
                }
            }

            return flag;
        }
        private static bool WordChecker(char a, char b)
        {
            return a == b;
        }

        //1343. Number of Sub-arrays of Size K and Average Greater than or Equal to Threshold
        public static int NumOfSubarrays(int[] arr, int k, int threshold)
        {
            int firstPointer = 0;
            int secondPointer = k-1;
            int count = 0;
            while (secondPointer != arr.Length)
            {
                count += CheckAverage(arr, k, threshold, firstPointer, secondPointer);
                secondPointer++;
                firstPointer++;
            }
            return count;

        }

        public static int CheckAverage(int[] arr, int k, int threshold, int firstPointer, int secondPointer)
        {
            int count = 0;
            while (firstPointer <= secondPointer)
            {
                count += arr[firstPointer];
                firstPointer++;
            }
            double sum = count / k; ;
            if (sum >= threshold) return 1;
            return 0;
        }
    }
}


