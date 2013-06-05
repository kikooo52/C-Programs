using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _7.DelegatesTimer
{
    public delegate void DelegatTimer(int count);

    class Timer
    {
        public int TickCount { get; private set; }
        public int Interval { get; private set; }
        private DelegatTimer call;

        public Timer(int Count, int Interval, DelegatTimer Call)
        {
            this.TickCount = Count;
            this.Interval = Interval;
            this.call = Call;
        }

        public void Run()
        {
            int ticks = this.TickCount;
            while (ticks > 0)
            {
                Thread.Sleep(Interval);
                ticks--;
                this.call(ticks);
            }
        }

        public static void PrintMasage(int tick)
        {
            Console.WriteLine(tick);
        }

        static void Main(string[] args)
        {
            DelegatTimer timer = new DelegatTimer(PrintMasage);

            Timer newTimer = new Timer(10, 800, timer);

            Thread thread = new Thread(new ThreadStart(newTimer.Run));
            thread.Start();


        }
    }
}
