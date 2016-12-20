using Newtonsoft.Json;

namespace OneSignal.CSharp.SDK.Resources.Notifications
{
	public class NotificationFilterOperator : INotificationFilter
	{
		[JsonProperty("operator")]
		public string Operator { get; set; }
	}
}