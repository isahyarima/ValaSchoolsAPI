﻿using Core.Common.Contracts;
using School.Business.Origin;
using School.Client.Business.Location;

namespace School.Data.Contracts.OriginContracts
{
    public interface IStateOfOriginRepository : IDataRepository<StateOfOrigin, ClientStateOfOrigin>
    {
    }
}
