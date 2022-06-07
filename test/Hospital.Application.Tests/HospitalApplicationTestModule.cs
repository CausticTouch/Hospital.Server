using Volo.Abp.Modularity;

namespace Hospital;

[DependsOn(
    typeof(HospitalApplicationModule),
    typeof(HospitalDomainTestModule)
    )]
public class HospitalApplicationTestModule : AbpModule
{

}
