using Volo.Abp.Settings;

namespace Hospital.Settings;

public class HospitalSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(HospitalSettings.MySetting1));
    }
}
