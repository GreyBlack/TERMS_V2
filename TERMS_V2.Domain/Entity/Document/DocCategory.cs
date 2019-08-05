using System.Collections.Generic;

namespace TERMS_V2.Domain.Entity
{
    public class DocCategory : AggregateRoot
    {
        public List<DocCategory> DocCategories { get; set; }
        public List<DocItem> DocItems { get; set; }
        public List<Status> Statuses { get; set; }
    }
}