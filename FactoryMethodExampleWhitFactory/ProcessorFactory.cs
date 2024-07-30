using Common;

namespace FactoryMethodExampleWhitFactory;

public class ProcessorFactory
{
    public IProcessor GetProcessors(string processorType)
    {
        switch (processorType)
        {
            case "A":
                return new AProcessor();
            case "B":
                return new BProcessor();
            default:
                return new DefaultProcessor();
        }
    }
}
