public class PcConfigurator
{
    private IPcFactory factory;
    public PcConfigurator()
    {
        factory = new OfficePcFactory();
    }
    public void SetOfficePcFactory()
    {
        factory = new OfficePcFactory();
    }
    public void SetHomePcFactory()
    {
        factory = new HomePcFfartory();
    }
    public void Configure(PC pc)
    {
        pc.Box = factory.CreateBox();
        pc.Processor = factory.CreateProcessor();
        pc.MainBoard = factory.CreateMainBoard();
        pc.Hdd = factory.CreateHdd();
        pc.Memory = factory.CreateMemory();
    }
}
