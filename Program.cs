// // Code Challenge
// Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. You write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". This will be used by the fraud team to investigate further.
// Declare an array and initialize it to contain the following elements:
// B123
// C234
// A345
// C15
// B177
// G3003
// C235
// B179

string[] orderId = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// Create a foreach statement to iterate through each element of your array.
// You need to evaluate each element of the array. Report the potentially fraudulent Order IDs by detecting the orders that start with the letter "B". To determine whether or not an element starts with the letter "B", use the String.StartsWith() method.

foreach (string id in orderId)
{
  if (id.StartsWith('B'))
  {
    Console.WriteLine(id);
  }
};