public class OfficePcFactory : IPcFactory
{
    public Box CreateBox()
    {
        return new BlackBox();
    }

    public Hdd CreateHdd()
    {
        return new LGHdd();
    }

    public MainBoard CreateMainBoard()
    {
        return new AsusMainBoard();
    }

    public Memory CreateMemory()
    {
        return new DdrMemory();
    }

    public Processor CreateProcessor()
    {
        return new AmdProcessor();
    }

}
