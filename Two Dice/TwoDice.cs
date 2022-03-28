using System;
using System.Collections.Generic;
using System.Linq;

namespace Two_Dice
{
 
public class TwoDice
{

    public static void Main()
    {
        // Declaring the empty list to split the input so i have tow integers to convert from string to int.
        string[] Inputs;
        // Splits input
        Inputs = Console.ReadLine().Split(" ");
        // Converts to int.
        int N = Convert.ToInt32(Inputs[0]);
        int M = Convert.ToInt32(Inputs[1]);

        TwoDice easy = new TwoDice();
        // Using my method.
        int[] answer = easy.Calculation(N, M);
        // Printing each value on a new line.
        Array.ForEach(answer, Console.WriteLine);

    }
    // This will be my calculation class that i will call in main.
    public int[] Calculation(int N, int M)
    {
        // There will always be N times M amount of sums. For array size
        int[] Sums = new int[N * M];

        // Counter that i will use to add each sum to the array.
        int index = 0;

        for (int i = 1; i < (N + 1); i++)
        {
            for (int j = 1; j < (M + 1); j++)
            {
                var sum = i + j;
                Sums[index] = sum;
                index++;
            }

        }
        // Creating a dictionary to store each sum and its count!
        var dict = new Dictionary<int, int>();

        // This will go through my Sums array and count how many times an element appears
        foreach (var element in Sums)
        {
            if (dict.ContainsKey(element))
                dict[element]++;
            else
                dict[element] = 1;
        }

        // A list of all the most probable outcomes
        List<int> MostProbableOutcomes = new List<int>();
        // Getting the max value of my dictionary
        var Max_Value = dict.Values.Max();

        // Goes through each KeyValuePair
        foreach (KeyValuePair<int, int> entry in dict)
        {
            // If the Value of the key is equal to the Max value of the dictionary. 
            if (entry.Value == Max_Value)
            {
                // Then add it to the MostprobableOutcomes list!
                MostProbableOutcomes.Add(entry.Key);
            }
        }

        return MostProbableOutcomes.ToArray();
    }

}


}