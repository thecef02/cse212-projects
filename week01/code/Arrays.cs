public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        //Plan:
        // 1) Create a new array double with size = lenght. We will call it multiples.
        // 2) For each position of i from 0 to lenght - 1,
            // var i, will be the index of the list.
            // append to list multiples with index i the value of number * (i + 1).
        // 3) return the filled list.
        
        double[] multiples = new double[length];    // New list double
        for (int i = 0; i < length; i++)            // loop 'lenght' amount of times.
        {
            multiples[i] = number * (i + 1);        // i is the index of the list, we assignd the value on each iteration.
        }
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Plan:
        // 1) Get the amount of item in the list. n = data.Count.
        // 2) Make sure amount is not = n, this will not perform a rotation.
        // 3) Get the last 'amount' of elements from tail of list.
        // 4) Remove the tail from the end.
        // 5) Insert the tail elements at the beginning of the list.
        // 6) List is rotated.
        int n = data.Count;                 // Step 1.
        amount = amount % n;        
        if (amount == 0) return;            // Step 2.

        List<int> tail = data.GetRange(n - amount, amount);     // Get the 'amount' elements from List tail.
        data.RemoveRange(n - amount, amount);                   // Remove the tail elements from List.
        data.InsertRange(0, tail);                              // Insert tail elements at index 0.
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}
