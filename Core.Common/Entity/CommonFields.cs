﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Entity
{
   public class CommonFields
    {
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedFrom { get; set; }
        public bool IsModefied { get; set; }
        public DateTime DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedFrom { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateDeleted { get; set; }
        public string DeletedBy { get; set; }
        public string DeletedFrom { get; set; }
        public bool IsApproved { get; set; }
        public DateTime DateApproved { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedFrom { get; set; }
        public string Status { get; set; }
        public string comment { get; set; }
        public int SchoolId { get; set; }
    }
}
