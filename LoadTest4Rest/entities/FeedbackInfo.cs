using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.Repower.LoadTest4Rest.entities
{
    /// <summary>
    /// Struttura contenente i dati di esecuzione del JOB
    /// </summary>
    public class FeedbackInfo
    {
        public string Name { get; set; }
        public List<ExecutionInfo> Executions { get; set; }
    }


    /// <summary>
    /// Struttura dei dati di esecuzione di una singola call
    /// </summary>
    public class ExecutionInfo
    {
        public string Name { get; set; }
        public TimeSpan ExecTime { get; set; }
        /// <summary>Flag indicante la chiamata ha generato un errore</summary>
        public bool Failed { get; set; } = false;
    }

}



