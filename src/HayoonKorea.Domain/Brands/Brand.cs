using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace HayoonKorea.Brands;

public class Brand : FullAuditedAggregateRoot<Guid>
{
    public string Name { get; set; }
    public string Logo { get; set; }
    // public List<Phone> Phones { get; set; } = new List<Phone>();
    
    // private Brand()
    // {
    // }
    //
    // internal Brand(
    //     Guid id,
    //     string name,
    //     string logo
    //     ) : base(id)
    // {
    //     SetName(name);
    //     SetLogo(logo);
    // }
    //
    // internal Brand ChangeName(string name)
    // {
    //     SetName(name);
    //     return this;
    // }
    //
    // internal Brand ChangLogo(string logo)
    // {
    //     SetLogo(logo);
    //     return this;
    // }
    //
    // private void SetName(string name)
    // {
    //     Name = Check.NotNullOrWhiteSpace(
    //         name, 
    //         nameof(name), 
    //         maxLength: BrandConsts.MaxNameLength
    //     );
    // }
    //
    // private void SetLogo(string logo)
    // {
    //     Logo = Check.NotNullOrWhiteSpace(
    //         logo, 
    //         nameof(logo) 
    //     );
    // }
}