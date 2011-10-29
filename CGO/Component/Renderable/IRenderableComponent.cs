﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGO
{
    public interface IRenderableComponent
    {
        void Render();
        SS3D_shared.GO.DrawDepth DrawDepth { get; set; }
        Entity Owner { get; set; }
    }
}