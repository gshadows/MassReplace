using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MassReplace.Entities {
    public class DirFilter {
        public string name;
        public string basePath;
        public bool isRecursive;
        Regex filter;
    }
}
