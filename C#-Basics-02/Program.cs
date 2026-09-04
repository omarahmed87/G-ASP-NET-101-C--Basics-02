#region 11st answer
//Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its 
//value. 
#endregion

class Program
{
    static void Main(string[] args)
    {
        int? year = null;
        Console.WriteLine(year.HasValue);
        year = 2023;
        Console.WriteLine(year);

    }
}


