using System;
using OneSignal.CSharp.SDK.Serializers;
using RestSharp;

namespace OneSignal.CSharp.SDK.Resources.Devices
{
    public class DevicesResource : BaseResource, IDevicesResource
    {
        public DevicesResource(string apiKey, string apiUri) : base(apiKey, apiUri)
        {
        }

        public DeviceAddResult Add(DeviceAddOptions options)
        {
            RestRequest restRequest = new RestRequest("players", Method.POST);

            restRequest.AddHeader("Authorization", string.Format("Basic {0}", base.ApiKey));

            restRequest.RequestFormat = DataFormat.Json;
            restRequest.JsonSerializer = new NewtonsoftJsonSerializer();
            restRequest.AddBody(options);

            IRestResponse<DeviceAddResult> restResponse = base.RestClient.Execute<DeviceAddResult>(restRequest);

            if (restResponse.ErrorException != null)
            {
                throw restResponse.ErrorException;
            }

            return restResponse.Data;
        }

        public void Edit(string id, DeviceEditOptions options)
        {
            RestRequest restRequest = new RestRequest("players/{id}", Method.PUT);

            restRequest.AddHeader("Authorization", string.Format("Basic {0}", base.ApiKey));

            restRequest.AddUrlSegment("id", id);

            restRequest.RequestFormat = DataFormat.Json;
            restRequest.JsonSerializer = new NewtonsoftJsonSerializer();
            restRequest.AddBody(options);

            IRestResponse restResponse = base.RestClient.Execute(restRequest);

            if (restResponse.ErrorException != null)
            {
                throw restResponse.ErrorException;
            }
        }
    }
}
