using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Media
{
    /// <summary>
    /// Allows for the capture of video frames on one or more cameras.
    /// </summary>
    public interface IFrameGrabber
    {
        /// <summary>
        /// Gets the cameras where frames will be grabbed.
        /// </summary>
        IReadOnlyCollection<ICamera> Cameras { get; }

        /// <summary>
        /// Gets the observable sequence of captured frames.
        /// </summary>
        IObservable<IFrame> WhenFrameCaptured { get; }

        ///// <summary>
        ///// 
        ///// </summary>
        //Units.SIValue<Double, FrequencyUnit> Framerate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Boolean IsCapturing { get; }

        /// <summary>
        /// Initiates capture on all cameras.  If the frame grabber supports multiple cameras, then 
        /// the capture is intended to be synchronous between cameras.
        /// 
        /// To get captured frames, subscribe to the WhenFrameCaptured observable.
        /// </summary>
        void StartCapture();

        /// <summary>
        /// Ceases capture on all cameras.
        /// </summary>
        void StopCapture();
    }
}
