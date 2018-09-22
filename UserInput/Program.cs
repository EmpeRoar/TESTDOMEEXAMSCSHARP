using System;
using System.Text;

public class TextInput
{
    protected StringBuilder _value;
    public TextInput()
    {
        _value = new StringBuilder();
    }
    public virtual void Add(char c)
    {
        _value.Append(c);
    }
    public string GetValue()
    {
        return _value.ToString();
    }
}

public class NumericInput : TextInput
{
    public override void Add(char c)
    {
        if (char.IsDigit(c))
        {
            _value.Append(c);
        }
    }
}

public class UserInput
{
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
        Console.ReadLine();
    }
}