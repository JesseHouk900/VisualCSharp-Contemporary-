/*/////////////////////////////////////////////////////////////////////////////
Jesse Houk:    Assignment 2:    Dr. Stringfellow:    4143

Get 3 integers from the user and display the sum, average, smalles, and largest numbers.

/////////////////////////////////////////////////////////////////////////////*/


using System;

class NumberCrunch {
    static void Main(string [] args) {
        int? sum, average, smallest, largest;
        int [] nums = new int [3];
        Console.WriteLine("Please enter 3 numbers");
        for (int i = 0; i < 3; i++) {
            nums[i] = Int32.Parse(Console.ReadLine());

        }
        sum = Sum(nums, 3);
        Print("Sum", sum);
        average = Average(sum, 3);
        Print("Average", average);
        smallest = Smallest(nums, 3);
        Print("Smallest", smallest);
        largest = Largest(nums, 3);
        Print("Largest", largest);
    }

    static int? Sum(int [] v, int size) {
        if (size > 0) {
            int s = 0;
            for (int i = 0; i < size; i++) {
                s += v[i];
            }
            return s;
        }
        else return null;
    }
    static int? Average(int? s, int size) {
        if (size > 0 && s != null) {
            return s / size;
        }
        else return null;
    }
    static int? Smallest(int [] v, int size) {
        int s;
        if (size > 0) {
            s = v[0];
        for (int i = 1; i < size; i++) {
            if (v[i] < s) {
                s = v[i];
            }
        }
        return s;
        }
        else return null;
    }
    static int? Largest(int [] v, int size) {
        int l;
        if (size > 0) {
            l = v[0];
        for (int i = 1; i < size; i++) {
            if (v[i] > l) {
                l = v[i];
            }
        }
        return l;
        }
        else return null;
    }
    static void Print(string message, int? n) {
        Console.Write(message);
        Console.Write(": ");
        if (n != null) {
            Console.WriteLine(n);
        }
        else {
            Console.WriteLine("ERROR");
        }
    }
}