using System;
using System.Collections.Generic;
public class Solution{
  public static int CountValidWays(int[] desk){
    int k = desk[0];
    HashSet<int> occupiedDesk = new HashSet<int>(desk[1..]);
    int validPairs = 0;
    for(int i = 1; i < k; i++){
      if(!occupiedDesk.Contains(i) && !occupiedDesk.Contains(i+1)){
        validPairs++;
      }
    }
    return validPairs;
  }

  public static string TransformAnswer(int result){
    string challengeToken = "46arkmwb91";
    string finalString = result.ToString() + challengeToken;
    char[] charArray = finalString.ToCharArray();
    for(int i=3; i<charArray.Length; i+=4){
      charArray[i] = '_';
    }
    return new string(charArray);
  }
  public static void Main(string[] args){
    int[] input1 = {6, 4};
    int result1 = CountValidWays(input1);
    string finalResult1 = TransformAnswer(result1);
    Console.WriteLine($"Output: {finalResult1}");  

    int[] input2 = {8, 1, 8, 1};  
    int result2 = CountValidWays(input2);
    string finalResult2 = TransformAnswer(result2);
    Console.WriteLine($"Output: {finalResult2}"); 

  }
}