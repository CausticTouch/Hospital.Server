using Hospital.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Hospital;

[DependsOn(
    typeof(HospitalEntityFrameworkCoreTestModule)
    )]
public class HospitalDomainTestModule : AbpModule
{

}
