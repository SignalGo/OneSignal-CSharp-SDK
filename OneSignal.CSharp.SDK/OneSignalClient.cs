using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneSignal.CSharp.SDK.Resources.Devices;
using OneSignal.CSharp.SDK.Resources.Notifications;

namespace OneSignal.CSharp.SDK
{
    public class OneSignalClient : IOneSignalClient
    {
        public IDevicesResource Devices { get; }

        public INotificationsResource Notifications { get; }

        public OneSignalClient(string apiKey, string apiUri = "https://onesignal.com/api/v1")
        {
        }
    }
}
