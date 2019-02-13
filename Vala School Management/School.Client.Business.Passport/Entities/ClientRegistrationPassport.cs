
using Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Client.Business.Passport
{
   public class ClientRegistrationPassport : CommonFields
    {
        public int RegistrationPassportsId { get; set; }
        public string PersonId { get; set; }
        public Byte? ImageBinary { get; set; }
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
        public string ImageExtention { get; set; }
        public string ImageSize { get; set; }
        public string EditedBy { get; set; }
        public string EditedFrom { get; set; }
        public string ImageStatus { get; set; }
      
    }
}
