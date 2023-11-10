using Codility_StoneWall;

namespace Codility_StoneWallTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestExample()
        {
            // Arrange
            Solution solution = new Solution();
            int[] H = { 8, 8, 5, 7, 9, 8, 7, 4, 8 };

            // Act
            int result = solution.solution(H);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void TestMinimumInput()
        {
            // Arrange
            Solution solution = new Solution();
            int[] H = { 1 };

            // Act
            int result = solution.solution(H);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestMaximumInput()
        {
            // Arrange
            Solution solution = new Solution();
            int[] H = new int[100000];
            for (int i = 0; i < 100000; i++)
               H[i] = 1000000000;
            
            // Act
            int result = solution.solution(H);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestRandomInput()
        {
            // Arrange
            Solution solution = new Solution();
            int[] H = { 3, 1, 4, 2, 2, 1, 5, 1, 2, 2, 4 };

            // Act
            int result = solution.solution(H);

            // Assert
            Assert.Equal(7, result);
        }
    }
}