public class HomePcFfartory : IPcFactory
{
    public Box CreateBox()
    {
        return new WhiteBox();
    }

    public Hdd CreateHdd()
    {
        return new SamsungHdd();
    }

    public MainBoard CreateMainBoard()
    {
        return new MSIMainBoard();
    }

    public Memory CreateMemory()
    {
        return new Ddr2Memory();
    }

    public Processor CreateProcessor()
    {
        return new IntelProcessor();
    }
}
