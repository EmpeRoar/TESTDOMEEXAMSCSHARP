using System;

public class Account
{
    [Flags]
    public enum Access
    {
        Writer,
        Editor,
        Owner,
        Delete,
        Publish,
        Submit,
        Comment,
        Modify
    }

    [Flags]
    public enum Writer
    {
        Submit = Access.Submit,
        Modify = Access.Modify
    }

    [Flags]
    public enum Editor
    {
        Delete = Access.Delete,
        Publish = Access.Publish,
        Comment = Access.Comment
    }

    [Flags]
    public enum Owner
    {
        Submit = Access.Submit,
        Modify = Access.Modify,
        Delete = Access.Delete,
        Publish = Access.Publish,
        Comment = Access.Comment
    }



    public static void Main(string[] args)
    {
        
        Console.WriteLine(Access.Writer.HasFlag(Access.Delete)); //Should print: "False"
    }
}