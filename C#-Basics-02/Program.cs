#region 10st answer
//Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int 
//variable, and print both.
#endregion

class Program
{
    static void Main(string[] args)
    {
        int copies = 100;
        object boxed = copies; //Boxing
        int unboxed = (int)boxed; //Unboxing
        Console.WriteLine(boxed);
        Console.WriteLine(unboxed);

    }
}


