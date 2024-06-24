Dictionary<char, string> letters = new Dictionary<char, string>();
letters.Add('a', "première lettre de l'alphabet");
letters.Add('b', "deuxème lettre de l'alphabet");
letters.Add('c', "troisième lettre de l'alphabet");

Console.WriteLine("Dictionary:");
foreach (var letter in letters) {
    Console.WriteLine($"Key: {letter.Key}; Value: {letter.Value}");
}

letters.Remove('c');

Console.WriteLine("\nDictionary après remove lettre C:");
foreach (var letter in letters) {
    Console.WriteLine($"Key: {letter.Key}; Value: {letter.Value}");
}