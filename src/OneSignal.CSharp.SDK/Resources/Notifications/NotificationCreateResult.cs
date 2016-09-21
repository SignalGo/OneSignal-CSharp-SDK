using RestSharp.Deserializers;

namespace OneSignal.CSharp.SDK.Resources.Notifications
{
    public class NotificationCreateResult
    {
        [DeserializeAs(Name = "recipients")]
        public int Recipients { get; set; }

        [DeserializeAs(Name = "id")]
        public string Id { get; set; }
    }
}
