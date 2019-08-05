using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TERMS_V2.Domain.Entity
{
    public class Episode : AggregateRoot
    {
        public MriEiMasterInfo EpisodeInfo { get; set; }
        public PatientInfo PatientInfo { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual List<MriEiDiagnosis> Diagnoses { get; set; }
        public virtual List<Operation> Operations { get; set; }
        public virtual List<Tag> Tags { get; set; }
        public virtual List<Status> Statuses { get; set; }
        public virtual List<DocCategory> DocCategories { get; set; }
    }
}
