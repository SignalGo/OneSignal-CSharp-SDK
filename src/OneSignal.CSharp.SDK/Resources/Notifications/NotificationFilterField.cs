using Newtonsoft.Json;

namespace OneSignal.CSharp.SDK.Resources.Notifications
{
	public class NotificationFilterField : INotificationFilter
	{
		[JsonProperty("field")]
		public string Field { get; set; }

		[JsonProperty("key")]
		public string Key { get; set; }

		[JsonProperty("relation")]
		public string Relation { get; set; }

		[JsonProperty("value")]
		public string Value { get; set; }
	}
}