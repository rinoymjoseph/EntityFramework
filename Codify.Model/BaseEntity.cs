﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.Entity
{
    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsCurrent { get; set; }
        public bool IsDeleted { get; set; }
        public virtual byte[] RecordTimeStamp { get; set; }
    }
}
