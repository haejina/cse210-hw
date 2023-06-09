using System;
using System.IO;
using System.Windows.Input;
class Scripture
{
    private string _reference;
    private string _text;
    List<Word> scripture = new List<Word>();
    string[] allScriptures;

    Random random = new Random();


    public Scripture() //The "Word" class constructor
    {
        allScriptures = System.IO.File.ReadAllLines("scriptures.txt");
        int index = random.Next(allScriptures.Count());
        string randscripture = allScriptures[index];

        string[] parts1 = randscripture.Split("|"); // split the refrences and the verse
        _reference = parts1[0];
        string[] parts2 = parts1[1].Split(" "); // split the word by space

        foreach(string part in parts2)
        {
            scripture.Add(new Word(part));
        }

    }
    public void Display()
    {
        foreach(Word word in scripture)
        {
            word.Display();
        }
    }
    public void SetReference(string reference) // to be able to track reference 
    {
        _reference = reference;
    }

    public string GetReference() // to be able to track reference 
    {
        return _reference;
    }
    public void SetText(string text) // to be able to track text
    {
        _text = text;
    }

    public string GetText() // to be able to track text
    {
        return _text;
    }

    public void HideRandomWord() // Hide rnadome words in the scripture
    {
        List<Word> hidddenWords = new List<Word>();

        foreach(Word word in scripture)
        {
            if(!word.IsHidden())
            {
               hidddenWords.Add(word);
            }
            
        }
        if (hidddenWords.Count == 0)
        {
            return;
        }
        int randomIndex = random.Next(hidddenWords.Count);
        scripture[scripture.IndexOf(hidddenWords[randomIndex])].Hide();


    }
    public bool HideAllWords() // Check if the words are all hidden
    {
        foreach (Word word in scripture)
        {
            if (!word.IsHidden())
            {
               return false; // if the word is not hidden completely, it's false
            }
        }
        return true;
    }
}