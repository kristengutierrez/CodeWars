/*
Given the triangle of consecutive odd numbers:
             1
          3     5
       7     9    11
   13    15    17    19
21    23    25    27    29
...
Calculate the row sums of this triangle from the row index (starting at index 1) e.g.:
rowSumOddNumbers(1); // 1
rowSumOddNumbers(2); // 3 + 5 = 8
*/

using System;
public static class Kata
{
  public static long rowSumOddNumbers(long row)
  {
    long sum = 0;
    for (long i = firstNinRow(row); i < firstNinRow(row) + row; i++)
      sum += numberFromIndex(i);
      
    return sum;
  }
  
  // Returns the first index in a row of the triangle
  // Index can be used to compute the numerical value of the first number in the row
  public static long firstNinRow(long rowNumber)
  {
    return (rowNumber * (rowNumber - 1))/2 + 1;
  }
  
  // Returns the indexTH odd number
  public static long numberFromIndex(long index)
  {
    return 2*index - 1;
  }
}