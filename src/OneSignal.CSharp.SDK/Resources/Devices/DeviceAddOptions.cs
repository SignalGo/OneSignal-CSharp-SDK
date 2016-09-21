using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSignal.CSharp.SDK.Resources.Devices
{
    public class DeviceAddOptions
    {
        /// <summary>
        /// Your OneSignal App Id found on the OneSignal dashboard under App Settings>Keys & IDs
        /// </summary>
        [SerializeAs(Name = "app_id", NameStyle = NameStyle.AsIs)]
        public string AppId { get; set; }

        /// <summary>
        /// 0 = iOS
        /// 1 = Android
        /// 2 = Amazon
        /// 3 = WindowsPhone(MPNS)
        /// 4 = ChromeApp
        /// 5 = ChromeWebsite
        /// 6 = WindowsPhone(WNS)
        /// 7 = Safari
        /// 8 = Firefox
        /// 9 = Mac OS X
        /// </summary>
        [SerializeAs(Name = "device_type")]
        public DeviceTypeEnum DeviceType { get; set; }

        /// <summary>
        /// Push notification identifier from Google or Apple. For Apple push identifiers, you must strip all non alphanumeric characters. 
        /// Example: ce777617da7f548fe7a9ab6febb56
        /// </summary>
        [SerializeAs(Name = "identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Language code. Typically lower case two letters, except for Chinese where it must be one of "zh-Hans" or "zh-Hant". Example: en
        /// </summary>
        [SerializeAs(Name = "language")]
        public string Language { get; set; }

        /// <summary>
        /// Number of seconds away from UTC. Example: -28800
        /// </summary>
        [SerializeAs(Name = "timezone")]
        public int? Timezone { get; set; }

        /// <summary>
        /// Version of the app.
        /// </summary>
        [SerializeAs(Name = "game_version")]
        public string GameVersion { get; set; }

        /// <summary>
        /// Device make and model. Example: iPhone5,1
        /// </summary>
        [SerializeAs(Name = "device_model")]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Device operating system version. Example: 7.0.4
        /// </summary>
        [SerializeAs(Name = "device_os")]
        public string DeviceOS { get; set; }

        /// <summary>
        /// Android = The Advertising Id
        /// iOS = The identifierForVendor
        /// WP8.0 = The DeviceUniqueId
        /// WP8.1 = The AdvertisingId
        /// </summary>
        [SerializeAs(Name = "ad_id")]
        public string AdId { get; set; }

        /// <summary>
        /// Name and version of the plugin that's calling this API method (if any)
        /// </summary>
        [SerializeAs(Name = "sdk")]
        public string SDK { get; set; }

        /// <summary>
        /// Number of times the user has played the game, defaults to 1
        /// </summary>
        [SerializeAs(Name = "session_count")]
        public string SessionCount { get; set; }

        /// <summary>
        /// Custom tags for the player. Example: {"foo":"bar","this":"that"}
        /// </summary>
        [SerializeAs(Name = "tags")]
        public IDictionary<string, object> Tags { get; set; }

        /// <summary>
        /// Amount the user has spent in USD, up to two decimal places
        /// </summary>
        [SerializeAs(Name = "amount_spent")]
        public string AmountSpent { get; set; }

        /// <summary>
        /// Unixtime when the player joined the game
        /// </summary>
        [SerializeAs(Name = "created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// Seconds player was running your app.
        /// </summary>
        [SerializeAs(Name = "playtime")]
        public int? PlayTime { get; set; }

        /// <summary>
        /// Current iOS badge count displayed on the app icon
        /// </summary>
        [SerializeAs(Name = "badge_count")]
        public int? BadgeCount { get; set; }

        /// <summary>
        /// Unixtime when the player was last active
        /// </summary>
        [SerializeAs(Name = "last_active")]
        public int? LastActive { get; set; }

        /// <summary>
        /// This is used in deciding whether to use your iOS Sandbox or Production push certificate when sending a push when both have been uploaded. 
        /// Set to the iOS provisioning profile that was used to build your app. 
        /// 1 = Development
        /// 2 = Ad-Hoc. 
        /// Omit this field for App Store builds.
        /// </summary>
        [SerializeAs(Name = "test_type")]
        public TestTypeEnum? TestType { get; set; }
    }
}
