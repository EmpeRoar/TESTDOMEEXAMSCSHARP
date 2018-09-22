using System;

public class Account
{


    [Flags]
    public enum Access
    {
        Delete,
        Publish,
        Submit,
        Comment,
        Modify
    }

   
    public enum Writer
    {
        Submit = Access.Submit,
        Modify = Access.Modify
    }

  
    public enum Editor
    {
        Publish = Access.Publish,
        Delete = Access.Delete,
        Comment = Access.Comment
    }

    [Flags]
    public enum Owner
    {
        Submit = Access.Submit,
        Modify = Access.Modify,
        Publish = Access.Publish,
        Delete = Access.Delete,
        Comment = Access.Comment
    }




    public static void Main(string[] args)
    {
        Console.WriteLine(Access.Writer.HasFlag(Access.Delete)); //Should print: "False"
    }
}