public class Program
{
    private static void Main(string[] args)
    {
        PcConfigurator configurator = new PcConfigurator();
        PC pc = new PC();

        Console.WriteLine("OfficePcFactory\n");
        configurator.Configure(pc);
        pc.ShowInfo();

        Console.WriteLine("\nHomePcFactory\n");
        configurator.SetHomePcFactory();

        configurator.Configure(pc);
        pc.ShowInfo();
    }
}