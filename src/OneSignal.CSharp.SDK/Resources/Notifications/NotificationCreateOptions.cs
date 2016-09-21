using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OneSignal.CSharp.SDK.Resources.Notifications
{
    public class NotificationCreateOptions
    {
        /// <summary>
        /// Your OneSignal application ID, which can be found on our dashboard at onesignal.com under App Settings > Keys & IDs. 
        /// It is a UUID and looks similar to 8250eaf6-1a58-489e-b136-7c74a864b434.
        /// </summary>
        [JsonProperty("app_id")]
        public Guid AppId { get; set; }

        /// <summary>
        /// The notification's content (excluding the title), a map of language codes to text for each language.
        /// Each hash must have a language code string for a key, mapped to the localized text you would like users to receive for that language.
        /// English must be included in the hash.
        /// Example: {"en": "English Message", "es": "Spanish Message"}
        /// </summary>
        [JsonProperty("contents")]
        public IDictionary<string, string> Contents { get; set; }

        public NotificationCreateOptions()
        {
            Contents = new Dictionary<string, string>();
        }
    }
}
