using com.Repower.LoadTest4Rest.entities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        /// <param name="urlServer"></param>
        /// <param name="visitors"></param>
        /// <param name="job2Execute"></param>
        /// <returns></returns>
        public List<FeedbackInfo> Execute(string urlServer, int visitors, JobInfo job2Execute)
        {
            List<Task<FeedbackInfo>> taskList = new List<Task<FeedbackInfo>>();
            for (int i = 0; i < visitors; i++)
            {
                taskList.Add(CreateTask(i, urlServer, job2Execute));
            }

            Task.WaitAll(taskList.ToArray());

            return taskList.Select(task => task.Result).ToList();
        }

        /// <summary>
        /// Crea ed esegue un singolo task
        /// </summary>
        /// <param name="urlServer"></param>
        /// <param name="job2Execute"></param>
        /// <returns></returns>
        private Task<FeedbackInfo> CreateTask(int taskID, string urlServer, JobInfo job2Execute)
        {
            return Task.Run(() =>
            {
                FeedbackInfo feedback = new FeedbackInfo() { TaskID = taskID, Name = job2Execute.Name };
                WebClient webClient = CreateHttpClient(urlServer);

                //lista parametri condivisa tra le call (serve per recuperare i parametri da una chiamata e passarli alla successiva)
                Dictionary<string, string> parameters = new Dictionary<string, string>
                {
                    { "##server##", "/api" },
                    { "##sessionID##", taskID.ToString() }
                };

                foreach (string call in job2Execute.Calls)
                {
                    ExecutionInfo result = ExecuteCall(webClient, call, parameters);
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
            ExecutionInfo execInfo = new ExecutionInfo
            {
                Name = call
            };

            DateTime startTime = DateTime.Now;

            CallInfo callInfo = CallInfo.Get(call);
            if (callInfo == null)
            {
                execInfo.ExecTime = TimeSpan.FromSeconds(0);
                execInfo.Failed = true;
                return execInfo;
            }
            try
            {
                ParseParameters(callInfo, out string request, out string body, parameters);

                //TODO: in base alla configurazione, effettuare una GET o una POST
                string res;

                switch (callInfo.Method)
                {                    
                    case "GET":
                        res = webClient.DownloadString(request);
                        break;


                    default:
                        res = webClient.UploadString(request, callInfo.Method, body);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                execInfo.Failed = true;
            }


            //TODO: recuperare il risultato ed eventualmente aggiungere o modificare i parametri sul dictionary
            execInfo.ExecTime = DateTime.Now - startTime;
            return execInfo;
        }

        private void ParseParameters(CallInfo callInfo, out string request, out string body, IDictionary<string, string> parameters)
        {
            request = "" + callInfo.URL;
            body = "" + callInfo.Body;

            foreach (KeyValuePair<string, string> kvp in parameters)
            {
                request = request.Replace(kvp.Key, kvp.Value);
                body = body.Replace(kvp.Key, kvp.Value);
            }
        }

        public class WebClientEx : WebClient
        {
            protected override WebRequest GetWebRequest(Uri address)
            {
                WebRequest req = base.GetWebRequest(address);
                req.Timeout = (int)TimeSpan.FromMinutes(1).TotalMilliseconds; //TODO: aggiungere parametro di configurazione;
                return req;
            }
        }
    }
}
