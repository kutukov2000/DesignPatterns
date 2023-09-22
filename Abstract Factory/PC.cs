public class PC
{
    public Box Box { get; set; }
    public Processor Processor { get; set; }
    public MainBoard MainBoard { get; set; }
    public Hdd Hdd { get; set; }
    public Memory Memory { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine("Сharacteristics:");
        Box.ShowInfo();
        Processor.ShowInfo();
        MainBoard.ShowInfo();
        Hdd.ShowInfo();
        Memory.ShowInfo();
    }
}
