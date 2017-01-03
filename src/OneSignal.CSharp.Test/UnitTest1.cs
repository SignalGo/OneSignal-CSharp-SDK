using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneSignal.CSharp.SDK;
using OneSignal.CSharp.SDK.Resources;
using OneSignal.CSharp.SDK.Resources.Notifications;
using System.Collections.Generic;

namespace OneSignal.CSharp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OneSignalTest()
        {
            try
            {
                var client = new OneSignalClient("ZWM3YThlMmQtMzY1NC00ODI1LTlkYjMtMTk3MzI2OTQzMjVh");

                var options = new NotificationCreateOptions();
                options.AppId = Guid.Parse("af447f99-a469-4fa2-a8aa-435bf449900f");
                //options.IncludedSegments = new List<string> { "All" };
                options.Contents.Add(LanguageCodes.English, "salam chetori?");
                options.IncludedPlayerIds = new List<string>() { "4581a321-9ce5-4201-be19-58e3436834c4" };
                var result = client.Notifications.Create(options);
            }
            catch(Exception ex)
            {

            }
        }
    }
}
