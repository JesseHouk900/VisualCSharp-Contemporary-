/*/////////////////////////////////////////////////////////////////////////////
Jesse Houk:    Assignment 2:    Dr. Stringfellow:    4143

Problem: Get 3 integers from the user and display the sum, average, smalles, and largest
	numbers.

/////////////////////////////////////////////////////////////////////////////*/


using System;

class NumberCrunch {
    static void Main(string [] args) {
		// sum, average, smallest, largest are all nullable integers
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
	// Take in a integer array with its size and return a nullable integer
	// Function will sum the elements in an array and return the sum
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
	// Take in a nullable s, representing the sum, and a size variable that
		// will divide the sum. Return type can be null, but otherwise
		// represents the average of the elements from some array.
    static int? Average(int? s, int size) {
        if (size > 0 && s != null) {
            return s / size;
        }
        else return null;
    }
	// Take in an array of integers with a size and return a nullable value
		// that should be the smallest integer in the array
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
	// Take in an array and its size and return a nullable integer value.
		// The return element represents the largest value in the array
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
	// A print function that helps pring variable data. Pass in the name
		// of the variable and an associated, nullable value. If the integer
		// is null, print ERROR
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