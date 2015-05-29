using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading;

namespace More.Net.Collections.Generic
{
    ///// <summary>
    ///// A specialized observable collection that uses a synchronization context to post collection 
    ///// and property change notification to the correct thread.
    ///// </summary>
    ///// <typeparam name="T"></typeparam>
    //public class SynchronizedObservableCollection<T> : BulkObservableCollection<T>, ISynchronizable
    //{
    //    #region ISynchronizable

    //    /// <summary>
    //    /// Gets or sets the synchronization context.
    //    /// </summary>
    //    public SynchronizationContext SynchronizationContext
    //    {
    //        get { return synchronizationContext; }
    //        set { SetSynchronizationContext(value); }
    //    }

    //    #endregion

    //    /// <summary>
    //    /// Gets or sets whether to use the captured or current synchronization context.
    //    /// </summary>
    //    public Boolean UseSynchronizationContext
    //    {
    //        get { return true; }
    //    }

    //    #region Protected Properties

    //    /// <summary>
    //    /// Gets if we must post to the synchronization context.
    //    /// </summary>
    //    protected Boolean PostRequired
    //    {
    //        get
    //        {
    //            Boolean postRequired = true;
    //            if (SynchronizationContext == null)
    //            {
    //                postRequired = false;
    //            }
    //            else if (SynchronizationContext == SynchronizationContext.Current)
    //            {
    //                postRequired = false;
    //            }
    //            return postRequired;
    //        }
    //    }

    //    #endregion

    //    #region Constructors

    //    /// <summary>
    //    /// Initializes a new instance of SynchronizedObservableCollection using the current
    //    /// thread's synchronization context.
    //    /// </summary>
    //    public SynchronizedObservableCollection()
    //        : this(SynchronizationContext.Current)
    //    {

    //    }

    //    /// <summary>
    //    /// Initializes a new instance of SynchronizedObservableCollection using the specified
    //    /// synchronization context.
    //    /// </summary>
    //    /// <param name="synchronizationContext"></param>
    //    public SynchronizedObservableCollection(SynchronizationContext synchronizationContext)
    //        : base()
    //    {
    //        locker = new Object();
    //        SynchronizationContext = synchronizationContext;
    //    }

    //    #endregion

    //    #region Setters

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="value"></param>
    //    private void SetSynchronizationContext(SynchronizationContext value)
    //    {
    //        lock (locker)
    //        {
    //            if (SynchronizationContext != value)
    //            {
    //                synchronizationContext = value;
    //                OnPropertyChanged(new PropertyChangedEventArgs("SynchronizationContext"));
    //            }
    //        }
    //    }

    //    #endregion

    //    #region Overrides

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="e"></param>
    //    /// <remarks>
    //    /// The lock is there to ensure that 
    //    /// </remarks>
    //    protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
    //    {
    //        if (PostRequired)
    //            SynchronizationContext.Post(delegate
    //            {
    //                lock (locker)
    //                    base.OnCollectionChanged(e);
    //            }, null);
    //        else
    //            base.OnCollectionChanged(e);
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="e"></param>
    //    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    //    {
    //        if (PostRequired)
    //            SynchronizationContext.Post(delegate
    //            {
    //                lock (locker)
    //                    base.OnPropertyChanged(e);
    //            }, null);
    //        else
    //            base.OnPropertyChanged(e);
    //    }

    //    #endregion

    //    #region Private Fields

    //    private readonly Object locker;
    //    private SynchronizationContext synchronizationContext;

    //    #endregion
    //}
}
