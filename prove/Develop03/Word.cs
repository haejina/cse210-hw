using System;

class Word
{
   private string _text;
   private bool _isHidden = false;

   public Word(string text)  //The "Word" class constructor
   {
      _text = text;
   }

   public void Hide()
   {
      _isHidden = true;
   }
   public void Show()
   {
      _isHidden = false;
   }
   public void Display()
   {
     if(!_isHidden)
     {
       Console.Write($" {_text}");
     }
     else
     {
        string wordsinScripture = "";
        for (int i = 0; i < _text.Length; i++)
        {
            wordsinScripture += "_";
        }
        Console.Write($" {wordsinScripture}");
     }
   }
   public bool IsHidden() // retrun current hidden word
   {
      return _isHidden;
   }
   public void SetHidden(bool isHidden)
   {
       _isHidden = isHidden;
   }
   public bool GetHidden()
   {
      return _isHidden;
   }   
   

}
