using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    public class GenerateReportTask
    {
        private AuditTrail auditTrail;

        public GenerateReportTask(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void Execute()
        {
            auditTrail.Record();

            Console.WriteLine("Generate Report");
        }
    }
}
