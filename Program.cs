// Array code challenge Write code to reverse each word in a message

string pangram = "The quick brown fox jumps over the lazy dog";

// expected output: ehT kciuq nworb xof spmuj revo eht yzal god

string[] soloWords;
soloWords = pangram.Split(" ");
string[] newSoloWords = new string[soloWords.Length];
for (int i = 0; i < soloWords.Length; i++)
{
  char[] letters = soloWords[i].ToCharArray();
  Array.Reverse(letters);
  newSoloWords[i] = new string(letters);
}

string result = String.Join(" ", newSoloWords);
Console.WriteLine(result);