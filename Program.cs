decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

// you use the casting operator () to surround a data type, then place it next to the variable you want to convert
int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

// number to string
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

// string to int
string firstFirst = "5";
string secondSecond = "7";
int sum = int.Parse(firstFirst) + int.Parse(secondSecond);
Console.WriteLine(sum);

// using Convert class
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

// casting vs converting
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value3 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value3);