using Common;

Console.WriteLine("Type Processor Type");

string processorType = Console.ReadLine();

IProcessor processor;

switch (processorType)
{
    case "A":
        processor = new AProcessor();
    break;
    case "B":
        processor = new BProcessor();
    break;
    default:
        processor = new DefaultProcessor();
    break;
}

processor.ProcessMessage("Message");