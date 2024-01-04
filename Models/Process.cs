using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameProcesses.Models
{
    public class Process
    {
        public string Name { get; set; }
        public List<Process> SubProcesses { get; set; }
    }
}
