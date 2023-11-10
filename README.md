# Codility-StoneWall
You are going to build a stone wall.</br>
The wall should be straight and N meters long, and its thickness should be constant;</br> 
however, it should have different heights in different places.</br> 
The height of the wall is specified by an array H of N positive integers.</br> 
H[I] is the height of the wall from I to I+1 meters to the right of its left end.</br> 
In particular, H[0] is the height of the wall's left end and H[N−1] is the height of the wall's right end.</br>
The wall should be built of cuboid stone blocks (that is, all sides of such blocks are rectangular).</br> 
Your task is to compute the minimum number of blocks needed to build the wall.

Write a function:</br>
class Solution { public int solution(int[] H); }</br>
that, given an array H of N positive integers specifying the height of the wall,</br> 
returns the minimum number of blocks needed to build it.

For example, given array H containing N = 9 integers:</br>
H[0] = 8    H[1] = 8    H[2] = 5</br>
H[3] = 7    H[4] = 9    H[5] = 8</br>
H[6] = 7    H[7] = 4    H[8] = 8</br>
the function should return 7.</br> 
The figure shows one possible arrangement of seven blocks.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [1..100,000];</br>
each element of array H is an integer within the range [1..1,000,000,000].
