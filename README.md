![OneSignal Logo](https://onesignal.com/assets/common/logo_onesignal_color.png)
# OneSignal-CSharp
A General purpose rest ApiClient write in C# language for the OneSignal API

[![Build status](https://ci.appveyor.com/api/projects/status/ki6wuc19tx7eho36/branch/master?svg=true)](https://ci.appveyor.com/project/MundiPagg/onesignal-csharp-sdk/branch/master)

## Install via NuGet

```
PM> Install-Package OneSignal.CSharp.SDK
```

## How to use

```csharp
                var client = new OneSignalClient("ZWM3YThlMmQtMzY1NC00ODI1LTlkYjMtMTk3MzI2OTQzMjVh");

                var options = new NotificationCreateOptions();
                options.AppId = Guid.Parse("af447f99-a469-4fa2-a8aa-435bf449900f");
                //options.IncludedSegments = new List<string> { "All" };
                options.Contents.Add(LanguageCodes.English, "salam chetori?");
                options.IncludedPlayerIds = new List<string>() { "4581a321-9ce5-4201-be19-58e3436834c4" };
                var result = client.Notifications.Create(options);
```

## OneSignal Api Oficial Documentation
[OneSignal Server API] (https://documentation.onesignal.com/reference)
