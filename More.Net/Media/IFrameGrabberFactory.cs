﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Media
{
    public interface IFrameGrabberFactory
    {
        IFrameGrabber Create(IEnumerable<ICamera> cameras);
    }
}