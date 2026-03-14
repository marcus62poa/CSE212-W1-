
using System;
using System.Collections.Generic;

public static class Arrays
{
    ///<summary>
    ///This function will create an array of 'number' and contains 'length' multiples.
    /// </summary>
    public static double[] MultiplesOf(double number, int length)
    {
        // --- PLAN ---
        // 1 Initialize a new double array called 'results' with the size of 'length'.
        // 2Loop through each index from 0 to length - 1.
        // 3 For each index 'i', calculate the multiple by multiplying 'number' by (i + 1).
        // 4Assign the calculated value to the current index in the 'results' array.
        //5Return the completed 'results' array.

        double[] results = new double[length];

        for (int i = 0; i < length; i++)
        {
            results[i] = number * (i + 1);
        }

        return results;
    }

    ///<summary>
    /// This function will rotate a list to the right by a specified amount.
    ///</summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // --- PLAN ---
        //1Check if the list has data and the amount is greater than 0 to avoid errors.
        // 2Determine the starting position of the slice by subtracting 'amount' from the total count.
        // 3Use GetRange to capture the last 'amount' elements from the list into a temporary list.
        //4 Remove those same elements from their original position at the end of the list using RemoveRange.
        // 5Insert the temporary list at the beginning (index 0) of the original list using InsertRange.

        if (data.Count > 0 && amount > 0)
        {
            int splitIndex = data.Count - amount;
            List<int> suffix = data.GetRange(splitIndex, amount);

            data.RemoveRange(splitIndex, amount);
            data.InsertRange(0, suffix);
        }
    }
}