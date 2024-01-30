// Code Challenge: Data comes in many formats. In this challenge you have to parse the individual "Order IDs", and output the "OrderIDs" sorted and tagged as "Error" if they aren't exactly four characters in length.

using System.Collections.Immutable;

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// Your code must produce the following output:
// A345
// B123
// B177
// B179
// C15     - Error
// C234
// C235
// G3003   - Error

string[] orderIds = orderStream.Split(",");
Array.Sort(orderIds);
foreach (string value in orderIds)
{
  if (value.Length != 4)
  {
    Console.WriteLine($"{value} \t -Error");
  }
  else
  {
    Console.WriteLine(value);
  }
}