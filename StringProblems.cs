using System.Data.SqlTypes;

namespace LeetCode
{
    public class StringProblems
    {
        //https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
        //status : accepted.
        public static int StrStr(string haystack, string needle)
        {
            int result = -1;
            if (haystack.Length < needle.Length) return result;
            for (int i = 0; i< haystack.Length; i++) 
            {
                if (haystack[i] == needle.FirstOrDefault())
                {
                    if(CheckSubstring(i, haystack, needle))
                    {
                        return i;
                    }
                }

            }
            return result;
        }
        private static bool CheckSubstring(int startIndex, string word, string substring)
        {
            if ((word.Length - startIndex) < substring.Length) return false;
            for (int i = 0; i < substring.Length; i++)
            {
                if (word[startIndex] != substring[i])
                {
                    return false;
                }
                else
                {
                    startIndex++;
                    continue;
                }
            }
            return true;
        }
    }
}
