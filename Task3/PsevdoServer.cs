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
        internal static void GetCount()
        {
            Console.WriteLine(Count);
        }
        internal static void AddToCount(int value) 
        {
            lock (locker)
            {
                Console.WriteLine($"Файл редактируется");
                Count += value;
                Thread.Sleep(2000);
            }
            Console.WriteLine($"значение измнено {Count}");
        }
    }
}
