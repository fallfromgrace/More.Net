using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More.Net.Media
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFrame
    {
        /// <summary>
        /// Gets the camera the frame came from.
        /// </summary>
        ICamera Camera { get; }

        /// <summary>
        /// Gets the time the frame was captured.
        /// </summary>
        DateTime Time { get; }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <returns></returns>
        IBitmapImage Image { get; }
    }
}
