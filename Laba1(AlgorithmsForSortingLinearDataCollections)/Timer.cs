using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_AlgorithmsForSortingLinearDataCollections_
{
    internal class Timer
    {
        Stopwatch timeWatch = new Stopwatch();
        public void Start()
        {
            timeWatch.Start();
        }
        public void Stop()
        {
            timeWatch.Stop();
            
        }
        public override string ToString()
        {
            TimeSpan timeSpend = timeWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timeSpend.Hours, timeSpend.Minutes, timeSpend.Seconds, timeSpend.Milliseconds / 10);
            return elapsedTime;
        }
    }
}
