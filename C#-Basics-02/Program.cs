#region 15st answer
//Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable 
//string confirmedName using the ! operator.
#endregion

class Program
{
    static void Main(string[] args)
    {
        string? name = "Ahmed";
        string confirmedName = name!;
        Console.WriteLine(confirmedName);
        
    }
}




