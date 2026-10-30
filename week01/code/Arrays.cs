
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// Creates an array containing multiples of a number.
    /// </summary>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array with the requested length.
        double[] multiples = new double[length];

        // Step 2: Loop through each position of the array.
        // Array indexes start at 0, not 1.
        for (int i = 0; i < length; i++)
        {
            // Step 3: Calculate the multiple using i + 1.
            // We add 1 because i starts at 0, and we want
            // the first multiple to be the original number.

            // Step 4: Store the calculated multiple
            // in the corresponding array position.
            multiples[i] = number * (i + 1);
        }

        // Step 5: Return the completed array.
        return multiples;
    }

    /// <summary>
    /// Rotates a list to the right by the specified amount.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Calculate the starting index.
        // Rotating to the right means moving the last
        // elements to the beginning of the list.
        // Subtract amount from data.Count to find
        // where the elements to move begin.
        int startIndex = data.Count - amount;

        // Step 2: Save the last elements temporarily.
        // GetRange selects the elements starting at
        // startIndex and takes the specified amount.
        List<int> lastElements = data.GetRange(startIndex, amount);

        // Step 3: Remove the selected elements
        // from their original positions in the list.
        data.RemoveRange(startIndex, amount);

        // Step 4: Insert the saved elements at index 0.
        // This moves them to the beginning while
        // keeping their original order.
        data.InsertRange(0, lastElements);
    }
}
