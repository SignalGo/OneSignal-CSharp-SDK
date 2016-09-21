using OneSignal.CSharp.SDK.Resources.Devices;
using OneSignal.CSharp.SDK.Resources.Notifications;

namespace OneSignal.CSharp.SDK
{
    public class OneSignalClient : IOneSignalClient
    {
        public IDevicesResource Devices { get; private set; }

        public INotificationsResource Notifications { get; private set; }

        public OneSignalClient(string apiKey, string apiUri = "https://onesignal.com/api/v1")
        {
            this.Devices = new DevicesResource(apiKey, apiUri);
            this.Notifications = new NotificationsResource(apiKey, apiUri);
        }
    }
}
