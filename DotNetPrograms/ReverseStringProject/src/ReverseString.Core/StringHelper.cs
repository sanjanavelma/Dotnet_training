namespace ReverseString.Core;

public class StringHelper
{
    public string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
            throw new Exception("Invalid string");

        char[] arr = input.ToCharArray();
        Array.Reverse(arr);

        return new string(arr);
    }
}
