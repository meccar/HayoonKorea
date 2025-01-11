using Volo.Abp.Settings;

namespace HayoonKorea.Settings;

public class HayoonKoreaSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(HayoonKoreaSettings.MySetting1));
    }
}
