#region 2st answer
//Using the Book class above, print the result of calling ToString(), Equals() (compare book
//with itself), GetHashCode(), and GetType() on book.
#endregion

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();
        book.title = "Math";
        book.pages = 10;

        Book newBook = new Book();
        newBook.title = "Math";
        newBook.pages = 10;

        Console.WriteLine(book.title);
        Console.WriteLine(book.pages);
        Console.WriteLine(book);
        Console.WriteLine(book.Equals(newBook));
        Console.WriteLine(book.Equals(book));
        Console.WriteLine(book.GetHashCode());
        Console.WriteLine(newBook.GetHashCode());
        Console.WriteLine(book.GetType());
        Console.WriteLine(newBook.GetType());
    }
}

class Book
{
    public string title;
    public int pages;
    public override string ToString()
    {
        return $"The title of book is:{title} and the pages is :{pages}";
    }
    public override bool Equals(object? obj)
    {
        Book newBook = (Book)obj;
        return this.title == newBook.title && this.pages == newBook.pages;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(title, pages);
    }
}