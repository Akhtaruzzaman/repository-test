using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLibrary
{
    public abstract class Entity
    {
        public long Id { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedFrom { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedFrom { get; set; }
    }
}
