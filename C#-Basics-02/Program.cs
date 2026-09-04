#region 13st answer
//Declare a Book? book = null;. Use?.to safely read book.Title without crashing the 
//program, and print the result. 
#endregion

class Program
{
    static void Main(string[] args)
    {
        Book? book = null;
        Console.WriteLine(book?.Title);

    }
    class Book
    {
        public string Title { get; set; }
    }
}


