using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.APIScripts
{
    public class StatusCheck
    {
        public int StatusCheckk(string url)
        {
            var restClient = new RestClient(url);
            var restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;
            IRestResponse response = restClient.Execute(restRequest);
            var status = Convert.ToInt32(response.StatusCode);
            return status;
        }
    }
}
