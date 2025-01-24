using postitOOP;

internal class Program
{
    private static void Main(string[] args)
    {
        Postit postit1= new("red");
        Postit postit2= new("green");
        Postit postit3= new("yellow");

        postit1.Text="asdasd";
        postit1.Text="asdasd";
        postit2.Text="asdasdasdasd";

        postit3.Text="asdasdasdasdasdasd";

        System.Console.WriteLine(postit1);
        System.Console.WriteLine(postit2);
        System.Console.WriteLine(postit3);

    }
}