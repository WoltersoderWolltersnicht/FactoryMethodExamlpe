using Common;
using FactoryMethodExampleWhitFactory;

Console.WriteLine("Type Processor Type");

string processorType = Console.ReadLine();

ProcessorFactory processorFactory = new();

IProcessor processor = processorFactory.GetProcessors(processorType);

processor.ProcessMessage("Message");