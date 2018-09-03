using com.Repower.LoadTest4Rest.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.Repower.LoadTest4Rest
{

    /// <summary>
    /// 
    /// </summary>
    public class LoadTestExecutor
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="visitors"></param>
        /// <param name="job2Execute"></param>
        /// <returns></returns>
        public List<FeedbackInfo> Execute(string url, int visitors, JobInfo job2Execute)
        {
            List<FeedbackInfo> lista = new List<FeedbackInfo>();

            Random rnd = new Random();

            for (int x = 0; x < visitors; ++x)
            {
                FeedbackInfo info = new FeedbackInfo
                {
                    Executions = new List<ExecutionInfo>()
                };

                foreach ( string callName in job2Execute.Calls)
                {
                    info.Executions.Add(new ExecutionInfo
                    {
                        Name = callName,
                        ExecTime = new TimeSpan(rnd.Next(1, 999) * 1_000_000)
                    });
                }
                lista.Add(info);
            }

            return lista;
        }
    }
}
