using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;

namespace Problem02_Asynchronous_Timer
{
    class AsynchronousTimer
    {
        private BackgroundWorker bw;

        private Action<int> action;
        private int ticks;
        private int timeInterval;

        public int Ticks
        {
            get
            {
                return this.ticks;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Ticks count can't be 0 or negative!");
                }
                else
                {
                    this.ticks = value;
                }
            }
        }

        public int TimeInterval
        {
            get
            {
                return this.timeInterval;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Time interval can't be 0 or negative!");
                }
                else
                {
                    this.timeInterval = value;
                }
            }
        }

        public AsynchronousTimer(Action<int> action, int ticks, int timeInterval)
        {
            this.action = action;
            this.Ticks = ticks;
            this.TimeInterval = timeInterval;
            this.bw = new BackgroundWorker();
        }

        public void StartTimer() 
        {
            bw.DoWork += new DoWorkEventHandler(BuildTimer);
            bw.RunWorkerAsync();
        }

        private void BuildTimer(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= ticks; i++)
            {
                action(i);
                Thread.Sleep(this.timeInterval);
            }
        }


    }
}
