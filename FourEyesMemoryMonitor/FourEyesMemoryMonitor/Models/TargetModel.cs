using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourEyesMemoryMonitor.Models
{
    public class TargetModel
    {
        public string ProcessName { get; set; }
        public int MemoryThreshold { get; set; }
        public int Opacity { get; set; }
        public int PollInterval { get; set; }
        public bool ProcessFound { get; set; } = false;
    }
}
