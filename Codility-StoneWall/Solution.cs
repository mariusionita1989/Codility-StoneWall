using System.Runtime.CompilerServices;

namespace Codility_StoneWall
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] H)
        {
            int N = H.Length;
            int result = 0;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                Stack<int> stack = new Stack<int>();
                for (int i = 0; i < N; i++)
                {
                    while (stack.Count > 0 && stack.Peek() > H[i])
                        stack.Pop();

                    if (stack.Count == 0 || stack.Peek() < H[i])
                    {
                        stack.Push(H[i]);
                        result++;
                    }
                }
            }
            
            return result;
        }
    }
}
