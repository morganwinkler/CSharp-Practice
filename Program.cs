// data conversion code challenge

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// Create a looping structure that can be used to iterate through each string value in the array values.
// Rule 1: If the value is alphabetical, concatenate it to form a message.

// Rule 2: If the value is numeric, add it to the total.

// Rule 3: The result should match the following output:

decimal total = 0m;
string message = "";

foreach (string value in values)
{
  decimal number; // stores the TryParse "out" value
  if (decimal.TryParse(value, out number))
  {
    total += number;
  }
  else
  {
    message += value;
  }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");