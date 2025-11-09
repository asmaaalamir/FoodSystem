using Volo.Abp.Settings;

namespace FoodSystem.Settings;

public class FoodSystemSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(FoodSystemSettings.MySetting1));
    }
}
