// will output a random number from 1-6
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


// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// Console.WriteLine(daysUntilExpiration);
// if (daysUntilExpiration == 0)
// {
//   Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//   Console.WriteLine("Your subscription expires within a day!");
//   discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//   Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//   discountPercentage = 10;
// }
// else if (daysUntilExpiration <= 10)
// {
//   Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0)
// {
//   Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }

using System.Globalization;

string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// or initialize at declaration
// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
  Console.WriteLine(name);
}

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int num in inventory)
{
  sum += num;
}
Console.WriteLine($"Sum: {sum}");