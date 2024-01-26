// will output a random number from 1-6
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

// returns the larger of two numbers
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);