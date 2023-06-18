using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MassReplace.Entities;

namespace MassReplace {
    public class ReplaceExecutor {
        private IList<Job> jobs;


        public ReplaceExecutor() {
            jobs = new List<Job>();
        }

        public ReplaceExecutor(IList<Job> jobs) {
            this.jobs = jobs;
        }


        public void PerformReplace() {
        }
    }
}
