#region 4st answer
//Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot 
//divide by zero", and then prints "Done" in a finally block. 
#endregion

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int result = 10 / 0;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Can't divide by zero");
        }
        finally
        {
           Console.WriteLine("Done");
        }

    }
}


