# StringUnicodeDecoding

## About

This library oriented on convert strings (example: "\u0048\u0065\u006c\u006c\u006f\u0020\u0077\u006f\u0072\u006c\u0064\u0021") to readable for human format.

## Usage

To convert string with unicodes to readable format you must include using: ```using StringUnicodeDecode```.
<br/>Now you can call the method-extension of string:<br/>
```C#
using StringUnicodeDecode;

string input = @"\u0048\u0065\u006c\u006c\u006f";

string result = input.DecodeUnicodes();

// result: "Hello"
```