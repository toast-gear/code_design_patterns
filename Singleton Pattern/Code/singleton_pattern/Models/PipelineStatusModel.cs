using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace singleton_pattern.Models
{
    public class PipelineStatusModel
    {
        public string PausedCause { get; set; }
        public string PausedBy { get; set; }
        public Boolean Paused { get; set; }
        public Boolean Schedulable { get; set; }
        public Boolean Locked { get; set; }
    }
}
