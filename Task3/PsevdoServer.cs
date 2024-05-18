namespace Task3
{
    internal static class PsevdoServer
    {
        static int _count;
        internal static int Count 
        { 
            get { return _count; }
            set { _count = value; }
        }
        internal async static Task GetCount()
        {
            await Task.Delay(2000);
            Console.WriteLine(Count);
        }
        internal async static Task AddToCount() 
        {
            await Task.Delay(2000);
            Count++;
        }
    }
}
