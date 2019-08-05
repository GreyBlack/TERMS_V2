using TERMS_V2.Domain.ValueObject;
using System;
using System.Collections.Generic;

namespace TERMS_V2.Domain.Entity
{
    public class ApplyOrder : AggregateRoot
    {
        public ApplyTimeRange ApplyTimeRange { get; set; }
        public ApplyReason ApplyReason { get; set; }
        public List<ApplyOperation> ApplyOperations { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual BdUiUser UserInfo { get; set; }
        public virtual List<DocCategory> DocCategories { get; set; }
    }
}