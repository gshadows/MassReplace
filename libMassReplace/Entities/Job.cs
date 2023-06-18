using System;
using System.Collections.Generic;
using System.Text;

namespace MassReplace.Entities {
    public class Job {
        public string name;
        public IList<DirFilter> dirFilters;
    }
}
