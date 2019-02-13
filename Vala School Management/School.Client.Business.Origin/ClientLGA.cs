
using Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Client.Business.Origin
{
   public class ClientLGA : CommonFields
    {
        public int LgaId { get; set; }
        public string LgaName { get; set; }
        public int StateId { get; set; }
      
    }
}
