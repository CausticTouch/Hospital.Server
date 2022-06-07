using Hospital.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Hospital.Blazor;

public abstract class HospitalComponentBase : AbpComponentBase
{
    protected HospitalComponentBase()
    {
        LocalizationResource = typeof(HospitalResource);
    }
}
