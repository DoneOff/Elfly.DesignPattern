using System;
using System.Threading.Tasks;
using System.Threading;

namespace Elfly.DesignPattern.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] taskArray = new Task[10];
            for (int i = 0; i < taskArray.Length; i++)
            {
                taskArray[i] = Task.Factory.StartNew((Object obj) =>
                {
                    dynamic o = obj;
                    int number = GetTicketNumber();
                    Console.WriteLine("Task #{0},ThreadID #{1},票根编码 #{2}", o.number, Thread.CurrentThread.ManagedThreadId,number);
                }, new {number = i });

            }
            Task.WaitAll(taskArray);
            Console.ReadLine();
        }

        /// <summary>
        /// 获取票根编码
        /// </summary>
        /// <returns></returns>
        private static int GetTicketNumber()
        {
            TicketMaker ticketMaker = TicketMaker.GetInstance();
            int number = ticketMaker.GetNextTickerNumber();
            return number;
        }
    }
}
