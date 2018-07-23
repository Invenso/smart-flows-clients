using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Xpertdoc.SmartFlows.Api;
using Xpertdoc.SmartFlows.Model;
using Xpertdoc.SmartFlows.Client.Samples.Annotations;

namespace Xpertdoc.SmartFlows.Client.Samples

{
    public partial class Form1 : Form
    {
        private DefaultApi _api;
        private ExecutionData _data;
        private Weahter _weather;

        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            // String url = "https://smartflowspreview.xpertdoc.com/api/v1";
            var url = "https://localhost:8080";
            _api = new DefaultApi(url);

            var login = new Login("USERNAME", "PASSWORD");
            var auth = _api.AuthenticateLoginPost(login);

            var token = auth.Tokens[0].Token;
            _api.Configuration.AccessToken = token;

            var flows = _api.GetFlows();
            Console.WriteLine(flows.Count);
            flowSelect.DisplayMember = "displayName";
            flowSelect.DataSource = flows;

            _data = new ExecutionData();
            result.DataBindings.Add("Text", _data, "Result");

            _weather = new Weahter("Gent");
            cityName.DataBindings.Add("Text", _weather, "City");
        }

        private void generateReport_Click(object sender, EventArgs e)
        {
            var progress = ExecuteFlow(Weahter.FlowId, _api);
            _data.Result = progress.Model.ToString();

            var jObject = (JObject) progress.Model;
            var firstProp = jObject.First as JProperty;

            var documentId = jObject[firstProp.Name]["document"]["id"].Value<string>();
            Console.WriteLine("document id: " + documentId);
            var content = _api.GetDocumentContent(documentId);

            File.WriteAllBytes(Path.Combine(Weahter.DocumentFolder, progress.Id + ".pdf"), content);


            Process.Start("explorer.exe", Weahter.DocumentFolder);
        }

        private void runFlow_Click(object sender, EventArgs e)
        {
            var flow = (Flow) flowSelect.SelectedItem;
            var executionProgress = ExecuteFlow(flow.Id, _api);
            _data.Result = executionProgress.Model.ToString();
        }


        private FlowExecutionProgress ExecuteFlow(string flowId, DefaultApi api)
        {
            try
            {
                var progress = api.ExecuteFlow(flowId);
                var executionId = progress.Id;

                var done = false;
                while (!done)
                {
                    Console.WriteLine($"Flow is {progress.Status}");
                    switch (progress.Status)
                    {
                        case FlowExecutionStatus.Running:
                        case FlowExecutionStatus.Queued:
                        case FlowExecutionStatus.SelectFlow:
                            // keep waiting
                            Console.WriteLine("waiting..");
                            Thread.Sleep(1000);
                            progress = api.GetFlowExecutionProgress(executionId, 10);
                            break;

                        case FlowExecutionStatus.Waiting:
                            throw new ApplicationException("won't wait for something that can take a long time");

                        case FlowExecutionStatus.UserInput:
                            // fill in user input
                            var properties = new JObject();
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

                Console.WriteLine("Done");

                return progress;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception during execution: " + ex.Message);
                throw ex;
                return null;
            }
        }
    }

    public class Weahter : INotifyPropertyChanged
    {
        private string _city;
        public static string FlowId { get; } = "a129dcfa-6c11-4e09-8144-5791e9f3b159";
        public static string DocumentFolder { get; } = @"C:\temp\documents";


        public string City
        {
            get => _city;
            set
            {
                if (value == _city) return;
                _city = value;
                OnPropertyChanged();
            }
        }

        public Weahter(string city)
        {
            _city = city;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class ExecutionData : INotifyPropertyChanged
    {
        private string _result;

        public string Result
        {
            get => _result;
            set
            {
                if (value == _result) return;
                _result = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}