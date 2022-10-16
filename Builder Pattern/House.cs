using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class House
    {
        public string Pillars { get; set; } = string.Empty;
        public string Base { get; set; } = string.Empty;
        public string Roof { get; set; } = string.Empty;
        public string Walls { get; set; } = string.Empty;
    }
}
