using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSignal.CSharp.SDK.Resources.Devices
{
    public class DeviceAddResult
    {
        [DeserializeAs(Name = "success")]
        public bool IsSuccess { get; set; }

        [DeserializeAs(Name = "id")]
        public string Id { get; set; }
    }
}
