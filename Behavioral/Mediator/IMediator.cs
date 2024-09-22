﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Behavioral.Mediator
{
    public interface IMediator
    {
        void Notify(Component component, string @event);
    }
}
