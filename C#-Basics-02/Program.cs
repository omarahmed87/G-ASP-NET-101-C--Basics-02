#region 9st answer
//Given int pages = 464;, convert it into a string using ToString() and print its type using 
//GetType() to prove it's now a string.
#endregion

class Program
{
    static void Main(string[] args)
    {
        int pages = 464;
        string result = pages.ToString();
        Console.WriteLine(result);
        Console.WriteLine(result.GetType());

    }
}


