using System;
using System.Collections.Generic;
using System.IO;

public class ScriptureLoader
{
    public List<Scripture> LoadScripturesFromFile(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Error: File not found.");
            return scriptures;
        }

        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length != 2)
            {
                Console.WriteLine($"Skipping invalid line: {line}");
                continue;
            }

            string referenceText = parts[0].Trim();
            string scriptureText = parts[1].Trim();

  
            int lastSpaceIndex = referenceText.LastIndexOf(' ');
            if (lastSpaceIndex == -1)
            {
                Console.WriteLine($"Error: Invalid reference format in '{referenceText}'");
                continue;
            }

            string book = referenceText.Substring(0, lastSpaceIndex);
            string chapterVerseText = referenceText.Substring(lastSpaceIndex + 1);

            string[] chapterVerseParts = chapterVerseText.Split(':');
            if (chapterVerseParts.Length != 2 || !int.TryParse(chapterVerseParts[0], out int chapter))
            {
                Console.WriteLine($"Error: Invalid chapter format in '{referenceText}'");
                continue;
            }

            string[] verseParts = chapterVerseParts[1].Split('-');
            if (!int.TryParse(verseParts[0], out int startVerse))
            {
                Console.WriteLine($"Error: Invalid start verse in '{referenceText}'");
                continue;
            }

            int endVerse = startVerse;
            if (verseParts.Length > 1 && int.TryParse(verseParts[1], out int tempEnd))
            {
                endVerse = tempEnd;
            }

            Reference reference = new Reference(book, chapter, startVerse, endVerse);
            scriptures.Add(new Scripture(reference, scriptureText));
        }

        return scriptures;
    }
}
