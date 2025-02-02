using System.Threading.Tasks;
using HayoonKorea.Localization;
using HayoonKorea.Permissions;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace HayoonKorea.Web.Menus;

public class HayoonKoreaMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private static Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var l = context.GetLocalizer<HayoonKoreaResource>();

        //Home
        context.Menu.AddItem(
            new ApplicationMenuItem(
                HayoonKoreaMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fa fa-home",
                order: 1
            )
        );


        //Administration
        var administration = context.Menu.GetAdministration();
        administration.Order = 5;

        //Administration->Identity
        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 1);
        
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        //Administration->Settings
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 7);
    
        context.Menu.AddItem(
            new ApplicationMenuItem(
                "PhonesStore",
                l["Menu:HayoonKorea"],
                icon: "fa fa-phone"
            ).AddItem(
                new ApplicationMenuItem(
                    "PhonesStore.Brands",
                    l["Menu:Brands"],
                    url: "/Brands"
                ).RequirePermissions(HayoonKoreaPermissions.Phones.Default) 
            ).AddItem(
            new ApplicationMenuItem(
                "PhonesStore.Phones",
                l["Menu:Phones"],
                url: "/Phones"
                ) 
            ).RequirePermissions(HayoonKoreaPermissions.Phones.Default)
        );
        
        return Task.CompletedTask;
    }
}
