using System;

namespace ExStopWatch
{
    public class StopWatch
    {
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }
        private bool _running;
        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("StopWatch Is Running");
            StartTime = DateTime.Now;
            _running = true;
        }

        public void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("StopWatch Is Running");
            EndTime = DateTime.Now;
            _running = false;
        }

        public TimeSpan GetInterval()
        {
            return EndTime - StartTime;
        }
    }
}
