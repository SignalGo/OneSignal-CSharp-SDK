using System;

namespace OneSignal.CSharp.SDK.Resources.Notifications
{
    public class NotificationsResource : BaseResource, INotificationsResource
    {
        public NotificationsResource(string apiKey, string apiUri) : base(apiKey, apiUri)
        {
        }

        public NotificationCreateResult Create(NotificationCreateOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
