#region 1st answer
//Create a Book class with a Title(string) and Pages(int). Create a Book object and store it 
//in a variable of type object. Print it. 
#endregion
class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();
        book.title = "Math";
        book.pages = 10;
        Console.WriteLine(book.title);
        Console.WriteLine(book.pages);
    }
}
class Book
{
    public string title;
    public int pages;
}
