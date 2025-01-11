using HayoonKorea.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace HayoonKorea.Permissions;

public class HayoonKoreaPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HayoonKoreaPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(HayoonKoreaPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(HayoonKoreaPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(HayoonKoreaPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(HayoonKoreaPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(HayoonKoreaPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HayoonKoreaResource>(name);
    }
}
