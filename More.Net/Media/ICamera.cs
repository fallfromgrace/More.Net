using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using More.Net.Units;

namespace More.Net.Media
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICamera
    {
        /// <summary>
        /// 
        /// </summary>
        String Name { get; }


        String SerialNumber { get; }

        /// <summary>
        /// Gets or sets the exposure time.
        /// </summary>
        Time Exposure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        ICameraPropertyInfo<Time> ExposureInfo { get; }

        /// <summary>
        /// Gets or sets the focus distance.
        /// </summary>
        Length Focus { get; }

        /// <summary>
        /// Gets or sets the zoom distance.
        /// </summary>
        Length Zoom { get; }
    }
}
