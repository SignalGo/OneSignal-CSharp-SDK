using OneSignal.CSharp.SDK.Resources.Notifications;
using OneSignal.CSharp.SDK.Resources.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSignal.CSharp.SDK
{
    public interface IOneSignalClient
    {
        IDevicesResource Devices { get; }

        INotificationsResource Notifications { get; }
    }
}
