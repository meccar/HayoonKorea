using HayoonKorea.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace HayoonKorea.Permissions;

public class HayoonKoreaPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var hayoonKoreaGroup = context.AddGroup(HayoonKoreaPermissions.GroupName, L("Permission:HayoonKorea"));

        var phonesPermission = hayoonKoreaGroup.AddPermission(HayoonKoreaPermissions.Phones.Default, L("Permission:Phones"));
        phonesPermission.AddChild(HayoonKoreaPermissions.Phones.Create, L("Permission:Phones.Create"));
        phonesPermission.AddChild(HayoonKoreaPermissions.Phones.Edit, L("Permission:Phones.Edit"));
        phonesPermission.AddChild(HayoonKoreaPermissions.Phones.Delete, L("Permission:Phones.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HayoonKoreaResource>(name);
    }
}
