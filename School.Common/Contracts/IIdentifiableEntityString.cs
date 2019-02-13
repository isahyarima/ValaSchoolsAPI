using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Common.Contracts
{
    public interface IIdentifiableEntityString
    {
        string EntityId { get; set; }
    }
}
