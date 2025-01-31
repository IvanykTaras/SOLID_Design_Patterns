﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Behavioral.Mediator
{
    public abstract class Component
    {
        protected IMediator _mediator;
        public void SetMediator(IMediator mediator) => _mediator = mediator;
    }
}
