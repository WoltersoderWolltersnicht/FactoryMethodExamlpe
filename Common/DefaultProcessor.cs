namespace Common;

public class DefaultProcessor : IProcessor
{
    public void ProcessMessage(string message)
    {
        Console.WriteLine("Proccesing Message as DefaultProcessor");
    }
}
