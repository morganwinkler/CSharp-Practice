string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}

string[] palletsTwo = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {palletsTwo[0]}");
Array.Clear(palletsTwo, 0, 2);
Console.WriteLine($"After: {palletsTwo[0]}");
Console.WriteLine($"Clearing 2 ... count: {palletsTwo.Length}");
foreach (var pallet in palletsTwo)
{
  Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");
// method to create a new array with a different size and copy the elements from the original array to the new one
Array.Resize(ref palletsTwo, 6);
Console.WriteLine($"Resizing 6 ... count: {palletsTwo.Length}");

palletsTwo[4] = "C01";
palletsTwo[5] = "C02";

foreach (var pallet in palletsTwo)
{
  Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref palletsTwo, 3);
Console.WriteLine($"Resizing 3 ... count: {palletsTwo.Length}");

foreach (var pallet in palletsTwo)
{
  Console.WriteLine($"-- {pallet}");
}

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

string valueNew = "abc123";
char[] valueNewArray = valueNew.ToCharArray();
Array.Reverse(valueNewArray);
// string result = new string(valueNewArray);
string resultNew = String.Join(",", valueNewArray);
Console.WriteLine(resultNew);

string[] items = resultNew.Split(',');
foreach (string item in items)
{
  Console.WriteLine(item);
}