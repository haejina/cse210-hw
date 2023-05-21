using System;

class Program
{
    static void Main(string[] args)
    {
        Word word = new Word("hello");

        Scripture scripture = new Scripture();

        scripture.HideWords();
        scripture.Diaply();
    }
}