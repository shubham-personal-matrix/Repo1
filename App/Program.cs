using SharedLib;

DeviceHelper helper = new DeviceHelper();

Console.WriteLine(helper.GetDeviceStatusTemp());
Console.WriteLine(helper.GetDeviceIP());

Console.ReadLine();