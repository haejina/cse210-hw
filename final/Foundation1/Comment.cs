using System;
using System.Collections.Generic;
class Comment
{
    private string name;
    private string text;

    public string GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        name = value;
    }

    public string GetText()
    {
        return text;
    }

    public void SetText(string value)
    {
        text = value;
    }

    public Comment(string name, string text)
    {
        SetName(name);
        SetText(text);
    }
}