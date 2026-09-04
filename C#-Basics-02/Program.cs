#region 14st answer
//Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??= 
//to assign title the value "Untitled" only if it's still null. 
#endregion

class Program
{
    static void Main(string[] args)
    {
        Book? book = null;
        Console.WriteLine(book?.Title ?? "Untitled");

        string? title = null;
        title ??= "Untitled";
        Console.WriteLine(title);
    }
}

class Book
{
    public string? Title { get; set; }
}


