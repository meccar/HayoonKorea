using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HayoonKorea.Phones;

public class CreateUpdatePhoneDto
{
    [Required]
    [StringLength(128, ErrorMessage = "The Name must be less than 128 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(64, ErrorMessage = "The Model must be less than 64 characters.")]
    public string Model { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; } = DateTime.Now;

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "Price must be greater than or equal to 0.")]
    public float Price { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Stock must be greater than or equal to 0.")]
    public int Stock { get; set; }

    [StringLength(500, ErrorMessage = "The Description must be less than 500 characters.")]
    public string Description { get; set; }

    [Required]
    public Guid BrandId { get; set; }

    [Required]
    public List<string> Images { get; set; } = new List<string>();

    public List<string> ColorOptions { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Width must be greater than or equal to 0.")]
    public int Width { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Height must be greater than or equal to 0.")]
    public int Height { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Depth must be greater than or equal to 0.")]
    public int Depth { get; set; }

    [StringLength(64, ErrorMessage = "The OS must be less than 64 characters.")]
    public string OS { get; set; }

    [StringLength(64, ErrorMessage = "The Processor must be less than 64 characters.")]
    public string Processor { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "RAM must be greater than or equal to 0.")]
    public int ram { get; set; }

    [Required]
    public List<int> StorageOptions { get; set; } = new List<int>();

    [Range(0, int.MaxValue, ErrorMessage = "Battery capacity must be greater than or equal to 0.")]
    public int BatteryCapacity { get; set; }

    [StringLength(16, ErrorMessage = "The Size must be less than 16 characters.")]
    public string Size { get; set; }

    [StringLength(64, ErrorMessage = "The Resolution must be less than 64 characters.")]
    public string Resolution { get; set; }

    [StringLength(64, ErrorMessage = "The Display Type must be less than 64 characters.")]
    public string DisplayType { get; set; }

    [StringLength(64, ErrorMessage = "The Rear Camera details must be less than 64 characters.")]
    public string Rear { get; set; }

    [StringLength(64, ErrorMessage = "The Front Camera details must be less than 64 characters.")]
    public string Front { get; set; }

    [StringLength(64, ErrorMessage = "The Network details must be less than 64 characters.")]
    public string Network { get; set; }

    [StringLength(64, ErrorMessage = "The WiFi details must be less than 64 characters.")]
    public string Wifi { get; set; }

    [StringLength(64, ErrorMessage = "The Bluetooth details must be less than 64 characters.")]
    public string Bluetooth { get; set; }

    public bool Nfc { get; set; }

    public bool Waterproof { get; set; }

    public bool WirelessCharging { get; set; }

    public bool FaceUnlock { get; set; }

    [Range(0, 10, ErrorMessage = "Warranty period must be between 0 and 10 years.")]
    public int WarrantyPeriod { get; set; }

    public List<string> Tags { get; set; } = new List<string>();
}

