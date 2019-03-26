using System;
using Xamarin.Forms;
using UIKit;

namespace myfirstxamarin.Config
{
    public enum DeviceTypes { ios, android, etc }

    public class DeviceSettings
    {
        public DeviceTypes type;
        public DeviceSettings()
        {
            //check device types
            this.type = Device.RuntimePlatform == Device.iOS ? DeviceTypes.ios : Device.RuntimePlatform == Device.Android ? DeviceTypes.android : DeviceTypes.etc;
            switch (type) {
                case DeviceTypes.ios:
                    Constant.deviceID = UIDevice.CurrentDevice.IdentifierForVendor.ToString();
                    break;
                case DeviceTypes.android:
                    Constant.deviceID = "FUCK";
                    break;
                default:
                    Constant.deviceID = "FUCK";
                    break;
            }
        }
    }
}
