namespace Task3
{
    internal static class PsevdoServer
    {
        static object locker = new object();
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
        internal async static Task AddToCount(int value) 
        {
            lock (locker)
            {                
                Count+=value;
            }
        }
    }
}
