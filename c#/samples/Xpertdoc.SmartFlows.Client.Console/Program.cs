using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Xpertdoc.SmartFlows.Api;
using Xpertdoc.SmartFlows.Client;
using Xpertdoc.SmartFlows.Model;

namespace Xpertdoc.SmartFlows.Client.Console
{
    public class Program
    {

        // String url = "https://smartflowspreview.xpertdoc.com/api/v1";
        public const string SMARTFLOWS_URL = "http://localhost:8080/api/v1";

        public const string SMARTFLOWS_USER = "USERNAME";
        public const string SMARTFLOWS_PASSWORD = "PASSWORD";

        public const string FLOW_ID = "a129dcfa-6c11-4e09-8144-5791e9f3b159";

        public const string DOCUMENT_FOLDER = @"C:\temp\documents";
        public static void Main(string[] args)
        {
            DefaultApi api = new DefaultApi(SMARTFLOWS_URL);

            Login login = new Login(SMARTFLOWS_USER, SMARTFLOWS_PASSWORD);
            Authentication auth = api.AuthenticateLoginPost(login);

            String token = auth.Tokens[0].Token;
            api.Configuration.AccessToken = token;

            for (int i = 0; i < 1; i++)
            {
                ExecuteFlow(api);
            }

            System.Console.ReadKey();
        }

        private static void ExecuteFlow(DefaultApi api)
        {
            try
            {
                FlowExecutionProgress progress = api.ExecuteFlow(FLOW_ID);
                string executionId = progress.Id;

                bool done = false;
                while (!done)
                {
                    System.Console.WriteLine($"Flow is {progress.Status}");
                    switch (progress.Status)
                    {
                        case FlowExecutionStatus.Running:
                        case FlowExecutionStatus.Queued:
                        case FlowExecutionStatus.SelectFlow:
                            // keep waiting
                            System.Console.WriteLine("waiting..");
                            System.Threading.Thread.Sleep(1000);
                            progress = api.GetFlowExecutionProgress(executionId, 10);
                            break;

                        case FlowExecutionStatus.Waiting:
                            throw new ApplicationException("won't wait for something that can take a long time");

                        case FlowExecutionStatus.UserInput:
                            // fill in user input
                            JObject properties = new JObject();
                            properties["55c8256f-1984-4fe7-870b-1692e6d7567f"] = "Gent";
                            progress = api.ContinueFlowExecution(executionId, properties);
                            break;

                        case FlowExecutionStatus.Canceled:
                        case FlowExecutionStatus.Error:
                        case FlowExecutionStatus.Interrupted:
                        case FlowExecutionStatus.Success:
                            done = true;
                            break;
                    }
                }

                System.Console.WriteLine("Done");
                JObject jObject = (JObject) progress.Model;
                JProperty firstProp = jObject.First as JProperty;

                string documentId = jObject[firstProp.Name]["document"]["id"].Value<string>();
                System.Console.WriteLine("document id: " + documentId);
                byte[] content = api.GetDocumentContent(documentId);

                File.WriteAllBytes(Path.Combine(DOCUMENT_FOLDER, executionId + ".pdf"), content);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception during execution: " + ex.Message);
            }
        }
    }
}
