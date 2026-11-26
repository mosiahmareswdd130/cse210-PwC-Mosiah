using System;
using ScriptureMemorizer;

var library =  new ScriptureLibrary();
var scripture = library.GetRandomScripture();

while (true)
{
    //Console.Clear();
    Console.WriteLine(scripture.GetDisplayText());
    Console.WriteLine();

    if (scripture.IsFullyHidden)
    {
        Console.WriteLine("Great work! You've hidden all the words. Keep killing it!");
        break;
    }

    Console.WriteLine("Press enter to hide more words, or type 'quit' to exit: ");
    string input = Console.ReadLine();

    if (input?.Trim().ToLower() == "quit")
        break;

    scripture.HideRandomWords();
}