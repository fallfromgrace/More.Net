using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EZMetrology.Threading
{
    /// <summary>
    /// 
    /// </summary>
    public class AsyncLock
    {
        public AsyncLock()
        {
            semaphore = new AsyncSemaphore(1);
            releaser = Task.FromResult(new Releaser(this));
        }

        public Task<Releaser> LockAsync()
        {
            Task wait = semaphore.WaitAsync();
            if (wait.IsCompleted)
                return releaser;
            else
                return wait.ContinueWith((_, state) => new Releaser((AsyncLock)state),
                    this, CancellationToken.None,
                    TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
        }

        public struct Releaser : IDisposable
        {
            private readonly AsyncLock lockToRelease;

            internal Releaser(AsyncLock lockToRelease)
            {
                this.lockToRelease = lockToRelease;
            }

            public void Dispose()
            {
                if (lockToRelease != null)
                    lockToRelease.semaphore.Release();
            }
        }

        private readonly AsyncSemaphore semaphore;
        private readonly Task<Releaser> releaser; 
    }
}
