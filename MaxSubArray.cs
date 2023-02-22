

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = Console.Re
        int[]
        Console.WriteLine ("Hello Mono World");
    }
    public static int maxSumSubarray(int[] arr, int n){
        // -1 2 3 4 -90 -80 1 56 90
        int currentSum = Math.Minimum;
        int maxSum = Math.Minimum;
        for(int i = 0;i < arr.Length;i++){
            if(arr[i] > 0){
                currentSum += arr[i];
                maxSum = currentSum;
            }else{
                currentSum = Math.Minimum;
                maxSum = currentSum;
            }
            return maxSum;
        } 
    }
}
