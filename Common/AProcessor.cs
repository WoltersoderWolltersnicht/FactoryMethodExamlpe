namespace Common;

public class AProcessor : IProcessor
{
    public void ProcessMessage(string message)
    {
        Console.WriteLine("Proccesing Message as AProcessor");
    }
}
