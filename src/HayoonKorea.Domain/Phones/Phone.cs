using System;
using System.Collections.Generic;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace HayoonKorea.Phones;

public class Phone : FullAuditedAggregateRoot<Guid>
{
    #region Basic Information
    public string Name { get;  set; }
    public string Model { get;  set; }
    public float Price { get;  set; }
    public int Stock { get;  set; }
    public string Description { get;  set; }
    public Guid BrandId { get;  set; }
    public DateTime ReleaseDate { get;  set; }
    #endregion

    #region Physical Specifications
    public float Width { get;  set; }
    public float Height { get;  set; }
    public float Depth { get;  set; }
    public int WarrantyPeriod { get;  set; }
    #endregion

    #region Technical Specifications
    public string OS { get;  set; }
    public string Processor { get;  set; }
    public int Ram { get;  set; }
    public int BatteryCapacity { get;  set; }
    #endregion

    #region Display
    public string Size { get;  set; }
    public string Resolution { get;  set; }
    public string DisplayType { get;  set; }
    #endregion

    #region Camera
    public string Rear { get;  set; }
    public string Front { get;  set; }
    #endregion

    #region Connectivity
    public string Network { get;  set; }
    public string Wifi { get;  set; }
    public string Bluetooth { get;  set; }
    public bool Nfc { get;  set; }
    #endregion

    #region Features
    public bool Waterproof { get;  set; }
    public bool WirelessCharging { get;  set; }
    public bool FaceUnlock { get;  set; }
    #endregion

    #region Collections
    public List<string> Images { get;  set; } = new List<string>();
    public List<string> ColorOptions { get;  set; } = new List<string>();
    public List<int> StorageOptions { get;  set; } = new List<int>();
    public List<string> Tags { get;  set; } = new List<string>();
    #endregion
}