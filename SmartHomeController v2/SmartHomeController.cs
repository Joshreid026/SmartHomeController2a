using SmartHomeController;
using System.Net.NetworkInformation;

public class Program
{
    private static List<SmartDevice> devices = new List<SmartDevice>();
    public static void Main()
    {
        SmartLight kitchenLight = new SmartLight(1, "Kitchen Light", 0.75, "White");
        SmartThermostat bathroomThermostat = new SmartThermostat(2, "Bathroom Thermostat", 22.5, 24.0);
        SmartSpeaker livingRoomSpeaker = new SmartSpeaker(3, "Living Room Speaker", 50);
        SmartSecurityCamera frontDoorCamera = new SmartSecurityCamera(4, "Front Door Camera", "1080p");

        devices.Add(kitchenLight);
        devices.Add(bathroomThermostat);
        devices.Add(livingRoomSpeaker);
        devices.Add(frontDoorCamera);

        ViewAllDevices();
    }

    public static void ViewAllDevices()
    {
        Console.WriteLine("List all Devices\n\n============================================================================\n");
        SmartDevice device = null;
        foreach(var smartItem in devices)
        {
            smartItem.GetStatus();
            Console.WriteLine("\n============================================================================\n");
        }
    }
 
}
