using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace HayoonKorea.Phones;

public class PhoneDto : FullAuditedEntityDto<Guid>
{
    public string Name { get; set; }
    public string Model { get; set; }
    public float Price { get; set; }
    public int Stock { get; set; }
    public string Description { get; set; }
    public Guid BrandId { get; set; }
    public List<string> Images { get; set; } = new List<string>();
    public DateTime ReleaseDate { get; set; }
    public List<string> ColorOptions { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Depth { get; set; }
    public string OS { get; set; }
    public string Processor { get; set; }
    public int ram { get; set; }
    public List<int> StorageOptions { get; set; } = new List<int>();
    public int BatteryCapacity { get; set; }
    public string Size { get; set; }
    public string Resolution { get; set; }
    public string DisplayType { get; set; }
    public string Rear { get; set; }
    public string Front { get; set; }
    public string Network { get; set; }
    public string Wifi { get; set; }
    public string Bluetooth { get; set; }
    public bool Nfc { get; set; }
    public bool Waterproof { get; set; }
    public bool WirelessCharging { get; set; }
    public bool FaceUnlock { get; set; }
    public int WarrantyPeriod { get; set; }
    public List<string> Tags { get; set; } = new List<string>();
}