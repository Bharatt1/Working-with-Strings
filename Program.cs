﻿/*
    Author: Clinton Daniel
    Date: 9/18/2019
    Comments: This C# Console application code demonstrates the various
    methods in which you can manipulate strings. This may be useful for
    a variety of use cases when you are working with data. 
*/

using System;

namespace strings
{
    class Program
    {
        // change 1 for sync
        static void Main(string[] args)
        {
            Console.Write("Type a string and press Enter: ");
            string input = Console.ReadLine();

            // Define Substring position and length
            int get_substring = 2;
            int get_length = 3;
            // Define index
            string get_index = "i";
            string get_multiple_index = "ton";

            // Using Substring()
            string partial_input = input.Substring(get_substring);
            string partial_input_with_length = input.Substring(get_substring, get_length);

            Console.WriteLine("Extract the first " + get_substring + " characters: " + partial_input);
            Console.WriteLine("Extract the first " + get_substring + " characters for length " + get_length + " : " + partial_input_with_length);

            // Using IndexOf()
            int string_position = input.IndexOf(get_index);
            int string_multiple_position = input.IndexOf(get_multiple_index);

            Console.WriteLine("String " + get_index + " position is: " + string_position);
            Console.WriteLine("The String " + get_multiple_index + " starts at position: " + string_multiple_position);

            // Using Contains()
            Console.WriteLine("Does the string " + input + " contain " + get_multiple_index + " : " + input.Contains(get_multiple_index));

            // Using StartsWith() and EndsWith()
            Console.WriteLine("Does the string " + input + " start with " + get_multiple_index + " : " + input.StartsWith(get_multiple_index));
            Console.WriteLine("Does the string " + input + " end with " + get_multiple_index + " : " + input.EndsWith(get_multiple_index));

            // Using Remove() and Insert()
            Console.WriteLine("Remove the rest of the string starting with position " + get_substring + " : " + input.Remove(get_substring));
            Console.WriteLine("Remove the rest of the string starting with position " + get_substring + " for length " + get_length + " : " + input.Remove(get_substring, get_length));
            Console.WriteLine("Insert " + get_index + " into the string at position 6 : " + input.Insert(6, get_index));

            // Using ToLower() and ToUpper()
            Console.WriteLine("All upper case: " + input.ToUpper());
            Console.WriteLine("All lower case: " + input.ToLower());

            // String in Columns
            string make_columns = "_________________________________________\n\"First_Name\"\t\"Middle_Init\"\t\"Last_Name\"\n_________________________________________\n";

            Console.WriteLine(make_columns);

            // String in Rows
            string make_row1 = "Clinton\t\tE\t\tDaniel\r";
            string make_row2 = "Christopher\tL\t\tDaniel\r";
            string make_row3 = "Carl\t\tA\t\tDaniel\r\n_________________________________________";
            Console.WriteLine(make_row1);
            Console.WriteLine(make_row2);
            Console.WriteLine(make_row3);
        }
    }
}
