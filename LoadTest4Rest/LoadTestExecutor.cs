using com.Repower.LoadTest4Rest.entities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        /// Crea ed esegue i task
        /// </summary>
        /// <param name="url"></param>
        /// <param name="visitors"></param>
        /// <param name="job2Execute"></param>
        /// <returns></returns>
        public List<FeedbackInfo> Execute(string url, int visitors, JobInfo job2Execute)
        {
            List<Task<FeedbackInfo>> taskList = new List<Task<FeedbackInfo>>();
            for (int i = 0; i < visitors; i++)
            {
                taskList.Add(CreateTask(url, job2Execute));
            }

            Task.WaitAll(taskList.ToArray());

            return taskList.Select(task => task.Result).ToList();
        }

        /// <summary>
        /// Crea ed esegue un singolo task
        /// </summary>
        /// <param name="url"></param>
        /// <param name="job2Execute"></param>
        /// <returns></returns>
        private Task<FeedbackInfo> CreateTask(string url, JobInfo job2Execute)
        {
            return Task.Run(() =>
            {
                FeedbackInfo feedback = new FeedbackInfo() { Name = job2Execute.Name };
                WebClient httpClient = CreateHttpClient(url);

                //lista parametri condivisa tra le call (serve per recuperare i parametri da una chiamata e passarli alla successiva)
                Dictionary<string, string> parameters = new Dictionary<string, string>();
                foreach (var call in job2Execute.Calls)
                {
                    ExecutionInfo result = ExecuteCall(httpClient, call, parameters);
                    feedback.Executions.Add(result);
                }
                return feedback;
            });
        }

        /// <summary>
        /// Crea l'oggetto HttpClient con la configurazione base (url e timeout)
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private WebClient CreateHttpClient(string url)
        {
            WebClientEx webClient = new WebClientEx();
            webClient.BaseAddress = url;
            return webClient;
        }

        /// <summary>
        /// Effettua la chiamata e restituisce il risultato
        /// </summary>
        /// <param name="webClient"></param>
        /// <param name="call"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private ExecutionInfo ExecuteCall(WebClient webClient, string call, IDictionary<string, string> parameters)
        {
            ExecutionInfo execInfo = new ExecutionInfo()
            {
                Name = call
            };
            DateTime startTime = DateTime.Now;
            //TODO: caricare la call dalla configurazione (callcollection.json) e sostituire eventuali parametri nella url
            string request = call;

            try
            {
                //TODO: in base alla configurazione, effettuare una GET o una POST
                var res = webClient.DownloadString(request);
            }
            catch (WebException wex)
            {
                //TODO: gestire eccezione
            }

            //TODO: recuperare il risultato ed eventualmente aggiungere o modificare i parametri sul dictionary

            execInfo.ExecTime = DateTime.Now - startTime;
            return execInfo;
        }


        public class WebClientEx : WebClient
        {
            protected override WebRequest GetWebRequest(Uri address)
            {
                WebRequest req =  base.GetWebRequest(address);
                req.Timeout = (int)TimeSpan.FromMinutes(1).TotalMilliseconds; //TODO: aggiungere parametro di configurazione;
                return req;
            }
        }
    }
}
