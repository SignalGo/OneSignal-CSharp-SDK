using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSignal.CSharp.SDK.Resources.Notifications
{
    public interface INotificationsResource
    {
        NotificationCreateResult Create(NotificationCreateOptions options);
    }
}
