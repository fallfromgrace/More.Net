using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Media
{
    public enum FrameFormat
    {
        MJPEG,
        RGB24,
        YUY2,
    }

    public interface IFrameGrabberConfiguration
    {
        /// <summary>
        /// Gets or sets the target frame rate.
        /// </summary>
        Double Framerate { get; set; }

        /// <summary>
        /// Gets or sets the format in which frame are transmitted from the camera to the frame 
        /// grabber.  For exmaple, this is useful if the camera supports onboard compression.
        /// </summary>
        FrameFormat CaptureFormat { get; set; }

        /// <summary>
        /// Gets or sets the format is which frames are output.
        /// </summary>
        FrameFormat OutputFormat { get; set; }


        Int32 NumBuffers { get; set; }


        Int32 BufferSize { get; set; }
    }
}
