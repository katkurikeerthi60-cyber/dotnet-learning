string paragraph = "C# is powerful. C# is simple. C# is powerful and simple.";

string[] words = paragraph
    .ToLower()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

List<string> wordList = new List<string>(words);
HashSet<string> uniqueWords = new HashSet<string>(words);

Console.WriteLine($"Total words: {wordList.Count}");
Console.WriteLine($"Unique words: {uniqueWords.Count}");

Dictionary<string, int> wordCounts = new Dictionary<string, int>();

foreach (string word in words)
{
    string cleanWord = word.Trim('.', ',', '!', '?', ';', ':');

    if (wordCounts.ContainsKey(cleanWord))
    {
        wordCounts[cleanWord]++;
    }
    else
    {
        wordCounts[cleanWord] = 1;
    }
}

Console.WriteLine("\nWord Counts - Descending:");

foreach (var item in wordCounts.OrderByDescending(x => x.Value))
{
    Console.WriteLine($"{item.Key} = {item.Value}");
}