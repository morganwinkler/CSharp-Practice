﻿// will output a random number from 1-6
// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// returns the larger of two numbers
// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//   if ((roll1 == roll2) && (roll2 == roll3))
//   {
//     Console.WriteLine("You rolled triples!  +6 bonus to total!");
//     total += 6;
//   }
//   else
//   {
//     Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//     total += 2;
//   }
// }
// Console.WriteLine(total);
// if (total >= 15)
// {
//   Console.WriteLine("You win!");
// }
// else
// {
//   Console.WriteLine("Sorry, you lose.");
// }


Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

Console.WriteLine(daysUntilExpiration);
if (daysUntilExpiration == 0)
{
  Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
  Console.WriteLine("Your subscription expires within a day!");
  discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
  Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
  discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
  Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
  Console.WriteLine($"Renew now and save {discountPercentage}%.");
}