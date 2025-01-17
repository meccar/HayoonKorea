using System.Collections.Generic;

namespace HayoonKorea.Phones;

public class PhoneSpecifications
{
    public List<int> StorageOptions { get; private set; } = new List<int>();
    public string OS { get; set; }
    public string Processor { get; set; }
    public int Ram { get; set; }
    public int BatteryCapacity { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Depth { get; set; }
    public string Size { get; set; }
    public string Resolution { get; set; }
    public string DisplayType { get; set; }
    public bool Waterproof { get; set; }
    public bool WirelessCharging { get; set; }
    public bool FaceUnlock { get; set; }
    public string Network { get; set; }
    public string Wifi { get; set; }
    public string Bluetooth { get; set; }
    public bool Nfc { get; set; }
}