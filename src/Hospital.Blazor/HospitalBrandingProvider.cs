using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Hospital.Blazor;

[Dependency(ReplaceServices = true)]
public class HospitalBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Hospital";
}
