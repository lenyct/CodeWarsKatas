using System;
using System.Collections.Generic;
namespace Geneva
{
    public class Dispatcher
    {
        private readonly Dictionary<int, Worker> workers = new Dictionary<int, Worker>();

        public IEnumerable<Worker> Workers { get { return this.workers.Values; } }

        public Worker AcquireWorker(int id)
        {
            Worker w = null;
            if (!this.workers.TryGetValue(id, out w))
            {
                w = new Worker(id);
                this.workers.Add(id, w);
            }

            return w;
        }

        public void ReleaseWorker(int id)
        {
            Worker w = null;
            if (!this.workers.TryGetValue(id, out w))
                throw new ArgumentException();

            w.Dispose();
            workers[id].Dispose();

        }
    }
}