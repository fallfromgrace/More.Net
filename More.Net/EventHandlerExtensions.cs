using System;

namespace EZMetrology
{
    /// <summary>
    /// Extension methods for events.
    /// </summary>
    public static class EventHandlerExtensions
    {
        /// <summary>
        /// Invokes an event handler by creating a temporary copy of the delegate before invoking.
        /// This prevents NullReferenceException when raising events in multithreaded code, but will 
        /// still invoke any event handlers that have been detached between the copying and invoking.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void SafeInvoke(this EventHandler handler, Object sender, EventArgs e)
        {
            if (handler != null)
                handler(sender, e);
        }

        /// <summary>
        /// Invokes an event handler by creating a temporary copy of the delegate before invoking.
        /// This prevents NullReferenceException when raising events in multithreaded code, but will 
        /// still invoke any event handlers that have been detached between the copying and invoking.
        /// </summary>
        /// <typeparam name="T">System.EventArgs</typeparam>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void SafeInvoke<T>(this EventHandler<T> handler, Object sender, T e)
            where T : EventArgs
        {
            if (handler != null)
                handler(sender, e);
        }
    }
}
