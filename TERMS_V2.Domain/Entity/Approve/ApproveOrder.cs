using TERMS_V2.Domain.ValueObject;
using System.Collections.Generic;

namespace TERMS_V2.Domain.Entity
{
    public class ApproveOrder : AggregateRoot
    {
        public ApplyOrder ApplyOrder { get; set; }
        public List<DocCategory> DocCategories { get; set; }
        public ApplyTimeRange ApproveTimeRange { get; set; }
        public List<ApplyOperation> ApproveOperations { get; set; }
    }
}