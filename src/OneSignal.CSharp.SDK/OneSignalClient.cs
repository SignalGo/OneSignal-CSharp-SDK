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
            this.Devices = new DevicesResource(apiKey, apiUri);
        }
    }
}
