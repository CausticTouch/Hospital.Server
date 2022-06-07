using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Hospital;

[Dependency(ReplaceServices = true)]
public class HospitalBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Hospital";
}
