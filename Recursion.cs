namespace LeetCode
{
    public class Recursion
    {
        public static int nthFibonacci(int n)
        {
            if(n <= 1) return n;
            return nthFibonacci(n-1) + nthFibonacci(n-2);
        }

        public static int nCr(int n, int r)
        {
            if(n==r || r==0) return 1;
            return nCr(n-1,r-1) + nCr(n-1,r);
        }

        public static long nCrAlt(int n, int r)
        {
            // n! / ((n-r)! * r!)
            if (n == r || r == 0) return 1;
            return Factorial(n) / (Factorial(n - r) * Factorial(r));
        }

        public static long Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

    }
}
