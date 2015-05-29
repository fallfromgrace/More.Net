using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Media
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public interface ICameraPropertyInfo<TValue>
    {
        /// <summary>
        /// 
        /// </summary>
        String Name { get; }

        /// <summary>
        /// Gets the minimum allowed value.
        /// </summary>
        TValue Minimum { get; }

        /// <summary>
        /// Gets the maximum allowed value.
        /// </summary>
        TValue Maximum { get; }

        /// <summary>
        /// Gets the step between values.
        /// </summary>
        TValue Step { get; }

        /// <summary>
        /// 
        /// </summary>
        TValue Default { get; }

        /// <summary>
        /// 
        /// </summary>
        TValue Current { get; set; }

        /// <summary>
        /// Gets whether this property can be changed.
        /// </summary>
        Boolean IsSupported { get; }
    }
}
