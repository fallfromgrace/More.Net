using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Media
{
    public interface IVideoFrameGrabber
    {
        /// <summary>
        /// Gets or sets the target frame rate.
        /// </summary>
        Double Framerate { get; set; }

        /// <summary>
        /// Gets the actual frame rate.
        /// </summary>
        Double ActualFramerate { get; }
    }
}
