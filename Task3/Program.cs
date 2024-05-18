namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread readingThread = new Thread(async ()=>await PsevdoServer.GetCount());
            readingThread.Start();
            Console.ReadLine();
        }
    }
}
