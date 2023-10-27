using System;

public class SquaredArray
{
    public int[] Array;

    public SquaredArray(int size)
    {
        Array = new int[size];
    }

    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= Array.Length)
            {
                throw new IndexOutOfRangeException("The index is outside the range of the array");
            }
            return Array[index];
        }
        set
        {
            if (index < 0 || index >= Array.Length)
            {
                throw new IndexOutOfRangeException("The index is outside the range of the array");
            }
            Array[index] = value * value; 
        }
    }
}

class App
{
    static void Main()
    {
        int size = 5;
        SquaredArray squaredArray = new SquaredArray(size);

        for (int i = 0; i < size; i++)
        {
            squaredArray[i] = i + 1;
        }

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Element {i}: {squaredArray[i]}");
        }
        Console.ReadKey();
    }
}