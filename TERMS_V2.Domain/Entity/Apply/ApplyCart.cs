using TERMS_V2.Domain.ValueObject;
using System.Collections.Generic;

namespace TERMS_V2.Domain.Entity
{
    public class ApplyCart : AggregateRoot
    {
        public BdUiUser UserInfo { get; set; }
        public Episode Episode { get; set; }
    }
}