#region 8st answer
////Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = 
//"abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
#endregion

class Program
{
    static void Main(string[] args)
    {
        string yearText = "2023";
        int year = int.Parse(yearText);

        string badText = "abc";
        if (!int.TryParse(badText, out int result))
        {
            Console.WriteLine("Invalid number");
        }


    }
}


