namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Симуляция обращений к серверу...");

            // Запуск нескольких потоков, имитирующих разных пользователей
            var threads = new[] {
                new Thread(() => { PsevdoServer.AddToCount(10); }),
                new Thread(() => { PsevdoServer.GetCount(); }),
                new Thread(() => { PsevdoServer.AddToCount(20); }),
                new Thread(() => { PsevdoServer.GetCount(); })
            };

            foreach (var thread in threads)
            {
                thread.Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }
            Console.ReadLine();
        }
    }
}
