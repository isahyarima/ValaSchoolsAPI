﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.Contracts
{
    public interface IIdentifiableEntity
    {
        int EntityId { get; set; }
    }
}
