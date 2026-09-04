#region 3st answer
//Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it. 
//int pages = "464";
//Compile - time error — you can't put text (string) into an int variable. 
//int pages = 464;
#endregion

class Program
{
    static void Main(string[] args)
    {
        int pages = 464;
        //this is a compile-time error ,we can't put text into an int variable.
        //the solution is to remove the quotes.
        
    }
}


