﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Structural.Proxy
{
    public interface IYouTubeService
    {
        byte[] GetVideo(int videoId);
    }
}
