namespace OneSignal.CSharp.SDK.Resources.Devices
{
    public interface IDevicesResource
    {
        DeviceAddResult Add(DeviceAddOptions options);

        void Edit(string id, DeviceEditOptions options);
    }
}
