using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Threading
{
    /// <summary>
    /// 
    /// </summary>
    public class AsyncSemaphore
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialCount"></param>
        public AsyncSemaphore(Int32 initialCount)
        {
            if (initialCount < 0)
                throw new ArgumentOutOfRangeException("initialCount");

            this.currentCount = initialCount;
            this.waiterQueue = new Queue<TaskCompletionSource<bool>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task WaitAsync()
        {
            lock (this.waiterQueue)
            {
                if (this.currentCount > 0)
                {
                    --this.currentCount;
                    return completed;
                }
                else
                {
                    TaskCompletionSource<Boolean> waiter = new TaskCompletionSource<Boolean>();
                    this.waiterQueue.Enqueue(waiter);
                    return waiter.Task;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Release()
        {
            TaskCompletionSource<Boolean> toRelease = null;
            lock (this.waiterQueue)
            {
                if (this.waiterQueue.Count > 0)
                    toRelease = this.waiterQueue.Dequeue();
                else
                    ++currentCount;
            }
            if (toRelease != null)
                toRelease.SetResult(true);
        }

        private readonly static Task completed = Task.FromResult(true);
        private readonly Queue<TaskCompletionSource<Boolean>> waiterQueue;
        private Int32 currentCount; 
    }
}
