using System.Text.RegularExpressions;

namespace StringUnicodeDecode;

public static class StringExtensions
{
    public static string DecodeUnicodes(this string source)
    {
        return Regex.Replace(source, @"\\u([0-9a-fA-F]{4})", match => 
        {
            string hex = match.Groups[1].Value;
            return ((char)Convert.ToInt32(hex, 16)).ToString();
        });
    }
}