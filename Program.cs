using System;
using System.Collections.Generic;
public class Solution
{
    public static void Main()

    {
        //Question-1
        Console.WriteLine("Write a word");
        string Word = Console.ReadLine();
        Solution Sol = new Solution();
        string Letters = Sol.RemoveVowels(Word);
        Console.WriteLine(Letters);

        //Question-2
        string Input1 = Console.ReadLine();
        string Input2 = Console.ReadLine();
        string[] bulls_string1 = Input1.Split(' ');
        string[] bulls_string2 = Input2.Split(' ');
        //Solution Sol = new Solution();
        bool Result = Sol.ArrayStringsAreEqual(bulls_string1, bulls_string2);
        Console.WriteLine(Result);

        //Question-3
        string Input3 = Console.ReadLine();
        int[] Value = Array.ConvertAll(Input3.Split(','), int.Parse);
        //Solution Sol = new Solution();
        int sum = Sol.SumOfUnique(Value);
        Console.WriteLine(sum);

        //Question-4
        int[][] bulls_grid = new int[3][];
        bulls_grid[0] = new int[] { 1, 2, 3 };
        bulls_grid[1] = new int[] { 4, 5, 6 };
        bulls_grid[2] = new int[] { 7, 8, 9 };

        //Solution Sol = new Solution();
        int sum1 = Sol.DiagonalSum(bulls_grid);
        Console.WriteLine(sum1);


        //Question-5


        string bulls_string = Console.ReadLine();
        string value = Console.ReadLine();
        int[] indices = Array.ConvertAll(value.Split(','), int.Parse);

        // Solution Sol = new Solution();
        if (bulls_string.Length == indices.Length)
        {
            string word1 = Sol.RestoreString(bulls_string, indices);
            Console.WriteLine(word1);
        }
        else
        {
            Console.WriteLine("String and indices should be of same length");
        }
    


    //Question-6
    string bulls_string3 = Console.ReadLine();
    char ch = Console.ReadLine()[0];

    //Solution Sol = new Solution();
    string word = Sol.ReversePrefix(bulls_string3, ch);
    Console.WriteLine(word);




    }
    // Question-1 check for vowel aeiou continue if it exist otherwise add to the string .
    public string RemoveVowels(string s)
    {
        string Result = "";

        foreach (char c in s)
        {
            if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' || c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                continue;
            }
            Result += c;

        }
        return Result;
    }

    //Question-2 loop the string array and add it to the string then convert it into upper case and compare, if equal return true
    public bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
    {
        string Input1 = "";
        string Input2 = "";
        foreach (string word in bulls_string1)
        {
            Input1 += word;
        }
        foreach (string word in bulls_string2)
        {
            Input2 += word;
        }
        if (Input1.ToUpper() == Input2.ToUpper())
        {
            return true;

        }
        return false;
    }

    //Question-3 form a dictionary with key as int[] and value as 1 the value will increase if the key is duplicate
    //loop through dictionary and check if key is 1 and add those numbers.

    public int SumOfUnique(int[] bull_bucks)
    {
        try
        {


            Dictionary<int, int> Dict = new Dictionary<int, int>();
            int sum = 0;

            for (int i = 0; i <= bull_bucks.Length - 1; i++)
            {

                if (Dict.ContainsKey(bull_bucks[i]))
                {
                    Dict[bull_bucks[i]] = Dict[bull_bucks[i]] + 1;

                }
                else
                {
                    Dict.Add(bull_bucks[i], 1);
                }


            }
            foreach (KeyValuePair<int, int> entry in Dict)
            {
                if (entry.Value == 1)
                {
                    sum += entry.Key;
                }
            }
            return sum;

        }
        catch
        {
            Console.WriteLine("Please Enter An Integer Number");
            return 0;
        }
    }

    //Question-4 if the matrix length is odd the middle element is in primary and secondary diagonal, add the element once

    public int DiagonalSum(int[][] bulls_grid)
    {
        int sum = 0, n = bulls_grid.Length;

        for (int i = 0; i < n; i++)
        {
            sum += bulls_grid[i][i] + bulls_grid[i][n - 1 - i];
        }

        return n % 2 == 0 ? sum : sum - bulls_grid[n / 2][n / 2];
    }

    //Question-5 itterate indices and place it into a new array,move each character in s to the index[i] in the final string
    public string RestoreString(string s, int[] indices)
    {

        var sCharArray = s.ToCharArray();
        for (int i = 0; i < s.Length; i++)
        {
            sCharArray[indices[i]] = s[i];

        }

        return new String(sCharArray);
    }
    //Question-6
    //Loop through the string and find the index of ch  divide into substring then reverse the first substring and append with the second.
    public string ReversePrefix(string bulls_string, char ch)
    {
        int index = 0;
        char[] chars = bulls_string.ToCharArray();
        string value = "";
        foreach (char s in bulls_string)
        {
            if (s == ch)
            {
                index = bulls_string.IndexOf(s);
                break;
            }
        }
        
        
            
                string word1 = bulls_string.Substring(0, index + 1);
                string word2 = bulls_string.Substring(index + 1, bulls_string.Length - (index + 1));

                string reversestring = "";
                int length;

                length = word1.Length - 1;

                while (length >= 0)
                {
                    reversestring = reversestring + word1[length];
                    length--;
                }
                ;

                value = reversestring + word2;




            


        
        return value;
    }

}








