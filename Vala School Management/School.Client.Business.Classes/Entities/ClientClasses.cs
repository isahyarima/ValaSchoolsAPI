
using Core.Common.Entity;

namespace School.Client.Business.Classes
{
    public class ClientClasses : CommonFields
    {
        public int ClassId { get; set; }
        public string ClassRef { get; set; }
        public string ClassAccronym { get; set; }
        public string ClassName { get; set; }

    }
}
