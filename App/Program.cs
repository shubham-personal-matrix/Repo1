using SharedLib;

DeviceHelper helper = new DeviceHelper();

Console.WriteLine(helper.GetDeviceStatus());
Console.WriteLine(helper.GetDeviceIP());

Console.ReadLine();