using System.ComponentModel;

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
            threads[0].IsBackground = true;
            threads[2].IsBackground = true;

            var n =1;
            foreach (var thread in threads)
            {
                Console.WriteLine($"запущен поток {thread.Name} {n++}");
                thread.Start();
                Thread.Sleep(1000);
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            Console.ReadLine();
        }
    }
}
